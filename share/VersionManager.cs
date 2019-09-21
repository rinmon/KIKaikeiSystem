using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace KI
{
    class VersionManager
    {
        public VersionManager() {
            
        }


        private string CurrentDir {
            get { return Environment.CurrentDirectory; }
        }

        private string LicenseClientPath {
            get { return CurrentDir + "\\LicenseClient.exe"; }
        }

        private string DatabaseUpdaterPath {
            get { return CurrentDir + "\\DatabaseUpdater.exe"; }
        }


        public void CheckUpdateAndRun(string binPath, string dbPath, string dbScriptPath) {
            RunLicenseCilent();
            UpdateExeFiles();
            RunDatabaseUpdater(dbPath, dbScriptPath);

            System.Diagnostics.Process p =
                System.Diagnostics.Process.Start(binPath);
        }

        private void RunLicenseCilent() {
            System.Diagnostics.Process p =
                System.Diagnostics.Process.Start(LicenseClientPath, "update-silent");
            p.WaitForExit();
        }


        private void RunDatabaseUpdater(string dbPath, string dbScriptPath) {
            if (File.Exists(dbScriptPath)) {
                System.Diagnostics.Process p =
                    System.Diagnostics.Process.Start(DatabaseUpdaterPath, dbPath + " " + dbScriptPath);
                p.WaitForExit();
            }
        }


        public void UpdateExeFiles() {
            const string updateFileSuffix = ".update";
            string str = "";
            string ownerExeFile = System.Reflection.Assembly.GetExecutingAssembly().Location;

            foreach (var updateFile in Directory.GetFiles(this.CurrentDir, "*" + updateFileSuffix)) {
                string originalFile = updateFile.Substring(0, updateFile.Length - updateFileSuffix.Length);
                str += originalFile;

                if (originalFile == ownerExeFile) {
                    continue;
                }

                try {
                    if (File.Exists(originalFile)) {
                        File.Delete(originalFile);
                    }
                    File.Move(updateFile, originalFile);
                }
                catch (IOException) {
                }
            }
        }
    }
}
