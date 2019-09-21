using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LicenseClient
{
    public partial class FormMain : Form
    {
        private string serverUrl;
        private string serviceName;
        private string accountId;
        private string password;

        private string binName;
        private string binPath;

        private LicenseClient client;

        
        public FormMain() {
            InitializeComponent();
        }


        private void PrintLogMsg(string msg) {
            listBoxMessage.Items.Add(msg);
        }


        private void FormMain_Load(object sender, EventArgs e) {
            serverUrl = Properties.Settings.Default.server;
            serviceName = Properties.Settings.Default.service;
            accountId = Properties.Settings.Default.accountId;
            password = Properties.Settings.Default.password;

            binName = Properties.Settings.Default.binaryName;
            binPath = Environment.CurrentDirectory + "\\" + binName;

            client = new LicenseClient(serverUrl, serviceName, accountId, password);

            CommandExecutor.PrintLogMsg += PrintLogMsg;
        }

        private void btnUpdateLicense_Click(object sender, EventArgs e) {
            bool res = CommandExecutor.GetLicense(client, Environment.CurrentDirectory + "\\" + Properties.Settings.Default.licenseFileName);

            if (res == true) {
                MessageBox.Show("正常終了しました", "License manager");
            }
            else {
                MessageBox.Show("異常終了", "License manager");
            }
        }

        private void btnUpdateProgram_Click(object sender, EventArgs e) {
            int currentVersion;

            try {
                System.Diagnostics.FileVersionInfo ver =
                    System.Diagnostics.FileVersionInfo.GetVersionInfo(binPath);
                currentVersion = ver.ProductMajorPart * 10000 + ver.ProductMinorPart;
            }
            catch (Exception) {
                currentVersion = 0;
            }

            bool res = CommandExecutor.Update(client, currentVersion, Environment.CurrentDirectory, binName, false);

            if (res == true) {
                //MessageBox.Show("正常終了しました", "License manager");
            }
            else {
                //MessageBox.Show("異常終了", "License manager");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
