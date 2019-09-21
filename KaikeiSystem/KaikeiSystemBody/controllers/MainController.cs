using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    /// <summary>
    /// アプリケーション全体の状態遷移の管理
    /// </summary>
    class MainController
    {
        public enum ActivitySwitchMethod
        {
            Push,
            PushModal,
            Change
        }

        public enum ActivityType
        {
            Menu = 0,
            KaikeiDenpyou = 1,
            KaikeiDenpyouCurrentYear = 2,
            SyuushiKakunin = 3,
            KanjouMototyou = 11,
            ShikinSyuushi = 12,
            JigyouSyuushi = 13,
            BalanceSheet = 14,
            BalanceSheetComment = 15,
            Tyuuki = 16,
            PrintMain = 21,
            Yosan = 61,
            YosanJisseki = 62,
            ZenkiKurikoshi = 63,
            KoteiShisan = 64,
            IkkatsuTourokuMaster = 65,
            KanjouKamoku = 71,
            Daikubun = 72,
            Tekiyou = 73,
            KaikeiTanni = 74,
            TorihikiKubun = 75,
            HoujinShisetsu = 81,
            KurikoshiSyori = 83,

            ExitApplication = 99,

            RootMenu = 901,

            // Dialog
            PrintYosan = 1001,
        }


        private Stack<AbstractActivity> activityStack;
        private Dictionary<ActivityType, AbstractActivity> activityHash;
        private KaikeiSystemBody.models.Context mainContext;


        public MainController(ActivityType initialActivity, string dbPath) {
            { // init context
                //var setting = new KaikeiSystemBody.models.Setting();
                var db = new KaikeiSystemBody.models.db.KaikeiDatabase(dbPath);
                //try {
                db.Open();
                db.InitTables(false);
                // }
                //catch (Exception e) {
                //    MessageBox.Show(KaikeiSystemBody.Properties.Resources.MSG_DB_OPEN_ERROR + " : " + e.Message);
                //}
                mainContext = new KaikeiSystemBody.models.Context(db);
            }

            /*if (mainContext.KaikeiDatabase.MTKamokuKubun.SetKanjouKamokuIdForAllRow()) {
                System.Windows.Forms.MessageBox.Show("set kaikei kamoku id ok!!");
            }
            else{
                System.Windows.Forms.MessageBox.Show("set kaikei kamoku id NG!!");
            }*/
            //mainContext.KaikeiDatabase.MTKamokuKubun.SetDislayOrderForAllRow();

            { // init activity
                activityStack = new Stack<AbstractActivity>();
                activityHash = new Dictionary<ActivityType, AbstractActivity>();
                AbstractActivity activity = GetActivity(initialActivity);
                activityStack.Push(activity);
                activity.ShowForm(100, 100, mainContext, null);
            }

            { // backup db
                helper.DBBackup.ExecutePeriodicDBBackup(mainContext.KaikeiDatabase.DBFilePath, "daily", 7, 1, mainContext.KaikeiDatabase.MTSetting);
                helper.DBBackup.ExecutePeriodicDBBackup(mainContext.KaikeiDatabase.DBFilePath, "weekly", 4, 7, mainContext.KaikeiDatabase.MTSetting);
                helper.DBBackup.ExecutePeriodicDBBackup(mainContext.KaikeiDatabase.DBFilePath, "monthly", 12, 30, mainContext.KaikeiDatabase.MTSetting);
            }

            { // load csv (for test)
                /*
                models.db.KaikeiDenpyouMeisai tbl = mainContext.KaikeiDatabase.Table(models.db.KaikeiDenpyouMeisai.TABLE_NAME) as models.db.KaikeiDenpyouMeisai;
                tbl.LoadCSV("denpyou.txt");
                models.db.MTKamoku tbl = main_context_.KaikeiDatabase.Table(models.db.MTKamoku.TABLE_NAME) as models.db.MTKamoku;
                tbl.LoadCSV("MTkamoku.txt");
                models.db.MTKaikeiTanni tbl = main_context_.KaikeiDatabase.Table(models.db.MTKaikeiTanni.TABLE_NAME) as models.db.MTKaikeiTanni;
                tbl.LoadCSV("MTKaikeiTanni.txt");
                models.db.MTTorihikiKubun tbl = main_context_.KaikeiDatabase.Table(models.db.MTTorihikiKubun.TABLE_NAME) as models.db.MTTorihikiKubun;
                tbl.LoadCSV("MTTorihikiKubun.txt");
                models.db.MTDaikubun tbl = main_context_.KaikeiDatabase.Table(models.db.MTDaikubun.TABLE_NAME) as models.db.MTDaikubun;
                tbl.LoadCSV("MTDaikubun.txt");
                models.db.MTHojoKamoku tbl = main_context_.KaikeiDatabase.Table(models.db.MTHojoKamoku.TABLE_NAME) as models.db.MTHojoKamoku;
                tbl.LoadCSV("MTHojoKamoku.txt");
                models.db.MTHoujinShisetsu tbl = main_context_.KaikeiDatabase.Table(models.db.MTHoujinShisetsu.TABLE_NAME) as models.db.MTHoujinShisetsu;
                tbl.LoadCSV("MTHoujinShisetsu.txt");
                models.db.MTSetting tbl = main_context_.KaikeiDatabase.Table(models.db.MTSetting.TABLE_NAME) as models.db.MTSetting;
                tbl.LoadCSV("MTSetting.txt");
                models.db.MTIkkatsuSyori tbl = main_context_.KaikeiDatabase.MTIkkatsuSyori;
                tbl.LoadCSV("MTIkkatsuSyori.txt");
                models.db.ZenkiKurikoshiKamoku tbl = mainContext.KaikeiDatabase.ZenkiKurikoshiKamoku;
                tbl.LoadCSV("ZenkiKurikoshiKamoku.txt");
                models.db.ZenkiKurikoshiHojoKamoku tbl = mainContext.KaikeiDatabase.ZenkiKurikoshiHojoKamoku;
                tbl.LoadCSV("ZenkiKurikoshiHojoKamoku.txt");
                for (int year = 2008; year <= 2010; year++) {
                    models.db.KaikeiDenpyouMeisai denpyou = mainContext.KaikeiDatabase.BackupTable<models.db.KaikeiDenpyouMeisai>(
                        models.db.KaikeiDenpyouMeisai.TABLE_NAME, year, true);
                    denpyou.LoadCSV(year.ToString() + "_denpyou_meisai.txt");

                    models.db.ZenkiKurikoshiKamoku kamoku = mainContext.KaikeiDatabase.BackupTable<models.db.ZenkiKurikoshiKamoku>(
                        models.db.ZenkiKurikoshiKamoku.TABLE_NAME, year, true);
                    kamoku.LoadCSV(year.ToString() + "_kurikoshi_kamoku.txt");

                    models.db.ZenkiKurikoshiHojoKamoku hojo = mainContext.KaikeiDatabase.BackupTable<models.db.ZenkiKurikoshiHojoKamoku>(
                        models.db.ZenkiKurikoshiHojoKamoku.TABLE_NAME, year, true);
                    hojo.LoadCSV(year.ToString() + "_kurikoshi_hojo.txt");
                }
                models.db.MTShikinSyuushiKoumoku tbl = mainContext.KaikeiDatabase.MTShikinSyuushiKoumoku;
                tbl.LoadCSV("MTShikinSyuushiKoumoku.txt");
                models.db.MTJigyouKatsudouSyuushiKoumoku tbl = mainContext.KaikeiDatabase.MTJigyouKatsudouSyuushiKoumoku;
                tbl.LoadCSV("MTJigyouKatsudouSyuushiKoumoku.txt");
                models.db.TaisyakuTaisyouhyouTyuuki tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki;
                tbl.LoadCSV("TaisyakuTaisyouhyouTyuuki.txt");
                models.db.TaisyakuTaisyouhyouTyuuki1 tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki1;
                tbl.LoadCSV("TaisyakuTaisyouhyouTyuuki1.txt");
                models.db.TaisyakuTaisyouhyouTyuuki3 tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki3;
                tbl.LoadCSV("TaisyakuTaisyouhyouTyuuki3.txt");
                models.db.TaisyakuTaisyouhyouTyuuki4 tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki4;
                tbl.LoadCSV("TaisyakuTaisyouhyouTyuuki4.txt");
                models.db.TaisyakuTaisyouhyouTyuuki5 tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki5;
                tbl.LoadCSV("TaisyakuTaisyouhyouTyuuki5.txt");
                models.db.TaisyakuTaisyouhyouKyakutyuu tbl = mainContext.KaikeiDatabase.TaisyakuTaisyouhyouKyakutyuu;
                tbl.LoadCSV("TaisyakuTaisyouhyouKyakutyuu.txt");
                models.db.MTYosanKubun tbl = mainContext.KaikeiDatabase.MTYosanKubun;
                tbl.LoadCSV("MTYosanKubun.txt");
                models.db.tables.YosanKamoku tbl = mainContext.KaikeiDatabase.YosanKamoku;
                tbl.LoadCSV("YosanKamoku.txt");
                models.db.tables.YosanHojokamoku tbl3 = mainContext.KaikeiDatabase.YosanHojokamoku;
                tbl3.LoadCSV("YosanHojokamoku.txt");
                models.db.tables.YosanDaikubun tbl4 = mainContext.KaikeiDatabase.YosanDaikubun;
                tbl4.LoadCSV("YosanDaikubun.txt");
                models.db.tables.YosanYobihi tbl2 = mainContext.KaikeiDatabase.YosanYobihi;
                tbl2.LoadCSV("YosanYobihi.txt");
                models.db.mtables.MTSyoukyakuKahi tbl = mainContext.KaikeiDatabase.MTSyoukyakuKahi;
                tbl.LoadCSV("MTSyoukyakuKahi.txt");
                models.db.mtables.MTSyoukyakuKubun tbl = mainContext.KaikeiDatabase.MTSyoukyakuKubun;
                tbl.LoadCSV("MTSyoukyakuKubun.txt");
                models.db.mtables.MTSyoukyakuHouhou tbl = mainContext.KaikeiDatabase.MTSyoukyakuHouhou;
                tbl.LoadCSV("MTSyoukyakuHouhou.txt");
                models.db.mtables.MTZoukaJiyuu tbl = mainContext.KaikeiDatabase.MTZoukaJiyuu;
                tbl.LoadCSV("MTZoukaJiyuu.txt");
                models.db.mtables.MTTaiyouNennsuu tbl = mainContext.KaikeiDatabase.MTTaiyouNennsuu;
                tbl.LoadCSV("MTTaiyouNennsuu.txt");
                models.db.mtables.MTKoteiShisan tbl = mainContext.KaikeiDatabase.MTKoteiShisan;
                tbl.LoadCSV("MTKoteiShisan.txt");
                models.db.mtables.MTKeijouHouhou tbl = mainContext.KaikeiDatabase.MTKeijouHouhou;
                tbl.LoadCSV("MTKeijouHouhou.txt");
                models.db.mtables.MTGensyouJiyuu tbl = mainContext.KaikeiDatabase.MTGensyouJiyuu;
                tbl.LoadCSV("MTGensyouJiyuu.txt");
                models.db.tables.GenkaSyoukyakuMeisai tbl = mainContext.KaikeiDatabase.GenkaSyoukyakuMeisai;
                tbl.LoadCSV("GenkaSyoukyakuMeisai.txt");
                models.db.mtables.MTKanrisya tbl = mainContext.KaikeiDatabase.MTKanrisya;
                tbl.LoadCSV("MTKanrisya.txt");
                models.db.mtables.MTTaisyakuTaisyouKoumoku tbl = mainContext.KaikeiDatabase.MTTaisyakuTaisyouKoumoku;
                tbl.LoadCSV("MTTaisyakuTaisyouKoumoku.txt");
                models.db.mtables.MTTekiyou tbl = mainContext.KaikeiDatabase.Table(models.db.mtables.MTTekiyou.TABLE_NAME) as models.db.mtables.MTTekiyou;
                tbl.LoadCSV("MTTekiyou.txt");
                models.db.mtables.MTHoujinDantai tbl = mainContext.KaikeiDatabase.MTHoujinDantai;
                tbl.LoadCSV("MTHoujinDantai.txt");
                models.db.mtables.MTTaisyakuKubun tbl = mainContext.KaikeiDatabase.MTTaisyakuKubun;
                tbl.LoadCSV("MTTaisyakuKubun.txt");
                */
            }
        }


        public bool SwitchActivity(ActivityType activity_type, ActivitySwitchMethod method, KaikeiSystemBody.models.Context context, object option = null) {
            var next_activity = GetActivity(activity_type);
            var form_x = CurrentActivity.Form.Left;
            var form_y = CurrentActivity.Form.Top;
            var form_w = CurrentActivity.Form.Width;
            var form_h = CurrentActivity.Form.Height;

            switch (method) {
                case ActivitySwitchMethod.Change:
                    CurrentActivity.HideForm();
                    activityStack.Pop();
                    activityStack.Push(next_activity);
                    CurrentActivity.ShowForm(form_x, form_y, context, option);
                    break;
                case ActivitySwitchMethod.Push:
                    CurrentActivity.HideForm();
                    activityStack.Push(next_activity);
                    CurrentActivity.ShowForm(form_x, form_y, context, option);
                    break;
                case ActivitySwitchMethod.PushModal:
                    activityStack.Push(next_activity);
                    CurrentActivity.ShowFormModal(form_x + form_w / 2, form_y + form_h / 2, context, option);
                    break;
            }

            return true;
        }

        public bool PopActivity() {
            if (activityStack.Count >= 2) {
                int x = CurrentActivity.Form.Left;
                int y = CurrentActivity.Form.Top;
                CurrentActivity.HideForm();
                activityStack.Pop();
                if (CurrentActivity.FormState == AbstractActivity.State.Hide) {
                    CurrentActivity.ShowForm(x, y, CurrentActivity.Context, null);
                }
                return true;
            }
            else {
                return false;
            }
        }


        public AbstractActivity CurrentActivity {
            get {
                if (activityStack.Count > 0) {
                    return activityStack.Peek();
                }
                else {
                    return null;
                }
            }
        }


        private AbstractActivity GetActivity(ActivityType key) {
            if (activityHash.ContainsKey(key)) {
                return activityHash[key];
            }
            else {
                AbstractActivity activity = null;
                switch (key) {
                    case ActivityType.Menu:
                        activity = new MenuFormController();
                        break;
                    case ActivityType.KaikeiDenpyou:
                        activity = new KaikeiDenpyouFormController();
                        break;
                    case ActivityType.SyuushiKakunin:
                        activity = new SyuushiKakuninFormController();
                        break;
                    case ActivityType.KanjouMototyou:
                        activity = new KanjouMototyouFormController();
                        break;
                    case ActivityType.ShikinSyuushi:
                        activity = new ShikinSyuushiFormController();
                        break;
                    case ActivityType.JigyouSyuushi:
                        activity = new JigyouSyuushiFormController();
                        break;
                    case ActivityType.BalanceSheet:
                        activity = new BalanceSheetFormController();
                        break;
                    case ActivityType.BalanceSheetComment:
                        activity = new BalanceSheetCommentFormController();
                        break;
                    case ActivityType.Tyuuki:
                        activity = new TyuukiFormController();
                        break;
                    case ActivityType.PrintMain:
                        activity = new PrintMainFormController();
                        break;
                    case ActivityType.Yosan:
                        activity = new YosanFormController();
                        break;
                    case ActivityType.YosanJisseki:
                        activity = new YosanJissekiFormController();
                        break;
                    case ActivityType.KoteiShisan:
                        activity = new KoteiShisanFormController();
                        break;
                    case ActivityType.IkkatsuTourokuMaster:
                        activity = new IkkatsuSyoriMasterFormController();
                        break;
                    case ActivityType.KanjouKamoku:
                        activity = new KanjouKamokuFormController();
                        break;
                    case ActivityType.Daikubun:
                        activity = new DaikubunFormController();
                        break;
                    case ActivityType.Tekiyou:
                        activity = new TekiyouFormController();
                        break;
                    case ActivityType.KaikeiTanni:
                        activity = new KaikeiTanniFormController();
                        break;
                    case ActivityType.TorihikiKubun:
                        activity = new TorihikiKubunFormController();
                        break;
                    case ActivityType.HoujinShisetsu:
                        activity = new HoujinShisetsuFormController();
                        break;
                    case ActivityType.ZenkiKurikoshi:
                        activity = new KurikoshiFormController();
                        break;
                    case ActivityType.KurikoshiSyori:
                        activity = new KurikoshiSyoriFormController();
                        break;

                    case ActivityType.RootMenu:
                        activity = new RootMenuFormController();
                        break;

                    // dialogs

                    case ActivityType.PrintYosan:
                        activity = new PrintYosanFormController();
                        break;
                }

                activity.MainController = this;
                activity.Form.FormClosed += delegate(Object sender, FormClosedEventArgs e) {
                    if (sender == CurrentActivity.Form) {
                        if (CurrentActivity.FormState == AbstractActivity.State.ShowModal) {
                            PopActivity();
                        }
                        else{
                            ExitApplication();
                        }
                    }
                };
                
                activityHash[key] = activity;
                return activityHash[key];
            }
        }

        public void ExitApplication() {
            if (CurrentActivity != null) {
                CurrentActivity.HideForm();
            }
            mainContext.KaikeiDatabase.Close();

            var mng = new KI.VersionManager();
            mng.UpdateExeFiles();

            Application.Exit();
        }
    }
}
