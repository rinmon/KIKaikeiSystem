using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class TekiyouList
    {
        public class TekiyouListRow{
            public string TekiyouCode { get; set; }
            public string Tekiyou { get; set; }

            public TekiyouListRow(string tekiyouCode, string tekiyou) {
                TekiyouCode = tekiyouCode;
                Tekiyou = tekiyou;
            }
        }


        public List<TekiyouListRow> Rows { get; private set; }

        private models.db.KaikeiDatabase db;


        public TekiyouList(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void CreateList() {
            string orderStr = "order by tekiyou_code";

            Rows = new List<TekiyouListRow>();

            foreach (models.db.Row tekiyouRow in db.MTTekiyou.Select(orderStr)) {
                var row = new TekiyouListRow(tekiyouRow.GetStr("tekiyou_code"), tekiyouRow.GetStr("tekiyou_mei"));
                Rows.Add(row);
            }
        }

    }
}
