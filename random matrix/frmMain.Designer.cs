﻿namespace random_matrix
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.lblSaveTo = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.lblLog = new System.Windows.Forms.Label();
            this.numCons = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clrPointColor = new System.Windows.Forms.Panel();
            this.clrLineColor = new System.Windows.Forms.Panel();
            this.numPointSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.clrBackcolor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.numRetry = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraw.Location = new System.Drawing.Point(897, 526);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveTo.Location = new System.Drawing.Point(82, 528);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.Size = new System.Drawing.Size(809, 20);
            this.txtSaveTo.TabIndex = 10;
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaveTo.AutoSize = true;
            this.lblSaveTo.Location = new System.Drawing.Point(11, 531);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(64, 13);
            this.lblSaveTo.TabIndex = 2;
            this.lblSaveTo.Text = "save file to :";
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(575, 38);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(397, 446);
            this.lstLog.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "points count :";
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCount.Location = new System.Drawing.Point(82, 10);
            this.numCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(479, 20);
            this.numCount.TabIndex = 0;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLog
            // 
            this.lblLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(575, 17);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 13);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Logs :";
            // 
            // numCons
            // 
            this.numCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCons.Location = new System.Drawing.Point(82, 38);
            this.numCons.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCons.Name = "numCons";
            this.numCons.Size = new System.Drawing.Size(479, 20);
            this.numCons.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "connections :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "points color :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "lines color :";
            // 
            // clrPointColor
            // 
            this.clrPointColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clrPointColor.BackColor = System.Drawing.Color.Black;
            this.clrPointColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrPointColor.Location = new System.Drawing.Point(83, 265);
            this.clrPointColor.Name = "clrPointColor";
            this.clrPointColor.Size = new System.Drawing.Size(479, 20);
            this.clrPointColor.TabIndex = 8;
            this.clrPointColor.Click += new System.EventHandler(this.clrLineColor_Click);
            // 
            // clrLineColor
            // 
            this.clrLineColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clrLineColor.BackColor = System.Drawing.Color.Black;
            this.clrLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrLineColor.Location = new System.Drawing.Point(83, 295);
            this.clrLineColor.Name = "clrLineColor";
            this.clrLineColor.Size = new System.Drawing.Size(479, 20);
            this.clrLineColor.TabIndex = 9;
            this.clrLineColor.Click += new System.EventHandler(this.clrLineColor_Click);
            // 
            // numPointSize
            // 
            this.numPointSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPointSize.Location = new System.Drawing.Point(82, 64);
            this.numPointSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPointSize.Name = "numPointSize";
            this.numPointSize.Size = new System.Drawing.Size(479, 20);
            this.numPointSize.TabIndex = 2;
            this.numPointSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "points size :";
            // 
            // numLineWidth
            // 
            this.numLineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numLineWidth.DecimalPlaces = 1;
            this.numLineWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLineWidth.Location = new System.Drawing.Point(82, 93);
            this.numLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numLineWidth.Name = "numLineWidth";
            this.numLineWidth.Size = new System.Drawing.Size(479, 20);
            this.numLineWidth.TabIndex = 3;
            this.numLineWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "lines width :";
            // 
            // cd
            // 
            this.cd.FullOpen = true;
            // 
            // numHeight
            // 
            this.numHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numHeight.Location = new System.Drawing.Point(82, 155);
            this.numHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(479, 20);
            this.numHeight.TabIndex = 5;
            this.numHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "height :";
            // 
            // numWidth
            // 
            this.numWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numWidth.Location = new System.Drawing.Point(82, 126);
            this.numWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(479, 20);
            this.numWidth.TabIndex = 4;
            this.numWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "width :";
            // 
            // clrBackcolor
            // 
            this.clrBackcolor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clrBackcolor.BackColor = System.Drawing.Color.Black;
            this.clrBackcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrBackcolor.Location = new System.Drawing.Point(83, 234);
            this.clrBackcolor.Name = "clrBackcolor";
            this.clrBackcolor.Size = new System.Drawing.Size(479, 20);
            this.clrBackcolor.TabIndex = 7;
            this.clrBackcolor.Click += new System.EventHandler(this.clrLineColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "back color :";
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.Location = new System.Drawing.Point(575, 497);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(397, 23);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "clear logs";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // numRetry
            // 
            this.numRetry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRetry.Location = new System.Drawing.Point(82, 181);
            this.numRetry.Name = "numRetry";
            this.numRetry.Size = new System.Drawing.Size(479, 20);
            this.numRetry.TabIndex = 6;
            this.numRetry.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "retry count :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.numRetry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.clrBackcolor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numLineWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPointSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clrLineColor);
            this.Controls.Add(this.clrPointColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblSaveTo);
            this.Controls.Add(this.txtSaveTo);
            this.Controls.Add(this.btnDraw);
            this.MinimumSize = new System.Drawing.Size(789, 358);
            this.Name = "frmMain";
            this.Text = "randomly matrix builder";
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPointSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.Label lblSaveTo;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.NumericUpDown numCons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel clrPointColor;
        private System.Windows.Forms.Panel clrLineColor;
        private System.Windows.Forms.NumericUpDown numPointSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLineWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel clrBackcolor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.NumericUpDown numRetry;
        private System.Windows.Forms.Label label10;
    }
}

