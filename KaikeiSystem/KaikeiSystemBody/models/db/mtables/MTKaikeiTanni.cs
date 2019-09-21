﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.db.mtables
{
    /// <summary>
    /// MT会計単位
    /// </summary>
    class MTKaikeiTanni : AbstractMasterTable
    {
        public const string TABLE_NAME = "mt_kaikei_tanni";

        public MTKaikeiTanni(AbstractDatabase db)
            : base(db, TABLE_NAME) {
            base.AddColumn("kaikei_tanni", ColumnType.TypeString, "");            // 会計単位
        }


        override public void LoadCSV(string filename) {
            using (var reader = new System.IO.StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"))) {
                string line;
                Row row = new Row(this);

                while ((line = reader.ReadLine()) != null) {
                    string[] token = line.Split('\t');
                    row.Set("id", CSVParser.ReadInt(token[0]));
                    row.Set("kaikei_tanni", CSVParser.ReadString(token[1]));
                    this.Insert(row);
                }
            }
        }
    }
}
