namespace SoftwareDev
{
    partial class Broker_Master
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
            this.dg_Broker = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrokerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brokerDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.brokerDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.BrokerDBTableAdapter();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Broker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Broker
            // 
            this.dg_Broker.AllowUserToAddRows = false;
            this.dg_Broker.AllowUserToDeleteRows = false;
            this.dg_Broker.AutoGenerateColumns = false;
            this.dg_Broker.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_Broker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Broker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.nameDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.Country,
            this.State,
            this.Postal_Code,
            this.BrokerID});
            this.dg_Broker.DataSource = this.brokerDBBindingSource;
            this.dg_Broker.Location = new System.Drawing.Point(12, 12);
            this.dg_Broker.Name = "dg_Broker";
            this.dg_Broker.ReadOnly = true;
            this.dg_Broker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Broker.Size = new System.Drawing.Size(445, 344);
            this.dg_Broker.TabIndex = 0;
            this.dg_Broker.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_Broker_RowPostPaint);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "Address_Line_1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            this.addressLine1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Visible = false;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Visible = false;
            // 
            // Postal_Code
            // 
            this.Postal_Code.DataPropertyName = "Postal_Code";
            this.Postal_Code.HeaderText = "Postal_Code";
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.ReadOnly = true;
            this.Postal_Code.Visible = false;
            // 
            // BrokerID
            // 
            this.BrokerID.DataPropertyName = "BrokerID";
            this.BrokerID.HeaderText = "BrokerID";
            this.BrokerID.Name = "BrokerID";
            this.BrokerID.ReadOnly = true;
            this.BrokerID.Visible = false;
            // 
            // brokerDBBindingSource
            // 
            this.brokerDBBindingSource.DataMember = "BrokerDB";
            this.brokerDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brokerDBTableAdapter
            // 
            this.brokerDBTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(463, 333);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(463, 282);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(463, 231);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 4;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(463, 180);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(463, 129);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_Display.TabIndex = 6;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(463, 78);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(463, 27);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNew.TabIndex = 8;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // Broker_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 363);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.dg_Broker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Broker_Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broker Master";
            this.Load += new System.EventHandler(this.Broker_Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Broker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brokerDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Broker;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource brokerDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.BrokerDBTableAdapter brokerDBTableAdapter;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrokerID;
    }
}