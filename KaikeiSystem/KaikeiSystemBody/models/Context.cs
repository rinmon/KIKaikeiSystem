using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models
{
    class Context
    {
        public db.KaikeiDatabase KaikeiDatabase {
            get;
            set;
        }

        public models.db.mtables.MTSetting Setting {
            get {
                return KaikeiDatabase.MTSetting;
            }
        }

        public Context(db.KaikeiDatabase db) {
            KaikeiDatabase = db;
        }
    }
}
