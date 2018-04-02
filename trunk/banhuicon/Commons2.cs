using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using MyLib.UI;
using Newtonsoft.Json.Linq;

namespace Banhuitong.Console {

    /// <summary>
    /// 
    /// </summary>
    public sealed class TextValues : IList<Tuple<string, string>> {
        private IList<Tuple<string, string>> m_data;

        /// <summary>
        /// TODO: 需要构造一个只读的子类。
        /// </summary>
        public static readonly TextValues Empty = new TextValues();

        /// <summary>
        /// 
        /// </summary>
        public TextValues() {
            m_data = new List<Tuple<string, string>>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="origin"></param>
        public TextValues(IEnumerable<Tuple<string, string>> origin) {
            m_data = origin != null ? origin.ToList() : new List<Tuple<string, string>>();
        }

        #region Implements of IList<Tuple<string, string>>

        public int IndexOf(Tuple<string, string> item) {
            return m_data.IndexOf(item);
        }

        public void Insert(int index, Tuple<string, string> item) {
            m_data.Insert(index, item);
        }

        public void RemoveAt(int index) {
            m_data.RemoveAt(index);
        }

        public Tuple<string, string> this[int index] {
            get {
                return m_data[index];
            }
            set {
                m_data[index] = value;
            }
        }

        public void Add(Tuple<string, string> item) {
            m_data.Add(item);
        }

        public void Clear() {
            m_data.Clear();
        }

        public bool Contains(Tuple<string, string> item) {
            return m_data.Contains(item);
        }

        public void CopyTo(Tuple<string, string>[] array, int arrayIndex) {
            m_data.CopyTo(array, arrayIndex);
        }

        public int Count {
            get { return m_data.Count; }
        }

        public bool IsReadOnly {
            get { return m_data.IsReadOnly; }
        }

        public bool Remove(Tuple<string, string> item) {
            return m_data.Remove(item);
        }

        public IEnumerator<Tuple<string, string>> GetEnumerator() {
            return m_data.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        #endregion

        /// <summary>
        /// 添加新的键值对。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public TextValues AddNew(string text, string value) {
            m_data.Add(Tuple.Create(text.TrimStr(), value.TrimStr()));
            return this;
        }

        /// <summary>
        /// 添加一个TextValues
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public TextValues AddRange(TextValues tv) {
            foreach (var t in tv) {
                m_data.Add(t);
            }
            return this;
        }

        /// <summary>
        /// 添加新的键值对。
        /// </summary>
        /// <param name="text"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public TextValues AddNew(string text, int value) {
            m_data.Add(Tuple.Create(text.TrimStr(), value.ToString()));
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string FindByText(string text) {
            text = text.TrimStr();
            var item = m_data.FirstOrDefault(t => t.Item1 == text);
            return item != null ? item.Item2 : "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FindByValue(string value) {
            value = value.TrimStr();
            var item = m_data.FirstOrDefault(t => t.Item2 == value);
            return item != null ? item.Item1 : "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FindByValue(int value) {
            var s = value.ToString();
            var item = m_data.FirstOrDefault(t => t.Item2 == s);
            return item != null ? item.Item1 : "";
        }
    }

    /// <summary>
    /// 额外选项。
    /// </summary>
    [Flags]
    public enum ExtraItems {
        /// <summary>
        /// 不添加任何额外的项。
        /// </summary>
        NoExtra = 0,

        /// <summary>
        /// 添加“无”选项。
        /// </summary>
        AddNone = 1,

        /// <summary>
        /// 添加“全部”选项。
        /// </summary>
        AddAll = 2,
    }

