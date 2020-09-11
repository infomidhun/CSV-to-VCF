namespace CSV_To_VCF
{
    partial class CMainDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mChkRemDup = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mTxtReplaceTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mTxtReplaceFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTxtPreFix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mTxtNameFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mNumRow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mTxtImport = new System.Windows.Forms.TextBox();
            this.mBtnImport = new System.Windows.Forms.Button();
            this.mLvImportData = new System.Windows.Forms.ListView();
            this.mBtnPreview = new System.Windows.Forms.Button();
            this.mLvPreview = new System.Windows.Forms.ListView();
            this.mBtnExport = new System.Windows.Forms.Button();
            this.mLblPreview = new System.Windows.Forms.Label();
            this.mLblImportData = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumRow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mChkRemDup);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mTxtReplaceTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mTxtReplaceFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mTxtPreFix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mTxtNameFormat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mNumRow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mTxtImport);
            this.groupBox1.Controls.Add(this.mBtnImport);
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mChkRemDup
            // 
            this.mChkRemDup.Checked = true;
            this.mChkRemDup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mChkRemDup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mChkRemDup.Location = new System.Drawing.Point(307, 130);
            this.mChkRemDup.Name = "mChkRemDup";
            this.mChkRemDup.Size = new System.Drawing.Size(66, 17);
            this.mChkRemDup.TabIndex = 19;
            this.mChkRemDup.Text = "Remove";
            this.mChkRemDup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mChkRemDup.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 11);
            this.label8.TabIndex = 18;
            this.label8.Text = "DUPLICATES";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 11);
            this.label7.TabIndex = 16;
            this.label7.Text = "REPLACE TO";
            // 
            // mTxtReplaceTo
            // 
            this.mTxtReplaceTo.Location = new System.Drawing.Point(206, 128);
            this.mTxtReplaceTo.MaxLength = 256;
            this.mTxtReplaceTo.Name = "mTxtReplaceTo";
            this.mTxtReplaceTo.Size = new System.Drawing.Size(88, 22);
            this.mTxtReplaceTo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 11);
            this.label6.TabIndex = 14;
            this.label6.Text = "REGEX REPLACE";
            // 
            // mTxtReplaceFrom
            // 
            this.mTxtReplaceFrom.Location = new System.Drawing.Point(112, 128);
            this.mTxtReplaceFrom.MaxLength = 256;
            this.mTxtReplaceFrom.Name = "mTxtReplaceFrom";
            this.mTxtReplaceFrom.Size = new System.Drawing.Size(88, 22);
            this.mTxtReplaceFrom.TabIndex = 15;
            this.mTxtReplaceFrom.Text = "[ ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 11);
            this.label5.TabIndex = 12;
            this.label5.Text = "PREFIX";
            // 
            // mTxtPreFix
            // 
            this.mTxtPreFix.Location = new System.Drawing.Point(17, 128);
            this.mTxtPreFix.MaxLength = 256;
            this.mTxtPreFix.Name = "mTxtPreFix";
            this.mTxtPreFix.Size = new System.Drawing.Size(88, 22);
            this.mTxtPreFix.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(206, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 11);
            this.label4.TabIndex = 11;
            this.label4.Text = "$C = Counter, $R[1] = 1ST ROW";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mTxtNameFormat
            // 
            this.mTxtNameFormat.Location = new System.Drawing.Point(112, 84);
            this.mTxtNameFormat.MaxLength = 256;
            this.mTxtNameFormat.Name = "mTxtNameFormat";
            this.mTxtNameFormat.Size = new System.Drawing.Size(261, 22);
            this.mTxtNameFormat.TabIndex = 10;
            this.mTxtNameFormat.Text = "$R[2]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 11);
            this.label3.TabIndex = 9;
            this.label3.Text = "NAME FORMAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 11);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUMBERS ROW";
            // 
            // mNumRow
            // 
            this.mNumRow.Location = new System.Drawing.Point(18, 84);
            this.mNumRow.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mNumRow.Name = "mNumRow";
            this.mNumRow.Size = new System.Drawing.Size(87, 22);
            this.mNumRow.TabIndex = 6;
            this.mNumRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "IMPORT FILENAME";
            // 
            // mTxtImport
            // 
            this.mTxtImport.Enabled = false;
            this.mTxtImport.Location = new System.Drawing.Point(18, 38);
            this.mTxtImport.MaxLength = 256;
            this.mTxtImport.Name = "mTxtImport";
            this.mTxtImport.Size = new System.Drawing.Size(263, 22);
            this.mTxtImport.TabIndex = 3;
            // 
            // mBtnImport
            // 
            this.mBtnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mBtnImport.Location = new System.Drawing.Point(287, 37);
            this.mBtnImport.Name = "mBtnImport";
            this.mBtnImport.Size = new System.Drawing.Size(87, 24);
            this.mBtnImport.TabIndex = 2;
            this.mBtnImport.Text = "&Import";
            this.mBtnImport.UseVisualStyleBackColor = true;
            this.mBtnImport.Click += new System.EventHandler(this.mBtnImport_Click);
            // 
            // mLvImportData
            // 
            this.mLvImportData.FullRowSelect = true;
            this.mLvImportData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mLvImportData.Location = new System.Drawing.Point(12, 12);
            this.mLvImportData.Name = "mLvImportData";
            this.mLvImportData.Size = new System.Drawing.Size(391, 226);
            this.mLvImportData.TabIndex = 1;
            this.mLvImportData.UseCompatibleStateImageBehavior = false;
            this.mLvImportData.View = System.Windows.Forms.View.Details;
            // 
            // mBtnPreview
            // 
            this.mBtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mBtnPreview.Location = new System.Drawing.Point(11, 413);
            this.mBtnPreview.Name = "mBtnPreview";
            this.mBtnPreview.Size = new System.Drawing.Size(194, 34);
            this.mBtnPreview.TabIndex = 3;
            this.mBtnPreview.Text = "&Preview";
            this.mBtnPreview.UseVisualStyleBackColor = true;
            this.mBtnPreview.Click += new System.EventHandler(this.mBtnPreview_Click);
            // 
            // mLvPreview
            // 
            this.mLvPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mLvPreview.FullRowSelect = true;
            this.mLvPreview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mLvPreview.Location = new System.Drawing.Point(413, 12);
            this.mLvPreview.Name = "mLvPreview";
            this.mLvPreview.Size = new System.Drawing.Size(391, 434);
            this.mLvPreview.TabIndex = 6;
            this.mLvPreview.UseCompatibleStateImageBehavior = false;
            this.mLvPreview.View = System.Windows.Forms.View.Details;
            // 
            // mBtnExport
            // 
            this.mBtnExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mBtnExport.Location = new System.Drawing.Point(210, 413);
            this.mBtnExport.Name = "mBtnExport";
            this.mBtnExport.Size = new System.Drawing.Size(194, 34);
            this.mBtnExport.TabIndex = 7;
            this.mBtnExport.Text = "&Export preview";
            this.mBtnExport.UseVisualStyleBackColor = true;
            this.mBtnExport.Click += new System.EventHandler(this.mBtnExport_Click);
            // 
            // mLblPreview
            // 
            this.mLblPreview.AutoSize = true;
            this.mLblPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mLblPreview.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLblPreview.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mLblPreview.Location = new System.Drawing.Point(735, 419);
            this.mLblPreview.Name = "mLblPreview";
            this.mLblPreview.Size = new System.Drawing.Size(52, 11);
            this.mLblPreview.TabIndex = 20;
            this.mLblPreview.Text = "PREVIEW";
            // 
            // mLblImportData
            // 
            this.mLblImportData.AutoSize = true;
            this.mLblImportData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mLblImportData.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLblImportData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mLblImportData.Location = new System.Drawing.Point(307, 212);
            this.mLblImportData.Name = "mLblImportData";
            this.mLblImportData.Size = new System.Drawing.Size(81, 11);
            this.mLblImportData.TabIndex = 21;
            this.mLblImportData.Text = "IMPORT DATA";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 208;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number";
            this.columnHeader3.Width = 123;
            // 
            // CMainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 456);
            this.Controls.Add(this.mLblImportData);
            this.Controls.Add(this.mLblPreview);
            this.Controls.Add(this.mBtnExport);
            this.Controls.Add(this.mLvPreview);
            this.Controls.Add(this.mBtnPreview);
            this.Controls.Add(this.mLvImportData);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CMainDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV to VCF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mNumRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView mLvImportData;
        private System.Windows.Forms.Button mBtnImport;
        private System.Windows.Forms.TextBox mTxtImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mNumRow;
        private System.Windows.Forms.TextBox mTxtNameFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mBtnPreview;
        private System.Windows.Forms.ListView mLvPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mTxtPreFix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mTxtReplaceFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mTxtReplaceTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox mChkRemDup;
        private System.Windows.Forms.Button mBtnExport;
        private System.Windows.Forms.Label mLblPreview;
        private System.Windows.Forms.Label mLblImportData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

