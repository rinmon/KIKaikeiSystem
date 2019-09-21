using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;

namespace LicenseClient
{
    class LicenseClient
    {
        string serverUrl;
        string serviceName;
        string accountId;
        string password;

        public LicenseClient(string serverUrl_, string serviceName_, string accountId_, string password_) {
            serverUrl = "https://" + serverUrl_;
            serviceName = serviceName_;
            accountId = accountId_;
            password = password_;

            // SSL の証明書のチェックを無効にする
            ServicePointManager.ServerCertificateValidationCallback = delegate(
                    Object sender,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    System.Security.Cryptography.X509Certificates.X509Chain chain,
                    SslPolicyErrors sslPolicyErrors) {
                return true;
            };
        }


        // Error時 -1を返す
        public int GetLastVersion() {
            string postData = string.Format("account_id={0}&password={1}&service={2}&command=version",
                accountId, password, serviceName);
            string versionText;

            try {
                versionText = Post(postData);
            }
            catch (WebException) {
                return -1;
            }

            return int.Parse(versionText);
        }


        public bool DownloadBinary(int version, string fileName) {
            string postData = string.Format("account_id={0}&password={1}&service={2}&command=download&version={3:D8}",
                accountId, password, serviceName, version);
            return Download(postData, fileName);
        }


        public bool DownloadLicenseFile(string fileName) {
            string postData = string.Format("account_id={0}&password={1}&service={2}&command=getlicense",
                accountId, password, serviceName);
            return Download(postData, fileName);
        }


        private bool Download(string postData, string fileName) {
            bool result = true;

            System.Text.Encoding enc =
                System.Text.Encoding.GetEncoding("shift_jis");

            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Encoding = enc;
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            try {
                wc.DownloadFile(serverUrl + "/?" + postData, fileName);
            }
            catch (WebException e) {
                result = false;
            }
            wc.Dispose();

            return result;
        }


        private string Post(string postData) {
            System.Text.Encoding enc =
                System.Text.Encoding.GetEncoding("shift_jis");

            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Encoding = enc;
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string resText = wc.UploadString(serverUrl, postData);
            wc.Dispose();

            return resText;
        }
    }
}
