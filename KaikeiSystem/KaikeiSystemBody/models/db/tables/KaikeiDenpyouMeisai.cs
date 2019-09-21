using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KaikeiSystemBody.models.db.mtables;

namespace KaikeiSystemBody.models.db.tables
{
    /// <summary>
    /// 会計伝票明細
    /// </summary>
    class KaikeiDenpyouMeisai : AbstractTable
    {
        public const string TABLE_NAME = "kaikei_denpyou_meisai";

        public KaikeiDenpyouMeisai(AbstractDatabase db, string tableName = TABLE_NAME) : base(db, tableName) {
            //base.AddColumn("meisai_id", ColumnType.TypeInt, "");                                // 明細ID
            base.AddColumn("kaikei_kubun", ColumnType.TypeInt, "");                               // 会計区分
            base.AddColumn("torihiki_kubun", ColumnType.TypeInt, "");                             // 取引区分
            base.AddColumn("kihyoubi", ColumnType.TypeDate, "");                                  // 起票日
            base.AddColumn("kihyoubi_gengou", ColumnType.TypeString, "");                         // 起票日　元号
            base.AddColumn("kihyoubi_year", ColumnType.TypeInt, "");                              // 起票日　年
            base.AddColumn("kihyoubi_month", ColumnType.TypeInt, "");                             // 起票日　月
            base.AddColumn("kihyoubi_day", ColumnType.TypeInt, "");                             　// 起票日　日
            base.AddColumn("karikata_kamoku_id", ColumnType.TypeInt, "");                         // 借方科目ID (勘定科目)
            base.AddColumn("karikata_hojo_id", ColumnType.TypeInt, "");                           // 借方補助ID (勘定科目)
            base.AddColumn("karikata_hojo_seiri", ColumnType.TypeInt, "");                        // 借方補助整理
            base.AddColumn("karikata_kingaku", ColumnType.TypeAmount, "");                        // 借方金額
            base.AddColumn("kashikata_kamoku_id", ColumnType.TypeInt, "");                        // 貸方科目ID (勘定科目)
            base.AddColumn("kashikata_hojo_id", ColumnType.TypeInt, "");                          // 貸方補助ID (勘定科目)
            base.AddColumn("kashikata_hojo_seiri", ColumnType.TypeInt, "");                       // 貸方補助整理
            base.AddColumn("kashikata_kingaku", ColumnType.TypeAmount, "");                       // 貸方金額
            base.AddColumn("tekiyou_id", ColumnType.TypeInt, "");                                 // 摘要ID
            base.AddColumn("comment", ColumnType.TypeString, "");                                 // コメント
            base.AddColumn("denpyou_kakunin", ColumnType.TypeBool, "");                           // 伝票確認
            base.AddColumn("karikata_kamoku_code", ColumnType.TypeString, "");                    // 借方科目コード
            base.AddColumn("kashikata_kamoku_code", ColumnType.TypeString, "");                   // 貸方科目コード
            base.AddColumn("kessan_syuuryou", ColumnType.TypeBool, "");                           // 決算終了
            base.AddColumn("denpyou_bangou", ColumnType.TypeString, "");                          // 伝票番号
            base.AddColumn("denpyou_renban", ColumnType.TypeInt, "");                             // 伝票連番
            base.AddColumn("hojo_kamoku_touroku", ColumnType.TypeString, "");                     // 補助科目登録
            base.AddColumn("created_at", ColumnType.TypeDate, "");                                // 登録日
            base.AddColumn("updated_at", ColumnType.TypeDate, "");                                // 更新日

            // 伝票番号はselectのorder byで使用するので、編集するとselectの結果の順番が変わってしまう。
            // そこで、編集中は伝票番号を一度キャッシュに入れて後で一括して更新する。
            base.AddColumn("denpyou_bangou_cache", ColumnType.TypeString, "");                    // 伝票番号 (キャッシュ)
            base.AddColumn("editing", ColumnType.TypeBool, "");                                   // 編集中かどうか

            base.AddColumn("parent_meisai_id", ColumnType.TypeInt, "");
            base.AddColumn("meisai_group_next_id", ColumnType.TypeInt, "");

            base.AddIndex("create index " + tableName + "_index on " + tableName + "(denpyou_bangou)");
        }


