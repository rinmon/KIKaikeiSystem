using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace KI
{
    class LicenseFileManager
    {
        public const int UpdateLinceseFileLimit = 10;

        private Dictionary<string, string> keyValue;


        public LicenseFileManager(string fileName = null) {
            if (fileName != null) {
                LicenseFileName = fileName;
            }
            else {
                LicenseFileName = "license.dat";
            }

            keyValue = new Dictionary<string,string>();
        }

        private string LicenseFileName { get; set; }

        private string CurrentDir {
            get { return Environment.CurrentDirectory; }
        }

        private string LicenseFilePath {
            get { return CurrentDir + "\\" + LicenseFileName; }
        }

        private string LicenseClientPath {
            get { return CurrentDir + "\\LicenseClient.exe"; }
        }

        public bool LicenseFileExist() {
            return File.Exists(LicenseFilePath);
        }

        public DateTime LicenseDate {
            get {
                return Convert.ToDateTime(keyValue["license"]);
            }
        }


        public void UpdateLicenseFile() {
            System.Diagnostics.Process p =
                System.Diagnostics.Process.Start(LicenseClientPath, "getlicense");
            p.WaitForExit();
        }


        public bool ReadFile() {
            char[] delim = new char[]{':'};

            string contents = "";
            string signature = "";

            keyValue.Clear();

            if (LicenseFileExist() == false) {
                return false;
            }

            using(var reader = new System.IO.StreamReader(LicenseFilePath)){
                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    string[] tokens = line.Split(delim);
                    string key = tokens[0];
                    string val = tokens[1];

                    keyValue[key] = val;

                    if(key == "signature"){
                        signature = val;
                    }
                    else{
                        contents = contents + line + "\n";
                    }
                }
            }

            if (keyValue.ContainsKey("license") == false) {
                return false;
            }

            string calcedSign = CalcSigniture(contents);
            if (calcedSign != signature) {
                return false;
            }

            return true;
        }


        private string CalcSigniture(string contents) {
            contents = contents + "key:IKduU0v6Xi";

            byte[] sourcebyte = System.Text.Encoding.GetEncoding("SHIFT_JIS").GetBytes(contents);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //or//MD5 md5 = MD5.Create()

            byte[] md5byte = md5.ComputeHash(sourcebyte);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < md5byte.Length; i++) {
                result.Append(md5byte[i].ToString("x2"));
            }

            return result.ToString();
        }
    }
}
