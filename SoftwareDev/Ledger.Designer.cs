namespace SoftwareDev
{
    partial class Ledger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clientDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.clientDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter();
            this.dg_ClientLedger = new System.Windows.Forms.DataGridView();
            this.clientDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchbyName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ClientLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(317, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ledger on Screen";
            // 
            // clientDBBindingSource
            // 
            this.clientDBBindingSource.DataMember = "ClientDB";
            this.clientDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientDBTableAdapter
            // 
            this.clientDBTableAdapter.ClearBeforeFill = true;
            // 
            // dg_ClientLedger
            // 
            this.dg_ClientLedger.AllowUserToAddRows = false;
            this.dg_ClientLedger.AllowUserToDeleteRows = false;
            this.dg_ClientLedger.AutoGenerateColumns = false;
            this.dg_ClientLedger.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_ClientLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ClientLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.balanceAmountDataGridViewTextBoxColumn});
            this.dg_ClientLedger.DataSource = this.clientDBBindingSource1;
            this.dg_ClientLedger.Location = new System.Drawing.Point(3, 72);
            this.dg_ClientLedger.Name = "dg_ClientLedger";
            this.dg_ClientLedger.ReadOnly = true;
            this.dg_ClientLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ClientLedger.Size = new System.Drawing.Size(773, 379);
            this.dg_ClientLedger.TabIndex = 1;
            this.dg_ClientLedger.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ClientLedger_CellContentDoubleClick);
            // 
            // clientDBBindingSource1
            // 
            this.clientDBBindingSource1.DataMember = "ClientDB";
            this.clientDBBindingSource1.DataSource = this.client_DatabaseDataSet;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Under Group";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceAmountDataGridViewTextBoxColumn
            // 
            this.balanceAmountDataGridViewTextBoxColumn.DataPropertyName = "balanceAmount";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.balanceAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.balanceAmountDataGridViewTextBoxColumn.HeaderText = "Balance Amount";
            this.balanceAmountDataGridViewTextBoxColumn.Name = "balanceAmountDataGridViewTextBoxColumn";
            this.balanceAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceAmountDataGridViewTextBoxColumn.Width = 430;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search :";
            // 
            // txt_SearchbyName
            // 
            this.txt_SearchbyName.Location = new System.Drawing.Point(60, 46);
            this.txt_SearchbyName.Name = "txt_SearchbyName";
            this.txt_SearchbyName.Size = new System.Drawing.Size(281, 20);
            this.txt_SearchbyName.TabIndex = 3;
            this.txt_SearchbyName.TextChanged += new System.EventHandler(this.txt_SearchbyName_TextChanged);
            // 
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 454);
            this.Controls.Add(this.txt_SearchbyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_ClientLedger);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ledger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.Ledger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ClientLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter clientDBTableAdapter;
        private System.Windows.Forms.DataGridView dg_ClientLedger;
        private System.Windows.Forms.BindingSource clientDBBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SearchbyName;
    }
}