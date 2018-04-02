using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;


namespace Banhuitong.Console {
    using Account;
    public partial class BankInfoPersonDlg : Form {
        private long m_auId;
        private BankInfoProperties m_bankInfo = null;

        public BankInfoPersonDlg(long auId) {
            InitializeComponent();
            m_auId = auId;
        }

        private void BankInfoUserDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_auId);
            UpdateTable();
        }

        private async void UpdateTable() {
            var p = await InvestPersons.BankInfo(m_auId);

            if (p.IsOk) {
                var d = p.AsDictionary;
                var name = d.GetOrDefault<string>("name");
                var mobile = d.GetOrDefault<string>("mobile");
                var idCard = d.GetOrDefault<string>("idCard");
                var reCard = d.GetOrDefault<string>("reCard");
                var userId = d.GetOrDefault<string>("userId");
                var datePoint = Commons.TimestampToDateString(d.GetOrDefault<long>("datePoint"));
                var visibleBal = string.Format("{0:#,##0.00}", d.GetOrDefault<decimal>("visibleBal"));
                var availableBal = string.Format("{0:#,##0.00}", d.GetOrDefault<decimal>("availableBal"));
                var isPwdSet = d.GetOrDefault<bool>("isPwdSet") ? "是" : "否";

                m_bankInfo = new BankInfoProperties(name, mobile, idCard, reCard, userId, datePoint, visibleBal, availableBal, isPwdSet);
                propertyGrid1.SelectedObject = m_bankInfo;

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private class BankInfoProperties {
            private string name;
            private string mobile;
            private string idCard;
            private string reCard;
            private string userId;
            private string datePoint;
            private string visibleBal;
            private string availableBal;
            private string isPwdSet;

            public BankInfoProperties(string name, string mobile, string idCard, string reCard, string userId, string datePoint,
                string visibleBal, string availableBal, string isPwdSet) {
                this.name = name;
                this.mobile = mobile;
                this.idCard = idCard;
                this.reCard = reCard;
                this.userId = userId;
                this.datePoint = datePoint;
                this.visibleBal = visibleBal;
                this.availableBal = availableBal;
                this.isPwdSet = isPwdSet;
            }

            [Category("基本")]
            [DisplayName("01-姓名")]
            [Description("银行开户使用的机构名称。")]
            public string Name {
                get { return name; }
            }

            [Category("基本")]
            [DisplayName("02-手机")]
            public string Mobile {
                get { return mobile; }
            }

            [Category("基本")]
            [DisplayName("03-身份证号码")]
            [Description("银行开户使用的身份证号码。")]
            public string IdCard {
                get { return idCard; }
            }

            [Category("基本")]
            [DisplayName("04-绑定卡")]
            [Description("提现时使用的银行卡。")]
            public string ReCard {
                get { return reCard; }
            }

            [Category("电子帐户")]
            [DisplayName("11-电子帐户号")]
            public string UserId {
                get { return userId; }
            }

            [Category("电子帐户")]
            [DisplayName("12-开户日期")]
            public string DatePoint {
                get { return datePoint; }
            }

            [Category("电子帐户")]
            [DisplayName("13-是否已设置密码")]
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
