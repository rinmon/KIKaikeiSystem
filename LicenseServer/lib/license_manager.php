<?php


class LicenseManager
{

	private $db_host = 'sddb0040154627.cgidb';
	private $db_dbname = 'sddb0040154627';
	private $db_username = 'sddbMzA1MDI4';
	private $db_password = 'fsafDFGSfasdf24314';
    private $db_link = NULL;

    function OpenDB()
    {
        $this->db_link = mysqli_connect($this->db_host, $this->db_username, $this->db_password, $this->db_dbname);
        if (mysqli_connect_errno() > 0) {
            return FALSE;
        }
//		if(!mysql_select_db($this->db_dbname)){
//			return FALSE;
//		}

        return TRUE;
    }


    function CloseDB()
    {
        mysqli_close($this->db_link);
    }


    function ValidateAccount($account_id, $password)
    {
        $result = FALSE;
        $resource = mysqli_query($this->db_link, "select password from accounts where id = {$account_id}");
        if ($resource == FALSE) {
            $result = FALSE;
        } else if (mysqli_num_rows($resource) != 1) {
            $result = FALSE;
        } else {
            $db_pass = $resource->fetch_assoc()['password'];
            if ($db_pass === md5($password)) {
                $result = TRUE;
            } else {
                $result = FALSE;
            }
            mysqli_free_result($resource);
        }
        return $result;
    }


    function GetLicenseLimitDate($account_id, $service)
    {
        $result = FALSE;

        $resource = mysqli_query($this->db_link, "select limit_date from licenses where account_id = {$account_id} and service_name = '{$service}'");
        if ($resource == FALSE) {
            $result = FALSE;
        } else if (mysqli_num_rows($resource) != 1) {
            $result = FALSE;
        } else {
            $result = strtotime($resource->fetch_assoc()['limit_date']);
            mysqli_free_result($resource);
        }

        return $result;
    }


    function GetLastVersion($service_name)
    {
        $result = FALSE;

        $resource = mysqli_query($this->db_link, "select last_version from services where service_name = '{$service_name}'");
        if ($resource == FALSE) {
            $result = FALSE;
        } else if (mysqli_num_rows($resource) != 1) {
            $result = FALSE;
        } else {
            $result = intval($resource->fetch_assoc()['last_version']);
            mysqli_free_result($resource);
        }

        return $result;
    }


    function GetEncryptKey($service_name)
    {
        $result = FALSE;

        $resource = mysqli_query($this->db_link, "select encrypt_key from services where service_name = '{$service_name}'");
        if ($resource == FALSE) {
            $result = FALSE;
        } else if (mysqli_num_rows($resource) != 1) {
            $result = FALSE;
        } else {
            $result = $resource->fetch_assoc()['encrypt_key'];
            mysqli_free_result($resource);
        }

        return $result;
    }
}


?>
