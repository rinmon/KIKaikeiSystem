using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaikeiSystemBody.views
{
    partial class PrintMainForm : Form
    {
        private models.db.KaikeiDatabase db;

        [Flags]
        public enum PrintTarget {
            MTKanjouKamoku = 0x0001,            // 勘定科目
            MTTekiyou = 0x0002,                 // 摘要
            ShiwakeDenpyou = 0x0004,            // 仕訳伝票
            ShiwakeNikki = 0x0008,              // 仕訳日記
            KessanHyoushi = 0x0010,             // 決算表紙
            KessanShikinKeisan = 0x0020,        // 決算資金収支計算書
            KessanShikinUchiwake = 0x0040,      // 決算資金収支内訳表
            KessanShikinKeisanHosei3 = 0x0080, // 決算資金収支計算書（補正3回まで）
            KessanJigyouKeisan = 0x0100,        // 事業活動収支計算書
            KessanJigyouUchiwake = 0x0200,      // 事業活動収支内訳表
            KessanGoukeiZandakaChukubunOnly = 0x0400,       // 合計残高試算表
            KessanGoukeiZandakaWithHojokamoku = 0x0800, // 合計残高試算表(補助科目まで含む)
            KessanBalanceSheet = 0x1000, // 貸借対照表
            KoteiShisanMeisai = 0x2000, // 固定資産の明細書
            HikiatekinMeisai = 0x4000, // 固定資産の明細書
            ShiwakeDenpyouEachKamoku = 0x8000,  // 仕訳伝票（科目ごと）
            Tyuuki = 0x10000,                   // 注記
        }

        public enum DenpyouPrintMethod {
            Kihyoubi,
            Tourokubi,
            Koushinbi,
            DenpyouBangou
        }

        public enum KanjouKamokuPrintType {
            UsableOnly,
            All
        }


        public event Action CloseButtonClicked;
        public event Action PrintButtonClicked;
        public event Action PrintMototyouButtonClicked;
        public event Action PrintShisanhyouButtonClicked;
        public event Action PrintKoteiShisanButtonClicked;
        public event Action PrintYosanButtonClicked;


        public PrintTarget SelectedPrintTarget {
            get {
                PrintTarget result = 0;
                if (chkKamoku.Checked) { result |= PrintTarget.MTKanjouKamoku; }
                if (chkTekiyou.Checked) { result |= PrintTarget.MTTekiyou; }
                if (chkKessanHyoushi.Checked) { result |= PrintTarget.KessanHyoushi; }
                if (chkShikinKeisan.Checked) { result |= PrintTarget.KessanShikinKeisan; }
                if (chkShikinUchiwake.Checked) { result |= PrintTarget.KessanShikinUchiwake; }
                if (chkShikinKeisanHosei.Checked) { result |= PrintTarget.KessanShikinKeisanHosei3; }
                if (chkJigyouKeisan.Checked) { result |= PrintTarget.KessanJigyouKeisan; }
                if (chkJigyouUchiwake.Checked) { result |= PrintTarget.KessanJigyouUchiwake; }
                if (chkGoukeiZandakaChukubunOnly.Checked) { result |= PrintTarget.KessanGoukeiZandakaChukubunOnly; }
                if (chkGoukeiZandakaHojokamoku.Checked) { result |= PrintTarget.KessanGoukeiZandakaWithHojokamoku; }
                if (chkTaisyakuTaisyou.Checked) { result |= PrintTarget.KessanBalanceSheet; }
                if (chkDenpyou.Checked) { result |= PrintTarget.ShiwakeDenpyou; }
                if (chkNikki.Checked) { result |= PrintTarget.ShiwakeNikki; }
                if (chkDenpyouForEachKamoku.Checked) { result |= PrintTarget.ShiwakeDenpyouEachKamoku; }
                if (chkKoteiShisanMeisai.Checked) { result |= PrintTarget.KoteiShisanMeisai; }
                if (chkHikiatekinMeisai.Checked) { result |= PrintTarget.HikiatekinMeisai; }
                if (chkTyuuki.Checked) { result |= PrintTarget.Tyuuki; }

                return result;
            }
        }

        public DenpyouPrintMethod SelectedDenpyouPrintMethod {
            get {
                if (radioKihyoubi.Checked) {
                    return DenpyouPrintMethod.Kihyoubi;
                }
                else if (radioTourokubi.Checked) {
                    return DenpyouPrintMethod.Tourokubi;
                }
                else if (radioKoushinbi.Checked) {
                    return DenpyouPrintMethod.Koushinbi;
                }
                else if(radioDenpyouBangou.Checked) {
                    return DenpyouPrintMethod.DenpyouBangou;
                }
                return DenpyouPrintMethod.Kihyoubi;
            }
        }

        public KanjouKamokuPrintType SelectedKanjouKamokuPrintType {
            get {
                if (this.radioAllKamoku.Checked) {
                    return KanjouKamokuPrintType.All;
                }
                else {
                    return KanjouKamokuPrintType.UsableOnly;
                }
            }
        }


        public bool OnlyCheckedDenpyouPrint {
            get {
                return chkOnlyCheckedDenpyouPrint.Checked;
            }
        }


        public int KaikeiKubun {
            get {
                object key = mtKaikeiKubun.SelectedKey;
                if (key != null) {
                    return (int)key;
                }
                return -1;
            }
        }


        public DateTime? StartDate{
            get {
                return dateStart.Date;
            }
        }


        public DateTime? EndDate {
            get {
                return dateEnd.Date;
            }
        }


        public DateTime? DenpyouBangouDate {
            get {
                return dateDenpyouBangou.Date;
            }
        }


        public int? DenpyouBangouStart {
            get {
                return helper.Converter.ObjToIntObj(txtStartBangou.Text);
            }
        }


        public int? DenpyouBangouEnd {
            get {
                return helper.Converter.ObjToIntObj(txtEndBangou.Text);
            }
        }

        public models.constants.MTKamokuKubunHierarchy KamokuKubunHierarchy{
            get {
                if (cmbKamokuHierarchy.Text == Properties.Resources.CaptionHierarchyDaikubun) {
                    return models.constants.MTKamokuKubunHierarchy.Daikubun;
                }
                if (cmbKamokuHierarchy.Text == Properties.Resources.CaptionHierarchyChukubun) {
                    return models.constants.MTKamokuKubunHierarchy.ChuuKubun;
                }
                if (cmbKamokuHierarchy.Text == Properties.Resources.CaptionHierarchySyoukubun) {
                    return models.constants.MTKamokuKubunHierarchy.SyouKubun;
                }
                if (cmbKamokuHierarchy.Text == Properties.Resources.CaptionHierarchyHojokamoku) {
                    return models.constants.MTKamokuKubunHierarchy.HojoKamoku;
                }
                return models.constants.MTKamokuKubunHierarchy.Daikubun;
            }
        }

        public bool OmitZeroRow{
            get {
                return chkOmitZeroRow.Checked;
            }
        }

        public Dictionary<int, bool> GetHideTyuukiRows() {
            var rows = new Dictionary<int, bool>();

            if (chkHideTyuuki1.Checked) {
                rows.Add(1, true);
            }
            if (chkHideTyuuki3.Checked) {
                rows.Add(3, true);
            }
            if (chkHideTyuuki9.Checked) {
                rows.Add(9, true);
            }
            if (chkHideTyuuki10.Checked) {
                rows.Add(10, true);
            }
            return rows;
        }

        public PrintMainForm(){
            InitializeComponent();

            dateStart.DateChanged += delegate(object sender, DateTime? date) {
                if (date != null) {
                    dateEnd.Date = (new DateTime(date.Value.Year, date.Value.Month, 1)).AddMonths(1).AddDays(-1);
                }
            };

            btnClose.Click += (s, e) => CloseButtonClicked();
            btnPrint.Click += (s, e) => PrintButtonClicked();
            btnPrintMototyou.Click += (s, e) => PrintMototyouButtonClicked();
            btnPrintShisanhyou.Click += (s, e) => PrintShisanhyouButtonClicked();
            btnPrintKoteiShisan.Click += (s, e) => PrintKoteiShisanButtonClicked();
            btnPrintYosan.Click += (s, e) => PrintYosanButtonClicked();

            radioAllKamoku.Checked = true;
            radioKihyoubi.Checked = true;

            chkKamoku_CheckedChanged(null, null);
            chkDenpyou_CheckedChanged(null, null);
            radioDenpyouBangou_CheckedChanged(null, null);

            //区分のコンボボックスの初期化
            cmbKamokuHierarchy.Items.Add(Properties.Resources.CaptionHierarchyDaikubun);
            cmbKamokuHierarchy.Items.Add(Properties.Resources.CaptionHierarchyChukubun);
            cmbKamokuHierarchy.Items.Add(Properties.Resources.CaptionHierarchySyoukubun);
            cmbKamokuHierarchy.Items.Add(Properties.Resources.CaptionHierarchyHojokamoku);
            cmbKamokuHierarchy.SelectedIndex = 0;
        }


        public void SetGengou(string gengou) {
            dateStart.GengouStr = gengou;
            dateEnd.GengouStr = gengou;
            dateDenpyouBangou.GengouStr = gengou;
        }


        public void SetDatabase(KaikeiSystemBody.models.db.KaikeiDatabase aDB) {
            if (db != aDB) {
                db = aDB;
                mtKaikeiKubun.InitRowsWithMTKaikeiKubun(db.MTKaikeiKubun, false);
                mtKaikeiKubun.SelectedIndex = -1;
            }
        }


        private void chkKamoku_CheckedChanged(object sender, EventArgs e) {
            groupKamokuType.Enabled = chkKamoku.Checked;
        }

        private void chkDenpyou_CheckedChanged(object sender, EventArgs e) {
            //groupDenpyouPrintMethod.Enabled = chkDenpyou.Checked;
        }

        private void radioDenpyouBangou_CheckedChanged(object sender, EventArgs e) {
            panelDenpyouBangouSelector.Enabled = radioDenpyouBangou.Checked;
        }
    }
}
