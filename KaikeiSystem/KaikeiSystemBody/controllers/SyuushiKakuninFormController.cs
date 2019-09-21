using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class SyuushiKakuninFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.SyuushiKakuninForm form;
        private grid.DBPanelGridController<views.grid.SyuushiKakuninRow> gridController;

        public SyuushiKakuninFormController() {
            form = new KaikeiSystemBody.views.SyuushiKakuninForm();
            form.TargetDateChanged += TargetDateChanged;
            form.ShowAllButtonClicked += ShowAllButtonClicked;

            form.ShowAddDenpyouViewButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.KaikeiDenpyou,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    this.Context,
                    KaikeiDenpyouFormController.QueryType.EditingRows
                );
            };

            form.ShowEditDenpyouViewButtonClicked += delegate() {
                this.MainController.SwitchActivity(
                    controllers.MainController.ActivityType.KaikeiDenpyou,
                    controllers.MainController.ActivitySwitchMethod.Change,
                    this.Context,
                    KaikeiDenpyouFormController.QueryType.CurrentYear
                );
            };

            form.ReturnToMenuButtonClicked += delegate() {
                this.MainController.PopActivity();
            };

            gridController = new grid.DBPanelGridController<views.grid.SyuushiKakuninRow>(form.Grid, false);
        }


        public override Form Form {
            get { return form; }
        }


        override protected void OnActivated(object option) {
            InitTargetDateComboBox();
            gridController.SetTable(Context.KaikeiDatabase.KaikeiDenpyouMeisai);
            ChangeQuery(null);
        }

        override protected void OnDeactivated() {
        }

        private void ChangeQuery(DateTime? targetDate) {
            (gridController.DBTable as models.db.tables.KaikeiDenpyouMeisai).UpdateEditingRows();

            var condition = "where (1=1)";

            if (targetDate == null) {
                form.TargetDate = targetDate; 

                var kisanbi = Context.Setting.GetStr("nenndo_kisanbi", "");
                if (kisanbi != "" && helper.Converter.IsDateStr(kisanbi)) {
                    int kisaibi_int = helper.Converter.DateTimeToInt(helper.Converter.DateStrToDateTime(kisanbi));
                    condition += "and kihyoubi >= " + kisaibi_int.ToString();
                }
            }
            else {
                int min = targetDate.Value.Year * 10000 + targetDate.Value.Month * 100 + 0;
                int max = targetDate.Value.Year * 10000 + targetDate.Value.Month * 100 + 99;
                condition += string.Format("and {0} <= kihyoubi and kihyoubi <= {1}", min, max);
            }

            var sortOrder = " order by kihyoubi, id";

            gridController.SetQuery(condition + sortOrder);

            {
                long sum = Context.KaikeiDatabase.KaikeiDenpyouMeisai.SelectSum("karikata_kingaku", condition);
                form.SumAmountText = helper.Converter.LongToAmount(sum);
            }
        }


        private void InitTargetDateComboBox() {
            form.ClearTargetDateComboBox();
            var reader = Context.KaikeiDatabase.ExecuteReader("select distinct kihyoubi_gengou, kihyoubi_year, kihyoubi_month from " + Context.KaikeiDatabase.KaikeiDenpyouMeisai.TableName + " order by denpyou_bangou desc");
            while (reader.Read()) {
                if (reader.IsDBNull(0) || reader.IsDBNull(1) || reader.IsDBNull(2)) {
                    continue;
                }
                string gengou = reader.GetString(0);
                int year = reader.GetInt32(1);
                int month = reader.GetInt32(2);
                DateTime? date = helper.Converter.ObjToDateTime(gengou, year, month, 1);
                if(date != null){
                    form.AddTargetDateComboBoxItem(date.Value);
                }
            }
        }


        private void ShowAllButtonClicked() {
            ChangeQuery(null);
        }


        private void TargetDateChanged(DateTime? targetDate) {
            if (targetDate == null) {
                ChangeQuery(null);
            }
            else {
                ChangeQuery(targetDate);
            }
        }
    }
}
