using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class KanjouKamokuList
    {
        public class KanjouKamokuListRow{
            public int Index { get; set; }
            public string DaikubunCode { get; set; }
            public string DaikubunName { get; set; }
            public string KamokuCode { get; set; }
            public string KamokuName { get; set; }
            public int Hierarchy { get; set; }

            public KanjouKamokuListRow(string daikubunCode, string daikubunName, string kamokuCode, string kamokuName, int hierarchy) {
                DaikubunCode = daikubunCode;
                DaikubunName = daikubunName;
                KamokuCode = kamokuCode;
                KamokuName = kamokuName;
                Hierarchy = hierarchy;
            }

            public KanjouKamokuListRow(models.db.Row daikubunRow, models.db.Row kamokuRow, models.db.KaikeiDatabase db){
                models.db.Row kanjouRow = db.MTKanjouKamoku.GetFirstRow("where id=" + kamokuRow.GetStr("kanjou_kamoku_id"));

                DaikubunCode = daikubunRow.GetStr("name");
                DaikubunName = daikubunRow.GetStr("display_order");
                KamokuCode = kanjouRow.GetStr("kamoku");
                KamokuName = kanjouRow.GetStr("kamoku_code");
                Hierarchy = (int)kanjouRow.GetLong("hierarchy", -1);
            }
        }


        public List<KanjouKamokuListRow> Rows { get; private set; }

        private models.db.KaikeiDatabase db;


        public KanjouKamokuList(models.db.KaikeiDatabase aDB) {
            db = aDB;
        }

        public void CreateList(bool usableOnly, bool withHojoKamkou) {
            string orderStr = "order by display_order";

            Rows = new List<KanjouKamokuListRow>();

            foreach (models.db.Row rootRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.Root, order: orderStr)) {
                foreach (models.db.Row kubunRow in db.MTKamokuKubun.SelectChildren(rootRow.GetId(), order: orderStr)) {
                    foreach (models.db.Row daikubunRow in db.MTKamokuKubun.SelectChildren(kubunRow.GetId(), order: orderStr)) {
                        foreach (models.db.Row chukubunRow in db.MTKamokuKubun.SelectChildren(daikubunRow.GetId(), order: orderStr)) {
                            AddRow(daikubunRow, chukubunRow, usableOnly);
                            foreach (models.db.Row syoukubunRow in db.MTKamokuKubun.SelectChildren(chukubunRow.GetId(), order: orderStr)) {
                                AddRow(daikubunRow, syoukubunRow, usableOnly);

                                if (withHojoKamkou) {
                                    foreach (models.db.Row hojokamokuRow in db.MTKamokuKubun.SelectChildren(syoukubunRow.GetId(), order: orderStr)) {
                                        AddRow(daikubunRow, hojokamokuRow, usableOnly);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AddRow(models.db.Row daikubunRow, models.db.Row kamokuRow, bool usableOnly) {
            models.db.Row kanjouRow = db.MTKanjouKamoku.GetFirstRow("where id=" + kamokuRow.GetStr("kanjou_kamoku_id"));

            if (usableOnly == true && kanjouRow.GetBool("usable", false) == false) {
                return;
            }
            if (kamokuRow.GetBool("deleted", false) == true) {
                return;
            }
            KanjouKamokuListRow row = new KanjouKamokuListRow(
                daikubunRow.GetStr("display_order"),
                daikubunRow.GetStr("name"),
                kanjouRow.GetStr("kamoku_code"),
                kanjouRow.GetStr("kamoku"),
                (int)kanjouRow.GetLong("hierarchy", -1));
            row.Index = Rows.Count;
            Rows.Add(row);
        }

    }
}
