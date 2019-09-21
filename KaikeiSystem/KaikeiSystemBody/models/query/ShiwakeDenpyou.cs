using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class ShiwakeDenpyou
    {
        public class ShiwakeDenpyouRow {
            public int Id{get;set;}
            public string DenpyouBangou{get;set;}
            public string KaikeiKubun{get;set;}
            public string TorihikiKubun{get;set;}
            public DateTime? Kihyoubi { get; set; }
            
            public string KarikataKamoku{get;set;}
            public string KarikataHojo{get;set;}
            public string KashikataKamoku{get;set;}
            public string KashikataHojo{get;set;}

            public string KarikataKamoku2 { get; set; }
            public string KarikataHojo2 { get; set; }
            public string KashikataKamoku2 { get; set; }
            public string KashikataHojo2 { get; set; }

            public string KarikataKamoku3 { get; set; }
            public string KarikataHojo3 { get; set; }
            public string KashikataKamoku3 { get; set; }
            public string KashikataHojo3 { get; set; }

            public string KarikataKamoku4 { get; set; }
            public string KarikataHojo4 { get; set; }
            public string KashikataKamoku4 { get; set; }
            public string KashikataHojo4 { get; set; }
            
            public string Tekiyou { get; set; }
            public long Kingaku{get;set;}

            public string KarikataKamokuCode { get; set; }
            public string KarikataHojoSeiri { get; set; }
            public string KashikataKamokuCode { get; set; }
            public string KashikataHojoSeiri { get; set; }

            public ShiwakeDenpyouRow(models.db.KaikeiDatabase db, models.db.Row row){
                Id = row.GetId();
                DenpyouBangou = row.GetStr("denpyou_bangou", "");
                KaikeiKubun = row.GetMasterStr("kaikei_kubun", "name", "", db.MTKaikeiKubun);
                TorihikiKubun = row.GetMasterStr("torihiki_kubun", "torihiki_kubun", "", db.MTTorihikiKubun);
                
                Kihyoubi = row.GetDate("kihyoubi");

                int torihikiKubunId = (int)row.GetLong("torihiki_kubun", -1);
                KarikataKamoku = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
                KashikataKamoku = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
                KarikataHojo = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_hojo_id", -1), torihikiKubunId);
                KashikataHojo = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_hojo_id", -1), torihikiKubunId);
                Tekiyou = row.GetStr("comment");
                //Kingaku = helper.Converter.LongToAmount(row.GetLong("karikata_kingaku", 0));
                Kingaku = row.GetLong("karikata_kingaku", 0);

                KarikataKamokuCode = row.GetStr("karikata_kamoku_code");
                int karikataHojoSeiriLong = (int)row.GetLong("karikata_hojo_seiri", 0);
                KarikataHojoSeiri = (karikataHojoSeiriLong > 0) ? karikataHojoSeiriLong.ToString() : "";

                KashikataKamokuCode = row.GetStr("kashikata_kamoku_code");
                int kashikataHojoSeiriLong = (int)row.GetLong("kashikata_hojo_seiri", 0);
                KashikataHojoSeiri = (kashikataHojoSeiriLong > 0) ? kashikataHojoSeiriLong.ToString() : "";

                KarikataKamoku2 = "";
                KashikataKamoku2 = "";
                KarikataHojo2 = "";
                KashikataHojo2 = "";

                KarikataKamoku3 = "";
                KashikataKamoku3 = "";
                KarikataHojo3 = "";
                KashikataHojo3 = "";

                KarikataKamoku4 = "";
                KashikataKamoku4 = "";
                KarikataHojo4 = "";
                KashikataHojo4 = "";
            }

            public void SetAddedShiwake(models.db.KaikeiDatabase db, models.db.Row row){
                int torihikiKubunId = (int)row.GetLong("torihiki_kubun", -1);
                KarikataKamoku2 = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_kamoku_id", -1), torihikiKubunId);
                KashikataKamoku2 = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_kamoku_id", -1), torihikiKubunId);
                KarikataHojo2 = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("karikata_hojo_id", -1), torihikiKubunId);
                KashikataHojo2 = db.MTKanjouKamoku.GetKamokuStr((int)row.GetLong("kashikata_hojo_id", -1), torihikiKubunId);
            }
        }


        public List<ShiwakeDenpyouRow> RowList { get; private set; }
        private Dictionary<int, bool> denpyouIdHash;
        private models.db.KaikeiDatabase db;


        public ShiwakeDenpyou(models.db.KaikeiDatabase aDB) {
            db = aDB;

            RowList = new List<ShiwakeDenpyouRow>();
            denpyouIdHash = new Dictionary<int, bool>();
        }


        public void SetQuery(string query, int targetKaikeiKubunId, bool margeDenpyouGroup){
            foreach (var row in db.KaikeiDenpyouMeisai.Select(query + " order by denpyou_bangou")) {
                int kaikeiKubunId = (int)row.GetLong("kaikei_kubun", -1);
                if(!db.MTKaikeiKubun.IsChildOf(kaikeiKubunId, targetKaikeiKubunId)){
                    continue;
                }

                if (denpyouIdHash.ContainsKey(row.GetId())) {
                    continue;
                }
                if (row.GetLong("parent_meisai_id", -1) != -1) {
                    continue;
                }

                ShiwakeDenpyouRow denpyouRow = new ShiwakeDenpyouRow(db, row);
                RowList.Add(denpyouRow);
                denpyouIdHash[row.GetId()] = true;

                models.db.Row nextRow = row.Table.GetFirstRow("where id = " + row.GetLong("meisai_group_next_id", -1));
                if (nextRow == null) {
                    continue;
                }
                if (denpyouIdHash.ContainsKey(nextRow.GetId())) {
                    continue;
                }

                if (margeDenpyouGroup) {
                    denpyouRow.SetAddedShiwake(db, nextRow);
                    denpyouIdHash[nextRow.GetId()] = true;
                }
                else {
                    RowList.Add(new ShiwakeDenpyouRow(db, nextRow));
                    denpyouIdHash[nextRow.GetId()] = true;
                }
            }
        }


        public void SetQuery(DateTime startDate, DateTime endDate, string dateColumnName, bool onlyChecked, bool margeDenpyouGroup, int kaikeiKubunId) {
            string sql = "where " + dateColumnName + " >= " + helper.Converter.DateTimeToInt(startDate) + 
                        " and " + dateColumnName + " <= " + helper.Converter.DateTimeToInt(endDate);

            sql += OnlyChecked(onlyChecked);

            SetQuery(sql, kaikeiKubunId, margeDenpyouGroup);
        }


        public void SetQuery(DateTime month, int startNum, int endNum, bool onlyChecked, bool margeDenpyouGroup, int kaikeiKubunId) {
            string start = db.KaikeiDenpyouMeisai.FormatDenpyouBangou(month, startNum);
            string end = db.KaikeiDenpyouMeisai.FormatDenpyouBangou(month, endNum);

            string sql = "where denpyou_bangou >= '" + start + "' and denpyou_bangou <= '" + end + "'";
            sql += OnlyChecked(onlyChecked);

            SetQuery(sql, kaikeiKubunId, margeDenpyouGroup);
        }


        private string OnlyChecked(bool onlyChecked) {
            if (onlyChecked) {
                return " and denpyou_kakunin = 1";
            }
            return "";
        }
    }
}