        public void UpdateEditingRows() {
            OwnerDB.ExecuteNonQuery("update " + TableName + " set denpyou_bangou = denpyou_bangou_cache, editing=0 where editing <> 0");
        }


        public void SetKihyoubiAndDenpyouBangouCache(Row row, DateTime kihyoubi) {
            string wareki = helper.Converter.DateTimeToWarekiStr(kihyoubi);

            row.Set("kihyoubi", kihyoubi);
            row.Set("kihyoubi_gengou", wareki.Substring(0, 1));
            row.Set("kihyoubi_year", helper.Converter.ObjToInt(wareki.Substring(1, 2), 0));
            row.Set("kihyoubi_month", kihyoubi.Month);
            row.Set("kihyoubi_day", kihyoubi.Day);

            // 伝票番号を起票日に合わせて設定
            this.SetColumnValue(row, "kihyoubi", kihyoubi);
        }


        public void UpdateCommentWithTekiyou(Row row) {
            int key = (int)row.GetLong("tekiyou_id", -1);
            var tekiyouRows = (OwnerDB as models.db.KaikeiDatabase).MTTekiyou.Select("where tekiyou_code = " + key);
            if (tekiyouRows.Count() > 0) {
                row.Set("comment", tekiyouRows.First().GetStr("tekiyou_mei"));
            }
        }


        public override bool SetColumnValue(Row row, string column, object val) {
            //System.Diagnostics.Debug.WriteLine("set column value:" + column + " value:" + val.ToString());

            if(!base.SetColumnValue(row, column, val)){
                return false;
            }

            // 他のカラムを連動して変更
            if (column == "kihyoubi_gengou" || column == "kihyoubi_year" || column == "kihyoubi_month" || column == "kihyoubi_day") {
                DateTime? date = helper.Converter.ObjToDateTime(row.Get("kihyoubi_gengou"), row.Get("kihyoubi_year"), row.Get("kihyoubi_month"), row.Get("kihyoubi_day"));
                SetColumnValue(row, "kihyoubi", date);
            }
            else if (column == "kihyoubi") {
                if (!row.IsNull(column)) {
                    DateTime date = row.GetDate(column).Value;
                    string denpyou_bangou = row.GetStr("denpyou_bangou_cache");
                    if (denpyou_bangou.Length >= 5 && denpyou_bangou.Substring(0, 5) == helper.Converter.DateTimeToWarekiStr(date).Replace("/", "").Substring(0, 5)) {

                    }
                    else {
                        int renban = this.GetNextDenpyouRenban(date.Year, date.Month);
                        row.Set("denpyou_renban", renban);
                        SetColumnValue(row, "denpyou_bangou_cache", this.FormatDenpyouBangou(date, renban));
                    }
                }
            }
            else if (column == "denpyou_bangou_cache") {
                row.Set("editing", true);
            }
            else if (column == "karikata_hojo_seiri") {
                Row kamoku = (OwnerDB.Table(MTKanjouKamoku.TABLE_NAME) as MTKanjouKamoku).GetRowFromCodeCacheByTopParent(
                                   (int)row.GetLong("karikata_kamoku_id", -2),  //科目IDが設定されていないときは補助IDも設定しない
                                   helper.Converter.ObjToString(val));
                if (kamoku != null && !kamoku.IsNull("id")) {
                    row.Set("karikata_hojo_id", kamoku.GetLong("id", -1));
                }
                else {
                    row.Set("karikata_hojo_id", null);
                }
            }
            else if (column == "kashikata_hojo_seiri") {
                Row kamoku = (OwnerDB.Table(MTKanjouKamoku.TABLE_NAME) as MTKanjouKamoku).GetRowFromCodeCacheByTopParent(
                                   (int)row.GetLong("kashikata_kamoku_id", -2),  //科目IDが設定されていないときは補助IDも設定しない
                                   helper.Converter.ObjToString(val));
                if (kamoku != null && !kamoku.IsNull("id")) {
                    row.Set("kashikata_hojo_id", kamoku.GetLong("id", -1));
                }
                else {
                    row.Set("kashikata_hojo_id", null);
                }
            }
            else if (column == "tekiyou_id") {/* 摘要を入力したときのみコメントを更新
                int? key = helper.Converter.ObjToIntObj(val);
                if (key != null && (db_.Table(models.db.MTTekiyou.TABLE_NAME) as models.db.MTTekiyou).RowCache.ContainsKey(key.Value)) {
                    var tekiyou = (db_.Table(models.db.MTTekiyou.TABLE_NAME) as models.db.MTTekiyou).RowCache[key.Value];
                    if (tekiyou != null) {
                        row.Set("comment", tekiyou.GetStr("tekiyou_mei"));
                    }
                }*/
            }
            else if (column == "karikata_kamoku_code") {
                if (val == null) {
                    row.Set("karikata_kamoku_id", null);
                    row.Set("karikata_hojo_id", null);
                    row.Set("karikata_hojo_seiri", null);
                }
                else {
                    Row kamoku = (OwnerDB.Table(MTKanjouKamoku.TABLE_NAME) as MTKanjouKamoku).GetRowFromCodeCache(
                                       -1, helper.Converter.ObjToString(val));
                    if (kamoku != null) {
                        row.Set("karikata_kamoku_id", kamoku.Get("id"));
                        this.SetColumnValue(row, "karikata_hojo_seiri", row.GetStr("karikata_hojo_seiri"));
                    }
                    else {
                        row.Set("karikata_kamoku_id", null);
                        row.Set("karikata_hojo_id", null);
                    }
                }
            }
            else if (column == "kashikata_kamoku_code") {
                if (val == null) {
                    row.Set("kashikata_kamoku_id", null);
                    row.Set("kashikata_hojo_id", null);
                    row.Set("kashikata_hojo_seiri", null);
                }
                else {
                    Row kamoku = (OwnerDB.Table(MTKanjouKamoku.TABLE_NAME) as MTKanjouKamoku).GetRowFromCodeCache(
                                       -1, helper.Converter.ObjToString(val));
                    if (kamoku != null) {
                        row.Set("kashikata_kamoku_id", kamoku.Get("id"));
                        this.SetColumnValue(row, "kashikata_hojo_seiri", row.GetStr("kashikata_hojo_seiri"));
                    }
                    else {
                        row.Set("kashikata_kamoku_id", null);
                        row.Set("kashikata_hojo_id", null);
                    }
                }
            }

            return true;
        }


