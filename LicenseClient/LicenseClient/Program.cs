using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LicenseClient
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0) {
                Application.Run(new FormMain());
            }
            else {
                string command = args[0];

                string serverUrl = Properties.Settings.Default.server;
                string serviceName = Properties.Settings.Default.service;
                string accountId = Properties.Settings.Default.accountId;
                string password = Properties.Settings.Default.password;

                string binName = Properties.Settings.Default.binaryName;
                string binPath = Environment.CurrentDirectory + "\\" + binName;
                int currentVersion;
                try {
                    System.Diagnostics.FileVersionInfo ver =
                        System.Diagnostics.FileVersionInfo.GetVersionInfo(binPath);
                    currentVersion = ver.ProductMajorPart * 10000 + ver.ProductMinorPart;
                }
                catch (Exception) {
                    currentVersion = 0;
                }

                bool res = false;
                LicenseClient client = new LicenseClient(serverUrl, serviceName, accountId, password);

                if (command == "update") {
                    res = CommandExecutor.Update(client, currentVersion, Environment.CurrentDirectory, binName, false);
                }
                else if (command == "update-silent") {
                    res = CommandExecutor.Update(client, currentVersion, Environment.CurrentDirectory, binName, true);
                }
                else if (command == "getlicense") {
                    res = CommandExecutor.GetLicense(client, Environment.CurrentDirectory + "\\" + Properties.Settings.Default.licenseFileName);
                }

                if (res == true) {
                    //MessageBox.Show("正常終了しました", "License manager");
                }
                else {
                    //MessageBox.Show("異常終了", "License manager");
                }
            }
        }
    }
}
