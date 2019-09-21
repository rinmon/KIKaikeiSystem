﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaikeiSystemBody.views.grid
{
    /// <summary>
    ///  Genericなクラスをデザイナで表示できなかったので、ラッパを作成
    /// </summary>
    partial class TorihikiKubunGrid : PanelGrid<TorihikiKubunRow>
    {
        public TorihikiKubunGrid() {
            InitializeComponent();
        }
    }
}
