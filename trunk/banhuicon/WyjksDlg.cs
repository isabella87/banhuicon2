using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;

namespace Banhuitong.Console {
    using Projs;
    public partial class WyjksDlg : Form {
        private IList<Tuple<int, CheckBox>> m_ckbPlans;
        private static readonly TextValues INACIERSTATUS;

        private long m_fId;

        static WyjksDlg() {
            INACIERSTATUS = new TextValues()
            .AddNew("申请中", 1)
            .AddNew("已分配", 2)
            .AddNew("已注册", 3)
            .AddNew("待审核", 4)
            .AddNew("已通过", 5)
            .AddNew("未通过", 6)
            .AddNew("已开户", 7);
        }

        public WyjksDlg(long fid) {
            InitializeComponent();
            m_fId = fid;
            GetAllPlans(tabPage2);
        }

        private void WyjksDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_fId);
            this.SetReadOnly(true);

            UpdateTable();
        }

        private void GetAllPlans(TabPage tabPage) {
            m_ckbPlans = new List<Tuple<int, CheckBox>>();
            foreach (var ctl in tabPage.Controls) {
                if (ctl is CheckBox) {
                    var ckb = (CheckBox)ctl;
                    m_ckbPlans.Add(Tuple.Create(Convert.ToInt32(Commons.NormalNumberStr(ckb.Name)), ckb));
                }
            }
        }

        private async void UpdateTable() {
            var p = await Wyjks.GetFinacierDetails(m_fId);
            if (p.IsOk) {
                var d = p.AsDictionary;

                tbName.Text = d.GetOrDefault<string>("name");
                tbEmail.Text = d.GetOrDefault<string>("email");
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbSrc.Text = d.GetOrDefault<string>("src");
                tbOrgCode.Text = d.GetOrDefault<string>("orgCode");
                tbLinkManName.Text = d.GetOrDefault<string>("linkmanName");
                tbLinkManMobile.Text = d.GetOrDefault<string>("linkmanMobile");
                tbLinkManQQ.Text = d.GetOrDefault<string>("linkmanQq");
                tbLinkManWeChat.Text = d.GetOrDefault<string>("linkmanWchat");


                tbAmt.Text = d.GetOrDefault<string>("amt");
                tbStartTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("startTime"));
                tbEndTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("endTime"));
                tbLoanPurpose.Text = d.GetOrDefault<string>("loanPurpose");

                int num = d.GetOrDefault<int>("guaranteeScheme");
                for (int i = 0; i < m_ckbPlans.Count; ++i) {
                    m_ckbPlans[i].Item2.Checked = Convert.ToBoolean(num & m_ckbPlans[i].Item1);
                }

                tbGuaranteeName.Text = d.GetOrDefault<string>("guaranteeName");
                tbPayerName.Text = d.GetOrDefault<string>("payerName");
                tbDrawerName.Text = d.GetOrDefault<string>("drawerName");
                tbOtherGuaranteeScheme.Text = d.GetOrDefault<string>("otherGuaranteeScheme");
                tbOtherInfo.Text = d.GetOrDefault<string>("otherInfo");

                tbCreateTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("createTime"));
                tbAssignerName.Text = d.GetOrDefault<string>("assignerName");
                tbAssigneTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("assigneTime"));
                tbUpdater.Text = d.GetOrDefault<string>("updater");
                tbUpdateTime.Text = Commons.TimestampToDateString(d.GetOrDefault<long>("updateTime"));
                tbTrackerName.Text = d.GetOrDefault<string>("trackerName");
                tbStatus.Text = INACIERSTATUS.FindByValue(d.GetOrDefault<string>("status"));
                tbInfoFeedBack.Text = d.GetOrDefault<string>("infoFeedback");

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
    }
}