        // 行全体として正当な値に整形する
        public override void FormalizeRow(Row row) {
            { // 起票日を、元号、月、日と同期する
                DateTime? date = row.GetDate("kihyoubi");

                if (date == null) {
                    row.Set("kihyoubi_gengou", null);
                    row.Set("kihyoubi_year", null);
                    row.Set("kihyoubi_month", null);
                    row.Set("kihyoubi_day", null);
                }
                else {
                    row.Set("kihyoubi_gengou", row.GetWarekiGengoStr("kihyoubi", ""));
                    row.Set("kihyoubi_year", int.Parse(row.GetWarekiYearStr("kihyoubi", "0")));
                    row.Set("kihyoubi_month", row.GetMonth("kihyoubi", 0));
                    row.Set("kihyoubi_day", row.GetDay("kihyoubi", 0));
                }
            }
        }


        public int GetNextDenpyouRenban(int year, int month) {
            var rows = this.Select(
                "where " + helper.Converter.DateToInt(year, month, 0).ToString() + " <= kihyoubi and " +
                " kihyoubi < " + helper.Converter.DateToInt(year, month + 1, 0).ToString() + " order by denpyou_renban desc limit 1"
            );

            int renban;
            if (rows.Count() > 0) {
                renban = (int)rows.First().GetLong("denpyou_renban", 0) + 1;
            }
            else {
                renban = 1;
            }

            return renban;
        }


        public string FormatDenpyouBangou(DateTime date, int renban) {
            string wareki = helper.Converter.DateTimeToWarekiStr(date);
            return String.Format("{0}{1:00}{2:00}-{3:0000}", wareki.Substring(0, 1), int.Parse(wareki.Substring(1, 2)), date.Month, renban);
        }


