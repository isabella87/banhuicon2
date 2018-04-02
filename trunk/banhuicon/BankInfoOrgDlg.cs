using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace Banhuitong.Console {
    using Account;
    using System.Reflection;
    public partial class BankInfoOrgDlg : Form {
        private long m_auId;
        private BankInfoProperties m_bankInfo = null;
        private static readonly TextValues CERT_TYPES;

        static BankInfoOrgDlg() {
            CERT_TYPES = new TextValues()
            .AddNew("组织机构代码", 20)
            .AddNew("社会信用号", 25);
        }

        public BankInfoOrgDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void BankInfoOrgDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await InvestOrgs.BankInfo(m_auId);

            if (p.IsOk) {
                var d = p.AsDictionary;
                var name = d.GetOrDefault<string>("name");
                var idCard = d.GetOrDefault<string>("idCard");
                var mobile = d.GetOrDefault<string>("mobile");
                var busId = d.GetOrDefault<string>("busId");
                var taxId = d.GetOrDefault<string>("taxId");
                var userId = d.GetOrDefault<string>("userId");
                var recard = d.GetOrDefault<string>("reCard");
                var raceCode = CERT_TYPES.FindByValue(d.GetOrDefault<string>("raceCode"));
                var visibleBal = string.Format("{0:#,##0.00}", d.GetOrDefault<decimal>("visibleBal"));
                var availableBal = string.Format("{0:#,##0.00}", d.GetOrDefault<decimal>("availableBal"));
                var isPwdSet = d.GetOrDefault<bool>("isPwdSet") ? "是" : "否";

                m_bankInfo = new BankInfoProperties(name, idCard, mobile, busId, taxId, userId, recard, raceCode, visibleBal, availableBal, isPwdSet);
                propertyGrid1.SelectedObject = m_bankInfo;

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private class BankInfoProperties {
            private string name;
            private string idCard;
            private string mobile;
            private string busId;
            private string taxId;
            private string userId;
            private string reCard;
            private string raceCode;
            private string visibleBal;
            private string availableBal;
            private string isPwdSet;

            public BankInfoProperties(string name, string idCard, string mobile, string busId, string taxId, string userId, string reCard,
                string raceCode, string visibleBal, string availableBal, string isPwdSet) {
                this.name = name;
                this.idCard = idCard;
                this.mobile = mobile;
                this.busId = busId;
                this.taxId = taxId;
                this.userId = userId;
                this.reCard = reCard;
                this.raceCode = raceCode;
                this.visibleBal = visibleBal;
                this.availableBal = availableBal;
                this.isPwdSet = isPwdSet;
            }

            [Category("基本")]
            [DisplayName("01-机构名称")]
            [Description("银行开户使用的机构名称。")]
            public string Name {
                get { return name; }
            }

            [Category("基本")]
            [DisplayName("02-证件类型")]
            [Description("银行开户使用的证件类型。")]
            public string RaceCode {
                get { return raceCode; }
            }

            [Category("基本")]
            [DisplayName("03-证件号码")]
            [Description("银行开户使用的证件号码。")]
            public string IdCard {
                get { return idCard; }
            }

            [Category("基本")]
            [DisplayName("04-联系电话")]
            public string Mobile {
                get { return mobile; }
            }

            [Category("基本")]
            [DisplayName("05-对公帐户")]
            [Description("提现时使用的银行帐户。")]
            public string ReCard {
                get { return reCard; }
            }

            [Category("基本")]
            [DisplayName("06-营业执照号")]
            public string BusId {
                get { return busId; }
            }

            [Category("基本")]
            [DisplayName("07-税务登记号")]
            public string TaxId {
                get { return taxId; }
            }

            [Category("电子帐户")]
            [DisplayName("11-电子帐户号")]
            public string UserId {
                get { return userId; }
            }

            [Category("电子帐户")]
            [DisplayName("12-是否已设置密码")]
            public string IsPwdSet {
                get { return isPwdSet; }
            }

            [Category("余额")]
            [DisplayName("21-总余额")]
            public string VisibleBal {
                get { return visibleBal; }
            }

            [Category("余额")]
            [DisplayName("22-可用余额")]
            [Description("可用余额不包含已投标但是尚未放款的那部分金额。")]
            public string AvailableBal {
                get { return availableBal; }
            }
        }
    }


}
