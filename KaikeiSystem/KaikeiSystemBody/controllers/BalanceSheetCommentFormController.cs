using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class BalanceSheetCommentFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.BalanceSheetCommentForm form;
        private misc.FocusController focusController;
        private grid.DBPanelGridController<views.grid.BSCGenkaRow> genkaGridController;
        private grid.DBPanelGridController<views.grid.BSCKaikeiHoushinRow> kaikeiHoushinGridController;
        private grid.DBPanelGridController<views.grid.BSCZaisanRow> zaisanGridController;
        private grid.DBPanelGridController<views.grid.BSCTorikuzushiRow> torikuzushiGridController;
        private grid.DBPanelGridController<views.grid.BSCTanpoRow> tanpoGridController;
        private int tyuukiId;
        private models.db.Row tyuukiRow;

        public BalanceSheetCommentFormController() {
            tyuukiRow = null;

            form = new KaikeiSystemBody.views.BalanceSheetCommentForm();
            form.CloseButtonClicked += () => MainController.PopActivity();

            form.JuuyouKaikeiHoushinHenkouChanged += delegate() {
                if (tyuukiRow != null) {
                    tyuukiRow.Table.SetColumnValue(tyuukiRow, "juuyou_henkou", form.JuuyouKaikeiHoushinHenkou);
                    tyuukiRow.Table.Update(tyuukiRow);
                }
            };

            form.JuuyouKouhatsuJisyouChanged += delegate() {
                if (tyuukiRow != null) {
                    tyuukiRow.Table.SetColumnValue(tyuukiRow, "juuyou_kouhatsu", form.JuuyouKouhatsuJisyou);
                    tyuukiRow.Table.Update(tyuukiRow);
                }
            };

            form.ExecButtonClicked += delegate() {
                if (form.InputDate != null) {
                    if (SetNenndo(form.InputDate.Value.Year) == SetNenndoResult.Inserted) {
                        helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgInsertSuccess);
                    }
                    else{
                        helper.MsgBox.Info(KaikeiSystemBody.Properties.Resources.MsgSearchSuccess);
                    }
                }
                else {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidDate);
                }
            };

            genkaGridController = new grid.DBPanelGridController<views.grid.BSCGenkaRow>(form.GenkaGrid, true);
            genkaGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            kaikeiHoushinGridController = new grid.DBPanelGridController<views.grid.BSCKaikeiHoushinRow>(form.KaikeiHoushinGrid, true);
            kaikeiHoushinGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
                row.Table.SetColumnValue(row, "seiri_bangou", row.Table.GetMax("seiri_bangou") + 1);
            };

            zaisanGridController = new grid.DBPanelGridController<views.grid.BSCZaisanRow>(form.ZaisanGrid, true);
            zaisanGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            torikuzushiGridController = new grid.DBPanelGridController<views.grid.BSCTorikuzushiRow>(form.TorikuzushiGrid, true);
            torikuzushiGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            tanpoGridController = new grid.DBPanelGridController<views.grid.BSCTanpoRow>(form.TanpoGrid, true);
            tanpoGridController.InitInsertedRow += delegate(models.db.Row row) {
                row.Table.SetColumnValue(row, "tyuuki_id", tyuukiId);
            };

            focusController = new misc.FocusController(form);

            tyuukiId = 0;
        }


        public override Form Form {
            get {
                return form;
            }
        }


        public void SetInitialData(int year) {
            models.db.Row tyuuki = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki.NewRow();
            tyuuki.Table.SetColumnValue(tyuuki, "nenndo", year);
            tyuuki.Table.SetColumnValue(tyuuki, "juuyou_henkou", KaikeiSystemBody.Properties.Resources.ConstantTokuhitsujikouNasi);
            tyuuki.Table.SetColumnValue(tyuuki, "juuyou_kouhatsu", KaikeiSystemBody.Properties.Resources.ConstantTokuhitsujikouNasi);
            tyuuki.Table.Insert(tyuuki);
            tyuuki = tyuuki.Table.LastInsertedRow();

            int tyuukiId = (int)tyuuki.GetLong("id", -1);

            models.db.Row tyuuki1 = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki1.NewRow();
            tyuuki1.Table.SetColumnValue(tyuuki1, "tyuuki_id", tyuukiId);
            tyuuki1.Table.SetColumnValue(tyuuki1, "seiri_bangou", 1);
            tyuuki1.Table.SetColumnValue(tyuuki1, "koumoku_mei", KaikeiSystemBody.Properties.Resources.ConstantTokuhitsujikouNasi);
            tyuuki1.Table.SetColumnValue(tyuuki1, "naiyou", "");
            tyuuki1.Table.Insert(tyuuki1);

            foreach (var row in Context.KaikeiDatabase.MTKaikeiKubun.Select("order by kubun_code ")) {
                int kaikeiKubunId = (int)row.GetLong("id", -1);
                var children = Context.KaikeiDatabase.MTKaikeiKubun.Select("where parent_id=" + kaikeiKubunId);
                if (children.Count() > 0) {
                    continue;
                }

                models.db.Row kyakutyuu = Context.KaikeiDatabase.TaisyakuTaisyouhyouKyakutyuu.NewRow();
                kyakutyuu.Table.SetColumnValue(kyakutyuu, "tyuuki_id", tyuukiId);
                kyakutyuu.Table.SetColumnValue(kyakutyuu, "kaikei_kubun", kaikeiKubunId);
                kyakutyuu.Table.SetColumnValue(kyakutyuu, "genka_baikyaku_ruikei", 0);
                kyakutyuu.Table.SetColumnValue(kyakutyuu, "tyousyuu_hunou_kin", 0);
                kyakutyuu.Table.Insert(kyakutyuu);

                models.db.Row tyuuki3 = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki3.NewRow();
                tyuuki3.Table.SetColumnValue(tyuuki3, "tyuuki_id", tyuukiId);
                tyuuki3.Table.SetColumnValue(tyuuki3, "kaikei_kubun", kaikeiKubunId);
                tyuuki3.Table.SetColumnValue(tyuuki3, "kamoku_id", 0);
                tyuuki3.Table.SetColumnValue(tyuuki3, "tekiyou", KaikeiSystemBody.Properties.Resources.ConstantTokuhitsujikouNasi);
                tyuuki3.Table.SetColumnValue(tyuuki3, "amount", 0);
                tyuuki3.Table.Insert(tyuuki3);

                models.db.Row tyuuki4 = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki4.NewRow();
                tyuuki4.Table.SetColumnValue(tyuuki4, "tyuuki_id", tyuukiId);
                tyuuki4.Table.SetColumnValue(tyuuki4, "kaikei_kubun", kaikeiKubunId);
                tyuuki4.Table.SetColumnValue(tyuuki4, "naiyou", KaikeiSystemBody.Properties.Resources.ConstantTokuhitsujikouNasi);
                tyuuki4.Table.Insert(tyuuki4);

                for (int tanpoKubun = 1; tanpoKubun <= 2; tanpoKubun++) {
                    models.db.Row tyuuki5 = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki5.NewRow();
                    tyuuki5.Table.SetColumnValue(tyuuki5, "tyuuki_id", tyuukiId);
                    tyuuki5.Table.SetColumnValue(tyuuki5, "kaikei_kubun", kaikeiKubunId);
                    tyuuki5.Table.SetColumnValue(tyuuki5, "tanpo_kubun", tanpoKubun);
                    tyuuki5.Table.SetColumnValue(tyuuki5, "kamoku_id", 0);
                    tyuuki5.Table.SetColumnValue(tyuuki5, "amount", 0);
                    tyuuki5.Table.Insert(tyuuki5);
                }
            }
        }


        private enum SetNenndoResult {
            Inserted,
            Searched,
            Failed,
        }

        private SetNenndoResult SetNenndo(int year) {
            bool inserted = false;

            var rows = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki.Select("where nenndo=" + year);
            if (rows.Count() == 0) {
                SetInitialData(year);
                rows = Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki.Select("where nenndo=" + year);
                if (rows.Count() == 0) {
                    System.Diagnostics.Debug.Print("貸借対照表注記　登録失敗");
                    return SetNenndoResult.Failed;
                }
                inserted = true;
            }

            models.db.Row row = rows.First();
            tyuukiRow = row;
            tyuukiId = (int)row.GetLong("id", 0);
            form.JuuyouKaikeiHoushinHenkou = row.GetStr("juuyou_henkou");
            form.JuuyouKouhatsuJisyou = row.GetStr("juuyou_kouhatsu");

            string sql = "where tyuuki_id=" + tyuukiId;

            genkaGridController.SetQuery(sql);
            kaikeiHoushinGridController.SetQuery(sql);
            zaisanGridController.SetQuery(sql);
            torikuzushiGridController.SetQuery(sql);
            tanpoGridController.SetQuery(sql);

            form.SetCurrentYear(year);

            if (inserted) {
                return SetNenndoResult.Inserted;
            }
            else {
                return SetNenndoResult.Searched;
            }
        }


        override protected void OnActivated(object option) {
            genkaGridController.SetTable(Context.KaikeiDatabase.TaisyakuTaisyouhyouKyakutyuu);
            kaikeiHoushinGridController.SetTable(Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki1);
            zaisanGridController.SetTable(Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki3);
            torikuzushiGridController.SetTable(Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki4);
            tanpoGridController.SetTable(Context.KaikeiDatabase.TaisyakuTaisyouhyouTyuuki5);

            {
                DateTime? kisanbi = Context.Setting.GetDateTime("nenndo_kisanbi");
                if(kisanbi != null){
                    SetNenndo(kisanbi.Value.Year);
                }

                form.InitInputDateStr(Context.Setting.GetStr("before_gengou", ""), "");
            }
        }

        override protected void OnDeactivated() {
        }
    }
}