        // 指定月の伝票番号を設定しなおす
        public void RenumberDenpyouBangou(DateTime targetMonth, bool sortWithKaikeiTanni) {
            OwnerDB.BeginTransaction();

            string kaikeiKubun = sortWithKaikeiTanni ? "kaikei_kubun, " : "";
            string select_sql = string.Format("where kihyoubi_gengou='{0}' and kihyoubi_year={1} and kihyoubi_month={2} " +
                "order by {3} kihyoubi, denpyou_renban, id",
                helper.Converter.DateTimeToWarekiGengou(targetMonth),
                helper.Converter.DateTimeToWarekiYear(targetMonth),
                targetMonth.Month,
                kaikeiKubun);

            int renban = 0;
            string prevOriginalDenpyouBangou = null;
            foreach (var row in this.Select(select_sql)) {
                if(row.IsNull("kihyoubi")){
                    continue;
                }
                string originalDenpyouBangou = row.GetStr("denpyou_bangou", "");
                if (prevOriginalDenpyouBangou != originalDenpyouBangou) {
                    renban++;
                }
                this.SetColumnValue(row, "denpyou_renban", renban);
                string bangou = this.FormatDenpyouBangou(row.GetDate("kihyoubi").Value, renban);
                row.Set("denpyou_bangou_cache", bangou);
                row.Set("denpyou_bangou", bangou);
                this.Update(row);

                prevOriginalDenpyouBangou = originalDenpyouBangou;
            }

            OwnerDB.CommitTransaction();
        }


        // 指定範囲の伝票番号を振りなおす
        public void RenumberDenpyouBangouRange(DateTime start, DateTime end) {
            DateTime target = start;
            while (true) {
                this.RenumberDenpyouBangou(target, false);

                if (target.Year == end.Year && target.Month == end.Month) {
                    break;
                }
                target = target.AddMonths(1);
            }
        }



        // 事業伝票に対応する資金伝票を作成する
        private void AddShikinDenpyouRowPairOfJigyouDenpyouRow(Row jigyouDenpyouRow, string denpyouBangou) {
            Row shikinDenpyouRow = this.NewRow();
            shikinDenpyouRow.Set("denpyou_bangou", denpyouBangou);
            UpdateShikinDenpyouRowPairOfJigyouDenpyouRowSub(jigyouDenpyouRow, shikinDenpyouRow);
            shikinDenpyouRow.Set("meisai_group_next_id", (int)jigyouDenpyouRow.GetLong("id", -1));
            shikinDenpyouRow.Set("parent_meisai_id", (int)jigyouDenpyouRow.GetLong("id", -1));
            this.Insert(shikinDenpyouRow);

            jigyouDenpyouRow.Set("meisai_group_next_id", (int)this.LastInsertedRow().GetLong("id", -1));
            this.Update(jigyouDenpyouRow);
        }

        // 事業伝票に対応する資金伝票を更新する
        private void UpdateShikinDenpyouRowPairOfJigyouDenpyouRow(Row jigyouDenpyouRow) {
            int shikinDenpyouId = (int)jigyouDenpyouRow.GetLong("meisai_group_next_id", -1);

            if (shikinDenpyouId != -1) {
                Row shikinDenpyouRow = this.GetRowById(shikinDenpyouId);
                UpdateShikinDenpyouRowPairOfJigyouDenpyouRowSub(jigyouDenpyouRow, shikinDenpyouRow);
                this.Update(shikinDenpyouRow);
            }
        }


