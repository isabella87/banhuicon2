using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace Banhuitong.Console {
    using Crm;
    public partial class CrmSpreadQrcodeDlg : Form {

        public CrmSpreadQrcodeDlg() {
            InitializeComponent();
        }

        private void CrmSpreadQrcodeDlg_Load(object sender, EventArgs e) {
            tbRCode.Text = "班汇通推广";
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Create();
        }

        private async void Create() {
            if (tbRCode.Text.Trim() == "") {
                Commons.ShowInfoBox(this, "必须输入推广代号");
                return;
            }
            btnCreate.Enabled = false;
            var d = new Dictionary<string, object>();
            d["ori-rcode"] = tbRCode.Text.Trim();
            var p = await CrmInvestor.SpreadQRCode(d);
            if (p.IsOk) {
                 tbRAddress.Text = p.AsString.Trim('\"');
                pictureBox1.Image = GetQRCodeBitmap(tbRAddress.Text);
            } else {
                Commons.ShowResultErrorBox(this, p);
            }
            btnCreate.Enabled = true;
        }

        private Bitmap GetQRCodeBitmap(string address) {
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = new QrCode();
            var isSuccess = qrEncoder.TryEncode(address, out qrCode);
            if (!isSuccess) {
                Commons.ShowInfoBox(this, "生成二维码失败");
                return null;
            }
            var render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            var map = new Bitmap(qrCode.Matrix.Width * 5, qrCode.Matrix.Height * 5);
            var g = Graphics.FromImage(map);
            g.FillRectangle(Brushes.White, 0, 0, qrCode.Matrix.Width * 5, qrCode.Matrix.Height * 5);
            render.Draw(g, qrCode.Matrix);

            pictureBox1.Location = new Point(panel1.Width / 2 + panel1.Location.X / 2 - map.Width / 2, panel1.Height / 2 - map.Height / 2);

            if (tbLogo.Text.Trim() != "") {
                Image logo = null;
                try {
                    logo = Image.FromFile(tbLogo.Text.Trim());
                    if (logo.Width > 100 || logo.Height > 100) {
                        throw (new System.OutOfMemoryException());
                    }
                    var logoPoint = new Point((map.Width - logo.Width) / 2, (map.Height - logo.Height) / 2);
                    g.DrawImage(logo, logoPoint.X, logoPoint.Y, logo.Width, logo.Height);
                } catch {
                    Commons.ShowInfoBox(this, "无法使用此Logo");
                }
            }

            return map;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (pictureBox1.Image != null) {
                var sFile = new SaveFileDialog();
                if (sFile.ShowDialog() == DialogResult.OK) {
                    sFile.Filter = "图片|*.jpg;*.png;*.gif;*.bmp;*.jpeg|所有文件(*.*)|*.*";
                    pictureBox1.Image.Save(sFile.FileName);
                }
            } else {
                Commons.ShowInfoBox(this, "无二维码保存");
            }
        }

        private void btnAddLogo_Click(object sender, EventArgs e) {
            var oFile = new OpenFileDialog();
            oFile.Filter = "图片|*.jpg;*.png;*.gif;*.bmp;*.jpeg|所有文件(*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK) {
                tbLogo.Text = oFile.FileName;
            }

        }

    }
}
