namespace SoftwareDev
{
    partial class MainWindow
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.BrokerMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.QualityMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseOrderToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseInvoiceToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleOrderToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saleOrderRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleInvoiceToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assortmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyProfileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.warehouseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.accountingToolStripMenuItem,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(669, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientMaster,
            this.BrokerMaster,
            this.AccountMaster,
            this.ColorMaster,
            this.SizeMaster,
            this.QualityMaster});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Masters";
            // 
            // ClientMaster
            // 
            this.ClientMaster.Name = "ClientMaster";
            this.ClientMaster.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.ClientMaster.Size = new System.Drawing.Size(232, 22);
            this.ClientMaster.Text = "Client Master";
            this.ClientMaster.Click += new System.EventHandler(this.ClientMaster_Click);
            // 
            // BrokerMaster
            // 
            this.BrokerMaster.Name = "BrokerMaster";
            this.BrokerMaster.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.BrokerMaster.Size = new System.Drawing.Size(232, 22);
            this.BrokerMaster.Text = "Broker Master";
            this.BrokerMaster.Click += new System.EventHandler(this.BrokerMaster_Click);
            // 
            // AccountMaster
            // 
            this.AccountMaster.Name = "AccountMaster";
            this.AccountMaster.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.AccountMaster.Size = new System.Drawing.Size(232, 22);
            this.AccountMaster.Text = "Account Master";
            this.AccountMaster.Click += new System.EventHandler(this.accountMasterToolStripMenuItem_Click);
            // 
            // ColorMaster
            // 
            this.ColorMaster.Name = "ColorMaster";
            this.ColorMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ColorMaster.Size = new System.Drawing.Size(232, 22);
            this.ColorMaster.Text = "Color Master";
            this.ColorMaster.Click += new System.EventHandler(this.colorMasterToolStripMenuItem_Click);
            // 
            // SizeMaster
            // 
            this.SizeMaster.Name = "SizeMaster";
            this.SizeMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SizeMaster.Size = new System.Drawing.Size(232, 22);
            this.SizeMaster.Text = "Size Master";
            this.SizeMaster.Click += new System.EventHandler(this.sizeMasterToolStripMenuItem_Click);
            // 
            // QualityMaster
            // 
            this.QualityMaster.Name = "QualityMaster";
            this.QualityMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.QualityMaster.Size = new System.Drawing.Size(232, 22);
            this.QualityMaster.Text = "Quality Master";
            this.QualityMaster.Click += new System.EventHandler(this.qualityMasterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PurchaseOrderToolStrip,
            this.purchaseOrderRegisterToolStripMenuItem,
            this.PurchaseInvoiceToolStrip,
            this.purchaseRegisterToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem2.Text = "Purchase";
            // 
            // PurchaseOrderToolStrip
            // 
            this.PurchaseOrderToolStrip.Name = "PurchaseOrderToolStrip";
            this.PurchaseOrderToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.PurchaseOrderToolStrip.Size = new System.Drawing.Size(270, 22);
            this.PurchaseOrderToolStrip.Text = "Purchase Order";
            this.PurchaseOrderToolStrip.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // purchaseOrderRegisterToolStripMenuItem
            // 
            this.purchaseOrderRegisterToolStripMenuItem.Name = "purchaseOrderRegisterToolStripMenuItem";
            this.purchaseOrderRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.purchaseOrderRegisterToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.purchaseOrderRegisterToolStripMenuItem.Text = "Purchase Order Register";
            // 
            // PurchaseInvoiceToolStrip
            // 
            this.PurchaseInvoiceToolStrip.Name = "PurchaseInvoiceToolStrip";
            this.PurchaseInvoiceToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PurchaseInvoiceToolStrip.Size = new System.Drawing.Size(270, 22);
            this.PurchaseInvoiceToolStrip.Text = "Purchase Invoice";
            this.PurchaseInvoiceToolStrip.Click += new System.EventHandler(this.purchaseInvoiceToolStripMenuItem_Click);
            // 
            // purchaseRegisterToolStripMenuItem
            // 
            this.purchaseRegisterToolStripMenuItem.Name = "purchaseRegisterToolStripMenuItem";
            this.purchaseRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.purchaseRegisterToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.purchaseRegisterToolStripMenuItem.Text = "Purchase Register";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaleOrderToolStrip,
            this.saleOrderRegisterToolStripMenuItem,
            this.SaleInvoiceToolStrip,
            this.salesRegisterToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem3.Text = "Sales";
            // 
            // SaleOrderToolStrip
            // 
            this.SaleOrderToolStrip.Name = "SaleOrderToolStrip";
            this.SaleOrderToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaleOrderToolStrip.Size = new System.Drawing.Size(244, 22);
            this.SaleOrderToolStrip.Text = "Sale Order";
            this.SaleOrderToolStrip.Click += new System.EventHandler(this.saleOrderToolStripMenuItem_Click);
            // 
            // saleOrderRegisterToolStripMenuItem
            // 
            this.saleOrderRegisterToolStripMenuItem.Name = "saleOrderRegisterToolStripMenuItem";
            this.saleOrderRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saleOrderRegisterToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.saleOrderRegisterToolStripMenuItem.Text = "Sale Order Register";
            // 
            // SaleInvoiceToolStrip
            // 
            this.SaleInvoiceToolStrip.Name = "SaleInvoiceToolStrip";
            this.SaleInvoiceToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaleInvoiceToolStrip.Size = new System.Drawing.Size(244, 22);
            this.SaleInvoiceToolStrip.Text = "Sale Invoice";
            this.SaleInvoiceToolStrip.Click += new System.EventHandler(this.saleInvoiceToolStripMenuItem_Click);
            // 
            // salesRegisterToolStripMenuItem
            // 
            this.salesRegisterToolStripMenuItem.Name = "salesRegisterToolStripMenuItem";
            this.salesRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salesRegisterToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.salesRegisterToolStripMenuItem.Text = "Sales Register";
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assortmentToolStripMenuItem,
            this.WarehouseToolStrip});
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            // 
            // assortmentToolStripMenuItem
            // 
            this.assortmentToolStripMenuItem.Name = "assortmentToolStripMenuItem";
            this.assortmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.assortmentToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.assortmentToolStripMenuItem.Text = "Assortment";
            this.assortmentToolStripMenuItem.Click += new System.EventHandler(this.assortmentToolStripMenuItem_Click);
            // 
            // WarehouseToolStrip
            // 
            this.WarehouseToolStrip.Name = "WarehouseToolStrip";
            this.WarehouseToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.WarehouseToolStrip.Size = new System.Drawing.Size(217, 22);
            this.WarehouseToolStrip.Text = "Warehouse Report";
            this.WarehouseToolStrip.Click += new System.EventHandler(this.warehouseReportToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem5.Text = "Logout";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // accountingToolStripMenuItem
            // 
            this.accountingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalToolStripMenuItem,
            this.ledgerToolStrip,
            this.outstandingsToolStripMenuItem});
            this.accountingToolStripMenuItem.Name = "accountingToolStripMenuItem";
            this.accountingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.accountingToolStripMenuItem.Text = "Accounting";
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.journalToolStripMenuItem.Text = "Journal";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.manualJournalToolStripMenuItem_Click);
            // 
            // ledgerToolStrip
            // 
            this.ledgerToolStrip.Name = "ledgerToolStrip";
            this.ledgerToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.ledgerToolStrip.Size = new System.Drawing.Size(187, 22);
            this.ledgerToolStrip.Text = "Ledger";
            this.ledgerToolStrip.Click += new System.EventHandler(this.ledgerToolStripMenuItem_Click);
            // 
            // outstandingsToolStripMenuItem
            // 
            this.outstandingsToolStripMenuItem.Name = "outstandingsToolStripMenuItem";
            this.outstandingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.outstandingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.outstandingsToolStripMenuItem.Text = "Outstandings";
            this.outstandingsToolStripMenuItem.Click += new System.EventHandler(this.outstandingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyProfileToolStrip});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem4.Text = "Settings";
            // 
            // companyProfileToolStrip
            // 
            this.companyProfileToolStrip.Name = "companyProfileToolStrip";
            this.companyProfileToolStrip.Size = new System.Drawing.Size(180, 22);
            this.companyProfileToolStrip.Text = "Company Profile";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem6});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(669, 24);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCompanyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCompanyToolStripMenuItem
            // 
            this.openCompanyToolStripMenuItem.Name = "openCompanyToolStripMenuItem";
            this.openCompanyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openCompanyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.openCompanyToolStripMenuItem.Text = "Open Company";
            this.openCompanyToolStripMenuItem.Click += new System.EventHandler(this.openCompanyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem6.Text = "Log Out";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(669, 261);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brokerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbClientDB;
        private System.Windows.Forms.DataGridView dg_ClientDB;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource clientDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ClientDBTableAdapter clientDBTableAdapter;
        private System.Windows.Forms.Button btn_CloseClientDB;
        private System.Windows.Forms.Button btn_ExportClientData;
        private System.Windows.Forms.Button btn_ImportClientData;
        private System.Windows.Forms.Button btn_DeleteClientData;
        private System.Windows.Forms.Button btn_DisplayClientData;
        private System.Windows.Forms.Button btn_EditCLientData;
        private System.Windows.Forms.Button btn_AddClientData;
        private System.Windows.Forms.Button btn_DisplayOK;
        private System.Windows.Forms.Button btn_ClientEdittoDB;
        private System.Windows.Forms.Button btn_AddDatatoDB;
        private System.Windows.Forms.Label lbl_ClientID;
        private System.Windows.Forms.Label lbl_ClientAC;
        private System.Windows.Forms.Label lbl_ClientCountry;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.Label lbl_ClientSC;
        private System.Windows.Forms.ComboBox cbo_ClientAccount;
        private System.Windows.Forms.TextBox txt_ClientCountry;
        private System.Windows.Forms.TextBox txt_ClientMS;
        private System.Windows.Forms.TextBox txt_ClientSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCode;
        private System.Windows.Forms.GroupBox gb_BrokerDB;
        private System.Windows.Forms.DataGridView dg_BrokerDB;
        private System.Windows.Forms.BindingSource brokerDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.BrokerDBTableAdapter brokerDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn brokerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_BrokerPostalCode;
        private System.Windows.Forms.Label lbl_BrokerState;
        private System.Windows.Forms.Label lbl_BrokerCountry;
        private System.Windows.Forms.Label lbl_BrokerAddress;
        private System.Windows.Forms.Label lbl_ContactBroker;
        private System.Windows.Forms.Label lbl_BrokerID;
        private System.Windows.Forms.Label lbl_BrokerName;
        private System.Windows.Forms.Button btn_DeleteBroker;
        private System.Windows.Forms.Button btn_AddNewBroker;
        private System.Windows.Forms.Button btn_EditBroker;
        private System.Windows.Forms.Button btn_DisplayBroker;
        private System.Windows.Forms.Button btn_ImportBroker;
        private System.Windows.Forms.Button btn_ExportBroker;
        private System.Windows.Forms.Button btn_BrokerClose;
        private System.Windows.Forms.TextBox txt_BrokerPostalCode;
        private System.Windows.Forms.TextBox txt_BrokerState;
        private System.Windows.Forms.TextBox txt_BrokerContact;
        private System.Windows.Forms.TextBox txt_BrokerName;
        private System.Windows.Forms.ComboBox cbo_BrokerCountry;
        private System.Windows.Forms.RichTextBox rt_BrokerAddress;
        private System.Windows.Forms.Button btn_DisplayBrokerDataFromDB;
        private System.Windows.Forms.Button btn_EditBrokerDatatoDB;
        private System.Windows.Forms.Button btn_AddBrokerDatatoDB;
        private System.Windows.Forms.BindingSource productColorDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter productColorDBTableAdapter;
        private System.Windows.Forms.BindingSource productSizeDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter productSizeDBTableAdapter;
        private System.Windows.Forms.BindingSource productQualityDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter productQualityDBTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem accountMasterToolStripMenuItem;
        private System.Windows.Forms.BindingSource accountDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter accountDBTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignUserRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualJournalToolStripMenuItem;
        private System.Windows.Forms.BindingSource WarehouseBindingSource;
        private WarehouseDataSet WarehouseDataSet;
        private System.Windows.Forms.BindingSource InvoiceProductDBBindingSource;
        private PurchaseInvoiceDBDataSet PurchaseInvoiceDBDataSet;
        private WarehouseDataSetTableAdapters.WarehouseTableAdapter WarehouseTableAdapter;
        private PurchaseInvoiceDBDataSetTableAdapters.InvoiceProductDBTableAdapter InvoiceProductDBTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem warehouseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companyProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesMoMReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem accountingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem outstandingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ClientMaster;
        private System.Windows.Forms.ToolStripMenuItem BrokerMaster;
        private System.Windows.Forms.ToolStripMenuItem AccountMaster;
        private System.Windows.Forms.ToolStripMenuItem ColorMaster;
        private System.Windows.Forms.ToolStripMenuItem SizeMaster;
        private System.Windows.Forms.ToolStripMenuItem QualityMaster;
        private System.Windows.Forms.ToolStripMenuItem PurchaseOrderToolStrip;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseInvoiceToolStrip;
        private System.Windows.Forms.ToolStripMenuItem purchaseRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleOrderToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saleOrderRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleInvoiceToolStrip;
        private System.Windows.Forms.ToolStripMenuItem salesRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehouseToolStrip;
        private System.Windows.Forms.ToolStripMenuItem companyProfileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem assortmentToolStripMenuItem;
    }
}