        private void UpdateShikinDenpyouRowPairOfJigyouDenpyouRowSub(Row jigyouDenpyouRow, Row shikinDenpyouRow) {
            DateTime? kihyoubi = jigyouDenpyouRow.GetDate("kihyoubi");
            if (kihyoubi != null) {
                this.SetKihyoubiAndDenpyouBangouCache(shikinDenpyouRow, kihyoubi.Value);
            }
            else {
                shikinDenpyouRow.Set("kihyoubi", null);
                shikinDenpyouRow.Set("kihyoubi_gengou", null);
                shikinDenpyouRow.Set("kihyoubi_year", null);
                shikinDenpyouRow.Set("kihyoubi_month", null);
                shikinDenpyouRow.Set("kihyoubi_day", null);
            }

            shikinDenpyouRow.Set("kaikei_kubun", jigyouDenpyouRow.Get("kaikei_kubun"));
            shikinDenpyouRow.Set("torihiki_kubun", (int)models.constants.MTTorihikiKubun.Shikin);
            shikinDenpyouRow.Set("karikata_kingaku", jigyouDenpyouRow.Get("karikata_kingaku"));
            shikinDenpyouRow.Set("kashikata_kingaku", jigyouDenpyouRow.Get("kashikata_kingaku"));
            shikinDenpyouRow.Set("tekiyou_id", jigyouDenpyouRow.Get("tekiyou_id"));
            shikinDenpyouRow.Set("comment", jigyouDenpyouRow.Get("comment"));
            shikinDenpyouRow.Set("denpyou_kakunin", jigyouDenpyouRow.Get("denpyou_kakunin"));
            shikinDenpyouRow.Set("kessan_syuuryou", jigyouDenpyouRow.Get("kessan_syuuryou"));
            shikinDenpyouRow.Set("hojo_kamoku_touroku", jigyouDenpyouRow.Get("hojo_kamoku_touroku"));

            Row karikataKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)jigyouDenpyouRow.GetLong("karikata_kamoku_id", -1));
            if (karikataKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1) {
                shikinDenpyouRow.Set("karikata_kamoku_id", (int)models.constants.MTKanjouKamoku.ShiharaiShikin);
                shikinDenpyouRow.Set("karikata_kamoku_code", (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)models.constants.MTKanjouKamoku.ShiharaiShikin).Get("kamoku_code"));
                shikinDenpyouRow.Set("karikata_hojo_id",0);
                shikinDenpyouRow.Set("karikata_hojo_seiri", 0);
            }
            else{
                shikinDenpyouRow.Set("karikata_kamoku_id", jigyouDenpyouRow.Get("karikata_kamoku_id"));
                shikinDenpyouRow.Set("karikata_kamoku_code", jigyouDenpyouRow.Get("karikata_kamoku_code"));
                shikinDenpyouRow.Set("karikata_hojo_id", jigyouDenpyouRow.Get("karikata_hojo_id"));
                shikinDenpyouRow.Set("karikata_hojo_seiri", jigyouDenpyouRow.Get("karikata_hojo_seiri"));
            }

            Row kashikataKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)jigyouDenpyouRow.GetLong("kashikata_kamoku_id", -1));
            if (kashikataKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1) {
                shikinDenpyouRow.Set("kashikata_kamoku_id", (int)models.constants.MTKanjouKamoku.ShiharaiShikin);
                shikinDenpyouRow.Set("kashikata_kamoku_code", (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)models.constants.MTKanjouKamoku.ShiharaiShikin).Get("kamoku_code"));
                shikinDenpyouRow.Set("kashikata_hojo_id", 0);
                shikinDenpyouRow.Set("kashikata_hojo_seiri", 0);
            }
            else {
                shikinDenpyouRow.Set("kashikata_kamoku_id", jigyouDenpyouRow.Get("kashikata_kamoku_id"));
                shikinDenpyouRow.Set("kashikata_kamoku_code", jigyouDenpyouRow.Get("kashikata_kamoku_code"));
                shikinDenpyouRow.Set("kashikata_hojo_id", jigyouDenpyouRow.Get("kashikata_hojo_id"));
                shikinDenpyouRow.Set("kashikata_hojo_seiri", jigyouDenpyouRow.Get("kashikata_hojo_seiri"));
            }
        }


        // 事業伝票
        // 　取引区分 ＝ 事業
        // （事業科目　←　貸借科目）or
        // （貸借科目　←　事業科目）or
        //  (事業科目　←　事業科目) の形式
        private bool IsJigyouDenpyouRow(Row row) {
            if ((int)row.GetLong("torihiki_kubun", -1) != (int)models.constants.MTTorihikiKubun.Jigyou) {
                return false;
            }

            Row karikataKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)row.GetLong("karikata_kamoku_id", -1));
            Row kashikataKamokuRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)row.GetLong("kashikata_kamoku_id", -1));
            if (karikataKamokuRow == null || kashikataKamokuRow == null) {
                return false;
            }

            Row jigyouKamokuRow = null;
            Row taisyakuKamokuRow = null;
            if (karikataKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1) {
                jigyouKamokuRow = kashikataKamokuRow;
                taisyakuKamokuRow = karikataKamokuRow;
            }
            else if (kashikataKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1) != -1) {
                jigyouKamokuRow = karikataKamokuRow;
                taisyakuKamokuRow = kashikataKamokuRow;
            }
            else {
                // 事業科目 ← 事業科目
                if (karikataKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1) == -1) {
                    return false;
                }
                if (karikataKamokuRow.GetLong("shikin_kamoku_kubun_id", -1) == -1) {
                    return false;
                }
                if (kashikataKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1) == -1) {
                    return false;
                }
                if (kashikataKamokuRow.GetLong("shikin_kamoku_kubun_id", -1) == -1) {
                    return false;
                }
                return true;
            }

            // （事業科目　←　貸借科目）or（貸借科目　←　事業科目）
            if (jigyouKamokuRow.GetLong("jigyou_kamoku_kubun_id", -1) == -1) {
                return false;
            }
            if (jigyouKamokuRow.GetLong("shikin_kamoku_kubun_id", -1) == -1) {
                return false;
            }

            //貸借科目が（諸口もしくは流動資産,流動負債）なら事業伝票、それ以外ならfalse
            int taisyakuKamokuKubunId = (int)taisyakuKamokuRow.GetLong("taisyaku_kamoku_kubun_id", -1);
            if (taisyakuKamokuKubunId != (int)models.constants.MTKamokuKubun.Syokuchi) {
                if ((OwnerDB as KaikeiDatabase).MTKamokuKubun.IsParentOf(childId: taisyakuKamokuKubunId, parentId: (int)models.constants.MTKamokuKubun.RyuudouShisan) == false &&
                    (OwnerDB as KaikeiDatabase).MTKamokuKubun.IsParentOf(childId: taisyakuKamokuKubunId, parentId: (int)models.constants.MTKamokuKubun.RyuudouHusai) == false) {
                    return false;
                }
            }
            return true;
        }


        // 自動入力された資金伝票
        public bool IsAutoInsertedShikinDenpyouRow(Row row) {
            if ((int)row.GetLong("torihiki_kubun", -1) != (int)models.constants.MTTorihikiKubun.Shikin) {
                return false;
            }

            if ((int)row.GetLong("parent_meisai_id", -1) == -1) {
                return false;
            }

            return true;
        }


        // 事業の伝票とペアになっている資金の伝票
        //  （自動入力されたものだけでよいはずだが、自動入力を実装する前に入力された伝票にも対応するためにIsAutoInsertedShikinDenpyouRowとは別に用意した）
        public bool IsPairedShikinRow(Row row) {
            if(IsAutoInsertedShikinDenpyouRow(row)){
                return true;
            }
            if ((int)row.GetLong("karikata_kamoku_id", -1) == (int)models.constants.MTKanjouKamoku.ShiharaiShikin) {
                Row kashikataRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)row.GetLong("kashikata_kamoku_id", -1));
                if (kashikataRow != null && kashikataRow.GetLong("shikin_kamoku_kubun_id", -1) != -1 && kashikataRow.GetLong("jigyou_kamoku_kubun_id", -1) != -1) {
                    return true;
                }
            }
            if ((int)row.GetLong("kashikata_kamoku_id", -1) == (int)models.constants.MTKanjouKamoku.ShiharaiShikin) {
                Row karikataRow = (OwnerDB as KaikeiDatabase).MTKanjouKamoku.GetRowById((int)row.GetLong("karikata_kamoku_id", -1));
                if (karikataRow != null && karikataRow.GetLong("shikin_kamoku_kubun_id", -1) != -1 && karikataRow.GetLong("jigyou_kamoku_kubun_id", -1) != -1) {
                    return true;
                }
            }

            return false;
        }


        public enum UpdateMeisaiGroupResult {
            Inserted,
            Updated,
            Deleted,
            None
        }

        public UpdateMeisaiGroupResult UpdateMeisaiGroup(Row row, string newDenpyouBangou) {
            UpdateMeisaiGroupResult result = UpdateMeisaiGroupResult.None;

            if (this.IsJigyouDenpyouRow(row)) {
                int nextId = (int)row.GetLong("meisai_group_next_id", -1);
                if (nextId == -1) {
                    result = UpdateMeisaiGroupResult.Inserted;
                    this.AddShikinDenpyouRowPairOfJigyouDenpyouRow(row, newDenpyouBangou);
                }
                else {
                    result = UpdateMeisaiGroupResult.Updated;
                    this.UpdateShikinDenpyouRowPairOfJigyouDenpyouRow(row);
                }
                //gridController.ShowMsgAndChangeFocus("事業伝票が入力された", "warn", null);
            }
            else {
                if (this.DeleteMeisaiGroup(row)) {
                    row.Set("meisai_group_next_id", -1);
                    row.Table.Update(row);
                    result = UpdateMeisaiGroupResult.Deleted;
                }
            }

            return result;
        }


        // 削除したらTrueを返す
        public bool DeleteMeisaiGroup(Row row) {
            // 明細グループのルートなら子明細を削除
            int parentId = (int)row.GetLong("parent_meisai_id", -1);
            if (parentId == -1) {
                int nextId = (int)row.GetLong("meisai_group_next_id", -1);
                if (nextId != -1) {
                    row.Table.Delete(nextId);
                    return true;
                }
            }

            return false;
        }


        public bool IsUsedKanjouKamoku(int kanjouKamokuId) {
            int ct = this.RowCount(
                "where karikata_kamoku_id = " + kanjouKamokuId +
                " or kashikata_kamoku_id = " + kanjouKamokuId +
                " or karikata_hojo_id = " + kanjouKamokuId +
                " or kashikata_hojo_id = " + kanjouKamokuId);

            return ct != 0;
        }


        override public void LoadCSV(string filename) {
            OwnerDB.BeginTransaction();

            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("meisai_id", CSVParser.ReadInt(token[1]));
                    row.Set("kaikei_tanni", CSVParser.ReadInt(token[2]));
                    row.Set("keiri_kubun", CSVParser.ReadInt(token[3]));
                    row.Set("torihiki_kubun", CSVParser.ReadInt(token[4]));
                    row.Set("kihyoubi", CSVParser.ReadDate(token[5]));
                    row.Set("karikata_kamoku_id", CSVParser.ReadInt(token[6]));
                    row.Set("karikata_hojo_id", CSVParser.ReadInt(token[7]));
                    row.Set("karikata_hojo_seiri", CSVParser.ReadInt(token[8]));
                    row.Set("karikata_kingaku", CSVParser.ReadAmount(token[9]));
                    row.Set("kashikata_kamoku_id", CSVParser.ReadInt(token[10]));
                    row.Set("kashikata_hojo_id", CSVParser.ReadInt(token[11]));
                    row.Set("kashikata_hojo_seiri", CSVParser.ReadInt(token[12]));
                    row.Set("kashikata_kingaku", CSVParser.ReadAmount(token[13]));
                    row.Set("tekiyou_id", CSVParser.ReadInt(token[14]));
                    row.Set("comment", CSVParser.ReadString(token[15]));
                    row.Set("denpyou_kakunin", CSVParser.ReadBool(token[16]));
                    row.Set("kihyoubi_gengou", CSVParser.ReadString(token[17]));
                    row.Set("kihyoubi_year", CSVParser.ReadInt(token[18]));
                    row.Set("kihyoubi_month", CSVParser.ReadInt(token[19]));
                    row.Set("kihyoubi_day", CSVParser.ReadInt(token[20]));
                    row.Set("karikata_kamoku_code", CSVParser.ReadString(token[21]));
                    row.Set("kashikata_kamoku_code", CSVParser.ReadString(token[22]));
                    row.Set("kessan_syuuryou", CSVParser.ReadBool(token[23]));
                    row.Set("denpyou_bangou", CSVParser.ReadString(token[25]));
                    row.Set("denpyou_renban", CSVParser.ReadInt(token[26]));
                    row.Set("hojo_kamoku_touroku", CSVParser.ReadString(token[28]));
                    row.Set("created_at", CSVParser.ReadDate(token[24]));
                    row.Set("updated_at", CSVParser.ReadDate(token[27]));

                    row.Set("denpyou_bangou_cache", CSVParser.ReadString(token[25]));
                    row.Set("editing", false);

                    this.Insert(row);
                }
            }

            OwnerDB.CommitTransaction();
        }
    }
}
