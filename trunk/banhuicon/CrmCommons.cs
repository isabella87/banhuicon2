using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Banhuitong.Console {
    public static class CrmCommons {

        /// <summary>
        /// 跟进名单来源
        /// </summary>
        public static readonly object[] SrTypes;

        /// <summary>
        /// 跟进名单进度
        /// </summary>
        public static readonly TextValues CustomerFollowStatus;

        /// <summary>
        /// 用户等级
        /// </summary>
        public static readonly TextValues PrLevels;

        /// <summary>
        /// 银行帐户状态
        /// </summary>
        public static readonly TextValues JxUserStatus;

        /// <summary>
        /// 年龄段
        /// </summary>
        public static readonly TextValues Ages;

        /// <summary>
        /// 所属部门
        /// </summary>
        public static readonly object[] Department;

        /// <summary>
        /// 用户类别
        /// </summary>
        public static readonly TextValues CustomerTypes;

        /// <summary>
        /// 职务
        /// </summary>
        public static readonly object[] Positions;

        public static readonly string NONE_TEXT = "--无--";
        public static readonly string ALL_TEXT = "--全部--";
        public static readonly string SELF_TEXT = "--我自己--";

        public static readonly string NONE_VALUE = "";
        public static readonly string ALL_VALUE = "*";
        public static readonly string SELF_VALUE = "+";

        public enum ExtraItem { NoExtra = 0, AddNone = 1, AddAll = 2, AddSelf = 4 }

        static CrmCommons() {
            CustomerFollowStatus = new TextValues()
                .AddNew("已发送第1次短信", 101)
                .AddNew("已发送第2次短信", 102)
                .AddNew("已发送第3次短信", 103)
                .AddNew("已发送第4次短信", 104)
                .AddNew("客户已回复短信", 120)
                .AddNew("已第1次添加微信", 201)
                .AddNew("已第2次添加微信", 202)
                .AddNew("已第3次添加微信", 203)
                .AddNew("客户已添加微信", 220)
                .AddNew("已微信宣传", 301)
                .AddNew("第1次电话未接通", 401)
                .AddNew("第2次电话未接通", 402)
                .AddNew("第3次电话未接通", 403)
                .AddNew("已电话沟通", 520)
                .AddNew("持续跟进", 620)
                .AddNew("无意向", 640)
                .AddNew("无法联系", 640);

            SrTypes = new object[]{
                "鲁班弹窗",
                "鲁班金融组织会议",
                "鲁班BIM会议",
                "中施协",
                "新中大",
                "鲁班用户",
                "市场活动",
                "转介绍",
                "自荐",
            };

            PrLevels = new TextValues()
                .AddNew("未指定", 1)
                .AddNew("A", 2)
                .AddNew("B", 4)
                .AddNew("C", 8)
                .AddNew("D", 16)
                .AddNew("E", 32);

            JxUserStatus = new TextValues()
                //.AddNew("未注册", 0)
                .AddNew("未开户", 2)
                .AddNew("未绑卡", 3)
                .AddNew("已绑卡", 4)
                .AddNew("已投资", 5);

            Ages = new TextValues()
            .AddNew("20到24岁", 1)
            .AddNew("25到29岁", 2)
            .AddNew("30到39岁", 3)
            .AddNew("40到49岁", 4)
            .AddNew("50到59岁", 5)
            .AddNew("60岁以上", 6);

            Department = new object[] { 
            "销售一部",
            "销售二部",
            "销售三部",
            "销售四部",
            "销售五部"};

            CustomerTypes = new TextValues()
            .AddNew("个人", 1)
            .AddNew("机构", 2);

            Positions = new object[] { 
            "高级副总裁",
            "副总裁",
            "代副总裁",
            "总监一级",
            "总监二级",
            "总监三级",
            "代总监",
            "客代",
            "经理一级",
            "经理二级",
            "经理三级",
            "代经理",
            "高级客代",
            "客户代表",
            "实习客代"
            };
        }

        public static string TextFromValue(string value) {
            if (value == NONE_VALUE)
                return NONE_TEXT;
            else if (value == ALL_VALUE)
                return ALL_TEXT;
            else if (value == SELF_VALUE)
                return SELF_TEXT;
            else
                return value;
        }
        public static string TextBoxShow(string value) {
            var pattern = new Regex("-+");
            return string.Format("({0})", pattern.Replace(value, ""));
        }

        public static bool IsNone(string uName) {
            return uName == NONE_VALUE;
        }

        public static bool IsAll(string uName) {
            return uName == ALL_VALUE;
        }

        public static bool IsSelf(string uName) {
            return uName == SELF_VALUE;
        }

        public static void GetTreeView(TreeView newTree, List<Tuple<string, string>> treeList, string rootName, int extraItems = 0) {
            var pnames = new Queue<string>();

            if ((extraItems & (int)ExtraItem.AddSelf) != 0) {
                var tn = new TreeNode();
                tn.Text = SELF_TEXT;
                tn.Name = SELF_TEXT;
                tn.Tag = SELF_VALUE;
                newTree.Nodes.Add(tn);
            }

            if ((extraItems & (int)ExtraItem.AddNone) != 0) {
                var tn = new TreeNode();
                tn.Text = NONE_TEXT;
                tn.Name = NONE_TEXT;
                tn.Tag = NONE_VALUE;
                newTree.Nodes.Add(tn);
            }

            if ((extraItems & (int)ExtraItem.AddAll) != 0) {
                var tn = new TreeNode();
                tn.Text = ALL_TEXT;
                tn.Name = ALL_TEXT;
                tn.Tag = ALL_VALUE;
                newTree.Nodes.Add(tn);
            }

            treeList.RemoveAll((t) => {
                bool b;
                if (string.IsNullOrWhiteSpace(rootName)) {
                    b = string.IsNullOrWhiteSpace(t.Item2);
                } else {
                    b = t.Item1 == rootName;
                }
                if (b) {
                    var tn = new TreeNode();
                    tn.Text = t.Item1;
                    tn.Name = t.Item1;
                    tn.Tag = t.Item1;
                    newTree.Nodes.Add(tn);
                    pnames.Enqueue(t.Item1);
                    return true;
                } else
                    return false;
            });

            while (pnames.Count != 0) {
                var pname = pnames.Dequeue();
                var f0 = newTree.Nodes.Find(pname, true);
                if (f0.Length != 0) {
                    treeList.RemoveAll((t) => {
                        if (t.Item2 == f0[0].Text) {
                            var tn = new TreeNode();
                            tn.Text = t.Item1;
                            tn.Name = t.Item1;
                            tn.Tag = t.Item1;
                            f0[0].Nodes.Add(tn);
                            pnames.Enqueue(t.Item1);
                            return true;
                        } else {
                            return false;
                        }
                    });
                }
            }

            if (treeList.Count != 0) {
                System.Console.WriteLine("remaining item:");
                foreach (var t in treeList) {
                    System.Console.WriteLine(t.Item1 + "->" + t.Item2);
                }
            }

        }



    }



}
