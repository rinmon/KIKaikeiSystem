using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models
{
    // 固定資産計算に使う計算
    class KoteiShisanFunc
    {
        public static bool IsKoteiShisanKamokuKubun(models.db.KaikeiDatabase db, int kamokuKubunId) {
            if(db.MTKamokuKubun.IsAncestorOf(kamokuKubunId, (int)models.constants.MTKamokuKubun.KoteiShisanKihonZaisan, depth: 1)){
                return true;
            }
            if (db.MTKamokuKubun.IsAncestorOf(kamokuKubunId, (int)models.constants.MTKamokuKubun.KoteiShisanSonota, depth: 1)) {
                return true;
            }
            return false;
        }

        public static bool IsKoteiShisanKanjouKamoku(models.db.KaikeiDatabase db, int kanjouKamokuId) {
            models.db.Row kamokuKubunRow = db.MTKanjouKamoku.GetKamokuKubunRow(kanjouKamokuId, models.constants.MTTorihikiKubun.Shikin);
            if (kamokuKubunRow == null) {
                return false;
            }
            return IsKoteiShisanKamokuKubun(db, kamokuKubunRow.GetId());
        }

        public static bool IsSonotaYuukeiKoteiShisan(int kamokuKubunId) {
            if ((int)models.constants.MTKamokuKubun.SonotaKoteiShisanYuukeiStart <= kamokuKubunId &&
                    kamokuKubunId <= (int)models.constants.MTKamokuKubun.SonotaKoteiShisanYuukeiEnd) {
                return true;
            }
            return false;
        }

        // 償却
        public static bool CreateGenkaSyoukyakuMeisai(models.Context context, int koteiShisanId) {
            models.db.Row koteiShisanRow = context.KaikeiDatabase.MTKoteiShisan.GetRowById(koteiShisanId);

            if(koteiShisanRow == null){
                return false;
            }

            DateTime? syutokubi = koteiShisanRow.GetDate("syutoku_nenngappi");
            long syutokuKakaku = koteiShisanRow.GetLong("syutoku_kakaku", -1);
            long taiyouNensuu = koteiShisanRow.GetLong("taiyou_nennsuu", -1);
            double syoukyakuritsu = koteiShisanRow.GetDouble("syoukyaku_ritsu", -1);
            double zanzonWariai = koteiShisanRow.GetDouble("zanzon_wariai", -1);

            if (syutokubi == null || syutokuKakaku < 0 || taiyouNensuu < 0 || syoukyakuritsu < 0 || zanzonWariai < 0) {
                return false;
            }

            long zanzonKagaku = (long)Math.Round(syutokuKakaku * zanzonWariai / 100);

            DateTime gensyoubi = helper.Converter.DateTimeToNenndoKimatsubi(syutokubi.Value);
            long ruikeiSyoukyakuhi = 0;
            long ruikeiShiyouTsukisuu = 0;
            long kaisuu = 1;

            while (ruikeiShiyouTsukisuu < taiyouNensuu * 12) {
                long shiyouTsukisuu;
                if (ruikeiShiyouTsukisuu == 0) {
                    shiyouTsukisuu = syutokubi.Value.Month >= 4 ? 15 - syutokubi.Value.Month : 3 - syutokubi.Value.Month;
                    if (context.Setting.GetInt("kounyuutsuki_syoukyaku", 0) != 0) {
                        shiyouTsukisuu++;
                    }
                    if (shiyouTsukisuu == 0) {
                        gensyoubi = gensyoubi.AddYears(1);
                        shiyouTsukisuu = 12;
                    }
                }
                else if (taiyouNensuu * 12 - ruikeiShiyouTsukisuu < 12) {
                    shiyouTsukisuu = taiyouNensuu * 12 - ruikeiShiyouTsukisuu;
                }
                else {
                    shiyouTsukisuu = 12;
                }

                long syoukyakuhi = TeigakuhouGenkaSyoukyakuhi(syutokuKakaku, zanzonWariai, shiyouTsukisuu, syoukyakuritsu);
                long kisyuTyouboKagaku = syutokuKakaku - ruikeiSyoukyakuhi;
                ruikeiShiyouTsukisuu += shiyouTsukisuu;

                if (kisyuTyouboKagaku - syoukyakuhi < zanzonKagaku)     // 償却残額が残存価額を下回る
                {
                    syoukyakuhi = kisyuTyouboKagaku - zanzonKagaku;
                    ruikeiSyoukyakuhi += syoukyakuhi;

                    insertMeisaiRow(context, koteiShisanId, kaisuu, shiyouTsukisuu, syoukyakuhi, gensyoubi,
                        kisyuTyouboKagaku, ruikeiSyoukyakuhi);

                    break;
                }

                if (ruikeiShiyouTsukisuu == taiyouNensuu * 12 &&        // 最終年
                    kisyuTyouboKagaku - syoukyakuhi != zanzonKagaku)    // 残存価額の調整が必要
                {
                    if (shiyouTsukisuu == 12)   // 年跨ぎ
                    {
                        ruikeiSyoukyakuhi += syoukyakuhi;

                        insertMeisaiRow(context, koteiShisanId, kaisuu, shiyouTsukisuu, syoukyakuhi, gensyoubi,
                            kisyuTyouboKagaku, ruikeiSyoukyakuhi);

                        shiyouTsukisuu = 1;
                        kaisuu++;
                        gensyoubi = gensyoubi.AddYears(1);
                        kisyuTyouboKagaku = kisyuTyouboKagaku - syoukyakuhi;
                        syoukyakuhi = kisyuTyouboKagaku - zanzonKagaku;
                        ruikeiSyoukyakuhi += syoukyakuhi;

                        insertMeisaiRow(context, koteiShisanId, kaisuu, shiyouTsukisuu, syoukyakuhi, gensyoubi,
                            kisyuTyouboKagaku, ruikeiSyoukyakuhi);
                    }
                    else
                    {
                        shiyouTsukisuu += 1;
                        syoukyakuhi = kisyuTyouboKagaku - zanzonKagaku;
                        ruikeiSyoukyakuhi += syoukyakuhi;

                        insertMeisaiRow(context, koteiShisanId, kaisuu, shiyouTsukisuu, syoukyakuhi, gensyoubi,
                            kisyuTyouboKagaku, ruikeiSyoukyakuhi);
                    }
                }
                else
                {
                    ruikeiSyoukyakuhi += syoukyakuhi;

                    insertMeisaiRow(context, koteiShisanId, kaisuu, shiyouTsukisuu, syoukyakuhi, gensyoubi,
                        kisyuTyouboKagaku, ruikeiSyoukyakuhi);
                }

                kaisuu++;
                gensyoubi = gensyoubi.AddYears(1);
            }

            return true;
        }


        private static void insertMeisaiRow(models.Context context, int koteiShisanId, long kaisuu, long shiyouTsukisuu,
            long syoukyakuhi, DateTime gensyoubi, long kisyuTyouboKagaku, long genkaSyoukyakuRuikeigaku)
        {
            string countCondition = "where kotei_shisan_bangou = " + koteiShisanId + " and kaisuu = " + kaisuu;
            if (context.KaikeiDatabase.GenkaSyoukyakuMeisai.RowCount(countCondition) == 0)
            {
                models.db.Row meisaiRow = context.KaikeiDatabase.GenkaSyoukyakuMeisai.NewRow();
                meisaiRow.Table.SetColumnValue(meisaiRow, "kotei_shisan_bangou", koteiShisanId);
                meisaiRow.Table.SetColumnValue(meisaiRow, "kaisuu", kaisuu);
                meisaiRow.Table.SetColumnValue(meisaiRow, "tsukisuu", shiyouTsukisuu);
                meisaiRow.Table.SetColumnValue(meisaiRow, "kisyu_tyoubo_kagaku", kisyuTyouboKagaku);
                meisaiRow.Table.SetColumnValue(meisaiRow, "touki_genka_syoukyaku_kagaku", syoukyakuhi);
                meisaiRow.Table.SetColumnValue(meisaiRow, "genka_syoukyaku_ruikeigaku", genkaSyoukyakuRuikeigaku);
                meisaiRow.Table.SetColumnValue(meisaiRow, "kimatsu_tyoubo_kagaku", kisyuTyouboKagaku - syoukyakuhi);
                meisaiRow.Table.SetColumnValue(meisaiRow, "gensyoubi", gensyoubi);
                meisaiRow.Table.SetColumnValue(meisaiRow, "denpyou_hakkou", false);
                meisaiRow.Table.Insert(meisaiRow);
            }
        }


        private static long TeigakuhouGenkaSyoukyakuhi(long syutokuKakaku, double zanzonWariai, long shiyouTsukisuu, double syoukyakuRitsu) {
            return (long)Math.Round(syutokuKakaku * (100 - zanzonWariai) / 100.0 * syoukyakuRitsu * shiyouTsukisuu / 12);
        }


        // 償却率
        public static double Syoukyakuritu(int syoukyakuHouhou, int taiyouNennsuu) {
            if(syoukyakuHouhou == (int)models.constants.MTSyoukyakuHouhou.Teigakuhou){
                switch(taiyouNennsuu){
                    case 2: return 0.5;
                    case 3: return 0.333;
                    case 4: return 0.25;
                    case 5: return 0.2;
                    case 6: return 0.166;
                    case 7: return 0.142;
                    case 8: return 0.125;
                    case 9: return 0.111;
                    case 10: return 0.1;
                    case 11: return 0.09;
                    case 12: return 0.083;
                    case 13: return 0.076;
                    case 14: return 0.071;
                    case 15: return 0.066;
                    case 16: return 0.062;
                    case 17: return 0.058;
                    case 18: return 0.055;
                    case 19: return 0.052;
                    case 20: return 0.05;
                    case 21: return 0.048;
                    case 22: return 0.046;
                    case 23: return 0.044;
                    case 24: return 0.042;
                    case 25: return 0.04;
                    case 26: return 0.039;
                    case 27: return 0.037;
                    case 28: return 0.036;
                    case 29: return 0.035;
                    case 30: return 0.034;
                    case 31: return 0.033;
                    case 32: return 0.032;
                    case 33: return 0.031;
                    case 34: return 0.03;
                    case 35: return 0.029;
                    case 36: return 0.028;
                    case 37: return 0.027;
                    case 38: return 0.027;
                    case 39: return 0.026;
                }
            }
            else if(syoukyakuHouhou == (int)models.constants.MTSyoukyakuHouhou.Teiritsuhou){
                switch(taiyouNennsuu){
                    case 3: return 0.536;
                    case 4: return 0.438;
                    case 5: return 0.369;
                    case 6: return 0.319;
                    case 7: return 0.28;
                    case 8: return 0.25;
                    case 9: return 0.226;
                    case 10: return 0.206;
                    case 11: return 0.189;
                    case 12: return 0.175;
                    case 13: return 0.162;
                    case 14: return 0.152;
                    case 15: return 0.142;
                    case 16: return 0.134;
                    case 17: return 0.127;
                    case 18: return 0.12;
                    case 19: return 0.114;
                    case 20: return 0.109;
                    case 21: return 0.104;
                    case 22: return 0.099;
                    case 23: return 0.095;
                    case 24: return 0.092;
                    case 25: return 0.088;
                    case 26: return 0.085;
                    case 27: return 0.082;
                    case 28: return 0.079;
                    case 29: return 0.076;
                    case 30: return 0.074;
                    case 31: return 0.072;
                    case 32: return 0.069;
                    case 33: return 0.067;
                    case 34: return 0.066;
                    case 35: return 0.064;
                    case 36: return 0.062;
                    case 37: return 0.06;
                    case 38: return 0.059;
                    case 39: return 0.057;
                }
            }
            return 0;
        }
    }
}
