using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace DatabaseUpdater
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if (args.Length < 2) {
                MessageBox.Show("実行時引数エラー", "DatabaseUpdater");
                return;
            }

            string dbFileName = args[0];
            string updateFile = args[1];
            bool withoutBackup = false;

            if (args.Length >= 3 && args[2] == "withoutBackup") {
                withoutBackup = true;
            }

            if ((File.Exists(dbFileName) && File.Exists(updateFile)) == false) {
                return;
            }

            List<string> updateCommandList = new List<string>();

            bool result = true;
            int dbCurrentVersion = ReadDBVersion(dbFileName);
            updateCommandList = ReadUpdateCommands(updateFile, dbCurrentVersion);
            if (updateCommandList != null && updateCommandList.Count > 0) {
                if (withoutBackup == false) {
                    MakeDBBackup(dbFileName, dbCurrentVersion);
                }
                result = ExecuteUpdate(dbFileName, updateCommandList);

            }

            if (updateCommandList != null && result == true && File.Exists(updateFile)) {
                File.Delete(updateFile);
            }
        }


        static void MakeDBBackup(string dbFileName, int dbCurrentVersion) {
            const string backupPath = "DatabaseUpdaterBackup";
            DateTime now = DateTime.Now;
            string dateStr = string.Format("{0:0000}{1:00}{2:00}", now.Year, now.Month, now.Day);
            if (Directory.Exists(backupPath) == false) {
                Directory.CreateDirectory(backupPath);
            }

            string filePath = backupPath + "\\" + dbFileName + ".v" + dbCurrentVersion + "_" + dateStr;

            if(!File.Exists(filePath)){
                File.Copy(dbFileName, filePath);
            }
        }


        static bool ExecuteUpdate(string dbFileName, List<string> updateCommandList) {
            System.Data.SQLite.SQLiteTransaction transaction;

            using (var conn = new SQLiteConnection("Data Source=" + dbFileName)) {
                conn.Open();
                transaction = conn.BeginTransaction();

                string line = "";

                try {
                    foreach (string cmdStr in updateCommandList) {
                        line = cmdStr;
                        if (cmdStr.Trim().Length == 0) {
                            continue; // 空白行
                        }
                        using (SQLiteCommand command = conn.CreateCommand()) {
                            command.CommandText = cmdStr;
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception e) {
                    transaction.Rollback();
                    conn.Close();
                    MessageBox.Show("DBのアップデートに失敗しました。\n" + line, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                conn.Close();

                return true;
            }
        }


        static int ReadDBVersion(string dbFileName){
            int version = 0;
            using (var conn = new SQLiteConnection("Data Source=" + dbFileName)){
                conn.Open();
                using (SQLiteCommand command = conn.CreateCommand()){
                    command.CommandText = "SELECT value FROM mt_setting WHERE key='version'";
                    using (SQLiteDataReader reader = command.ExecuteReader()){
                        while (reader.Read()){
                            int.TryParse(reader.GetString(0), out version);
                        }
                    }
                }
                conn.Close();
            }

            return version;
        }


        static List<string> ReadUpdateCommands(string updateFile, int dbCurrentVersion) {
            List<string> commandList = new List<string>();

            using(var reader = new System.IO.StreamReader(updateFile)){
                string lineBuf = "";
                string versionCmdStr = "";
                char[] cmdSeparator = new char[]{';'};
                int version;
                int insertPt = 0;

                while (!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    const string versionStrConst = "*version:";

                    if (line.Length <= 1 || line.Substring(0, 2) == "//") {
                        continue;
                    }

                    if (line.Length > versionStrConst.Length && line.Substring(0, versionStrConst.Length) == versionStrConst) {
                        if (lineBuf.Length > 0) {
                            MessageBox.Show("dbupdate.src format error\n" + lineBuf, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }

                        string versionStr = line.Split(new char[] { ':' })[1];
                        int.TryParse(versionStr, out version);

                        if (version <= dbCurrentVersion) {
                            break;
                        }
                        if (versionCmdStr == "") {
                            versionCmdStr = "update mt_setting set value='" + version + "' where key='version'";
                        }
                        insertPt = 0;
                    }
                    else {
                        if (versionCmdStr.Length == 0) {
                            MessageBox.Show("format error. バージョン行なし" + lineBuf, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                        lineBuf += line;
                        string[] cmdArray = lineBuf.Split(cmdSeparator);
                        for(int i = 0; i < cmdArray.Length - 1; i++){
                            commandList.Insert(insertPt, cmdArray[i]);
                            insertPt++;
                        }
                        lineBuf = cmdArray.Last();
                    }
                }
                commandList.Insert(insertPt, lineBuf);
                commandList.Add(versionCmdStr);
            }

            return commandList;
        }
    }
}
