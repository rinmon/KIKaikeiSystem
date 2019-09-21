<?php

function ReturnLastVersion($license_manager, $service){
	$version = $license_manager->GetLastVersion($service);

	header("Content-type: text/plain");
	print("{$version}\n");
}


function ReturnError($error_code){
	header("HTTP", true, 400);
}


function ReturnBinary($service, $version){
	$file = sprintf("v%08d.zip", $version);
	$path = sprintf("%s/%s", $service, $file);

	if(file_exists($path)){
//		$file_length = filesize($path);
		header("Content-Disposition: attachment; filename={$file}");
//		header("Content-Length:{$file_length}");
		header("Content-Type: application/octet-stream");
		header("Connection: close");
		readfile($path);
	}
	else{
		ReturnError("file not exist: {$path}");
	}
}


function ReturnLicense($license, $account_id, $service){
	$license_date = $license->GetLicenseLimitDate($account_id, $service);
	$limit = strtotime("+1 month");

	if($license_date < $limit){
		$limit = $license_date;
	}

	$date_str = date("Y/m/d", $limit);

	header("Content-type: text/plain");

	$data =
		"account:{$account_id}\n" .
		"service:{$service}\n" .
		"license:{$date_str}\n";


	//$key = $license->GetEncryptKey($service);
	$key = "key:IKduU0v6Xi";

	$encrypted = md5($data . $key);
	//$encstr = base64_encode($encrypted);
	print($data);
	print("signature:{$encrypted}"); 
}


?>
