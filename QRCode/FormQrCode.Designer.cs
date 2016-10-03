namespace QRCode {
    partial class FormQrCode {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.barCorrection = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSaveBitmap = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveSVG = new System.Windows.Forms.Button();
            this.saveSVGDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barCorrection)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "二维码内容";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(15, 29);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(260, 60);
            this.textBoxContent.TabIndex = 2;
            this.textBoxContent.TextChanged += new System.EventHandler(this.textBoxContent_TextChanged);
            this.textBoxContent.Enter += new System.EventHandler(this.textBoxContent_Enter);
            this.textBoxContent.Leave += new System.EventHandler(this.textBoxContent_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "建议字符不要超过200";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonGen
            // 
            this.buttonGen.Enabled = false;
            this.buttonGen.Location = new System.Drawing.Point(203, 256);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(69, 23);
            this.buttonGen.TabIndex = 3;
            this.buttonGen.Text = "预览";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // barCorrection
            // 
            this.barCorrection.LargeChange = 1;
            this.barCorrection.Location = new System.Drawing.Point(3, 3);
            this.barCorrection.Maximum = 3;
            this.barCorrection.Name = "barCorrection";
            this.barCorrection.Size = new System.Drawing.Size(104, 45);
            this.barCorrection.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(63, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Q";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(88, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "H";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.barCorrection);
            this.panel1.Location = new System.Drawing.Point(15, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 60);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.trackBarSize);
            this.panel2.Location = new System.Drawing.Point(162, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 60);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(88, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "25";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "1";
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 3;
            this.trackBarSize.Location = new System.Drawing.Point(3, 3);
            this.trackBarSize.Maximum = 25;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(104, 45);
            this.trackBarSize.TabIndex = 0;
            this.trackBarSize.TickFrequency = 5;
            this.trackBarSize.Value = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(287, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "容错率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(163, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "单个点大小";
            // 
            // buttonSaveBitmap
            // 
            this.buttonSaveBitmap.Enabled = false;
            this.buttonSaveBitmap.Location = new System.Drawing.Point(116, 256);
            this.buttonSaveBitmap.Name = "buttonSaveBitmap";
            this.buttonSaveBitmap.Size = new System.Drawing.Size(81, 23);
            this.buttonSaveBitmap.TabIndex = 12;
            this.buttonSaveBitmap.Text = "保存成图片";
            this.buttonSaveBitmap.UseVisualStyleBackColor = true;
            this.buttonSaveBitmap.Click += new System.EventHandler(this.buttonSaveBitmap_Click);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "*.jpg";
            this.saveImageDialog.Filter = "JPEG 图像|*.jpg|BMP 位图|*.bmp|PNG 图像|*.png|所有文件|*.*";
            this.saveImageDialog.Title = "将 QRCode 保存成图片";
            // 
            // buttonSaveSVG
            // 
            this.buttonSaveSVG.Enabled = false;
            this.buttonSaveSVG.Location = new System.Drawing.Point(15, 256);
            this.buttonSaveSVG.Name = "buttonSaveSVG";
            this.buttonSaveSVG.Size = new System.Drawing.Size(97, 23);
            this.buttonSaveSVG.TabIndex = 13;
            this.buttonSaveSVG.Text = "保存成矢量图";
            this.buttonSaveSVG.UseVisualStyleBackColor = true;
            this.buttonSaveSVG.Click += new System.EventHandler(this.buttonSaveSVG_Click);
            // 
            // saveSVGDialog
            // 
            this.saveSVGDialog.Filter = "SVG 矢量文件|*.svg|所有文件|*.*";
            this.saveSVGDialog.Title = "将 QRCode 保存成矢量图";
            // 
            // FormQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 296);
            this.Controls.Add(this.buttonSaveSVG);
            this.Controls.Add(this.buttonSaveBitmap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormQrCode";
            ((System.ComponentModel.ISupportInitialize)(this.barCorrection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TrackBar barCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveBitmap;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Button buttonSaveSVG;
        private System.Windows.Forms.SaveFileDialog saveSVGDialog;
    }
}

