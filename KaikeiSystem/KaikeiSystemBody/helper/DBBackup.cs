using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KaikeiSystemBody.helper
{
    class DBBackup
    {
        private const string backupPath = "Backup";

        static public void CreateDBPathIfNotExist() {
            if (Directory.Exists(backupPath) == false) {
                Directory.CreateDirectory(backupPath);
            }
        }

        static public void ExecutePeriodicDBBackup(string dbPath, string suffix, int numOfBackup, int span, models.db.mtables.MTSetting setting) {
            CreateDBPathIfNotExist();

            string timeStampKey = "last_db_backup_" + suffix;
            DateTime? lastBackupTime =setting.GetDateTime(timeStampKey);

            DateTime now = DateTime.Now;

            if (lastBackupTime == null || now.Subtract(lastBackupTime.Value).Days >= span) {
                string[] files = Directory.GetFiles(backupPath, dbPath + "." + suffix + "_*");
                Array.Sort(files);

                for(int i = 0; i < files.Length - numOfBackup + 1; i++){
                    File.Delete(files[i]);
                }

                MakeDBBackup(dbPath, suffix);
                setting.SetDateTime(timeStampKey, now);
            }            
        }


        /// <summary>
        /// バックアップファイル作成
        /// </summary>
        /// <param name="dbFileName"></param>
        /// <param name="dbCurrentVersion"></param>
        static public void MakeDBBackup(string dbPath, string suffix) {
            DateTime now = DateTime.Now;
            string dateStr = string.Format("{0:0000}{1:00}{2:00}", now.Year, now.Month, now.Day);

            CreateDBPathIfNotExist();

            string filePath = backupPath + "\\" + dbPath + "." + suffix + "_" + dateStr;

            for (int i = 0; i < 100; i++) {
                string filePathWithCt = filePath + "_" + i;
                if (!File.Exists(filePathWithCt)) {
                    File.Copy(dbPath, filePathWithCt);
                    break;
                }
            }
        }

    }
}
