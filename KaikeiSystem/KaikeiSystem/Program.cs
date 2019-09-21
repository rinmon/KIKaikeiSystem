using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KaikeiSystem
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            { // licenseのチェックを無効にするバージョン
                KI.VersionManager mng = new KI.VersionManager();
                mng.CheckUpdateAndRun("KaikeiSystemBody.exe", "kaikei.db", "dbupdate.scr");
                return;
            }

            bool licenseUpdated = false;
            while (true) {
                KI.LicenseFileManager license = new KI.LicenseFileManager();
                if (license.ReadFile() == false) {
                    if (licenseUpdated == false) {
                        license.UpdateLicenseFile();
                        licenseUpdated = true;
                        continue;
                    }
                    else {
                        MessageBox.Show("有効なライセンスファイルが存在しません", "KaikeiSystem");
                        return;
                    }
                }

                TimeSpan remain = license.LicenseDate - DateTime.Now;
                if (remain.Days <= KI.LicenseFileManager.UpdateLinceseFileLimit && licenseUpdated == false) {
                    license.UpdateLicenseFile();
                    licenseUpdated = true;
                    continue;
                }

                if (remain.Days >= 0) {
                    KI.VersionManager mng = new KI.VersionManager();
                    mng.CheckUpdateAndRun("KaikeiSystemBody.exe", "kaikei.db", "dbupdate.scr");
                    return;
                }
                else {
                    MessageBox.Show("ライセンスの有効期限がすぎています", "KaikeiSystem");
                    return;
                }
            }
        }
    }
}
