namespace SoftwareDev
{
    partial class Journals
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
            this.components = new System.ComponentModel.Container();
            this.dt_JVDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_JVDate = new System.Windows.Forms.Label();
            this.lbl_JournalNo = new System.Windows.Forms.Label();
            this.lbl_JournalAutoNo = new System.Windows.Forms.Label();
            this.rt_Notes = new System.Windows.Forms.RichTextBox();
            this.lbl_Notes = new System.Windows.Forms.Label();
            this.tb_JournalEntry = new System.Windows.Forms.TabControl();
            this.tb_JournalDetails = new System.Windows.Forms.TabPage();
            this.dg_JVDetails = new System.Windows.Forms.DataGridView();
            this.accountDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.clientDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_SubmitJV = new System.Windows.Forms.Button();
            this.accountDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter();
            this.clientDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter();
            this.AccountTypes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DescriptionJV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientJV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DebitJV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditJV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartOfAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsDataSet = new SoftwareDev.AccountsDataSet();
            this.chartOfAccountsTableAdapter = new SoftwareDev.AccountsDataSetTableAdapters.ChartOfAccountsTableAdapter();
            this.tb_JournalEntry.SuspendLayout();
            this.tb_JournalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_JVDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_JVDate
            // 
            this.dt_JVDate.Location = new System.Drawing.Point(86, 8);
            this.dt_JVDate.Name = "dt_JVDate";
            this.dt_JVDate.Size = new System.Drawing.Size(115, 20);
            this.dt_JVDate.TabIndex = 0;
            // 
            // lbl_JVDate
            // 
            this.lbl_JVDate.AutoSize = true;
            this.lbl_JVDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JVDate.Location = new System.Drawing.Point(37, 12);
            this.lbl_JVDate.Name = "lbl_JVDate";
            this.lbl_JVDate.Size = new System.Drawing.Size(43, 16);
            this.lbl_JVDate.TabIndex = 1;
            this.lbl_JVDate.Text = "Date :";
            // 
            // lbl_JournalNo
            // 
            this.lbl_JournalNo.AutoSize = true;
            this.lbl_JournalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JournalNo.Location = new System.Drawing.Point(15, 45);
            this.lbl_JournalNo.Name = "lbl_JournalNo";
            this.lbl_JournalNo.Size = new System.Drawing.Size(65, 16);
            this.lbl_JournalNo.TabIndex = 2;
            this.lbl_JournalNo.Text = "Journal# :";
            // 
            // lbl_JournalAutoNo
            // 
            this.lbl_JournalAutoNo.AutoSize = true;
            this.lbl_JournalAutoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JournalAutoNo.ForeColor = System.Drawing.Color.Red;
            this.lbl_JournalAutoNo.Location = new System.Drawing.Point(86, 45);
            this.lbl_JournalAutoNo.Name = "lbl_JournalAutoNo";
            this.lbl_JournalAutoNo.Size = new System.Drawing.Size(0, 16);
            this.lbl_JournalAutoNo.TabIndex = 2;
            // 
            // rt_Notes
            // 
            this.rt_Notes.Location = new System.Drawing.Point(86, 80);
            this.rt_Notes.Name = "rt_Notes";
            this.rt_Notes.Size = new System.Drawing.Size(115, 47);
            this.rt_Notes.TabIndex = 3;
            this.rt_Notes.Text = "";
            // 
            // lbl_Notes
            // 
            this.lbl_Notes.AutoSize = true;
            this.lbl_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notes.Location = new System.Drawing.Point(30, 81);
            this.lbl_Notes.Name = "lbl_Notes";
            this.lbl_Notes.Size = new System.Drawing.Size(50, 16);
            this.lbl_Notes.TabIndex = 2;
            this.lbl_Notes.Text = "Notes :";
            // 
            // tb_JournalEntry
            // 
            this.tb_JournalEntry.Controls.Add(this.tb_JournalDetails);
            this.tb_JournalEntry.Location = new System.Drawing.Point(18, 133);
            this.tb_JournalEntry.Name = "tb_JournalEntry";
            this.tb_JournalEntry.SelectedIndex = 0;
            this.tb_JournalEntry.Size = new System.Drawing.Size(551, 176);
            this.tb_JournalEntry.TabIndex = 4;
            // 
            // tb_JournalDetails
            // 
            this.tb_JournalDetails.Controls.Add(this.dg_JVDetails);
            this.tb_JournalDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_JournalDetails.Name = "tb_JournalDetails";
            this.tb_JournalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_JournalDetails.Size = new System.Drawing.Size(543, 150);
            this.tb_JournalDetails.TabIndex = 1;
            this.tb_JournalDetails.Text = "Journal Details";
            this.tb_JournalDetails.UseVisualStyleBackColor = true;
            // 
            // dg_JVDetails
            // 
            this.dg_JVDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_JVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_JVDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountTypes,
            this.DescriptionJV,
            this.ClientJV,
            this.DebitJV,
            this.CreditJV});
            this.dg_JVDetails.Location = new System.Drawing.Point(0, 0);
            this.dg_JVDetails.Name = "dg_JVDetails";
            this.dg_JVDetails.Size = new System.Drawing.Size(543, 150);
            this.dg_JVDetails.TabIndex = 0;
            // 
            // accountDBBindingSource
            // 
            this.accountDBBindingSource.DataMember = "AccountDB";
            this.accountDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientDBBindingSource
            // 
            this.clientDBBindingSource.DataMember = "ClientDB";
            this.clientDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // btn_SubmitJV
            // 
            this.btn_SubmitJV.Location = new System.Drawing.Point(459, 332);
            this.btn_SubmitJV.Name = "btn_SubmitJV";
            this.btn_SubmitJV.Size = new System.Drawing.Size(75, 40);
            this.btn_SubmitJV.TabIndex = 1;
            this.btn_SubmitJV.Text = "Submit";
            this.btn_SubmitJV.UseVisualStyleBackColor = true;
            this.btn_SubmitJV.Click += new System.EventHandler(this.btn_SubmitJV_Click);
            // 
            // accountDBTableAdapter
            // 
            this.accountDBTableAdapter.ClearBeforeFill = true;
            // 
            // clientDBTableAdapter
            // 
            this.clientDBTableAdapter.ClearBeforeFill = true;
            // 
            // AccountTypes
            // 
            this.AccountTypes.DataSource = this.chartOfAccountsBindingSource;
            this.AccountTypes.DisplayMember = "Account";
            this.AccountTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AccountTypes.HeaderText = "Account";
            this.AccountTypes.Name = "AccountTypes";
            this.AccountTypes.ValueMember = "Account";
            // 
            // DescriptionJV
            // 
            this.DescriptionJV.HeaderText = "Description";
            this.DescriptionJV.Name = "DescriptionJV";
            // 
            // ClientJV
            // 
            this.ClientJV.DataSource = this.clientDBBindingSource;
            this.ClientJV.DisplayMember = "Name";
            this.ClientJV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientJV.HeaderText = "Client";
            this.ClientJV.Name = "ClientJV";
            this.ClientJV.ValueMember = "Name";
            // 
            // DebitJV
            // 
            this.DebitJV.HeaderText = "Debits";
            this.DebitJV.Name = "DebitJV";
            // 
            // CreditJV
            // 
            this.CreditJV.HeaderText = "Credits";
            this.CreditJV.Name = "CreditJV";
            // 
            // chartOfAccountsBindingSource
            // 
            this.chartOfAccountsBindingSource.DataMember = "ChartOfAccounts";
            this.chartOfAccountsBindingSource.DataSource = this.accountsDataSet;
            // 
            // accountsDataSet
            // 
            this.accountsDataSet.DataSetName = "AccountsDataSet";
            this.accountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartOfAccountsTableAdapter
            // 
            this.chartOfAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // Journals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btn_SubmitJV);
            this.Controls.Add(this.tb_JournalEntry);
            this.Controls.Add(this.rt_Notes);
            this.Controls.Add(this.lbl_JournalAutoNo);
            this.Controls.Add(this.lbl_Notes);
            this.Controls.Add(this.lbl_JournalNo);
            this.Controls.Add(this.lbl_JVDate);
            this.Controls.Add(this.dt_JVDate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Journals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Journals_Load);
            this.tb_JournalEntry.ResumeLayout(false);
            this.tb_JournalDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_JVDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOfAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_JVDate;
        private System.Windows.Forms.Label lbl_JVDate;
        private System.Windows.Forms.Label lbl_JournalNo;
        private System.Windows.Forms.Label lbl_JournalAutoNo;
        private System.Windows.Forms.RichTextBox rt_Notes;
        private System.Windows.Forms.Label lbl_Notes;
        private System.Windows.Forms.TabControl tb_JournalEntry;
        private System.Windows.Forms.TabPage tb_JournalDetails;
        private System.Windows.Forms.DataGridView dg_JVDetails;
        private System.Windows.Forms.Button btn_SubmitJV;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource accountDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter accountDBTableAdapter;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter clientDBTableAdapter;
        private AccountsDataSet accountsDataSet;
        private System.Windows.Forms.BindingSource chartOfAccountsBindingSource;
        private AccountsDataSetTableAdapters.ChartOfAccountsTableAdapter chartOfAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn AccountTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionJV;
        private System.Windows.Forms.DataGridViewComboBoxColumn ClientJV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitJV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditJV;
    }
}