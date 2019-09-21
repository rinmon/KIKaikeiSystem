using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody
{
    static class Program
    {
        const string DB_PATH = "kaikei.db";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ライセンスの確認
            /*{
                KI.LicenseFileManager license = new KI.LicenseFileManager();
                if (license.ReadFile() == false) {
                    MessageBox.Show("有効なライセンスファイルが存在しません");
                    return;
                }
                TimeSpan remain = license.LicenseDate - DateTime.Now;
                if (remain.Days < 0) {
                    MessageBox.Show("ライセンスの有効期限がすぎています");
                    return;
                }
            }*/


            // singletonクラスの初期化
            helper.Converter.Init();

            controllers.MainController main_controller = new controllers.MainController(
                controllers.MainController.ActivityType.Menu,
                DB_PATH
            );

            Application.Run(main_controller.CurrentActivity.Form);
        }
    }
}
