using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QRCode
{
    partial class FormQrCode
    {
        public delegate void Work(ref QrCode qrc);

        private void QR_DoAction(Button button, Work w) {
            ErrorCorrectionLevel c = ErrorCorrectionLevel.M;
            switch (barCorrection.Value) {
                case 0: c = ErrorCorrectionLevel.L; break;
                case 1: c = ErrorCorrectionLevel.M; break;
                case 2: c = ErrorCorrectionLevel.Q; break;
                case 3: c = ErrorCorrectionLevel.H; break;
            }

            button.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            QrEncoder enc = new QrEncoder(c);
            GCHandle gc_enc = GCHandle.Alloc(enc);
            QrCode qr = null;
            GCHandle qr_enc = GCHandle.Alloc(qr);

            if (enc.TryEncode(textBoxContent.Text, out qr)) {
                w.Invoke(ref qr);
            } else {
                MessageBox.Show("生成失败。请删除一部分内容。", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            gc_enc.Free();
            qr_enc.Free();

            GC.Collect();

            button.Enabled = true;
            this.Cursor = Cursors.Default;

        }

        private void Work_Preview(ref QrCode qrc) {
            using (MemoryStream stream = new MemoryStream()) {
                WriteableBitmapRenderer gp = new WriteableBitmapRenderer
                (new FixedModuleSize(trackBarSize.Value, QuietZoneModules.Zero));
                GCHandle gc_wbr = GCHandle.Alloc(gp);

                gp.WriteToStream(qrc.Matrix, ImageFormatEnum.BMP, stream);
                pictureBox.Image = new Bitmap(stream);
                gc_wbr.Free();
            }
        }

		private void Work_SaveBitmap(ref QrCode qrc) {

            saveImageDialog.FileName = null;
            saveImageDialog.ShowDialog();
            if (saveImageDialog.FileName == null) return;
            FileInfo f = new FileInfo(saveImageDialog.FileName);

            //if (f.Exists) {
            //    DialogResult result = MessageBox.Show
			//		("文件已存在. 是否要覆盖?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //    if (result == DialogResult.Cancel) return;
            //}

            using (FileStream fs = f.Open(FileMode.Create)) {
                WriteableBitmapRenderer gp = new WriteableBitmapRenderer
                (new FixedModuleSize(trackBarSize.Value, QuietZoneModules.Two));
                GCHandle gc_wbr = GCHandle.Alloc(gp);
                ImageFormatEnum img = ImageFormatEnum.JPEG;
                switch (f.Extension.ToLower()) {
                    case "jpg": img = ImageFormatEnum.JPEG; break;
                    case "bmp": img = ImageFormatEnum.BMP; break;
                    case "png": img = ImageFormatEnum.PNG; break;
                    default: break;
                }

                gp.WriteToStream(qrc.Matrix, img, fs);
                gc_wbr.Free();

                MessageBox.Show("文件保存成功",null,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private class G_Black : GColor {
            public override byte A {
                get { return 255; }
            }

            public override byte B {
                get { return 0; }
            }

            public override byte G {
                get { return 0; }
            }

            public override byte R {
                get { return 0; }
            }
        }

        private class G_White : GColor {
            public override byte A
            {
                get { return 255; }
            }

            public override byte B
            {
                get { return 255; }
            }

            public override byte G
            {
                get { return 255; }
            }

            public override byte R
            {
                get { return 255; }
            }
        }

        private void Work_SaveSVG(ref QrCode qrc) {

            saveSVGDialog.FileName = null;
            saveSVGDialog.ShowDialog();
            if (saveSVGDialog.FileName == null) return;
            FileInfo f = new FileInfo(saveSVGDialog.FileName);

            //if (f.Exists) {
            //    DialogResult result = MessageBox.Show
            //		("文件已存在. 是否要覆盖?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            //    if (result == DialogResult.Cancel) return;
            //}

            using (FileStream fs = f.Open(FileMode.Create)) {
                SVGRenderer gp = new SVGRenderer
                (new FixedModuleSize(trackBarSize.Value, QuietZoneModules.Two),new G_Black(),new G_White());
                GCHandle gc_wbr = GCHandle.Alloc(gp);

                gp.WriteToStream(qrc.Matrix, fs, true);
                gc_wbr.Free();

                MessageBox.Show("文件保存成功", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
