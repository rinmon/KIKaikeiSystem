using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.db
{
    class KaikeiDatabaseHandler
    {
        static Dictionary<int, int> kamokuKubunId2Id;
        static Dictionary<int, int> kanjouKamokuId2Id;
        static Dictionary<int, int> kamokuKubunId2KanjouKamokuId;

        static public void MargeKanjouKamoku(KaikeiDatabase db1, KaikeiDatabase db2) {
            kamokuKubunId2Id = new Dictionary<int, int>();
            kanjouKamokuId2Id = new Dictionary<int, int>();
            kamokuKubunId2KanjouKamokuId = new Dictionary<int, int>();

            AddKamokuKubun(db1, db2);
            AddKanjouKamoku(db1, db2);

            foreach (int kamokuKubunId in kamokuKubunId2Id.Values) {
                if (!kamokuKubunId2KanjouKamokuId.ContainsKey(kamokuKubunId)) {
                    throw new Exception("kamoku_kubun has no kanjou_kamoku : " + kamokuKubunId);
                }
                Row row = db1.MTKamokuKubun.GetRowById(kamokuKubunId);
                row.Set("kanjou_kamoku_id", kamokuKubunId2KanjouKamokuId[kamokuKubunId]);
                db1.MTKamokuKubun.Update(row);
            }
        }


        static public void MargeDenpyou(KaikeiDatabase db1, KaikeiDatabase db2) {
            MargeKanjouKamoku(db1, db2);

            Dictionary<int, int> oldId2newId = new Dictionary<int, int>();

            foreach(var denpyouRow in db2.KaikeiDenpyouMeisai.Select("")){
                int oldId = denpyouRow.GetId();

                db1.KaikeiDenpyouMeisai.SetColumnValue(denpyouRow, "karikata_kamoku_id", GetDict(db1, kanjouKamokuId2Id, (int)denpyouRow.GetLong("karikata_kamoku_id", -1)));
                db1.KaikeiDenpyouMeisai.SetColumnValue(denpyouRow, "kashikata_kamoku_id", GetDict(db1, kanjouKamokuId2Id, (int)denpyouRow.GetLong("kashikata_kamoku_id", -1)));
                db1.KaikeiDenpyouMeisai.SetColumnValue(denpyouRow, "karikata_hojo_id", GetDict(db1, kanjouKamokuId2Id, (int)denpyouRow.GetLong("karikata_hojo_id", -1)));
                db1.KaikeiDenpyouMeisai.SetColumnValue(denpyouRow, "kashikata_hojo_id", GetDict(db1, kanjouKamokuId2Id, (int)denpyouRow.GetLong("kashikata_hojo_id", -1)));
                denpyouRow.RemoveColumn("id");
                db1.KaikeiDenpyouMeisai.Insert(denpyouRow);
                int newId = db1.KaikeiDenpyouMeisai.LastInsertedRow().GetId();

                oldId2newId.Add(oldId, newId);
            }

            foreach (var oldId in oldId2newId.Keys) {
                int newId = oldId2newId[oldId];

                Row denpyouRow = db1.KaikeiDenpyouMeisai.GetRowById(newId);

                int parenetMeisaiId = (int)denpyouRow.GetLong("parent_meisai_id", -1);
                int meisaiGroupNextId = (int)denpyouRow.GetLong("meisai_group_next_id", -1);

                if (parenetMeisaiId > 0) {
                    denpyouRow.Set("parent_meisai_id", oldId2newId[parenetMeisaiId]);
                }
                if (meisaiGroupNextId > 0) {
                    denpyouRow.Set("meisai_group_next_id", oldId2newId[meisaiGroupNextId]);
                }
                if (meisaiGroupNextId > 0 || parenetMeisaiId > 0) {
                    db1.KaikeiDenpyouMeisai.Update(denpyouRow);
                }
            }
        }

        static public void MargeKurikoshi(KaikeiDatabase db1, KaikeiDatabase db2){
            foreach (var kurikoshiRow in db2.ZenkiKurikoshiKamokuKubun.Select("")) {
                int kamokuKubunId = GetDict(db1, kamokuKubunId2Id, (int)kurikoshiRow.GetLong("kamoku_kubun_id", -1));

                string sql = string.Format(
                    "where kaikei_kubun_id = {0} and nenndo = {1} and kamoku_kubun_id = {2}",
                    (int)kurikoshiRow.GetLong("kaikei_kubun_id", -1),
                    (int)kurikoshiRow.GetLong("nenndo", -1),
                    kamokuKubunId);
                if (db1.ZenkiKurikoshiKamokuKubun.RowCount(sql) == 0) {
                    db1.ZenkiKurikoshiKamokuKubun.SetColumnValue(kurikoshiRow, "kamoku_kubun_id", kamokuKubunId);
                    db1.ZenkiKurikoshiKamokuKubun.Insert(kurikoshiRow);
                }
                else {
                    var row = db1.ZenkiKurikoshiKamokuKubun.GetFirstRow(sql);
                    long value = row.GetLong("zenki_kurikoshi_gaku", 0);
                    value += kurikoshiRow.GetLong("zenki_kurikoshi_gaku", 0);
                    row.Set("zenki_kurikoshi_gaku", value);
                    db1.ZenkiKurikoshiKamokuKubun.Update(row);
                }
            }
        }


        static public int GetDict(KaikeiDatabase db1, Dictionary<int, int> dict, int id) {
            if (dict.ContainsKey(id)) {
                return dict[id];
            }
            
            Row originalRow = db1.MTKanjouKamoku.GetRowFromCache(id);
            if(originalRow != null){
                return originalRow.GetId();
            }

            return -1;
        }


        static private bool IsNewKamokuKubun(KaikeiDatabase db1, KaikeiDatabase db2, Row originalRow) {
            List<Row> rowList = new List<Row>();

            Row row = originalRow;
            while (row != null) {
                rowList.Add(row);
                if (db2.MTKamokuKubun.HasInvalidParent(row)) {
                    return false; // invalidな科目の場合追加しない
                }
                row = db2.MTKamokuKubun.GetParentOf(row);
            }

            int parentId = -1;
            for (int i = rowList.Count - 1; i >= 0; i--) {
                row = rowList[i];

                string sql = string.Format(
                    "where name = '{0}' and hierarchy = {1} and parent_id = {2}",
                    row.GetStr("name"), row.GetLong("hierarchy", -1), parentId
                );
                var selectRows = db1.MTKamokuKubun.Select(sql);
                if (selectRows.Count() == 0) {
                    return true;
                }
                else if (selectRows.Count() > 1) {
                    string buf = "";
                    foreach (var r in rowList) {
                        buf += r.GetStr("name") + "(" + r.GetStr("display_order") + ") - ";
                    }
                    helper.MsgBox.Warn("警告:mt_kamoku_kubun " + buf + " が二重に登録されています");
                    parentId = selectRows.First().GetId();
                }
                else {
                    parentId = selectRows.First().GetId();
                }
            }

            return false;
        }

        static private bool IsNewKanjouKamoku(KaikeiDatabase db1, KaikeiDatabase db2, Row originalRow) {
            List<Row> rowList = new List<Row>();

            Row row = originalRow;
            while (row != null) {
                rowList.Add(row);
                row = db2.MTKanjouKamoku.GetParentOf(row);
            }

            int parentId = -1;
            for (int i = rowList.Count - 1; i >= 0; i--) {
                row = rowList[i];

                string sql = string.Format(
                    "where kamoku = '{0}' and hierarchy = {1} and kamoku_code = '{2}' and parent_id = {3}",
                    row.GetStr("kamoku"),
                    row.GetLong("hierarchy", -1),
                    row.GetStr("kamoku_code"),
                    parentId);
                var selectRows = db1.MTKanjouKamoku.Select(sql);
                if (selectRows.Count() == 0) {
                    return true;
                }
                else if (selectRows.Count() > 1) {
                    string buf = "";
                    foreach (var r in rowList) {
                        buf += r.GetStr("kamoku") + "(" + r.GetStr("kamoku_code") + ") - ";
                    }
                    helper.MsgBox.Warn("警告:mt_kanjou_kamoku " + buf + " が二重に登録されています");
                    parentId = selectRows.First().GetId();
                }
                else {
                    parentId = selectRows.First().GetId();
                }
            }

            return false;

            /*string sql = string.Format("where kamoku = '{0}' and hierarchy = {1} and kamoku_code = '{2}'", originalRow.GetStr("kamoku"), originalRow.GetLong("hierarchy", -1), originalRow.GetStr("kamoku_code"));
            if (db1.MTKanjouKamoku.RowCount(sql) > 0) {
                int parentId = (int)originalRow.GetLong("parent_id", -1);
                if (parentId == -1) {
                    return false;
                }
                Row parentRow = db2.MTKanjouKamoku.GetRowById(parentId);
                return IsNewKanjouKamoku(db1, db2, parentRow);
            }
            else {
                return true;
            }*/
        }

        static private void AddKamokuKubun(KaikeiDatabase db1, KaikeiDatabase db2) {
            foreach (Row row in db2.MTKamokuKubun.Select("order by id")) {
                int originalId = row.GetId();
                int parentId = (int)row.GetLong("parent_id", -1);

                if (IsNewKamokuKubun(db1, db2, row)) {
                    if (parentId == -1) {
                    }
                    else if (kamokuKubunId2Id.ContainsKey(parentId)) {
                        row.Set("parent_id", kamokuKubunId2Id[parentId]);
                    }
                    else {
                        Row parentRow = db1.MTKamokuKubun.GetRowById(parentId);
                        if (parentRow != null) {
                            parentRow.Set("has_child", 1);
                            db1.MTKamokuKubun.Update(parentRow);
                        }
                        else {
                            throw new Exception("unknown parent_id");
                        }
                    }

                    row.Set("kanjou_kamoku_id", -2);
                    row.RemoveColumn("id");
                    db1.MTKamokuKubun.Insert(row);
                    kamokuKubunId2Id[originalId] = db1.MTKamokuKubun.LastInsertedRow().GetId();
                }
            }
        }


        static private void AddKanjouKamoku(KaikeiDatabase db1, KaikeiDatabase db2) {
            foreach (Row row in db2.MTKanjouKamoku.Select("order by id")) {
                int originalId = row.GetId();
                int parentId = (int)row.GetLong("parent_id", -1);

                if (IsNewKanjouKamoku(db1, db2, row)) {
                    if (parentId == -1) {
                    }
                    else if (kanjouKamokuId2Id.ContainsKey(parentId)) {
                        row.Set("parent_id", kanjouKamokuId2Id[parentId]);
                    }
                    else {
                        Row parentRow = db1.MTKanjouKamoku.GetRowById(parentId);
                        if (parentRow != null) {
                            parentRow.Set("has_child", 1);
                            db1.MTKanjouKamoku.Update(parentRow);
                        }
                        else {
                            throw new Exception("unknown parent_id");
                        }
                    }

                    foreach (string colName in new string[] { "shikin_kamoku_kubun_id", "jigyou_kamoku_kubun_id", "taisyaku_kamoku_kubun_id" }) {
                        int kamokuKubunId = (int)row.GetLong(colName, -1);
                        if (kamokuKubunId == -1) {
                        }
                        else if (kamokuKubunId2Id.ContainsKey(kamokuKubunId)) {
                            row.Set(colName, kamokuKubunId2Id[kamokuKubunId]);
                        }
                        else if (db1.MTKamokuKubun.GetRowById(kamokuKubunId) == null) {
                            throw new Exception("unknown " + colName);
                        }
                    }

                    row.RemoveColumn("id");
                    db1.MTKanjouKamoku.Insert(row);

                    int insertedId = db1.MTKanjouKamoku.LastInsertedRow().GetId();
                    kanjouKamokuId2Id[originalId] = insertedId;

                    foreach (string colName in new string[] { "shikin_kamoku_kubun_id", "jigyou_kamoku_kubun_id", "taisyaku_kamoku_kubun_id" }) {
                        int kamokuKubunId = (int)row.GetLong(colName, -1);
                        kamokuKubunId2KanjouKamokuId[kamokuKubunId] = insertedId;
                    }
                }
            }
        }
    }
}
