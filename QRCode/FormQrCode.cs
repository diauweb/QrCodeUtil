using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode {
    public partial class FormQrCode : Form {
        public FormQrCode() {
            InitializeComponent();
        }

        #region LOGIC AREA
        private void label2_Click(object sender, EventArgs e) {
            textBoxContent.Focus();
        }

        private void textBoxContent_Enter(object sender, EventArgs e) {
            label2.Visible = false;
        }

        private void textBoxContent_Leave(object sender, EventArgs e) {
            if (textBoxContent.Text.Trim() == "") {
                textBoxContent.Text = "";
                label2.Visible = true;
            }
        }

        private void textBoxContent_TextChanged(object sender, EventArgs e) {
            buttonGen.Enabled = !(textBoxContent.Text.Trim() == "");
            buttonSaveBitmap.Enabled = !(textBoxContent.Text.Trim() == "");
            buttonSaveSVG.Enabled = !(textBoxContent.Text.Trim() == "");
        }
        #endregion

        #region WORK_AREA
        private void buttonGen_Click(object sender, EventArgs e) {
            QR_DoAction(buttonGen, Work_Preview);
        }
        private void buttonSaveBitmap_Click(object sender, EventArgs e) {
            QR_DoAction(buttonSaveBitmap, Work_SaveBitmap);
        }

        private void buttonSaveSVG_Click(object sender, EventArgs e) {
            QR_DoAction(buttonSaveSVG, Work_SaveSVG);
        }

        #endregion


    }
}
