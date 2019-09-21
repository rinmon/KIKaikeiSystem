<?php

require 'lib/license_manager.php';
require 'lib/commands.php';
date_default_timezone_set('Asia/Tokyo');

$account_id = $_REQUEST['account_id'];
$password = $_REQUEST['password'];
$service = $_REQUEST['service'];
$command = $_REQUEST['command'];

$license = new LicenseManager();
$license->OpenDB();

if($license->ValidateAccount($account_id, $password) == FALSE){
	ReturnError("invalid account");
	exit();
}
$license_date = $license->GetLicenseLimitDate($account_id, $service);
$today = time();
if($license_date == FALSE || $license_date < $today){
	ReturnError("invalid service_name or license");
	exit();
}

switch($command){
case 'version':
	ReturnLastVersion($license, $service);
	break;
case 'download':
	ReturnBinary($service, $_REQUEST['version']);
	break;
case 'getlicense':
	ReturnLicense($license, $account_id, $service);
	break;
default:
	ReturnError("invalid command");
	break;
}

$license->CloseDB();


?>
