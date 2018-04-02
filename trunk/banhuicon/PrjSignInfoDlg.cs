﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banhuitong.Console {
    using BaseData;
    public partial class PrjSignInfoDlg : Form {
        private long m_pId;

        public PrjSignInfoDlg(long pId) {
            InitializeComponent();
            m_pId = pId;
        }

        private void PrjSignInfoDlg_Load(object sender, EventArgs e) {
            this.Text += m_pId;

            UpdateTable();
        }

        private async void UpdateTable() {
            toolStrip1.Enabled = false;
            var r = new Dictionary<string, object>();
            var p = await PrjSignAgreements.GetSignInfo(m_pId);
            if (p.IsOk) {
                myGridViewBinding1.BindTo(p);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            toolStrip1.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            UpdateTable();
        }

        private void myGridViewBinding1_GridDataTableDisplayValueNeeded(object sender, MyLib.UI.MyGridDataTableDisplayValueNeededArgs e) {
            if (e.Key == "signStatus") {
                e.Value = PrjSignAgreements.SIGN_STATUS.FindByValue(Convert.ToString(e.Value));
            }
        }

    }
}
