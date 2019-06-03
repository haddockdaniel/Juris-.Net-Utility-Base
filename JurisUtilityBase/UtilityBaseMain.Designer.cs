namespace JurisUtilityBase
{
    partial class UtilityBaseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilityBaseMain));
            this.JurisLogoImageBox = new System.Windows.Forms.PictureBox();
            this.LexisNexisLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelPercentComplete = new System.Windows.Forms.Label();
            this.OpenFileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.buttonReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7500 = new System.Windows.Forms.CheckBox();
            this.checkBox7400 = new System.Windows.Forms.CheckBox();
            this.checkBox7300 = new System.Windows.Forms.CheckBox();
            this.checkBox7200 = new System.Windows.Forms.CheckBox();
            this.checkBox5300 = new System.Windows.Forms.CheckBox();
            this.checkBox5200 = new System.Windows.Forms.CheckBox();
            this.checkBox5100 = new System.Windows.Forms.CheckBox();
            this.checkBox5000 = new System.Windows.Forms.CheckBox();
            this.checkBox4900 = new System.Windows.Forms.CheckBox();
            this.checkBox4700 = new System.Windows.Forms.CheckBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllForUser = new System.Windows.Forms.RadioButton();
            this.labelYr = new System.Windows.Forms.Label();
            this.labelMo = new System.Windows.Forms.Label();
            this.radioButtonPrdOnly = new System.Windows.Forms.RadioButton();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.radioButtonPriorToDate = new System.Windows.Forms.RadioButton();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.JurisLogoImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexisNexisLogoPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // JurisLogoImageBox
            // 
            this.JurisLogoImageBox.Image = ((System.Drawing.Image)(resources.GetObject("JurisLogoImageBox.Image")));
            this.JurisLogoImageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("JurisLogoImageBox.InitialImage")));
            this.JurisLogoImageBox.Location = new System.Drawing.Point(0, 1);
            this.JurisLogoImageBox.Name = "JurisLogoImageBox";
            this.JurisLogoImageBox.Size = new System.Drawing.Size(104, 336);
            this.JurisLogoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.JurisLogoImageBox.TabIndex = 0;
            this.JurisLogoImageBox.TabStop = false;
            // 
            // LexisNexisLogoPictureBox
            // 
            this.LexisNexisLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LexisNexisLogoPictureBox.Image")));
            this.LexisNexisLogoPictureBox.Location = new System.Drawing.Point(8, 343);
            this.LexisNexisLogoPictureBox.Name = "LexisNexisLogoPictureBox";
            this.LexisNexisLogoPictureBox.Size = new System.Drawing.Size(96, 28);
            this.LexisNexisLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LexisNexisLogoPictureBox.TabIndex = 1;
            this.LexisNexisLogoPictureBox.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(710, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel.Text = "Status: Ready to Execute";
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.Location = new System.Drawing.Point(111, 1);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(292, 69);
            this.listBoxCompanies.TabIndex = 0;
            this.listBoxCompanies.SelectedIndexChanged += new System.EventHandler(this.listBoxCompanies_SelectedIndexChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.Location = new System.Drawing.Point(409, 1);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(290, 69);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Removes transaction folder visibility in Juris to clean up the interface. This ut" +
    "ility can also clean the log tables to improve performance.";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.labelCurrentStatus);
            this.statusGroupBox.Controls.Add(this.progressBar);
            this.statusGroupBox.Controls.Add(this.labelPercentComplete);
            this.statusGroupBox.Location = new System.Drawing.Point(111, 77);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(588, 73);
            this.statusGroupBox.TabIndex = 5;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Utility Status:";
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.AutoSize = true;
            this.labelCurrentStatus.Location = new System.Drawing.Point(7, 50);
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Size = new System.Drawing.Size(77, 13);
            this.labelCurrentStatus.TabIndex = 2;
            this.labelCurrentStatus.Text = "Current Status:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(7, 27);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(569, 20);
            this.progressBar.TabIndex = 0;
            // 
            // labelPercentComplete
            // 
            this.labelPercentComplete.AutoSize = true;
            this.labelPercentComplete.Location = new System.Drawing.Point(495, 11);
            this.labelPercentComplete.Name = "labelPercentComplete";
            this.labelPercentComplete.Size = new System.Drawing.Size(62, 13);
            this.labelPercentComplete.TabIndex = 0;
            this.labelPercentComplete.Text = "% Complete";
            // 
            // OpenFileDialogOpen
            // 
            this.OpenFileDialogOpen.FileName = "openFileDialog1";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.LightGray;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonReport.Location = new System.Drawing.Point(166, 396);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(148, 38);
            this.buttonReport.TabIndex = 16;
            this.buttonReport.Text = "Exit";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(502, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7500);
            this.groupBox1.Controls.Add(this.checkBox7400);
            this.groupBox1.Controls.Add(this.checkBox7300);
            this.groupBox1.Controls.Add(this.checkBox7200);
            this.groupBox1.Controls.Add(this.checkBox5300);
            this.groupBox1.Controls.Add(this.checkBox5200);
            this.groupBox1.Controls.Add(this.checkBox5100);
            this.groupBox1.Controls.Add(this.checkBox5000);
            this.groupBox1.Controls.Add(this.checkBox4900);
            this.groupBox1.Controls.Add(this.checkBox4700);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(462, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 221);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Types";
            // 
            // checkBox7500
            // 
            this.checkBox7500.AutoSize = true;
            this.checkBox7500.Location = new System.Drawing.Point(15, 197);
            this.checkBox7500.Name = "checkBox7500";
            this.checkBox7500.Size = new System.Drawing.Size(150, 20);
            this.checkBox7500.TabIndex = 9;
            this.checkBox7500.Text = "Trust Adjustments";
            this.checkBox7500.UseVisualStyleBackColor = true;
            // 
            // checkBox7400
            // 
            this.checkBox7400.AutoSize = true;
            this.checkBox7400.Location = new System.Drawing.Point(15, 177);
            this.checkBox7400.Name = "checkBox7400";
            this.checkBox7400.Size = new System.Drawing.Size(121, 20);
            this.checkBox7400.TabIndex = 8;
            this.checkBox7400.Text = "Quick Checks";
            this.checkBox7400.UseVisualStyleBackColor = true;
            // 
            // checkBox7300
            // 
            this.checkBox7300.AutoSize = true;
            this.checkBox7300.Location = new System.Drawing.Point(15, 158);
            this.checkBox7300.Name = "checkBox7300";
            this.checkBox7300.Size = new System.Drawing.Size(78, 20);
            this.checkBox7300.TabIndex = 7;
            this.checkBox7300.Text = "Checks";
            this.checkBox7300.UseVisualStyleBackColor = true;
            // 
            // checkBox7200
            // 
            this.checkBox7200.AutoSize = true;
            this.checkBox7200.Location = new System.Drawing.Point(15, 139);
            this.checkBox7200.Name = "checkBox7200";
            this.checkBox7200.Size = new System.Drawing.Size(156, 20);
            this.checkBox7200.TabIndex = 6;
            this.checkBox7200.Text = "Payment Vouchers";
            this.checkBox7200.UseVisualStyleBackColor = true;
            // 
            // checkBox5300
            // 
            this.checkBox5300.AutoSize = true;
            this.checkBox5300.Location = new System.Drawing.Point(15, 119);
            this.checkBox5300.Name = "checkBox5300";
            this.checkBox5300.Size = new System.Drawing.Size(128, 20);
            this.checkBox5300.TabIndex = 5;
            this.checkBox5300.Text = "Cash Receipts";
            this.checkBox5300.UseVisualStyleBackColor = true;
            // 
            // checkBox5200
            // 
            this.checkBox5200.AutoSize = true;
            this.checkBox5200.Location = new System.Drawing.Point(15, 99);
            this.checkBox5200.Name = "checkBox5200";
            this.checkBox5200.Size = new System.Drawing.Size(122, 20);
            this.checkBox5200.TabIndex = 4;
            this.checkBox5200.Text = "Credit Memos";
            this.checkBox5200.UseVisualStyleBackColor = true;
            // 
            // checkBox5100
            // 
            this.checkBox5100.AutoSize = true;
            this.checkBox5100.Location = new System.Drawing.Point(15, 79);
            this.checkBox5100.Name = "checkBox5100";
            this.checkBox5100.Size = new System.Drawing.Size(111, 20);
            this.checkBox5100.TabIndex = 3;
            this.checkBox5100.Text = "Manual Bills";
            this.checkBox5100.UseVisualStyleBackColor = true;
            // 
            // checkBox5000
            // 
            this.checkBox5000.AutoSize = true;
            this.checkBox5000.Location = new System.Drawing.Point(15, 60);
            this.checkBox5000.Name = "checkBox5000";
            this.checkBox5000.Size = new System.Drawing.Size(139, 20);
            this.checkBox5000.TabIndex = 2;
            this.checkBox5000.Text = "Expense Entries";
            this.checkBox5000.UseVisualStyleBackColor = true;
            // 
            // checkBox4900
            // 
            this.checkBox4900.AutoSize = true;
            this.checkBox4900.Location = new System.Drawing.Point(15, 41);
            this.checkBox4900.Name = "checkBox4900";
            this.checkBox4900.Size = new System.Drawing.Size(114, 20);
            this.checkBox4900.TabIndex = 1;
            this.checkBox4900.Text = "Time Entries";
            this.checkBox4900.UseVisualStyleBackColor = true;
            // 
            // checkBox4700
            // 
            this.checkBox4700.AutoSize = true;
            this.checkBox4700.Location = new System.Drawing.Point(15, 21);
            this.checkBox4700.Name = "checkBox4700";
            this.checkBox4700.Size = new System.Drawing.Size(130, 20);
            this.checkBox4700.TabIndex = 0;
            this.checkBox4700.Text = "Journal Entries";
            this.checkBox4700.UseVisualStyleBackColor = true;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(120, 175);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(304, 21);
            this.comboBoxUser.TabIndex = 21;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelUser.ForeColor = System.Drawing.Color.Navy;
            this.labelUser.Location = new System.Drawing.Point(117, 156);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(261, 16);
            this.labelUser.TabIndex = 22;
            this.labelUser.Text = "Select the User to purge folders from";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAllForUser);
            this.groupBox2.Controls.Add(this.labelYr);
            this.groupBox2.Controls.Add(this.labelMo);
            this.groupBox2.Controls.Add(this.radioButtonPrdOnly);
            this.groupBox2.Controls.Add(this.comboBoxYear);
            this.groupBox2.Controls.Add(this.radioButtonPriorToDate);
            this.groupBox2.Controls.Add(this.comboBoxMonth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(121, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 136);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purge Folders Option";
            // 
            // radioButtonAllForUser
            // 
            this.radioButtonAllForUser.AutoSize = true;
            this.radioButtonAllForUser.Location = new System.Drawing.Point(15, 23);
            this.radioButtonAllForUser.Name = "radioButtonAllForUser";
            this.radioButtonAllForUser.Size = new System.Drawing.Size(180, 20);
            this.radioButtonAllForUser.TabIndex = 29;
            this.radioButtonAllForUser.TabStop = true;
            this.radioButtonAllForUser.Text = "All folders for this user";
            this.radioButtonAllForUser.UseVisualStyleBackColor = true;
            // 
            // labelYr
            // 
            this.labelYr.AutoSize = true;
            this.labelYr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelYr.ForeColor = System.Drawing.Color.Navy;
            this.labelYr.Location = new System.Drawing.Point(143, 97);
            this.labelYr.Name = "labelYr";
            this.labelYr.Size = new System.Drawing.Size(41, 16);
            this.labelYr.TabIndex = 28;
            this.labelYr.Text = "Year";
            // 
            // labelMo
            // 
            this.labelMo.AutoSize = true;
            this.labelMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelMo.ForeColor = System.Drawing.Color.Navy;
            this.labelMo.Location = new System.Drawing.Point(24, 97);
            this.labelMo.Name = "labelMo";
            this.labelMo.Size = new System.Drawing.Size(49, 16);
            this.labelMo.TabIndex = 27;
            this.labelMo.Text = "Month";
            // 
            // radioButtonPrdOnly
            // 
            this.radioButtonPrdOnly.AutoSize = true;
            this.radioButtonPrdOnly.Location = new System.Drawing.Point(15, 67);
            this.radioButtonPrdOnly.Name = "radioButtonPrdOnly";
            this.radioButtonPrdOnly.Size = new System.Drawing.Size(288, 20);
            this.radioButtonPrdOnly.TabIndex = 1;
            this.radioButtonPrdOnly.TabStop = true;
            this.radioButtonPrdOnly.Text = "This specific Accounting Period ONLY";
            this.radioButtonPrdOnly.UseVisualStyleBackColor = true;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(190, 92);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(88, 24);
            this.comboBoxYear.TabIndex = 26;
            // 
            // radioButtonPriorToDate
            // 
            this.radioButtonPriorToDate.AutoSize = true;
            this.radioButtonPriorToDate.Location = new System.Drawing.Point(15, 45);
            this.radioButtonPriorToDate.Name = "radioButtonPriorToDate";
            this.radioButtonPriorToDate.Size = new System.Drawing.Size(238, 20);
            this.radioButtonPriorToDate.TabIndex = 0;
            this.radioButtonPriorToDate.TabStop = true;
            this.radioButtonPriorToDate.Text = "Prior to  this Accounting Period";
            this.radioButtonPriorToDate.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(79, 92);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(47, 24);
            this.comboBoxMonth.TabIndex = 25;
            // 
            // UtilityBaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listBoxCompanies);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.LexisNexisLogoPictureBox);
            this.Controls.Add(this.JurisLogoImageBox);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UtilityBaseMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPS - Remove Transaction Batch Folders";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JurisLogoImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexisNexisLogoPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JurisLogoImageBox;
        private System.Windows.Forms.PictureBox LexisNexisLogoPictureBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.Label labelCurrentStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelPercentComplete;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogOpen;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7500;
        private System.Windows.Forms.CheckBox checkBox7400;
        private System.Windows.Forms.CheckBox checkBox7300;
        private System.Windows.Forms.CheckBox checkBox7200;
        private System.Windows.Forms.CheckBox checkBox5300;
        private System.Windows.Forms.CheckBox checkBox5200;
        private System.Windows.Forms.CheckBox checkBox5100;
        private System.Windows.Forms.CheckBox checkBox5000;
        private System.Windows.Forms.CheckBox checkBox4900;
        private System.Windows.Forms.CheckBox checkBox4700;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPrdOnly;
        private System.Windows.Forms.RadioButton radioButtonPriorToDate;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label labelMo;
        private System.Windows.Forms.Label labelYr;
        private System.Windows.Forms.RadioButton radioButtonAllForUser;
    }
}

