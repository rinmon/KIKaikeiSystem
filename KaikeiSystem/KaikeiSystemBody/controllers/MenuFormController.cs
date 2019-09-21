using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.controllers
{
    class MenuFormController : AbstractActivity
    {
        private KaikeiSystemBody.views.MenuForm form;

        public MenuFormController() {
            form = new KaikeiSystemBody.views.MenuForm();

            form.SwitchForm += delegate(int formId) {
                if (formId == (int)controllers.MainController.ActivityType.KaikeiDenpyou) {
                    this.MainController.SwitchActivity(
                        controllers.MainController.ActivityType.KaikeiDenpyou,
                        controllers.MainController.ActivitySwitchMethod.Push,
                        this.Context,
                        KaikeiDenpyouFormController.QueryType.EditingRows
                    );
                }
                else if (formId == (int)controllers.MainController.ActivityType.KaikeiDenpyouCurrentYear) {
                    this.MainController.SwitchActivity(
                        controllers.MainController.ActivityType.KaikeiDenpyou,
                        controllers.MainController.ActivitySwitchMethod.Push,
                        this.Context,
                        KaikeiDenpyouFormController.QueryType.CurrentYear
                    );
                }
                else if (formId == (int)controllers.MainController.ActivityType.ExitApplication) {
                    this.MainController.ExitApplication();
                }
                else if (System.Enum.IsDefined(typeof(controllers.MainController.ActivityType), formId)) {
                    this.MainController.SwitchActivity(
                        (controllers.MainController.ActivityType)formId,
                        controllers.MainController.ActivitySwitchMethod.Push,
                        this.Context,
                        null
                    );
                }
                else {
                    helper.MsgBox.Err(KaikeiSystemBody.Properties.Resources.MsgInvalidActivityType);
                }
            };
        }


        override protected void OnActivated(object option) {
            SetInfoText();
        }

        override protected void OnDeactivated() {

        }

        
        private void SetInfoText() {
            string houjin = (string)Context.KaikeiDatabase.MTKaikeiKubun.GetFirst("name", "where parent_id = -1");
            string dbPath = Context.KaikeiDatabase.DBFilePath;

            string binPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            System.Diagnostics.FileVersionInfo ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(binPath);
            string verStr = "" + ver.ProductMajorPart + "." + ver.ProductMinorPart;

            string dbVerStr = Context.Setting.GetStr("version", "0");

            form.SetInfo(houjin, dbPath, verStr, dbVerStr);
        }


        public override Form Form {
            get{return form;}
        }
    }
}
