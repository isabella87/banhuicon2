using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace Banhuitong.Console {
    using CustomAttribute;
    using Security;
    using CheckBoxProperty = Dictionary<string, string>;
    using GroupBoxProperty = Dictionary<string, Dictionary<string, string>>;

    public partial class SysRoleRightsDlg : Form {
        private IDictionary<string, Dictionary<string, Dictionary<string, string>>> JurisdictionRelationShip;

        private readonly static IList<Type> TypesOfServerClass;
        private readonly static string JurisdictionPath;

        private string m_roleName;
        private string m_title;
        private Hashtable m_allCheckBoxs;

        static SysRoleRightsDlg() {
            JurisdictionPath = System.Windows.Forms.Application.StartupPath + "\\Jurisdiction.xml";
            TypesOfServerClass = new List<Type>{
                typeof(Projs.Projects),
                typeof(Projs.CreditAssignProjs),
                typeof(Projs.Wyjks),
                typeof(Account.DataStatistic),
                typeof(BaseData.PrjEngineers),
                typeof(BaseData.PrjCtors),
                typeof(BaseData.PrjOwners),
                typeof(BaseData.PrjGuaranteePers),
                typeof(BaseData.PrjGuaranteeOrgs),
                typeof(BaseData.PrjBorPersons),
                typeof(BaseData.PrjBorOrgs),
                typeof(BaseData.PrjSignAgreements),
                typeof(BaseData.Files),
                typeof(Account.InvestBase),
                typeof(Account.InvestPersons),
                typeof(Account.InvestOrgs),
                typeof(Account.BusinessTransfers),
                typeof(Account.FreezeMoney),
                typeof(Account.Messages),
                typeof(Crm.CrmInvestor),
                typeof(Crm.CrmPerformance),
                typeof(Security.Users),
                typeof(Security.Roles),
            };
        }

        public SysRoleRightsDlg(string roleName, string title) {
            JurisdictionRelationShip = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            ReadJurisdictionRelationShip();
            new Thread(new ThreadStart(WriteToXml)).Start();

            InitializeComponent();

            m_roleName = roleName;
            m_title = title;
            m_allCheckBoxs = new Hashtable();
        }

        private void JurisdictionDlg_Load(object sender, EventArgs e) {
            this.Text = string.Format(this.Text, m_roleName);
            this.title.Text = m_title;

            GetAllCheckBoxs();
            UpdateTable();
        }

        private void ReadJurisdictionRelationShip() {
            foreach (var c in TypesOfServerClass) {
                foreach (var m in c.GetMethods()) {
                    var find = false;
                    foreach (var a in m.GetCustomAttributes(false)) {
                        if (find) {
                            continue;
                        }
                        if (a is JurisdictionAttribute) {
                            find = true;
                            var p = a as JurisdictionAttribute;
                            if (!JurisdictionRelationShip.Keys.Contains(p.TabName)) {
                                var checkbox = new CheckBoxProperty();
                                checkbox[p.Description] = p.JurisdictionID;
                                var groupbox = new GroupBoxProperty();
                                groupbox[p.GroupBoxName] = checkbox;
                                JurisdictionRelationShip[p.TabName] = groupbox;
                            } else {
                                if (!JurisdictionRelationShip[p.TabName].Keys.Contains(p.GroupBoxName)) {
                                    var checkbox = new CheckBoxProperty();
                                    checkbox[p.Description] = p.JurisdictionID;
                                    JurisdictionRelationShip[p.TabName][p.GroupBoxName] = checkbox;
                                } else {
                                    if (!JurisdictionRelationShip[p.TabName][p.GroupBoxName].Keys.Contains(p.Description)) {
                                        JurisdictionRelationShip[p.TabName][p.GroupBoxName][p.Description] = p.JurisdictionID;
                                    } else {
                                        System.Console.WriteLine(m.Name + "服务ID设置重复!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void WriteToXml() {
            try {
                var root = new XElement("root");
                var doc = new XDocument(root);
                foreach (var s in JurisdictionRelationShip.Keys) {
                    var tabNode = new XElement(s);
                    root.Add(tabNode);
                    foreach (var t in JurisdictionRelationShip[s].Keys) {
                        var groupBoxNode = new XElement(t);
                        tabNode.Add(groupBoxNode);
                        foreach (var p in JurisdictionRelationShip[s][t].Keys) {
                            var jurisdictionNode = new XElement("R" + JurisdictionRelationShip[s][t][p]);
                            jurisdictionNode.Add(new XAttribute("Description", p));
                            groupBoxNode.Add(jurisdictionNode);
                        }
                    }
                }
                doc.Save(JurisdictionPath);
            } catch (Exception e) {
                MessageBox.Show(e.Message, "权限记录有误");
            }
        }

        private void GetAllCheckBoxs() {
            foreach (TabPage tp in tabControl.TabPages) {
                foreach (GroupBox gb in tp.Controls) {
                    foreach (FlowLayoutPanel flp in gb.Controls) {
                        foreach (CheckBox ckb in flp.Controls) {
                            m_allCheckBoxs[ckb.Tag] = ckb;
                        }
                    }
                }
            }
        }

        private async void UpdateTable() {
            btnOk.Enabled = false;
            tabControl.Enabled = false;
            var p = await Roles.Perms(m_roleName);
            if (p.IsOk) {
                var dl = JArray.Parse(p.AsString).ToList();
                foreach (var v in dl) {
                    if (m_allCheckBoxs.Contains(v.ToStdString())) {
                        ((CheckBox)m_allCheckBoxs[v.ToStdString()]).Checked = true;
                    }
                }
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            tabControl.Enabled = true;
            btnOk.Enabled = true;
        }

        private async void SaveData() {
            var perms = new List<string>();
            foreach (DictionaryEntry ckb in m_allCheckBoxs) {
                if (((CheckBox)ckb.Value).Checked) {
                    perms.Add(Convert.ToString(ckb.Key));
                }
            }

            if (perms.Count == 0) {
                Commons.ShowInfoBox(this, "请至少设定一个权限");
                return;
            }

            var d = new Dictionary<string, object>();
            d["role-name"] = m_roleName;
            d["perms"] = string.Join(",", perms);
            var p = await Roles.AssignPerms(d);
            if (p.IsOk) {
                DialogResult = DialogResult.OK;
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SaveData();
        }

    }
}
