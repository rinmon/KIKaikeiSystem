using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using Ionic.Zlib;

namespace LicenseClient
{
    class CommandExecutor
    {
        public static event Action<string> PrintLogMsg = delegate(string m) { };


        public static bool Update(LicenseClient client, int currentVersion, string targetDir, string targetBinName, bool silent = false) {
            int lastVersion = client.GetLastVersion();

            // Error
            if (lastVersion == -1) {
                MessageBox.Show("サーバとの接続に失敗しました。ネットワーク接続に問題があるか、アカウントの設定が間違えています。", "license client");
                return false;
            }

            PrintLogMsg("現行バージョン：" + currentVersion);
            PrintLogMsg("最新バージョン：" + lastVersion);

            if (lastVersion <= currentVersion) {
                if (silent == false) {
                    MessageBox.Show("新しいアップデートは存在しません", "license client");
                }
                return false;
            }

            DialogResult res = MessageBox.Show("新しいバージョンが存在します。アップデートを実行しますか？", "license client", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes) {
                return false;
            }

            string fileName;
            try {
                fileName = System.IO.Path.GetTempFileName();
            }
            catch (System.IO.IOException) {
                MessageBox.Show("一時ファイルの作成に失敗しました。システムの一時ファイルのフォルダを整理してください。");
                return false;
            }

            if (client.DownloadBinary(lastVersion, fileName) == false) {
                MessageBox.Show("ダウンロードに失敗しました", "license client");
                return false;
            }

            if (!silent) {
                if (CommandExecutor.ExitTargetProcess(targetDir, targetBinName) == false) {
                    MessageBox.Show(targetBinName + "の終了に失敗しました。");
                    return false;
                }
            }

            if (ExtractZipFile(fileName, targetDir) == false) {
                MessageBox.Show("ファイルの展開に失敗しました", "license client");
                return false;           
            }

            if (System.IO.File.Exists(fileName)) {
                try {
                    System.IO.File.Delete(fileName);
                }
                catch (Exception) {
                    MessageBox.Show("一時ファイルの削除に失敗しました。", "license client");
                }
            }

            PrintLogMsg("Version" + lastVersion + "に更新しました。");
            MessageBox.Show("正常終了", "license client");

            return true;
        }


        public static bool GetLicense(LicenseClient client, string fileName) {
            return client.DownloadLicenseFile(fileName);
        }


        private static bool ExtractZipFile(string zipFileName, string targetDir){
            var option = new ReadOptions { Encoding = Encoding.GetEncoding("shift_jis") };
            using (ZipFile zip = ZipFile.Read(zipFileName, option)) {
                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;

                foreach (var entry in zip) {
                    while (true) {
                        try {
                            string targetFile = targetDir + "\\" + entry.FileName;
                            if (System.IO.File.Exists(targetFile)) {
                                System.IO.File.Delete(targetFile);
                            }
                            entry.Extract(targetDir);
                            break;
                        }
                        catch (ZipException) {
                            string tmpFile = targetDir + "\\" + entry.FileName + ".tmp";
                            if (System.IO.File.Exists(tmpFile)) {
                                System.IO.File.Delete(tmpFile);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }


        private static bool ExitTargetProcess(string targetDir, string targetBinName) {

            /*
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();

            foreach (System.Diagnostics.Process p in ps) {
                if (p.MainModule.FileName == (targetDir + "\\" + targetBinName)) {
                    p.CloseMainWindow();
                    p.WaitForExit(1000);

                    if (p.HasExited) {
                    }
                    else{
                        return false;
                    }
                }
            }
             */

            MessageBox.Show("実行中の" + targetBinName + "を終了してください", "license client");

            return true;
        }
    }
}
