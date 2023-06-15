namespace Konwerter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathNameLabel = new System.Windows.Forms.Label();
            this.PathNameOutputLabel = new System.Windows.Forms.Label();
            this.InputPath = new System.Windows.Forms.TextBox();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.Type7z = new System.Windows.Forms.RadioButton();
            this.TypeZIP = new System.Windows.Forms.RadioButton();
            this.CompressButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CompressionLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.CompFastest = new System.Windows.Forms.RadioButton();
            this.CompNormal = new System.Windows.Forms.RadioButton();
            this.CompUltra = new System.Windows.Forms.RadioButton();
            this.CompMethodZIP = new System.Windows.Forms.GroupBox();
            this.CompMethodPPMd = new System.Windows.Forms.RadioButton();
            this.CompMethodLZMA = new System.Windows.Forms.RadioButton();
            this.CompMethodBZip2 = new System.Windows.Forms.RadioButton();
            this.CompMethodDeflate64 = new System.Windows.Forms.RadioButton();
            this.CompMethodDeflate = new System.Windows.Forms.RadioButton();
            this.CompMethod7z = new System.Windows.Forms.GroupBox();
            this.CompMethod7zBZip2 = new System.Windows.Forms.RadioButton();
            this.CompMethod7zPPMd = new System.Windows.Forms.RadioButton();
            this.CompMethod7zLZMA2 = new System.Windows.Forms.RadioButton();
            this.CompMethod7zLZMA = new System.Windows.Forms.RadioButton();
            this.TypeGroupBox.SuspendLayout();
            this.CompressionLevelGroupBox.SuspendLayout();
            this.CompMethodZIP.SuspendLayout();
            this.CompMethod7z.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathNameLabel
            // 
            this.PathNameLabel.AutoSize = true;
            this.PathNameLabel.Location = new System.Drawing.Point(31, 30);
            this.PathNameLabel.Name = "PathNameLabel";
            this.PathNameLabel.Size = new System.Drawing.Size(277, 20);
            this.PathNameLabel.TabIndex = 0;
            this.PathNameLabel.Text = "Ścieżka pliku/foleru do zkompresowania";
            // 
            // PathNameOutputLabel
            // 
            this.PathNameOutputLabel.AutoSize = true;
            this.PathNameOutputLabel.Location = new System.Drawing.Point(358, 30);
            this.PathNameOutputLabel.Name = "PathNameOutputLabel";
            this.PathNameOutputLabel.Size = new System.Drawing.Size(213, 20);
            this.PathNameOutputLabel.TabIndex = 1;
            this.PathNameOutputLabel.Text = "Ścieżka archiwum wynikowego";
            // 
            // InputPath
            // 
            this.InputPath.Location = new System.Drawing.Point(31, 53);
            this.InputPath.Name = "InputPath";
            this.InputPath.Size = new System.Drawing.Size(248, 27);
            this.InputPath.TabIndex = 2;
            this.InputPath.Text = "C:\\Users";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(358, 53);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(226, 27);
            this.OutputPath.TabIndex = 3;
            this.OutputPath.Text = "C:\\Users";
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.Type7z);
            this.TypeGroupBox.Controls.Add(this.TypeZIP);
            this.TypeGroupBox.Location = new System.Drawing.Point(31, 108);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Size = new System.Drawing.Size(83, 127);
            this.TypeGroupBox.TabIndex = 4;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Forma";
            // 
            // Type7z
            // 
            this.Type7z.AutoSize = true;
            this.Type7z.Location = new System.Drawing.Point(3, 59);
            this.Type7z.Name = "Type7z";
            this.Type7z.Size = new System.Drawing.Size(45, 24);
            this.Type7z.TabIndex = 1;
            this.Type7z.Text = "7z";
            this.Type7z.UseVisualStyleBackColor = true;
            this.Type7z.CheckedChanged += new System.EventHandler(this.Type7z_CheckedChanged);
            // 
            // TypeZIP
            // 
            this.TypeZIP.AutoSize = true;
            this.TypeZIP.Checked = true;
            this.TypeZIP.Location = new System.Drawing.Point(3, 29);
            this.TypeZIP.Name = "TypeZIP";
            this.TypeZIP.Size = new System.Drawing.Size(51, 24);
            this.TypeZIP.TabIndex = 0;
            this.TypeZIP.TabStop = true;
            this.TypeZIP.Text = "ZIP";
            this.TypeZIP.UseVisualStyleBackColor = true;
            this.TypeZIP.CheckedChanged += new System.EventHandler(this.TypeZIP_CheckedChanged);
            // 
            // CompressButton
            // 
            this.CompressButton.Location = new System.Drawing.Point(31, 241);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(248, 109);
            this.CompressButton.TabIndex = 5;
            this.CompressButton.Text = "Kompresuj";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // CompressionLevelGroupBox
            // 
            this.CompressionLevelGroupBox.Controls.Add(this.CompFastest);
            this.CompressionLevelGroupBox.Controls.Add(this.CompNormal);
            this.CompressionLevelGroupBox.Controls.Add(this.CompUltra);
            this.CompressionLevelGroupBox.Location = new System.Drawing.Point(128, 106);
            this.CompressionLevelGroupBox.Name = "CompressionLevelGroupBox";
            this.CompressionLevelGroupBox.Size = new System.Drawing.Size(151, 129);
            this.CompressionLevelGroupBox.TabIndex = 6;
            this.CompressionLevelGroupBox.TabStop = false;
            this.CompressionLevelGroupBox.Text = "Stopień kompresji";
            // 
            // CompFastest
            // 
            this.CompFastest.AutoSize = true;
            this.CompFastest.Location = new System.Drawing.Point(3, 29);
            this.CompFastest.Name = "CompFastest";
            this.CompFastest.Size = new System.Drawing.Size(103, 24);
            this.CompFastest.TabIndex = 2;
            this.CompFastest.TabStop = true;
            this.CompFastest.Text = "Najszybsza";
            this.CompFastest.UseVisualStyleBackColor = true;
            // 
            // CompNormal
            // 
            this.CompNormal.AutoSize = true;
            this.CompNormal.Location = new System.Drawing.Point(3, 59);
            this.CompNormal.Name = "CompNormal";
            this.CompNormal.Size = new System.Drawing.Size(96, 24);
            this.CompNormal.TabIndex = 1;
            this.CompNormal.Text = "Normalna";
            this.CompNormal.UseVisualStyleBackColor = true;
            // 
            // CompUltra
            // 
            this.CompUltra.AutoSize = true;
            this.CompUltra.Checked = true;
            this.CompUltra.Location = new System.Drawing.Point(3, 89);
            this.CompUltra.Name = "CompUltra";
            this.CompUltra.Size = new System.Drawing.Size(62, 24);
            this.CompUltra.TabIndex = 0;
            this.CompUltra.TabStop = true;
            this.CompUltra.Text = "Ultra";
            this.CompUltra.UseVisualStyleBackColor = true;
            // 
            // CompMethodZIP
            // 
            this.CompMethodZIP.Controls.Add(this.CompMethodPPMd);
            this.CompMethodZIP.Controls.Add(this.CompMethodLZMA);
            this.CompMethodZIP.Controls.Add(this.CompMethodBZip2);
            this.CompMethodZIP.Controls.Add(this.CompMethodDeflate64);
            this.CompMethodZIP.Controls.Add(this.CompMethodDeflate);
            this.CompMethodZIP.Location = new System.Drawing.Point(301, 108);
            this.CompMethodZIP.Name = "CompMethodZIP";
            this.CompMethodZIP.Size = new System.Drawing.Size(182, 176);
            this.CompMethodZIP.TabIndex = 7;
            this.CompMethodZIP.TabStop = false;
            this.CompMethodZIP.Text = "Metoda kompresji ZIP";
            // 
            // CompMethodPPMd
            // 
            this.CompMethodPPMd.AutoSize = true;
            this.CompMethodPPMd.Location = new System.Drawing.Point(6, 147);
            this.CompMethodPPMd.Name = "CompMethodPPMd";
            this.CompMethodPPMd.Size = new System.Drawing.Size(68, 24);
            this.CompMethodPPMd.TabIndex = 4;
            this.CompMethodPPMd.TabStop = true;
            this.CompMethodPPMd.Text = "PPMd";
            this.CompMethodPPMd.UseVisualStyleBackColor = true;
            // 
            // CompMethodLZMA
            // 
            this.CompMethodLZMA.AutoSize = true;
            this.CompMethodLZMA.Location = new System.Drawing.Point(6, 117);
            this.CompMethodLZMA.Name = "CompMethodLZMA";
            this.CompMethodLZMA.Size = new System.Drawing.Size(69, 24);
            this.CompMethodLZMA.TabIndex = 3;
            this.CompMethodLZMA.Text = "LZMA";
            this.CompMethodLZMA.UseVisualStyleBackColor = true;
            // 
            // CompMethodBZip2
            // 
            this.CompMethodBZip2.AutoSize = true;
            this.CompMethodBZip2.Location = new System.Drawing.Point(6, 87);
            this.CompMethodBZip2.Name = "CompMethodBZip2";
            this.CompMethodBZip2.Size = new System.Drawing.Size(69, 24);
            this.CompMethodBZip2.TabIndex = 2;
            this.CompMethodBZip2.Text = "BZip2";
            this.CompMethodBZip2.UseVisualStyleBackColor = true;
            // 
            // CompMethodDeflate64
            // 
            this.CompMethodDeflate64.AutoSize = true;
            this.CompMethodDeflate64.Location = new System.Drawing.Point(6, 57);
            this.CompMethodDeflate64.Name = "CompMethodDeflate64";
            this.CompMethodDeflate64.Size = new System.Drawing.Size(95, 24);
            this.CompMethodDeflate64.TabIndex = 1;
            this.CompMethodDeflate64.Text = "Deflate64";
            this.CompMethodDeflate64.UseVisualStyleBackColor = true;
            // 
            // CompMethodDeflate
            // 
            this.CompMethodDeflate.AutoSize = true;
            this.CompMethodDeflate.Checked = true;
            this.CompMethodDeflate.Location = new System.Drawing.Point(6, 29);
            this.CompMethodDeflate.Name = "CompMethodDeflate";
            this.CompMethodDeflate.Size = new System.Drawing.Size(79, 24);
            this.CompMethodDeflate.TabIndex = 0;
            this.CompMethodDeflate.TabStop = true;
            this.CompMethodDeflate.Text = "Deflate";
            this.CompMethodDeflate.UseVisualStyleBackColor = true;
            // 
            // CompMethod7z
            // 
            this.CompMethod7z.Controls.Add(this.CompMethod7zBZip2);
            this.CompMethod7z.Controls.Add(this.CompMethod7zPPMd);
            this.CompMethod7z.Controls.Add(this.CompMethod7zLZMA2);
            this.CompMethod7z.Controls.Add(this.CompMethod7zLZMA);
            this.CompMethod7z.Enabled = false;
            this.CompMethod7z.Location = new System.Drawing.Point(505, 108);
            this.CompMethod7z.Name = "CompMethod7z";
            this.CompMethod7z.Size = new System.Drawing.Size(172, 176);
            this.CompMethod7z.TabIndex = 8;
            this.CompMethod7z.TabStop = false;
            this.CompMethod7z.Text = "Metoda kompresji 7z";
            // 
            // CompMethod7zBZip2
            // 
            this.CompMethod7zBZip2.AutoSize = true;
            this.CompMethod7zBZip2.Location = new System.Drawing.Point(6, 116);
            this.CompMethod7zBZip2.Name = "CompMethod7zBZip2";
            this.CompMethod7zBZip2.Size = new System.Drawing.Size(69, 24);
            this.CompMethod7zBZip2.TabIndex = 3;
            this.CompMethod7zBZip2.Text = "BZip2";
            this.CompMethod7zBZip2.UseVisualStyleBackColor = true;
            // 
            // CompMethod7zPPMd
            // 
            this.CompMethod7zPPMd.AutoSize = true;
            this.CompMethod7zPPMd.Location = new System.Drawing.Point(6, 86);
            this.CompMethod7zPPMd.Name = "CompMethod7zPPMd";
            this.CompMethod7zPPMd.Size = new System.Drawing.Size(68, 24);
            this.CompMethod7zPPMd.TabIndex = 2;
            this.CompMethod7zPPMd.Text = "PPMd";
            this.CompMethod7zPPMd.UseVisualStyleBackColor = true;
            // 
            // CompMethod7zLZMA2
            // 
            this.CompMethod7zLZMA2.AutoSize = true;
            this.CompMethod7zLZMA2.Location = new System.Drawing.Point(6, 56);
            this.CompMethod7zLZMA2.Name = "CompMethod7zLZMA2";
            this.CompMethod7zLZMA2.Size = new System.Drawing.Size(77, 24);
            this.CompMethod7zLZMA2.TabIndex = 1;
            this.CompMethod7zLZMA2.Text = "LZMA2";
            this.CompMethod7zLZMA2.UseVisualStyleBackColor = true;
            // 
            // CompMethod7zLZMA
            // 
            this.CompMethod7zLZMA.AutoSize = true;
            this.CompMethod7zLZMA.Checked = true;
            this.CompMethod7zLZMA.Location = new System.Drawing.Point(6, 26);
            this.CompMethod7zLZMA.Name = "CompMethod7zLZMA";
            this.CompMethod7zLZMA.Size = new System.Drawing.Size(69, 24);
            this.CompMethod7zLZMA.TabIndex = 0;
            this.CompMethod7zLZMA.TabStop = true;
            this.CompMethod7zLZMA.Text = "LZMA";
            this.CompMethod7zLZMA.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.CompMethod7z);
            this.Controls.Add(this.CompMethodZIP);
            this.Controls.Add(this.CompressionLevelGroupBox);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.TypeGroupBox);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.InputPath);
            this.Controls.Add(this.PathNameOutputLabel);
            this.Controls.Add(this.PathNameLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kompresor";
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            this.CompressionLevelGroupBox.ResumeLayout(false);
            this.CompressionLevelGroupBox.PerformLayout();
            this.CompMethodZIP.ResumeLayout(false);
            this.CompMethodZIP.PerformLayout();
            this.CompMethod7z.ResumeLayout(false);
            this.CompMethod7z.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PathNameLabel;
        private Label PathNameOutputLabel;
        private TextBox InputPath;
        private TextBox OutputPath;
        private GroupBox TypeGroupBox;
        private RadioButton Type7z;
        private RadioButton TypeZIP;
        private Button CompressButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox CompressionLevelGroupBox;
        private RadioButton CompNormal;
        private RadioButton CompUltra;
        private RadioButton CompFastest;
        private GroupBox CompMethodZIP;
        private RadioButton CompMethodLZMA;
        private RadioButton CompMethodBZip2;
        private RadioButton CompMethodDeflate64;
        private RadioButton CompMethodDeflate;
        private GroupBox CompMethod7z;
        private RadioButton CompMethodPPMd;
        private RadioButton CompMethod7zBZip2;
        private RadioButton CompMethod7zPPMd;
        private RadioButton CompMethod7zLZMA2;
        private RadioButton CompMethod7zLZMA;
    }
}