namespace APD_Bot
{
    partial class FrmMain
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
            this.btnEngage = new System.Windows.Forms.Button();
            this.btnComms = new System.Windows.Forms.Button();
            this.btnLicenses = new System.Windows.Forms.Button();
            this.btnIllegal = new System.Windows.Forms.Button();
            this.btnSeize = new System.Windows.Forms.Button();
            this.btnTicket1 = new System.Windows.Forms.Button();
            this.btnTicket2 = new System.Windows.Forms.Button();
            this.btnJail = new System.Windows.Forms.Button();
            this.cbLicenses = new System.Windows.Forms.CheckedListBox();
            this.dgvChargesList = new System.Windows.Forms.DataGridView();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblVoices = new System.Windows.Forms.Label();
            this.cbAudio = new System.Windows.Forms.ComboBox();
            this.cbVoices = new System.Windows.Forms.ComboBox();
            this.btnWaitTime = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.tbCustom = new System.Windows.Forms.TextBox();
            this.colCharge1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargesList)).BeginInit();
            this.gbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEngage
            // 
            this.btnEngage.Location = new System.Drawing.Point(346, 31);
            this.btnEngage.Name = "btnEngage";
            this.btnEngage.Size = new System.Drawing.Size(75, 23);
            this.btnEngage.TabIndex = 1;
            this.btnEngage.Text = "Engage";
            this.btnEngage.UseVisualStyleBackColor = true;
            this.btnEngage.Click += new System.EventHandler(this.btnEngage_Click);
            // 
            // btnComms
            // 
            this.btnComms.Location = new System.Drawing.Point(346, 60);
            this.btnComms.Name = "btnComms";
            this.btnComms.Size = new System.Drawing.Size(75, 23);
            this.btnComms.TabIndex = 1;
            this.btnComms.Text = "Comms";
            this.btnComms.UseVisualStyleBackColor = true;
            this.btnComms.Click += new System.EventHandler(this.btnComms_Click);
            // 
            // btnLicenses
            // 
            this.btnLicenses.Location = new System.Drawing.Point(346, 89);
            this.btnLicenses.Name = "btnLicenses";
            this.btnLicenses.Size = new System.Drawing.Size(75, 23);
            this.btnLicenses.TabIndex = 1;
            this.btnLicenses.Text = "Licenses";
            this.btnLicenses.UseVisualStyleBackColor = true;
            this.btnLicenses.Click += new System.EventHandler(this.btnLicenses_Click);
            // 
            // btnIllegal
            // 
            this.btnIllegal.Location = new System.Drawing.Point(346, 118);
            this.btnIllegal.Name = "btnIllegal";
            this.btnIllegal.Size = new System.Drawing.Size(75, 23);
            this.btnIllegal.TabIndex = 1;
            this.btnIllegal.Text = "Illegals";
            this.btnIllegal.UseVisualStyleBackColor = true;
            this.btnIllegal.Click += new System.EventHandler(this.btnIllegal_Click);
            // 
            // btnSeize
            // 
            this.btnSeize.Location = new System.Drawing.Point(346, 147);
            this.btnSeize.Name = "btnSeize";
            this.btnSeize.Size = new System.Drawing.Size(75, 23);
            this.btnSeize.TabIndex = 1;
            this.btnSeize.Text = "Seize";
            this.btnSeize.UseVisualStyleBackColor = true;
            this.btnSeize.Click += new System.EventHandler(this.btnSeize_Click);
            // 
            // btnTicket1
            // 
            this.btnTicket1.Location = new System.Drawing.Point(346, 176);
            this.btnTicket1.Name = "btnTicket1";
            this.btnTicket1.Size = new System.Drawing.Size(75, 23);
            this.btnTicket1.TabIndex = 1;
            this.btnTicket1.Text = "Ticket #1";
            this.btnTicket1.UseVisualStyleBackColor = true;
            this.btnTicket1.Click += new System.EventHandler(this.btnTicket1_Click);
            // 
            // btnTicket2
            // 
            this.btnTicket2.Location = new System.Drawing.Point(346, 234);
            this.btnTicket2.Name = "btnTicket2";
            this.btnTicket2.Size = new System.Drawing.Size(75, 23);
            this.btnTicket2.TabIndex = 1;
            this.btnTicket2.Text = "Ticket #2";
            this.btnTicket2.UseVisualStyleBackColor = true;
            this.btnTicket2.Click += new System.EventHandler(this.btnTicket2_Click);
            // 
            // btnJail
            // 
            this.btnJail.Location = new System.Drawing.Point(346, 263);
            this.btnJail.Name = "btnJail";
            this.btnJail.Size = new System.Drawing.Size(75, 23);
            this.btnJail.TabIndex = 1;
            this.btnJail.Text = "Jail";
            this.btnJail.UseVisualStyleBackColor = true;
            this.btnJail.Click += new System.EventHandler(this.btnJail_Click);
            // 
            // cbLicenses
            // 
            this.cbLicenses.FormattingEnabled = true;
            this.cbLicenses.Location = new System.Drawing.Point(427, 147);
            this.cbLicenses.Name = "cbLicenses";
            this.cbLicenses.Size = new System.Drawing.Size(136, 49);
            this.cbLicenses.TabIndex = 2;
            // 
            // dgvChargesList
            // 
            this.dgvChargesList.AllowUserToAddRows = false;
            this.dgvChargesList.AllowUserToDeleteRows = false;
            this.dgvChargesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChargesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCharge1,
            this.colAmount,
            this.ChargeAmount});
            this.dgvChargesList.Location = new System.Drawing.Point(12, 12);
            this.dgvChargesList.Name = "dgvChargesList";
            this.dgvChargesList.Size = new System.Drawing.Size(330, 426);
            this.dgvChargesList.TabIndex = 3;
            this.dgvChargesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChargesList_CellContentClick);
            this.dgvChargesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChargesList_CellDoubleClick);
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.lblAudio);
            this.gbConfig.Controls.Add(this.lblVoices);
            this.gbConfig.Controls.Add(this.cbAudio);
            this.gbConfig.Controls.Add(this.cbVoices);
            this.gbConfig.Location = new System.Drawing.Point(346, 368);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(231, 70);
            this.gbConfig.TabIndex = 4;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Settings";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Location = new System.Drawing.Point(6, 46);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(67, 13);
            this.lblAudio.TabIndex = 1;
            this.lblAudio.Text = "Select Audio";
            // 
            // lblVoices
            // 
            this.lblVoices.AutoSize = true;
            this.lblVoices.Location = new System.Drawing.Point(6, 19);
            this.lblVoices.Name = "lblVoices";
            this.lblVoices.Size = new System.Drawing.Size(67, 13);
            this.lblVoices.TabIndex = 1;
            this.lblVoices.Text = "Select Voice";
            // 
            // cbAudio
            // 
            this.cbAudio.FormattingEnabled = true;
            this.cbAudio.Location = new System.Drawing.Point(79, 43);
            this.cbAudio.Name = "cbAudio";
            this.cbAudio.Size = new System.Drawing.Size(138, 21);
            this.cbAudio.TabIndex = 0;
            this.cbAudio.SelectedIndexChanged += new System.EventHandler(this.cbAudio_SelectedIndexChanged);
            // 
            // cbVoices
            // 
            this.cbVoices.FormattingEnabled = true;
            this.cbVoices.Location = new System.Drawing.Point(79, 16);
            this.cbVoices.Name = "cbVoices";
            this.cbVoices.Size = new System.Drawing.Size(138, 21);
            this.cbVoices.TabIndex = 0;
            this.cbVoices.SelectedIndexChanged += new System.EventHandler(this.cbVoices_SelectedIndexChanged);
            // 
            // btnWaitTime
            // 
            this.btnWaitTime.Location = new System.Drawing.Point(346, 205);
            this.btnWaitTime.Name = "btnWaitTime";
            this.btnWaitTime.Size = new System.Drawing.Size(75, 23);
            this.btnWaitTime.TabIndex = 1;
            this.btnWaitTime.Text = "Ticket Wait ";
            this.btnWaitTime.UseVisualStyleBackColor = true;
            this.btnWaitTime.Click += new System.EventHandler(this.btnWaitTime_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(434, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suspect Name:";
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(346, 292);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(75, 23);
            this.btnCustom.TabIndex = 1;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // tbCustom
            // 
            this.tbCustom.Location = new System.Drawing.Point(427, 294);
            this.tbCustom.Multiline = true;
            this.tbCustom.Name = "tbCustom";
            this.tbCustom.Size = new System.Drawing.Size(152, 38);
            this.tbCustom.TabIndex = 7;
            // 
            // colCharge1
            // 
            this.colCharge1.HeaderText = "Charge";
            this.colCharge1.Name = "colCharge1";
            this.colCharge1.ReadOnly = true;
            this.colCharge1.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // ChargeAmount
            // 
            this.ChargeAmount.HeaderText = "ChargeAmount";
            this.ChargeAmount.Name = "ChargeAmount";
            this.ChargeAmount.ReadOnly = true;
            this.ChargeAmount.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.tbCustom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.gbConfig);
            this.Controls.Add(this.dgvChargesList);
            this.Controls.Add(this.cbLicenses);
            this.Controls.Add(this.btnWaitTime);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnJail);
            this.Controls.Add(this.btnTicket2);
            this.Controls.Add(this.btnTicket1);
            this.Controls.Add(this.btnSeize);
            this.Controls.Add(this.btnIllegal);
            this.Controls.Add(this.btnLicenses);
            this.Controls.Add(this.btnComms);
            this.Controls.Add(this.btnEngage);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargesList)).EndInit();
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEngage;
        private System.Windows.Forms.Button btnComms;
        private System.Windows.Forms.Button btnLicenses;
        private System.Windows.Forms.Button btnIllegal;
        private System.Windows.Forms.Button btnSeize;
        private System.Windows.Forms.Button btnTicket1;
        private System.Windows.Forms.Button btnTicket2;
        private System.Windows.Forms.Button btnJail;
        private System.Windows.Forms.CheckedListBox cbLicenses;
        private System.Windows.Forms.DataGridView dgvChargesList;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.ComboBox cbVoices;
        private System.Windows.Forms.Button btnWaitTime;
        private System.Windows.Forms.Label lblVoices;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.ComboBox cbAudio;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox tbCustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCharge1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeAmount;
    }
}