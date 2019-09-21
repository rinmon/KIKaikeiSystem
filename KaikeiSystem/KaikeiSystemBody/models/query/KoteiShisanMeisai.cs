using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.query
{
    class KoteiShisanMeisai
    {
        public enum SummaryItem {
            SonotaKoteiShisanSum = 0,               // その他固定資産計
            KihonZaisanSonotaKoteiShisanSum = 1,    // 基本財産及びその他の固定資産計
            SyouraiNyuukinYotei = 2,                // 将来入金予定の償還補助金の額
            Sashihiki = 3,                          // 差引
        }

        public enum KoteiShisanType {
            KihonZaisan,
            SonotaYuukei,
            SonotaMukei,
        }

        public class MeisaiRow
        {
            public KoteiShisanType Type{get;set;}
            public string KamokuName{get;set;}
            public string DaikubunName{get;set;}
            public long Col0{get;set;} // 期首帳簿価額
            public long Col1{get;set;} // 当期増加額
            public long Col2{get;set;} // 当期減価償却額
            public long Col3{get;set;} // 当期減少額
            public long Col4{          // 期末帳簿価額
                get {
                    return Col0 + Col1 - Col2 - Col3;
                }
            }
            public long Col5{get;set;} // 減価償却累計額
            public long Col6 {         // 期末取得価額
                get {
                    return Col4 + Col5;
                }
            }
            public long Col0Kokko{get;set;}
            public long Col1Kokko{get;set;}
            public long Col2Kokko{get;set;}
            public long Col3Kokko{get;set;}
            public long Col4Kokko{get;set;}
            public long Col5Kokko{get;set;}
            public long Col6Kokko{get;set;}

            public MeisaiRow(string kamokuName, string daikubunName, KoteiShisanType type) {
                KamokuName = kamokuName;
                DaikubunName = daikubunName;
                Type = type;

                Col0 = 0;
                Col1 = 0;
                Col2 = 0;
                Col3 = 0;
                Col5 = 0;

                Col0Kokko = 0;
                Col1Kokko = 0;
                Col2Kokko = 0;
                Col3Kokko = 0;
                Col4Kokko = 0;
                Col5Kokko = 0;
                Col6Kokko = 0;
            }

            public void Add(MeisaiRow row) {
                Col0 += row.Col0;
                Col1 += row.Col1;
                Col2 += row.Col2;
                Col3 += row.Col3;
                Col5 += row.Col5;

                Col0Kokko += row.Col0Kokko;
                Col1Kokko += row.Col1Kokko;
                Col2Kokko += row.Col2Kokko;
                Col3Kokko += row.Col3Kokko;
                Col4Kokko += row.Col4Kokko;
                Col5Kokko += row.Col5Kokko;
                Col6Kokko += row.Col6Kokko;
            }
        };

        
        private db.KaikeiDatabase db;
        private Dictionary<int, MeisaiRow> meisaiTable;
        private List<MeisaiRow> meisaiList;
        private List<MeisaiRow> summaryList;

        public List<MeisaiRow> GetMeisaiList() {
            return meisaiList;
        }

        public List<MeisaiRow> GetSummaryList() {
            return summaryList;
        }

        public MeisaiRow SonotaRow{
            get { return summaryList[(int)SummaryItem.SonotaKoteiShisanSum]; }
        }
        public MeisaiRow KihonSonotaRow {
            get { return summaryList[(int)SummaryItem.KihonZaisanSonotaKoteiShisanSum]; }
        }
        public MeisaiRow SyouraiRow {
            get { return summaryList[(int)SummaryItem.SyouraiNyuukinYotei]; }
        }
        public MeisaiRow SashihikiRow {
            get { return summaryList[(int)SummaryItem.Sashihiki]; }
        }


        public KoteiShisanMeisai(db.KaikeiDatabase aDB) {
            db = aDB;

            meisaiTable = new Dictionary<int, MeisaiRow>();
        }


        public DateTime StartDate {
            get;
            private set;
        }

        public DateTime EndDate {
            get;
            private set;
        }

        public int KaikeiKubun{
            get;
            private set;
        }

        public void Calc(DateTime startDate, DateTime endDate, int kaikeiKubun){
            StartDate = startDate;
            EndDate = endDate;
            KaikeiKubun = kaikeiKubun;

            InitTables();

            SummarizeKoteiShisan();
            SummarizeMeisaiTable();
            CalcSummaryList();
        }

        private void InitTables() {
            meisaiTable = new Dictionary<int, MeisaiRow>();
            meisaiList = new List<MeisaiRow>();
            summaryList = new List<MeisaiRow>();

            foreach(var kamokuKubunRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.KoteiShisanKihonZaisan, order:"order by id")){
                InitTableAddRow(kamokuKubunRow);
            }
            foreach(var kamokuKubunRow in db.MTKamokuKubun.SelectChildren((int)models.constants.MTKamokuKubun.KoteiShisanSonota, order:"order by id")){
                InitTableAddRow(kamokuKubunRow);
            }
        }

        private void InitTableAddRow(models.db.Row kamokuKubunRow) {
            int kamokuKubunId = kamokuKubunRow.GetId();
            int parentId = (int)kamokuKubunRow.GetLong("parent_id", -1);
            string parentName;
            KoteiShisanType type;
            if (parentId == (int)models.constants.MTKamokuKubun.KoteiShisanKihonZaisan) {
                parentName = KaikeiSystemBody.Properties.Resources.CaptionKihonZaisanYuukei;
                type = KoteiShisanType.KihonZaisan;
            }
            else if (models.KoteiShisanFunc.IsSonotaYuukeiKoteiShisan(kamokuKubunId)) {
                parentName = Properties.Resources.CaptionSonotaKoteishisanYuukei;
                type = KoteiShisanType.SonotaYuukei;
            }
            else {
                parentName = Properties.Resources.CaptionSonotaKoteishisanMukei;
                type = KoteiShisanType.SonotaMukei;
            }
            MeisaiRow row = new MeisaiRow(kamokuKubunRow.GetStr("name"), parentName, type);
            meisaiTable.Add(kamokuKubunRow.GetId(), row);
            meisaiList.Add(row);
        }

        private void SummarizeKoteiShisan() {
            foreach(var shisanRow in db.MTKoteiShisan.Select("where syutoku_nenngappi < " + helper.Converter.DateTimeToInt(StartDate))){
                if (!db.MTKaikeiKubun.IsChildOf((int)shisanRow.GetLong("kaikei_kubun", -1), KaikeiKubun)) {
                    continue;
                }

                int kamokuKubunId = (int)shisanRow.GetLong("kamoku_kubun_id", -1);
                if(!meisaiTable.ContainsKey(kamokuKubunId)){
                    continue;
                }
                MeisaiRow meisaiRow = meisaiTable[kamokuKubunId];

                var syoukyakuRows = db.GenkaSyoukyakuMeisai.Select(string.Format(
                    "where kotei_shisan_bangou = {0} and {1} <= gensyoubi and gensyoubi <= {2} order by kaisuu",
                    shisanRow.GetId(),
                    helper.Converter.DateTimeToInt(StartDate),
                    helper.Converter.DateTimeToInt(EndDate)
                    ));
                if(syoukyakuRows.Count() <= 0){
                    continue;
                }
                models.db.Row syoukyakuRow = syoukyakuRows.Last();

                meisaiRow.Col0 += syoukyakuRow.GetLong("kisyu_tyoubo_kagaku", 0);
                meisaiRow.Col2 += syoukyakuRow.GetLong("touki_genka_syoukyaku_kagaku", 0);
                meisaiRow.Col5 += syoukyakuRow.GetLong("genka_syoukyaku_ruikeigaku", 0);
            }
        }


        private void SummarizeMeisaiTable() {
            string sql = string.Format("where {0} <= kihyoubi and kihyoubi <= {1} ",
                            helper.Converter.DateTimeToInt(StartDate),
                            helper.Converter.DateTimeToInt(EndDate));

            foreach (var row in db.KaikeiDenpyouMeisai.Select(sql)) {
                if(!db.MTKaikeiKubun.IsChildOf((int)row.GetLong("kaikei_kubun", -1), KaikeiKubun)){
                    continue;
                }

                if(models.KoteiShisanFunc.IsKoteiShisanKanjouKamoku(db, (int)row.GetLong("karikata_kamoku_id", -1))){
                    int karikataKamokuKubunId = db.MTKanjouKamoku.GetKamokuKubunId((int)row.GetLong("karikata_kamoku_id", -1), models.constants.MTTorihikiKubun.Shikin);
                    meisaiTable[karikataKamokuKubunId].Col1 += row.GetLong("karikata_kingaku", 0); // 当期増加額
                }
                if ((int)row.GetLong("karikata_kamoku_id", -1) != (int)models.constants.MTKanjouKamoku.GenkaSyoukyakuhi && 
                        models.KoteiShisanFunc.IsKoteiShisanKanjouKamoku(db, (int)row.GetLong("kashikata_kamoku_id", -1))) {
                    int kashikataKamokuKubunId = db.MTKanjouKamoku.GetKamokuKubunId((int)row.GetLong("kashikata_kamoku_id", -1), models.constants.MTTorihikiKubun.Shikin);
                    meisaiTable[kashikataKamokuKubunId].Col3 += row.GetLong("karikata_kingaku", 0); // 当期減少額
                }
            }
        }


        private void CalcSummaryList() {
            for(int i = 0; i <= (int)SummaryItem.Sashihiki; i++){
                summaryList.Add(new MeisaiRow("", "", KoteiShisanType.KihonZaisan));
            }

            foreach (var meisaiRow in meisaiList) {
                if (meisaiRow.Type == KoteiShisanType.SonotaMukei || meisaiRow.Type == KoteiShisanType.SonotaYuukei) {
                    summaryList[(int)SummaryItem.SonotaKoteiShisanSum].Add(meisaiRow);
                }
                summaryList[(int)SummaryItem.KihonZaisanSonotaKoteiShisanSum].Add(meisaiRow);
                summaryList[(int)SummaryItem.Sashihiki].Add(meisaiRow);
            }
        }
    }
}
