using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using Ionic.Zlib;

namespace Archiver
{
    public partial class Form1 : Form
    {
        private List<string> binFiles;
        private List<string> dllFiles;
        private string publishDir;
        private string binDir;
        private string dbFile;
        private string dbUpdateFile;
        private string dstDbFile;

        private string workDir;

        public Form1() {
            InitializeComponent();

            workDir = Environment.CurrentDirectory + "\\work";
            if (!System.IO.Directory.Exists(workDir)) {
                System.IO.Directory.CreateDirectory(workDir);
            }
            Environment.CurrentDirectory = workDir;

            GetFileNames();
            ShowFileNames();
        }


        private void GetFileNames() {
            publishDir = "..\\" + Archiver.Properties.Settings.Default.publishDir;
            binDir = "..\\" + Archiver.Properties.Settings.Default.binDir;
            dbFile = Archiver.Properties.Settings.Default.dbFile;
            dstDbFile = Archiver.Properties.Settings.Default.dstDbFile;
            dbUpdateFile = Archiver.Properties.Settings.Default.dbUpdateFile;

            binFiles = new List<string>();
            dllFiles = new List<string>();

            foreach (var binFile in Archiver.Properties.Settings.Default.binFiles) {
                binFiles.Add(binFile);
            }

            foreach (string dll in System.IO.Directory.GetFiles(publishDir, "*.dll")) {
                dllFiles.Add(System.IO.Path.GetFileName(dll));
            }
        }


        private void ShowFileNames() {
            listInfo.Items.Add("<bin files>");
            foreach (var file in binFiles) {
                listInfo.Items.Add(file);
            }
            listInfo.Items.Add("");

            listInfo.Items.Add("<dll files>");
            foreach (var file in dllFiles) {
                listInfo.Items.Add(file);
            }
            listInfo.Items.Add("");

            listInfo.Items.Add("<db file>");
            listInfo.Items.Add(dbFile);
            listInfo.Items.Add("");

            listInfo.Items.Add("<db update file>");
            listInfo.Items.Add(dbUpdateFile);
            listInfo.Items.Add("");
        }


        private void btnMakeUpdateArchive_Click(object sender, EventArgs e) {
            using (ZipFile zip = new ZipFile(Encoding.GetEncoding("shift_jis"))) {
                zip.CompressionLevel = CompressionLevel.BestCompression;
                //ファイルを追加

                AddBinFilesToZip(zip, ".update");

                CopyFile(publishDir + "\\" + dbUpdateFile, dbUpdateFile);
                zip.AddFile(dbUpdateFile);

                string target = "v" +
                    GetVersionStr(binDir + "\\" + Archiver.Properties.Settings.Default.mainBin) + ".zip";
                zip.Save(target);
            }

            MessageBox.Show("正常終了");
        }


        private void btnMakeFullArchive_Click(object sender, EventArgs e) {
            using (ZipFile zip = new ZipFile(Encoding.GetEncoding("shift_jis"))) {
                zip.CompressionLevel = CompressionLevel.BestCompression;
                //ファイルを追加

                AddDllFilesToZip(zip);
                AddBinFilesToZip(zip, "");

                CopyFile(publishDir + "\\" + dbUpdateFile, dbUpdateFile);
                CopyFile(publishDir + "\\" + dbFile, dstDbFile);
                RunDatabaseUpdater(dstDbFile, dbUpdateFile);
                zip.AddFile(dstDbFile);

                string target = Archiver.Properties.Settings.Default.archivePrefix + "v" +
                    GetVersionStr(binDir + "\\" + Archiver.Properties.Settings.Default.mainBin) + ".zip";
                zip.Save(target);
            }

            MessageBox.Show("正常終了");
        }


        private void AddDllFilesToZip(ZipFile zip) {
            foreach (var dllFile in dllFiles) {
                CopyFile(publishDir + "\\" + dllFile, dllFile);
                zip.AddFile(dllFile);
            }
        }

        private void AddBinFilesToZip(ZipFile zip, string suffix) {
            foreach (var binFile in binFiles) {
                CopyFile(binDir + "\\" + binFile, binFile + suffix);
                zip.AddFile(binFile + suffix);
            }
        }


        private void CopyFile(string srcFileName, string dstFileName) {
            if (System.IO.File.Exists(dstFileName)) {
                System.IO.File.Delete(dstFileName);
            }
            System.IO.File.Copy(srcFileName, dstFileName);
        }


        private void RunDatabaseUpdater(string dbPath, string dbScriptPath) {
            if (System.IO.File.Exists(dbScriptPath)) {
                System.Diagnostics.Process p =
                    System.Diagnostics.Process.Start(Archiver.Properties.Settings.Default.dbUpdater, dbPath + " " + dbScriptPath + " withoutBackup");
                p.WaitForExit();
            }
        }

        private string GetVersionStr(string binName) {
            System.Diagnostics.FileVersionInfo ver =
                System.Diagnostics.FileVersionInfo.GetVersionInfo(binName);
            string currentVersion = string.Format("{0:D8}", ver.ProductMajorPart * 10000 + ver.ProductMinorPart);
            return currentVersion;
        }
    }
}
