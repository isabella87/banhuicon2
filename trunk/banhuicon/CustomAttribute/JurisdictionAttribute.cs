using System;

namespace Banhuitong.Console.CustomAttribute {
    class JurisdictionAttribute : Attribute {
        /// <summary>
        /// Tab名
        /// </summary>
        public string TabName { get; private set; }
        /// <summary>
        /// GroupBox名
        /// </summary>
        public string GroupBoxName { get; private set; }
        /// <summary>
        /// CheckBox显示信息
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// 权限标识
        /// </summary>
        public string JurisdictionID { get; private set; }

        public JurisdictionAttribute(string tabName, string groupBoxName, string description, string jurisdictionID) {
            TabName = tabName;
            GroupBoxName = groupBoxName;
            Description = description;
            JurisdictionID = jurisdictionID;
        }
    }
}