    public static partial class Commons {
        private static ILog Log {
            get {
                return LogManager.GetLogger(typeof(Commons));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public const string NoneValue = "";

        /// <summary>
        /// 
        /// </summary>
        public const string AllValue = "*";

        public const string YesValue = "yes";

        public const string NoValue = "no";

        public const string MaleValue = "1";

        public const string FemaleValue = "2";

        /// <summary>
        /// 是否
        /// </summary>
        public static readonly TextValues YesOrNo = new TextValues()
            .AddNew(Properties.Resources.Commons_Yes, YesValue)
            .AddNew(Properties.Resources.Commons_No, NoValue);

        /// <summary>
        /// 性别
        /// </summary>
        public static readonly TextValues Genders = new TextValues()
            .AddNew(Properties.Resources.Commons_Unknown, "")
            .AddNew(Properties.Resources.Commons_Male, MaleValue)
            .AddNew(Properties.Resources.Commons_Female, FemaleValue);

        #region ToolStrip

        /// <summary>
        /// 在工具栏的指定位置后加入控件。
        /// </summary>
        /// <param name="toolStrip">工具栏。</param>
        /// <param name="ctrl">被加入的控件。</param>
        /// <param name="archor">指定的位置。</param>
        public static void AddControlAfter(
            this System.Windows.Forms.ToolStrip toolStrip,
            System.Windows.Forms.Control ctrl,
            System.Windows.Forms.ToolStripItem archor) {
            NotNull(toolStrip, "toolStrip");
            NotNull(ctrl, "ctrl");
            var host = new ToolStripControlHost(ctrl);
            if (archor != null) {
                var index = toolStrip.Items.IndexOf(archor);
                toolStrip.Items.Insert(index + 1, host);
            } else {
                toolStrip.Items.Add(host);
            }
        }

        #endregion

        #region Show Dialog

        /// <summary>
        /// 显示消息对话框。
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="text">消息内容。</param>
        public static void ShowInfoBox(IWin32Window owner, string text) {
            text = NotBlank(text, "text").Trim();
            MessageBox.Show(owner, text, Properties.Resources.InfoBox_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示错误对话框。
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="text">错误内容。</param>
        public static void ShowErrorBox(IWin32Window owner, string text) {
            text = NotBlank(text, "text").Trim();
            MessageBox.Show(owner, text, Properties.Resources.ErrorBox_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 显示RPC错误对话框。
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="r">RPC的调用结果。</param>
        public static void ShowResultErrorBox(IWin32Window owner, Rpc.IResult r) {
            if (r != null && !r.IsOk) {
                var dlg = new ErrorDlg();
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Exception = r.Exception;
                dlg.ShowDialog(owner);
            }
        }

        /// <summary>
        /// 显示警告对话框。
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="text">警告内容。</param>
        public static void ShowWarnBox(IWin32Window owner, string text) {
            text = NotBlank(text, "text").Trim();
            MessageBox.Show(owner, text, Properties.Resources.WarnBox_Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 显示输入对话框。
        /// </summary>
        /// <param name="owner">对话框的所有者。</param>
        /// <param name="promopt">提示文本。</param>
        /// <param name="caption">对话框的标题。</param>
        /// <param name="maxWidth">对话框的最大宽度。</param>
        /// <returns></returns>
        public static string ShowInputDialog(IWin32Window owner, string promopt = "", string caption = "",
            int maxWidth = 640, Regex pattern = null, bool isPassword = false, string defaultValue = "") {
            caption = caption.TrimStr();
            if (caption == "") {
                caption = Properties.Resources.InputBox_Caption;
            }

            var inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ClientSize = new System.Drawing.Size(maxWidth, 240);

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.Text = caption;

            var labelMsg = new Label();
            labelMsg.TabIndex = 0;
            labelMsg.AutoSize = true;
            labelMsg.AutoEllipsis = false;
            labelMsg.MaximumSize = new System.Drawing.Size(maxWidth - 12, 240);
            labelMsg.Text = promopt;
            labelMsg.Location = new System.Drawing.Point(6, 6);

            var pSize = new System.Drawing.Size(labelMsg.PreferredWidth, labelMsg.PreferredHeight);
            labelMsg.AutoSize = false;
            labelMsg.AutoEllipsis = true;
            labelMsg.Size = pSize;

            var ctl = new TextBox();
            ctl.TabIndex = 1;
            ctl.Size = new System.Drawing.Size(maxWidth - 12, ctl.Height);
            ctl.Location = new System.Drawing.Point(labelMsg.Left, labelMsg.Bottom + 6);
            ctl.Text = defaultValue;
            if (isPassword) {
                ctl.UseSystemPasswordChar = true;
            }

            var btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.CausesValidation = false;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnCancel.Text = Properties.Resources.StrongConfirmBox_Cancel;
            btnCancel.Location = new System.Drawing.Point(ctl.Right - btnCancel.Width, ctl.Bottom + 6);

            var btnOk = new Button();
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnOk.Text = Properties.Resources.StrongConfirmBox_OK;
            btnOk.Location = new System.Drawing.Point(ctl.Right - btnOk.Width - 6 - btnCancel.Width, ctl.Bottom + 6);

            inputBox.Controls.Add(labelMsg);
            inputBox.Controls.Add(ctl);
            inputBox.Controls.Add(btnOk);
            inputBox.Controls.Add(btnCancel);

            inputBox.AcceptButton = btnOk;
            inputBox.CancelButton = btnCancel;
            inputBox.ClientSize = new System.Drawing.Size(inputBox.ClientSize.Width, btnOk.Bottom + 6);

            ctl.Validating += (sender, e) => {
                if (pattern != null && !pattern.IsMatch(((TextBoxBase)sender).Text.Trim())) {
                    e.Cancel = true;
                }
            };

            return inputBox.ShowDialog(owner) == DialogResult.OK ? ctl.Text.Trim() : "";
        }

        /// <summary>
        /// 显示输入对话框。
        /// </summary>
        /// <param name="owner">对话框的所有者。</param>
        /// <param name="promopt">提示文本。</param>
        /// <param name="caption">对话框的标题。</param>
        /// <param name="maxWidth">对话框的最大宽度。</param>
        /// <returns></returns>
        public static DateTime ShowDateTimeInputDialog(IWin32Window owner, DateTime minDate, string promopt = "", string caption = "",
            int maxWidth = 640) {
            caption = caption.TrimStr();
            if (caption == "") {
                caption = Properties.Resources.InputBox_Caption;
            }

            var inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ClientSize = new System.Drawing.Size(maxWidth, 240);

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.Text = caption;

            var labelMsg = new Label();
            labelMsg.TabIndex = 0;
            labelMsg.AutoSize = true;
            labelMsg.AutoEllipsis = false;
            labelMsg.MaximumSize = new System.Drawing.Size(maxWidth - 12, 240);
            labelMsg.Text = promopt;
            labelMsg.Location = new System.Drawing.Point(6, 6);

            var pSize = new System.Drawing.Size(labelMsg.PreferredWidth, labelMsg.PreferredHeight);
            labelMsg.AutoSize = false;
            labelMsg.AutoEllipsis = true;
            labelMsg.Size = pSize;

            var ctl = new DateTimePicker();
            ctl.MinDate = minDate;
            ctl.TabIndex = 1;
            ctl.Size = new System.Drawing.Size(maxWidth - 12, ctl.Height);
            ctl.Location = new System.Drawing.Point(labelMsg.Left, labelMsg.Bottom + 6);

            var btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnCancel.Text = Properties.Resources.StrongConfirmBox_Cancel;
            btnCancel.Location = new System.Drawing.Point(ctl.Right - btnCancel.Width, ctl.Bottom + 6);

            var btnOk = new Button();
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnOk.Text = Properties.Resources.StrongConfirmBox_OK;
            btnOk.Location = new System.Drawing.Point(ctl.Right - btnOk.Width - 6 - btnCancel.Width, ctl.Bottom + 6);

            inputBox.Controls.Add(labelMsg);
            inputBox.Controls.Add(ctl);
            inputBox.Controls.Add(btnOk);
            inputBox.Controls.Add(btnCancel);

            inputBox.AcceptButton = btnOk;
            inputBox.CancelButton = btnCancel;

            inputBox.ClientSize = new System.Drawing.Size(inputBox.ClientSize.Width, btnOk.Bottom + 6);

            return inputBox.ShowDialog(owner) == DialogResult.OK ? ctl.Value : minDate;
        }

        /// <summary>
        /// 显示输入对话框。
        /// </summary>
        /// <param name="owner">对话框的所有者。</param>
        /// <param name="promopt">提示文本。</param>
        /// <param name="caption">对话框的标题。</param>
        /// <param name="maxWidth">对话框的最大宽度。</param>
        /// <returns></returns>
        public static Decimal ShowDecimalInputDialog(IWin32Window owner, Decimal minValue, string promopt = "",
            string caption = "", int maxWidth = 640) {
            caption = caption.TrimStr();
            if (caption == "") {
                caption = Properties.Resources.InputBox_Caption;
            }

            var inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ClientSize = new System.Drawing.Size(maxWidth, 240);

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.Text = caption;

            var labelMsg = new Label();
            labelMsg.TabIndex = 0;
            labelMsg.AutoSize = true;
            labelMsg.AutoEllipsis = false;
            labelMsg.MaximumSize = new System.Drawing.Size(maxWidth - 12, 240);
            labelMsg.Text = promopt;
            labelMsg.Location = new System.Drawing.Point(6, 6);

            var pSize = new System.Drawing.Size(labelMsg.PreferredWidth, labelMsg.PreferredHeight);
            labelMsg.AutoSize = false;
            labelMsg.AutoEllipsis = true;
            labelMsg.Size = pSize;

            var ctl = new NumericUpDown();
            ctl.DecimalPlaces = 2;
            ctl.Minimum = minValue;
            ctl.Maximum = 99999999999;
            ctl.TabIndex = 1;
            ctl.Size = new System.Drawing.Size(maxWidth - 12, ctl.Height);
            ctl.Location = new System.Drawing.Point(labelMsg.Left, labelMsg.Bottom + 6);

            var btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnCancel.Text = Properties.Resources.StrongConfirmBox_Cancel;
            btnCancel.Location = new System.Drawing.Point(ctl.Right - btnCancel.Width, ctl.Bottom + 6);

            var btnOk = new Button();
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnOk.Text = Properties.Resources.StrongConfirmBox_OK;
            btnOk.Location = new System.Drawing.Point(ctl.Right - btnOk.Width - 6 - btnCancel.Width, ctl.Bottom + 6);

            inputBox.Controls.Add(labelMsg);
            inputBox.Controls.Add(ctl);
            inputBox.Controls.Add(btnOk);
            inputBox.Controls.Add(btnCancel);

            inputBox.AcceptButton = btnOk;
            inputBox.CancelButton = btnCancel;

            inputBox.ClientSize = new System.Drawing.Size(inputBox.ClientSize.Width, btnOk.Bottom + 6);

            return inputBox.ShowDialog(owner) == DialogResult.OK ? ctl.Value : -1;
        }

        /// <summary>
        /// 显示输入对话框。
        /// </summary>
        /// <param name="owner">对话框的所有者。</param>
        /// <param name="promopt">提示文本。</param>
        /// <param name="caption">对话框的标题。</param>
        /// <param name="maxWidth">对话框的最大宽度。</param>
        /// <returns></returns>
        public static string ShowComboboxInputDialog(IWin32Window owner, TextValues tv, string promopt = "",
            string caption = "", string defaultValue = "", int maxWidth = 640) {
            caption = caption.TrimStr();
            if (caption == "") {
                caption = Properties.Resources.InputBox_Caption;
            }

            var inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.ClientSize = new System.Drawing.Size(maxWidth, 240);

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MinimizeBox = false;
            inputBox.MaximizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.Text = caption;

            var labelMsg = new Label();
            labelMsg.TabIndex = 0;
            labelMsg.AutoSize = true;
            labelMsg.AutoEllipsis = false;
            labelMsg.MaximumSize = new System.Drawing.Size(maxWidth - 12, 240);
            labelMsg.Text = promopt;
            labelMsg.Location = new System.Drawing.Point(6, 6);

            var pSize = new System.Drawing.Size(labelMsg.PreferredWidth, labelMsg.PreferredHeight);
            labelMsg.AutoSize = false;
            labelMsg.AutoEllipsis = true;
            labelMsg.Size = pSize;

            var ctl = new ComboBox();
            ctl.TabIndex = 1;
            ctl.Size = new System.Drawing.Size(maxWidth - 12, ctl.Height);
            ctl.Location = new System.Drawing.Point(labelMsg.Left, labelMsg.Bottom + 6);
            ctl.BindTo(tv, ExtraItems.NoExtra);
            if (defaultValue != "") {
                ctl.SetSelectedValue(defaultValue);
            }

            var btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnCancel.Text = Properties.Resources.StrongConfirmBox_Cancel;
            btnCancel.Location = new System.Drawing.Point(ctl.Right - btnCancel.Width, ctl.Bottom + 6);

            var btnOk = new Button();
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(80, btnCancel.Height);
            btnOk.Text = Properties.Resources.StrongConfirmBox_OK;
            btnOk.Location = new System.Drawing.Point(ctl.Right - btnOk.Width - 6 - btnCancel.Width, ctl.Bottom + 6);

            inputBox.Controls.Add(labelMsg);
            inputBox.Controls.Add(ctl);
            inputBox.Controls.Add(btnOk);
            inputBox.Controls.Add(btnCancel);

            inputBox.AcceptButton = btnOk;
            inputBox.CancelButton = btnCancel;

            inputBox.ClientSize = new System.Drawing.Size(inputBox.ClientSize.Width, btnOk.Bottom + 6);

            return inputBox.ShowDialog(owner) == DialogResult.OK ? ctl.GetSelectedValue() : "-1";
        }

        /// <summary>
        /// 显示确认对话框。
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="text">确认的内容。</param>
        /// <param name="strong">二次确认时需要输入的文本，如果为空则表示不需要二次确认。</param>
        /// <returns></returns>
        public static bool ShowConfirmBox(IWin32Window owner, string text, string strong = "") {
            text = NotBlank(text, "text").Trim();
            var dr = MessageBox.Show(text, Properties.Resources.ConfirmBox_Caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var ret = dr == DialogResult.Yes;

            if (ret) {
                // 如果第一级对话框中点击了“是”，那么继续判断。
                strong = strong.TrimStr();
                if (strong != "") {
                    // 如果指定了验证字符串，那么还要求输入验证字符串。
                    var inputs = ShowInputDialog(owner,
                        string.Format(Properties.Resources.StrongConfirmBox_Promopt, strong),
                        Properties.Resources.StrongConfirmBox_Caption, 480).Trim();
                    return inputs == strong;
                } else {
                    // 如果未指定验证字符串那么验证通过。
                    return true;
                }
            } else {
                // 如果第一级对话框中未点击“是”，那么验证不通过。
                return false;
            }
        }

        #endregion

        #region BindTo

        [Flags]
        public enum BindFlag {
            /// <summary>
            /// 绑定的数据替换所有原有的数据。
            /// </summary>
            Replace = 0,

            /// <summary>
            /// 绑定的数据替换原有的数据，未替换的保持不变。
            /// </summary>
            Update = 1,

            /// <summary>
            /// 删除绑定的数据。
            /// </summary>
            Delete = 2
        }

        private static IList<object> ToDataTableRow(IDictionary<string, object> dict, IList<MyGridColumn> columns) {
            NotNull(dict, "dict");
            NotNull(columns, "columns");

            return columns.Select<MyGridColumn, object>(gc => {
                var origin = dict.ContainsKey(gc.DataKey) ? dict[gc.DataKey].TrimStr() : "";
                if (origin.Length == 0) {
                    return null;
                }
                switch (gc.Type) {
                    case MyGridColumnType.Text:
                        return origin;
                    case MyGridColumnType.Number:
                        return Convert.ToInt64(origin);
                    case MyGridColumnType.Money:
                        return Commons.ToDecimal(origin);
                    case MyGridColumnType.IntMoney:
                        return decimal.Floor(Commons.ToDecimal(origin));
                    case MyGridColumnType.Percent:
                        return Convert.ToDouble(origin);
                    case MyGridColumnType.Date:
                    case MyGridColumnType.DateTime: {
                            var dateTime = Commons.FromTimestamp(Convert.ToInt64(origin));
                            if (dateTime.Year >= 3000)
                                return null;
                            else
                                return dateTime;
                        }
                    case MyGridColumnType.Boolean:
                        return Commons.ToBoolean(origin);
                    default:
                        return origin;
                }
            }).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="r"></param>
        /// <param name="flag"></param>
        /// <param name="colName"></param>
        /// <param name="afterBound">成功绑定后需要指定的动作，这些动作会在UI线程中被执行。</param>
        public static void BindTo(this MyGridViewBinding binding, Rpc.IResult r, BindFlag flag = BindFlag.Replace, string colName = "", params Action[] afterBound) {
            NotNull(binding, "binding");
            NotNull(r, "r");

            Action vact = null;
            var columns = binding.Columns.Cast<MyGridColumn>().ToList();
            switch (flag) {
                case BindFlag.Delete:
                    // 此时返回值应当是单独的key。
                    // 根据key值和字段名称从DataTable中删除已被删除的记录。
                    var deletedRowIndex = binding.DataTable.RemoveByKey(colName, r.AsString.Trim('\"'));
                    // 如果被删除的行被选中了，那么取消选中。
                    binding.View.SelectedRows.Cast<DataGridViewRow>().ForEach(row => {
                        if (row.Index == deletedRowIndex) {
                            row.Selected = false;
                        }
                    });
                    // 从视图中同步所有行。
                    // 删除操作可能导致其它行的序号发生变化，所以需要同步所有的行。  
                    vact = () => {
                        binding.View.RowCount = binding.DataTable.Count;
                        binding.View.Invalidate();
                    };
                    break;
                case BindFlag.Update:
                    // 此时返回值应当是一条记录。
                    // 根据字段名称更新到DataTable中。
                    var updatedRowIndex = binding.DataTable.UpdateByKey(colName, ToDataTableRow(r.AsDictionary, columns));
                    vact = () => {
                        binding.View.RowCount = binding.DataTable.Count;
                        binding.View.InvalidateRow(updatedRowIndex);
                        // 更新行可见。
                        binding.View.FirstDisplayedScrollingRowIndex = updatedRowIndex;
                        // 更新行作为当前的选中行。
                        binding.View.ClearSelection();
                        binding.View.Rows[updatedRowIndex].Selected = true;
                    };
                    break;
                case BindFlag.Replace:
                    // 此时返回值应当是一个数组。每个元素都可以解析为一条记录。
                    // 将数据转化为DataTable，并替换当前的DataTable。
                    var dataTable = new MyGridDataTable(binding.Columns, r.AsDictList.Select(_ => ToDataTableRow(_, columns)).ToList());
                    // 从视图同步全部数据。
                    vact = () => {
                        binding.DataTable = dataTable;
                    };
                    break;
                default:
                    throw new ArgumentException("unknown flag: " + flag);
            }

            Action vact2 = () => {
                if (vact != null)
                    vact();
                foreach (var a in afterBound) {
                    a();
                }
            };

            try {
                binding.View.BeginInvoke(vact2);
            } catch (InvalidOperationException) {
                // 忽略获取数据后，但窗口已经关闭的异常
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="data"></param>
        /// <param name="afterBound"></param>
        public static void BindTo(this MyGridViewBinding binding, IList<IDictionary<string, object>> data, BindFlag flag = BindFlag.Replace, string colName = "", params Action[] afterBound) {
            var columns = binding.Columns.Cast<MyGridColumn>().ToList();

            Action vact = null;
            switch (flag) {
                case BindFlag.Update:
                    // 此时返回值应当是一条记录。
                    // 根据字段名称更新到DataTable中。
                    foreach (var r in data) {
                        var updatedRowIndex = binding.DataTable.UpdateByKey(colName, ToDataTableRow(r, columns));
                        vact += () => {
                            binding.View.RowCount = binding.DataTable.Count;
                            binding.View.InvalidateRow(updatedRowIndex);
                            // 更新行可见。
                            binding.View.FirstDisplayedScrollingRowIndex = updatedRowIndex;
                            // 更新行作为当前的选中行。
                            binding.View.ClearSelection();
                            binding.View.Rows[updatedRowIndex].Selected = true;
                        };
                    }
                    break;
                case BindFlag.Replace:
                    // 此时返回值应当是一个数组。每个元素都可以解析为一条记录。
                    // 将数据转化为DataTable，并替换当前的DataTable。
                    var dataTable = new MyGridDataTable(binding.Columns, data.Select(_ => ToDataTableRow(_, columns)).ToList());
                    // 从视图同步全部数据。
                    vact = () => {
                        binding.DataTable = dataTable;
                    };
                    break;
                default:
                    throw new ArgumentException("unknown flag: " + flag);
            }


            // 从视图同步全部数据。
            Action vact2 = () => {
                if (vact != null)
                    vact();
                foreach (var a in afterBound) {
                    a();
                }
            };

            try {
                binding.View.BeginInvoke(vact2);
            } catch (InvalidOperationException) {
                // 忽略获取数据后，但窗口已经关闭的异常
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tv"></param>
        /// <param name="extra"></param>
        public static void BindTo(this ComboBox ctrl, TextValues tv, ExtraItems extra = ExtraItems.NoExtra
            , ComboBoxStyle style = ComboBoxStyle.DropDownList) {
            NotNull(ctrl, "ctrl");
            NotNull(tv, "tv");

            ctrl.Items.Clear();
            ctrl.DisplayMember = "Item1"; // name of Tuple.Item1
            ctrl.ValueMember = "Item2"; // name of Tuple.Item2
            ctrl.DropDownStyle = style;

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemNone, NoneValue));
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemAll, AllValue));
            }

            tv.ForEach(_ => ctrl.Items.Add(_));

            if (ctrl.Items.Count > 0) {
                ctrl.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tv"></param>
        /// <param name="extra"></param>
        public static void BindTo(this ListBox ctrl, TextValues tv, ExtraItems extra = ExtraItems.NoExtra) {
            NotNull(ctrl, "ctrl");
            NotNull(tv, "tv");

            ctrl.Items.Clear();
            ctrl.DisplayMember = "Item1"; // name of Tuple.Item1
            ctrl.ValueMember = "Item2"; // name of Tuple.Item2

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemNone, NoneValue));
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemAll, AllValue));
            }

            tv.ForEach(_ => ctrl.Items.Add(_));
        }

        public static void BindTo(this ListView ctrl, TextValues tv, ExtraItems extra = ExtraItems.NoExtra) {
            NotNull(ctrl, "ctrl");
            NotNull(tv, "tv");

            ctrl.Items.Clear();

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(NoneValue, Properties.Resources.ListControl_ItemNone, 1);
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(AllValue, Properties.Resources.ListControl_ItemAll, 2);
            }

            tv.ForEach(item => {
                ctrl.Items.Add(item.Item2, item.Item1, 9);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tv"></param>
        /// <param name="extra"></param>
        public static async void BindTo(this ComboBox ctrl, Task<TextValues> tv, ExtraItems extra = ExtraItems.NoExtra) {
            NotNull(ctrl, "ctrl");
            if (tv == null) {
                throw new ArgumentNullException("tv");
            }

            ctrl.Items.Clear();
            ctrl.DisplayMember = "Item1"; // name of Tuple.Item1
            ctrl.ValueMember = "Item2"; // name of Tuple.Item2
            ctrl.DropDownStyle = ComboBoxStyle.DropDownList;

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemNone, NoneValue));
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemAll, AllValue));
            }

            (await tv).ForEach(_ => ctrl.Items.Add(_));

            if (ctrl.Items.Count > 0) {
                ctrl.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="tv"></param>
        /// <param name="extra"></param>
        public static async void BindTo(this ListBox ctrl, Task<TextValues> tv, ExtraItems extra = ExtraItems.NoExtra) {
            NotNull(ctrl, "ctrl");
            if (tv == null) {
                throw new ArgumentNullException("tv");
            }

            ctrl.Items.Clear();
            ctrl.DisplayMember = "Item1"; // name of Tuple.Item1
            ctrl.ValueMember = "Item2"; // name of Tuple.Item2

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemNone, NoneValue));
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(Tuple.Create(Properties.Resources.ListControl_ItemAll, AllValue));
            }

            (await tv).ForEach(_ => ctrl.Items.Add(_));

            if (ctrl.Items.Count > 0) {
                ctrl.SelectedIndex = 0;
            }
        }

        public static async void BindTo(this ListView ctrl, Task<TextValues> tv, ExtraItems extra = ExtraItems.NoExtra) {
            NotNull(ctrl, "ctrl");
            if (tv == null) {
                throw new ArgumentNullException("tv");
            }

            ctrl.Items.Clear();

            if ((extra & ExtraItems.AddNone) != 0) {
                ctrl.Items.Add(NoneValue, Properties.Resources.ListControl_ItemNone, 1);
            }
            if ((extra & ExtraItems.AddAll) != 0) {
                ctrl.Items.Add(AllValue, Properties.Resources.ListControl_ItemAll, 2);
            }
            (await tv).ForEach(item => {
                ctrl.Items.Add(item.Item2, item.Item1, 9);
            });
        }

        #endregion

        #region Rpc.IResult

        /// <summary>
        /// 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="textField"></param>
        /// <param name="valueField"></param>
        /// <returns></returns>
        public static async Task<TextValues> ToTextValues(this Task<Rpc.IResult> r, string textField, string valueField) {
            if (r == null) {
                throw new ArgumentNullException("r");
            }
            NotBlank(textField, "textField");
            NotBlank(valueField, "valueField");

            var r_ = await r;
            if (r_.IsOk) {
                return new TextValues(JArray.Parse(r_.AsString)
                    .OfType<JObject>()
                    .Select<JObject, Tuple<string, string>>(jo => {
                        var jpt = jo.Property(textField);
                        var jpv = jo.Property(valueField);
                        if (jpt != null && jpv != null) {
                            return Tuple.Create(jpt.Value.Value<string>(), jpv.Value.Value<string>());
                        } else {
                            return null;
                        }
                    })
                    .Where(_ => _ != null));
            } else {
                return TextValues.Empty;
            }
        }

        #endregion

        #region Set Value

        public static void SetValue(this NumericUpDown ctrl, decimal value) {
            if (value > ctrl.Maximum) {
                ctrl.Value = ctrl.Maximum;
                Commons.ShowErrorBox(ctrl.Parent, string.Format("{0}={1} 值设置超出范围", ctrl.Name, value));
            } else if (value < ctrl.Minimum) {
                ctrl.Value = ctrl.Minimum;
                Commons.ShowErrorBox(ctrl.Parent, string.Format("{0}={1} 值设置超出范围", ctrl.Name, value));
            } else {
                ctrl.Value = value;
            }
        }

        #endregion

        #region Get/Set SelectedValue

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static string GetSelectedValue(this ComboBox ctrl) {
            NotNull(ctrl, "ctrl");

            var item = ctrl.SelectedItem;
            if (item != null) {
                object ret;
                if (!string.IsNullOrWhiteSpace(ctrl.ValueMember)) {
                    ret = item.GetType().GetProperty(ctrl.ValueMember.Trim()).GetValue(item);
                } else {
                    ret = item;
                }
                return ret.TrimStr();
            } else {
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="value"></param>
        public static void SetSelectedValue(this ComboBox ctrl, object value) {
            NotNull(ctrl, "ctrl");

            foreach (var item in ctrl.Items) {
                if (item != null) {
                    object v;
                    if (!string.IsNullOrWhiteSpace(ctrl.ValueMember)) {
                        v = item.GetType().GetProperty(ctrl.ValueMember.Trim()).GetValue(item);
                    } else {
                        v = item;
                    }

                    if (v.TrimStr() == value.TrimStr()) {
                        ctrl.SelectedItem = item;
                        return;
                    }
                }
            }
            ctrl.SelectedIndex = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetCheckedValues(this ListView ctrl) {
            NotNull(ctrl, "ctrl");

            return ctrl.CheckedItems.OfType<ListViewItem>()
                .Select(_ => _.Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="keys"></param>
        public static void SetCheckedValues(this ListView ctrl, IEnumerable<string> keys) {
            NotNull(ctrl, "ctrl");
            NotNull(keys, "keys");

            var keys2 = new HashSet<string>(keys);

            ctrl.Items.Cast<ListViewItem>()
                .ForEach(_ => _.Checked = keys2.Contains(_.Name));
        }

        public static IDictionary<string, object> AddVF(this IDictionary<string, object> d, string key, object value, ref string vf) {
            string temp = "";
            if (value is DateTime) {
                var dt = (DateTime)value;
                temp = Commons.ToTimestamp(dt).ToString();
            } else if (value is Decimal) {
                var dec = (decimal)value;
                temp = dec.ToString("#0.00");
            } else if (value is bool) {
                temp = (bool)value ? "true" : "false";
            } else {
                temp = value.ToString();
            }
            d[key] = temp;
            vf += temp;
            return d;
        }

        public static Dictionary<string, object> AddVF(this Dictionary<string, object> d, string key, object value, ref string vf) {
            string temp = "";
            if (value is DateTime) {
                var dt = (DateTime)value;
                temp = Commons.ToTimestamp(dt).ToString();
            } else if (value is Decimal) {
                var dec = (decimal)value;
                temp = dec.ToString("#0.00");
            } else if (value is bool) {
                temp = (bool)value ? "true" : "false";
            } else {
                temp = value.ToString();
            }
            d[key] = temp;
            vf += temp;
            return d;
        }

        #endregion
    }
}
