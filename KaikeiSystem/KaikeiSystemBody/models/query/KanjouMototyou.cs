

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaikeiSystemBody.models.query
{
    class KanjouMototyou
    {
        public class MototyouRow
        {
            public int KaikeiDenpyouMeisaiId { get; private set; }
            public string DenpyouBangou { get; private set; }
            public int DenpyouRenban { get; private set; }
            public DateTime Kihyoubi { get; private set; }
            public string KaikeiKubunStr { get; private set; }
            public string AiteKamokuStr { get; private set; }
            public long KarikataKingaku { get; private set; }
            public long KashikataKingaku { get; private set; }
            public long Zandaka { get; private set; }
            public string Comment { get; private set; }
            public bool HasHojoKamoku { get; private set; }

            public string MonthStr { get; private set; }
            public long ZengetsuKurikoshi { get; private set; }

            public MototyouRow(int kaikeiDenpyouMeisaiId, string denpyouBangou, int denpyouRenban, DateTime kihyoubi, string kaikeiKubun, string aiteKamokuStr,
                        long karikataKingaku, long kashikataKingaku, long zandaka, string comment, bool hasHojo, long zengetsuKurikoshi) {
                KaikeiDenpyouMeisaiId = kaikeiDenpyouMeisaiId;
                DenpyouRenban = denpyouRenban;
                DenpyouBangou = denpyouBangou;
                Kihyoubi = kihyoubi;
                KaikeiKubunStr = kaikeiKubun;
                AiteKamokuStr = aiteKamokuStr;
                KarikataKingaku = karikataKingaku;
                KashikataKingaku = kashikataKingaku;
                Zandaka = zandaka;
                Comment = comment;
                HasHojoKamoku = hasHojo;

                //勘定元帳の印刷で使う。ここで設定するのは美しくないが時間がないので適当にやった。
                MonthStr = kihyoubi.ToString("gyy年MM月", helper.Converter.JpCultureInfo);
                ZengetsuKurikoshi = zengetsuKurikoshi;
            }
        }


        private bool calced;
        private List<MototyouRow> rowList;
        private models.db.KaikeiDatabase db;

        public models.db.tables.KaikeiDenpyouMeisai MeisaiTable {
            get;
            private set;
        }

        public models.db.tables.ZenkiKurikoshiKamokuKubun KurikoshiKamokuTable {
            get;
            private set;
        }

        public DateTime StartDate {
            get;
            private set;
        }

        public DateTime EndDate {
            get;
            private set;
        }

        public bool IsHojoKamoku {
            get;
            private set;
        }

        public int KanjouKamokuId {
            get;
            private set;
        }

        public string KanjouKamokuStr {
            get {
                string name = db.MTKanjouKamoku.GetFirst("kamoku", "where id=" + KanjouKamokuId) as string;
                return name != null ? name : "";
            }
        }

        public int KaikeiKubunId {
            get;
            private set;
        }

        public long ZengetsuKurikoshiGaku{
            get;
            private set;
        }

        public models.constants.MTTaisyakuKubun TaisyakuKubunId{
            get;
            private set;
        }

        public string TaisyakuKubunStr{
            get;
            private set;
        }

        public long KashikataSum {
            get;
            private set;
        }

        public long KarikataSum {
            get;
            private set;
        }

        public long SashihikiSum {
            get;
            private set;
        }

        public List<MototyouRow> MototyouRows {
            get { return rowList; }
        }

        public models.db.Row GetDenpyouMeisaiRow(int index) {
            return db.KaikeiDenpyouMeisai.GetFirstRow("where id=" + rowList[index].KaikeiDenpyouMeisaiId);
        }


        private string KarikataColumnName {
            get {
                if (IsHojoKamoku) {
                    return "karikata_hojo_id";
                }
                else {
                    return "karikata_kamoku_id";
                }
            }
        }

        private string KashikataColumnName {
            get {
                if (IsHojoKamoku) {
                    return "kashikata_hojo_id";
                }
                else {
                    return "kashikata_kamoku_id";
                }
            }
        }


        public KanjouMototyou(models.db.KaikeiDatabase aDB) {
            db = aDB;
            calced = false;

            rowList = new List<MototyouRow>();

            MeisaiTable = db.KaikeiDenpyouMeisai;
            KurikoshiKamokuTable = db.ZenkiKurikoshiKamokuKubun;
        }


        public void Calc(DateTime startDate, DateTime endDate, int kanjouKamokuId, int kaikeiKubunId, bool renumberDenpyouBangou, bool isHojoKamoku) {
            StartDate = startDate;
            EndDate = endDate;
            KanjouKamokuId = kanjouKamokuId;
            KaikeiKubunId = kaikeiKubunId;
            IsHojoKamoku = isHojoKamoku;

            rowList.Clear();

            MeisaiTable = db.KaikeiDenpyouMeisai;
            KurikoshiKamokuTable = db.ZenkiKurikoshiKamokuKubun;

            if (renumberDenpyouBangou) {
                RenumberDenpyouBangou(MeisaiTable, StartDate, EndDate);
            }

            CalcZengetsuKurikoshi();
            CalcRows();

            calced = true;
        }


        public void Recalc() {
            if (!calced) {
                return;
            }
            CalcZengetsuKurikoshi();
            CalcRows();
        }


        private void CalcZengetsuKurikoshi() {
            long karikataKingaku = 0;
            long kashikataKingaku = 0;
            
            {
                string sql = string.Format(
                    "where kihyoubi >= {0} and kihyoubi < {1} ",
                    helper.Converter.DateTimeToInt(helper.Helper.GetNenndoKisanbi(StartDate)),
                    helper.Converter.DateTimeToInt(StartDate)); 

                if (IsHojoKamoku == false) {
                    sql += string.Format("and ({1}={0} or {2}={0}) ", KanjouKamokuId, KashikataColumnName, KarikataColumnName);
                }

                //if (KaikeiKubunId != -1) {
                //    sql += " and kaikei_kubun=" + KaikeiKubunId;
                //}

                foreach (var row in MeisaiTable.Select(sql)) {
                    if (db.KaikeiDenpyouMeisai.IsPairedShikinRow(row)) {
                        continue;
                    }

                    if (KaikeiKubunId != -1 && !db.MTKaikeiKubun.IsAncestorOf((int)row.GetLong("kaikei_kubun", -1), KaikeiKubunId)) {
                        continue;
                    }

                    if (db.MTKanjouKamoku.IsAncestorOf((int)row.GetLong(KarikataColumnName, -1), KanjouKamokuId)) {
                        karikataKingaku += row.GetLong("karikata_kingaku", 0);
                    }
                    if (db.MTKanjouKamoku.IsAncestorOf((int)row.GetLong(KashikataColumnName, -1), KanjouKamokuId)) {
                        kashikataKingaku += row.GetLong("karikata_kingaku", 0);
                    }
                }
            }

            object taisyakuKubunIdObj = db.MTKanjouKamoku.GetFirst("taisyaku_kubun_id", "where id=" + KanjouKamokuId);
            TaisyakuKubunId = (models.constants.MTTaisyakuKubun)((int)(long)taisyakuKubunIdObj);
            TaisyakuKubunStr = db.MTTaisyakuKubun.GetFirst("caption", "where id=" + (int)TaisyakuKubunId) as string;

            long zenkiKurikoshi = 0;
            long? kamokuKubunIdObj = (long?)db.MTKamokuKubun.GetFirst("id", "where kanjou_kamoku_id=" + KanjouKamokuId);

            // 不正な科目
            if (kamokuKubunIdObj == null) {
                ZengetsuKurikoshiGaku = 0;
                return;
            }
            int kamokuKubunId = (int)kamokuKubunIdObj.Value;
            string condition = "where kamoku_kubun_id=" + kamokuKubunId + " and nenndo=" + (helper.Helper.GetNenndoOfDate(StartDate));

            // 繰越金額の計算
            foreach(var row in KurikoshiKamokuTable.Select(condition)){
                if (KaikeiKubunId != -1 && !db.MTKaikeiKubun.IsAncestorOf((int)row.GetLong("kaikei_kubun_id", -1), KaikeiKubunId)) {
                    continue;
                }
                zenkiKurikoshi += row.GetLong("zenki_kurikoshi_gaku", -1);
            }

            switch (TaisyakuKubunId) {
                case constants.MTTaisyakuKubun.KariPlus:
                case constants.MTTaisyakuKubun.KariMinus:
                    ZengetsuKurikoshiGaku = karikataKingaku - kashikataKingaku + zenkiKurikoshi;
                    break;

                case constants.MTTaisyakuKubun.KashiPlus:
                case constants.MTTaisyakuKubun.KashiMinus:
                    ZengetsuKurikoshiGaku = kashikataKingaku - karikataKingaku + zenkiKurikoshi;
                    break;
            }
        }


        private void CalcRows() {
            rowList.Clear();

            db.KaikeiDenpyouMeisai.UpdateEditingRows();

            string sql = string.Format(
                "where kihyoubi >= {0} and kihyoubi <= {1} ",
                helper.Converter.DateTimeToInt(StartDate),
                helper.Converter.DateTimeToInt(EndDate));

            if (IsHojoKamoku == false) {
                sql += string.Format("and ({1}={0} or {2}={0}) ", KanjouKamokuId, KashikataColumnName, KarikataColumnName);
            }

            //if (KaikeiKubunId != -1) {
            //    sql += " and kaikei_kubun=" + KaikeiKubunId;
            //}

            sql += " order by denpyou_bangou";

            long zandaka = ZengetsuKurikoshiGaku;
            long zengetsuKurikoshi = ZengetsuKurikoshiGaku;
            long karikataSum = 0;
            long kashikataSum = 0;
            int month = StartDate.Month;

            //models.db.Row kanjouKamokuRow = db.MTKanjouKamoku.GetFirstRow("where id=" + KanjouKamokuId);

            foreach (var row in MeisaiTable.Select(sql)) {
                int aiteKamokuId = -1;
                long karikataKingaku = 0;
                long kashikataKingaku = 0;

                if (db.KaikeiDenpyouMeisai.IsPairedShikinRow(row)) {
                    continue;
                }

                if (KaikeiKubunId != -1 && !db.MTKaikeiKubun.IsAncestorOf((int)row.GetLong("kaikei_kubun", -1), KaikeiKubunId)) {
                    continue;
                }

                if (db.MTKanjouKamoku.IsAncestorOf((int)row.GetLong(KarikataColumnName, -1), KanjouKamokuId)) {
                    aiteKamokuId = (int)row.GetLong("kashikata_kamoku_id", -1);
                    karikataKingaku = row.GetLong("karikata_kingaku", 0);
                }
                if (db.MTKanjouKamoku.IsAncestorOf((int)row.GetLong(KashikataColumnName, -1), KanjouKamokuId)) {
                    aiteKamokuId = (int)row.GetLong("karikata_kamoku_id", -1);
                    kashikataKingaku = row.GetLong("karikata_kingaku", 0);
                }

                if(aiteKamokuId == -1){
                    continue;
                }

                int kihyoubiMonth = (int)row.GetLong("kihyoubi_month", -1);
                if (kihyoubiMonth != month) {
                    month = kihyoubiMonth;
                    zengetsuKurikoshi = zandaka;
                }

                /*if ((int)row.GetLong(KarikataColumnName, -1) == KanjouKamokuId) {
                    aiteKamokuId = (int)row.GetLong("kashikata_kamoku_id", -1);
                    karikataKingaku = row.GetLong("karikata_kingaku", 0);
                }
                else {
                    aiteKamokuId = (int)row.GetLong("karikata_kamoku_id", -1);
                    kashikataKingaku = row.GetLong("karikata_kingaku", 0);
                }*/

                switch (TaisyakuKubunId) {
                    case constants.MTTaisyakuKubun.KariPlus:
                    case constants.MTTaisyakuKubun.KariMinus:
                        zandaka += karikataKingaku - kashikataKingaku;
                        break;

                    case constants.MTTaisyakuKubun.KashiPlus:
                    case constants.MTTaisyakuKubun.KashiMinus:
                        zandaka += kashikataKingaku - karikataKingaku;
                        break;
                }

                string aiteKamokuStr = db.MTKanjouKamoku.GetFirst("kamoku", "where id=" + aiteKamokuId) as string;
                if (aiteKamokuStr == null) {
                    aiteKamokuStr = "";
                }

                string kaikeiKubun = db.MTKaikeiKubun.GetFirst("name", "where id=" + row.GetLong("kaikei_kubun", -1)) as string;
                if (kaikeiKubun == null) {
                    kaikeiKubun = "";
                }

                bool hasHojo = true;
                if (row.GetLong("kashikata_hojo_id", 0) == 0 && row.GetLong("karikata_hojo_id", 0) == 0) {
                    hasHojo = false;
                }

                MototyouRow mototyouRow = new MototyouRow(
                    (int)row.GetLong("id", -1),
                    row.GetStr("denpyou_bangou"),
                    (int)row.GetLong("denpyou_renban", 0),
                    row.GetDate("kihyoubi").Value,
                    kaikeiKubun,
                    aiteKamokuStr,
                    karikataKingaku,
                    kashikataKingaku,
                    zandaka,
                    row.GetStr("comment"),
                    hasHojo,
                    zengetsuKurikoshi
                );
                rowList.Add(mototyouRow);

                karikataSum += karikataKingaku;
                kashikataSum += kashikataKingaku;
            }

            KarikataSum = karikataSum;
            KashikataSum = kashikataSum;
            SashihikiSum = zandaka;
        }


        private void RenumberDenpyouBangou(models.db.tables.KaikeiDenpyouMeisai tbl, DateTime start, DateTime end) {
            DateTime target = start;
            while (true) {
                tbl.RenumberDenpyouBangou(target, false);

                if (target.Year == end.Year && target.Month == end.Month) {
                    break;
                }
                target = target.AddMonths(1);
            }
        }
    }
}
