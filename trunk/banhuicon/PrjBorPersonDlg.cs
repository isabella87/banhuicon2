using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {
    using BaseData;
    using Rpc;
    public partial class PrjBorPersonDlg : Form {
        private long m_bpmId;

        public IResult DlgResult { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bpmId"></param>
        public PrjBorPersonDlg(long bpmId = 0) {
            InitializeComponent();

            DlgResult = new JsonResult("{}");
            m_bpmId = bpmId;
        }

        private async void UpdateData() {
            var r = await PrjBorPersons.GetById(m_bpmId);
            if (r.IsOk) {
                var d = r.AsDictionary;
                //借款人信息
                tbRealName.Text = d.GetOrDefault<string>("realName");
                tbShowName.Text = d.GetOrDefault<string>("showName");
                tbAge.Text = d.GetOrDefault<string>("age");
                tbShowAge.Text = d.GetOrDefault<string>("showAge");
                tbMobile.Text = d.GetOrDefault<string>("mobile");
                tbEmail.Text = d.GetOrDefault<string>("email");
                cbbGenders.SetSelectedValue(d.GetOrDefault<int>("gender"));
                tbIdCard.Text = d.GetOrDefault<string>("idCard");
                tbProvince.Text = d.GetOrDefault<string>("idCardAddressProv");
                tbCity.Text = d.GetOrDefault<string>("idCardAddressCity");
                tbAddress.Text = d.GetOrDefault<string>("address");
                tbCompany.Text = d.GetOrDefault<string>("company");
                tbPosition.Text = d.GetOrDefault<string>("position");
                tbWorkYear.Text = d.GetOrDefault<string>("workYears");
                tbWechat.Text = d.GetOrDefault<string>("wchat");
                tbFax.Text = d.GetOrDefault<string>("fax");
                tbShowAddress.Text = d.GetOrDefault<string>("showAddress");
                tbIndustry.Text = d.GetOrDefault<string>("industry");
                cbbWorkNature.Text = d.GetOrDefault<string>("workNature");
                tbOtherInfo.Text = d.GetOrDefault<string>("otherInfo");

                //联系人信息
                tbLinkManName.Text = d.GetOrDefault<string>("linkmanName");
                tbShowLinkManName.Text = d.GetOrDefault<string>("linkmanShowName");
                tbLinkManAddress.Text = d.GetOrDefault<string>("linkmanAddress");
                tbShowLinkManAddress.Text = d.GetOrDefault<string>("linkmanShowAddress");
                tbLinkManEmail.Text = d.GetOrDefault<string>("linkmanEmail");
                tbLinkManFax.Text = d.GetOrDefault<string>("linkmanFax");
                tbLinkManIdCard.Text = d.GetOrDefault<string>("linkmanIdCard");
                tbLinkManMobile.Text = d.GetOrDefault<string>("linkmanMobile");
                tbLinkManWeChat.Text = d.GetOrDefault<string>("linkmanWchat");

                //介绍
                tbIntro.Text = d.GetOrDefault<string>("intro");

            } else {
                Commons.ShowResultErrorBox(this, r);
            }
        }

        private async void SaveData() {
            btnOk.Enabled = false;
            try {
                var data = new Dictionary<string, object>();
                data["bpm-id"] = m_bpmId;
                //借款人信息
                data["real-name"] = tbRealName.Text.Trim();
                data["show-name"] = tbShowName.Text.Trim();
                data["mobile"] = tbMobile.Text.Trim();
                data["gender"] = cbbGenders.GetSelectedValue();
                data["age"] = tbAge.Text.Trim();
                data["show-age"] = tbShowAge.Text.Trim();
                data["id-card"] = tbIdCard.Text.Trim();
                data["id-card-address-prov"] = tbProvince.Text.Trim();
                data["id-card-address-city"] = tbCity.Text.Trim();
                data["email"] = tbEmail.Text.Trim();
                data["address"] = tbAddress.Text.Trim();
                data["show-address"] = tbShowAddress.Text.Trim();
                data["company"] = tbCompany.Text.Trim();
                data["position"] = tbPosition.Text.Trim();
                data["work-years"] = tbWorkYear.Text.Trim();
                data["fax"] = tbFax.Text.Trim();
                data["wchat"] = tbWechat.Text.Trim();
                data["industry"] = tbIndustry.Text.Trim();
                data["work-nature"] = cbbWorkNature.Text;
                data["other-info"] = tbOtherInfo.Text;

                //联系人信息
                data["linkman-name"] = tbLinkManName.Text.Trim();
                data["linkman-show-name"] = tbShowLinkManName.Text.Trim();
                data["linkman-mobile"] = tbLinkManMobile.Text.Trim();
                data["linkman-email"] = tbLinkManEmail.Text.Trim();
                data["linkman-wchat"] = tbLinkManWeChat.Text.Trim();
                data["linkman-fax"] = tbLinkManFax.Text.Trim();
                data["linkman-id-card"] = tbLinkManIdCard.Text.Trim();
                data["linkman-address"] = tbLinkManAddress.Text.Trim();
                data["linkman-show-address"] = tbShowLinkManAddress.Text.Trim();

                data["intro"] = tbIntro.Text.Trim();
                IResult r;
                if (m_bpmId == 0) {
                    r = await PrjBorPersons.Create(data);
                } else {
                    r = await PrjBorPersons.Update(data);
                }
                if (r.IsOk) {
                    DlgResult = r;
                    DialogResult = DialogResult.OK;
                } else {
                    Commons.ShowResultErrorBox(this, r);
                }
            } finally {
                btnOk.Enabled = true;
            }
        }

        private void SysUserDlg_Load(object sender, EventArgs e) {
            Commons.BindTo(cbbGenders, Commons.Genders);
            cbbWorkNature.SelectedIndex = 0;

            if (m_bpmId != 0)
                this.Text = "修改借款人-" + m_bpmId;

            UpdateData();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (this.ValidateChildren()) {
                SaveData();
            }
        }

        private async void GetSignInfo() {
            var data = new Dictionary<string, object>();
            data["mgr-id"] = m_bpmId;
            data["mgr-type"] = 1;
            var p = await PrjSignAgreements.GetSignerInfoAgreements(data);
            if (p.IsOk) {
                var info = JObject.Parse(p.AsString);
                var authorizers = JArray.Parse(info["authorizers"].ToStdString());
                var email = authorizers[0]["email"].ToStdString();
                var fullName = authorizers[0]["fullName"].ToStdString();
                var idNumber = authorizers[0]["idNumber"].ToStdString();
                var phoneNum = authorizers[0]["phoneNum"].ToStdString();
                var certType = info["certType"].ToStdString();
                var code = info["code"].ToStdString();
                var companyName = info["fullName"].ToStdString();
                var idNoType = info["idNoType"].ToStdString();
                var userName = info["userName"].ToString();
                Commons.ShowInfoBox(this, string.Format(
                    "公司:{0}\r\n" +
                    "证书类型:{1}\r\n" +
                    "用户名:{2}\r\n" +
                    "唯一识别码:{3}\r\n" +
                    "识别码类型:{4}\r\n" +
                    "委托人信息:\r\n" +
                    "      姓名:{5}\r\n" +
                    "      身份证:{6}\r\n" +
                    "      电话:{7}\r\n" +
                    "      E-Mail:{8}\r\n", companyName, PrjSignAgreements.CertTypes.FindByText(certType), userName, code, PrjSignAgreements.IDTypes.FindByText(idNoType)
                    , fullName, idNumber, phoneNum, email
                    ));

            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }
        private void btnGetSignInfo_Click(object sender, EventArgs e) {
            GetSignInfo();
        }
    }
}
