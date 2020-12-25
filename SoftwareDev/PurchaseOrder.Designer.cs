namespace SoftwareDev
{
    partial class PurchaseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_POClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_ProductDetails = new System.Windows.Forms.TabPage();
            this.dg_PDetails = new System.Windows.Forms.DataGridView();
            this.lbl_PONo = new System.Windows.Forms.Label();
            this.dg_POReport = new System.Windows.Forms.DataGridView();
            this.SNoPurchaseOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_OrderDBDataSet = new SoftwareDev.Purchase_OrderDBDataSet();
            this.dt_PONo = new System.Windows.Forms.DateTimePicker();
            this.lbl_datePO = new System.Windows.Forms.Label();
            this.lbl_POMS = new System.Windows.Forms.Label();
            this.txt_POSC = new System.Windows.Forms.TextBox();
            this.txt_POMS = new System.Windows.Forms.TextBox();
            this.btn_SelectMS = new System.Windows.Forms.Button();
            this.lbl_PONarration = new System.Windows.Forms.Label();
            this.rt_PONarration = new System.Windows.Forms.RichTextBox();
            this.btn_InsertNewPO = new System.Windows.Forms.Button();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.lbl_POTotalAmount = new System.Windows.Forms.Label();
            this.btn_POEdit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbo_PurchaseCurrency = new System.Windows.Forms.ComboBox();
            this.lbl_PurchaseCurrency = new System.Windows.Forms.Label();
            this.purchaseOrderDBTableAdapter = new SoftwareDev.Purchase_OrderDBDataSetTableAdapters.PurchaseOrderDBTableAdapter();
            this.btn_DeletePO = new System.Windows.Forms.Button();
            this.btn_OKPO = new System.Windows.Forms.Button();
            this.btn_AddNewPO = new System.Windows.Forms.Button();
            this.btn_ImportPO = new System.Windows.Forms.Button();
            this.btn_ExportPO = new System.Windows.Forms.Button();
            this.txt_PONo = new System.Windows.Forms.TextBox();
            this.SNoProductDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateConvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pri_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tp_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_PDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_POReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_OrderDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_POClose
            // 
            this.btn_POClose.Location = new System.Drawing.Point(507, 338);
            this.btn_POClose.Name = "btn_POClose";
            this.btn_POClose.Size = new System.Drawing.Size(75, 23);
            this.btn_POClose.TabIndex = 10;
            this.btn_POClose.Text = "Close";
            this.btn_POClose.UseVisualStyleBackColor = true;
            this.btn_POClose.Click += new System.EventHandler(this.btn_POClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_ProductDetails);
            this.tabControl1.Location = new System.Drawing.Point(1, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 189);
            this.tabControl1.TabIndex = 6;
            // 
            // tp_ProductDetails
            // 
            this.tp_ProductDetails.Controls.Add(this.dg_PDetails);
            this.tp_ProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tp_ProductDetails.Name = "tp_ProductDetails";
            this.tp_ProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ProductDetails.Size = new System.Drawing.Size(573, 163);
            this.tp_ProductDetails.TabIndex = 0;
            this.tp_ProductDetails.Text = "Product Details";
            this.tp_ProductDetails.UseVisualStyleBackColor = true;
            // 
            // dg_PDetails
            // 
            this.dg_PDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_PDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_PDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoProductDetails,
            this.ColorCode,
            this.ColorProduct,
            this.SizeCode,
            this.SizeProduct,
            this.QualityCode,
            this.QualityProduct,
            this.LotProduct,
            this.QuantityProduct,
            this.RateProduct,
            this.RateConvProduct,
            this.AmountProduct,
            this.Discount1,
            this.Discount1Amount,
            this.Discount2,
            this.Discount2Amount,
            this.Discount3,
            this.Discount3Amount,
            this.finalAmount,
            this.pri_No});
            this.dg_PDetails.Location = new System.Drawing.Point(0, 0);
            this.dg_PDetails.Name = "dg_PDetails";
            this.dg_PDetails.Size = new System.Drawing.Size(573, 167);
            this.dg_PDetails.TabIndex = 0;
            this.dg_PDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_PDetails_CellEndEdit);
            this.dg_PDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_PDetails_CellFormatting);
            this.dg_PDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_PDetails_CellValueChanged);
            this.dg_PDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_PDetails_EditingControlShowing);
            this.dg_PDetails.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_PDetails_RowEnter);
            this.dg_PDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_PDetails_RowPostPaint);
            this.dg_PDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_PDetails_KeyDown);
            // 
            // lbl_PONo
            // 
            this.lbl_PONo.AutoSize = true;
            this.lbl_PONo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PONo.Location = new System.Drawing.Point(2, 9);
            this.lbl_PONo.Name = "lbl_PONo";
            this.lbl_PONo.Size = new System.Drawing.Size(61, 16);
            this.lbl_PONo.TabIndex = 2;
            this.lbl_PONo.Text = "PO No.:";
            // 
            // dg_POReport
            // 
            this.dg_POReport.AllowUserToAddRows = false;
            this.dg_POReport.AllowUserToDeleteRows = false;
            this.dg_POReport.AutoGenerateColumns = false;
            this.dg_POReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_POReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_POReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoPurchaseOrder,
            this.pONoDataGridViewTextBoxColumn,
            this.pODateDataGridViewTextBoxColumn,
            this.ShortCode,
            this.mSDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.PurchaseCurrency});
            this.dg_POReport.DataSource = this.purchaseOrderDBBindingSource;
            this.dg_POReport.Location = new System.Drawing.Point(584, 9);
            this.dg_POReport.Name = "dg_POReport";
            this.dg_POReport.ReadOnly = true;
            this.dg_POReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_POReport.Size = new System.Drawing.Size(643, 311);
            this.dg_POReport.TabIndex = 4;
            this.dg_POReport.TabStop = false;
            this.dg_POReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_POReport_CellDoubleClick);
            this.dg_POReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_POReport_RowPostPaint);
            // 
            // SNoPurchaseOrder
            // 
            this.SNoPurchaseOrder.HeaderText = "Sr. No.";
            this.SNoPurchaseOrder.Name = "SNoPurchaseOrder";
            this.SNoPurchaseOrder.ReadOnly = true;
            // 
            // pONoDataGridViewTextBoxColumn
            // 
            this.pONoDataGridViewTextBoxColumn.DataPropertyName = "PO_No";
            this.pONoDataGridViewTextBoxColumn.HeaderText = "PO. No.";
            this.pONoDataGridViewTextBoxColumn.Name = "pONoDataGridViewTextBoxColumn";
            this.pONoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pODateDataGridViewTextBoxColumn
            // 
            this.pODateDataGridViewTextBoxColumn.DataPropertyName = "PO_Date";
            this.pODateDataGridViewTextBoxColumn.HeaderText = "PO Date";
            this.pODateDataGridViewTextBoxColumn.Name = "pODateDataGridViewTextBoxColumn";
            this.pODateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShortCode
            // 
            this.ShortCode.DataPropertyName = "ShortCode";
            this.ShortCode.HeaderText = "ShortCode";
            this.ShortCode.Name = "ShortCode";
            this.ShortCode.ReadOnly = true;
            this.ShortCode.Visible = false;
            // 
            // mSDataGridViewTextBoxColumn
            // 
            this.mSDataGridViewTextBoxColumn.DataPropertyName = "MS";
            this.mSDataGridViewTextBoxColumn.HeaderText = "MS";
            this.mSDataGridViewTextBoxColumn.Name = "mSDataGridViewTextBoxColumn";
            this.mSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narrationDataGridViewTextBoxColumn
            // 
            this.narrationDataGridViewTextBoxColumn.DataPropertyName = "Narration";
            this.narrationDataGridViewTextBoxColumn.HeaderText = "Narration";
            this.narrationDataGridViewTextBoxColumn.Name = "narrationDataGridViewTextBoxColumn";
            this.narrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PurchaseCurrency
            // 
            this.PurchaseCurrency.DataPropertyName = "PurchaseCurrency";
            this.PurchaseCurrency.HeaderText = "PurchaseCurrency";
            this.PurchaseCurrency.Name = "PurchaseCurrency";
            this.PurchaseCurrency.ReadOnly = true;
            this.PurchaseCurrency.Visible = false;
            // 
            // purchaseOrderDBBindingSource
            // 
            this.purchaseOrderDBBindingSource.DataMember = "PurchaseOrderDB";
            this.purchaseOrderDBBindingSource.DataSource = this.purchase_OrderDBDataSet;
            // 
            // purchase_OrderDBDataSet
            // 
            this.purchase_OrderDBDataSet.DataSetName = "Purchase_OrderDBDataSet";
            this.purchase_OrderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dt_PONo
            // 
            this.dt_PONo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PONo.Location = new System.Drawing.Point(251, 7);
            this.dt_PONo.Name = "dt_PONo";
            this.dt_PONo.Size = new System.Drawing.Size(79, 20);
            this.dt_PONo.TabIndex = 0;
            this.dt_PONo.Value = new System.DateTime(2020, 9, 26, 19, 9, 52, 0);
            // 
            // lbl_datePO
            // 
            this.lbl_datePO.AutoSize = true;
            this.lbl_datePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datePO.Location = new System.Drawing.Point(171, 9);
            this.lbl_datePO.Name = "lbl_datePO";
            this.lbl_datePO.Size = new System.Drawing.Size(74, 16);
            this.lbl_datePO.TabIndex = 6;
            this.lbl_datePO.Text = "PO Date :";
            // 
            // lbl_POMS
            // 
            this.lbl_POMS.AutoSize = true;
            this.lbl_POMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_POMS.Location = new System.Drawing.Point(2, 31);
            this.lbl_POMS.Name = "lbl_POMS";
            this.lbl_POMS.Size = new System.Drawing.Size(41, 16);
            this.lbl_POMS.TabIndex = 7;
            this.lbl_POMS.Text = "M/s :";
            // 
            // txt_POSC
            // 
            this.txt_POSC.Location = new System.Drawing.Point(49, 30);
            this.txt_POSC.Name = "txt_POSC";
            this.txt_POSC.Size = new System.Drawing.Size(32, 20);
            this.txt_POSC.TabIndex = 2;
            this.txt_POSC.TextChanged += new System.EventHandler(this.txt_POSC_TextChanged);
            // 
            // txt_POMS
            // 
            this.txt_POMS.Location = new System.Drawing.Point(87, 30);
            this.txt_POMS.Name = "txt_POMS";
            this.txt_POMS.Size = new System.Drawing.Size(86, 20);
            this.txt_POMS.TabIndex = 3;
            // 
            // btn_SelectMS
            // 
            this.btn_SelectMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectMS.Location = new System.Drawing.Point(179, 30);
            this.btn_SelectMS.Name = "btn_SelectMS";
            this.btn_SelectMS.Size = new System.Drawing.Size(27, 21);
            this.btn_SelectMS.TabIndex = 4;
            this.btn_SelectMS.Text = "...";
            this.btn_SelectMS.UseVisualStyleBackColor = true;
            this.btn_SelectMS.Click += new System.EventHandler(this.btn_SelectMS_Click);
            // 
            // lbl_PONarration
            // 
            this.lbl_PONarration.AutoSize = true;
            this.lbl_PONarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PONarration.Location = new System.Drawing.Point(-2, 53);
            this.lbl_PONarration.Name = "lbl_PONarration";
            this.lbl_PONarration.Size = new System.Drawing.Size(80, 16);
            this.lbl_PONarration.TabIndex = 11;
            this.lbl_PONarration.Text = "Narration :";
            // 
            // rt_PONarration
            // 
            this.rt_PONarration.Location = new System.Drawing.Point(85, 57);
            this.rt_PONarration.Name = "rt_PONarration";
            this.rt_PONarration.Size = new System.Drawing.Size(121, 41);
            this.rt_PONarration.TabIndex = 5;
            this.rt_PONarration.Text = "";
            // 
            // btn_InsertNewPO
            // 
            this.btn_InsertNewPO.Location = new System.Drawing.Point(426, 338);
            this.btn_InsertNewPO.Name = "btn_InsertNewPO";
            this.btn_InsertNewPO.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertNewPO.TabIndex = 9;
            this.btn_InsertNewPO.Text = "Submit";
            this.btn_InsertNewPO.UseVisualStyleBackColor = true;
            this.btn_InsertNewPO.Click += new System.EventHandler(this.btn_InsertNewPO_Click);
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Location = new System.Drawing.Point(477, 300);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalAmount.TabIndex = 7;
            // 
            // lbl_POTotalAmount
            // 
            this.lbl_POTotalAmount.AutoSize = true;
            this.lbl_POTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_POTotalAmount.Location = new System.Drawing.Point(364, 301);
            this.lbl_POTotalAmount.Name = "lbl_POTotalAmount";
            this.lbl_POTotalAmount.Size = new System.Drawing.Size(107, 16);
            this.lbl_POTotalAmount.TabIndex = 15;
            this.lbl_POTotalAmount.Text = "Total Amount :";
            // 
            // btn_POEdit
            // 
            this.btn_POEdit.Location = new System.Drawing.Point(1152, 338);
            this.btn_POEdit.Name = "btn_POEdit";
            this.btn_POEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_POEdit.TabIndex = 12;
            this.btn_POEdit.Text = "Edit";
            this.btn_POEdit.UseVisualStyleBackColor = true;
            this.btn_POEdit.Click += new System.EventHandler(this.btn_POEdit_Click);
            this.btn_POEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_POEdit_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(345, 338);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbo_PurchaseCurrency
            // 
            this.cbo_PurchaseCurrency.FormattingEnabled = true;
            this.cbo_PurchaseCurrency.Items.AddRange(new object[] {
            "₹ Purchase",
            "$ Purchase"});
            this.cbo_PurchaseCurrency.Location = new System.Drawing.Point(477, 7);
            this.cbo_PurchaseCurrency.Name = "cbo_PurchaseCurrency";
            this.cbo_PurchaseCurrency.Size = new System.Drawing.Size(101, 21);
            this.cbo_PurchaseCurrency.TabIndex = 1;
            this.cbo_PurchaseCurrency.SelectedIndexChanged += new System.EventHandler(this.cbo_PurchaseCurrency_SelectedIndexChanged);
            // 
            // lbl_PurchaseCurrency
            // 
            this.lbl_PurchaseCurrency.AutoSize = true;
            this.lbl_PurchaseCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchaseCurrency.Location = new System.Drawing.Point(336, 11);
            this.lbl_PurchaseCurrency.Name = "lbl_PurchaseCurrency";
            this.lbl_PurchaseCurrency.Size = new System.Drawing.Size(135, 15);
            this.lbl_PurchaseCurrency.TabIndex = 19;
            this.lbl_PurchaseCurrency.Text = "Purchase Currency :";
            // 
            // purchaseOrderDBTableAdapter
            // 
            this.purchaseOrderDBTableAdapter.ClearBeforeFill = true;
            // 
            // btn_DeletePO
            // 
            this.btn_DeletePO.Location = new System.Drawing.Point(1071, 338);
            this.btn_DeletePO.Name = "btn_DeletePO";
            this.btn_DeletePO.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePO.TabIndex = 11;
            this.btn_DeletePO.Text = "Delete";
            this.btn_DeletePO.UseVisualStyleBackColor = true;
            this.btn_DeletePO.Click += new System.EventHandler(this.btn_DeletePO_Click);
            // 
            // btn_OKPO
            // 
            this.btn_OKPO.Location = new System.Drawing.Point(264, 338);
            this.btn_OKPO.Name = "btn_OKPO";
            this.btn_OKPO.Size = new System.Drawing.Size(75, 23);
            this.btn_OKPO.TabIndex = 20;
            this.btn_OKPO.Text = "OK";
            this.btn_OKPO.UseVisualStyleBackColor = true;
            // 
            // btn_AddNewPO
            // 
            this.btn_AddNewPO.Location = new System.Drawing.Point(183, 337);
            this.btn_AddNewPO.Name = "btn_AddNewPO";
            this.btn_AddNewPO.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNewPO.TabIndex = 21;
            this.btn_AddNewPO.Text = "Add New";
            this.btn_AddNewPO.UseVisualStyleBackColor = true;
            this.btn_AddNewPO.Click += new System.EventHandler(this.btn_AddNewPO_Click);
            // 
            // btn_ImportPO
            // 
            this.btn_ImportPO.Location = new System.Drawing.Point(990, 338);
            this.btn_ImportPO.Name = "btn_ImportPO";
            this.btn_ImportPO.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportPO.TabIndex = 22;
            this.btn_ImportPO.Text = "Import";
            this.btn_ImportPO.UseVisualStyleBackColor = true;
            // 
            // btn_ExportPO
            // 
            this.btn_ExportPO.Location = new System.Drawing.Point(909, 338);
            this.btn_ExportPO.Name = "btn_ExportPO";
            this.btn_ExportPO.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportPO.TabIndex = 22;
            this.btn_ExportPO.Text = "Export";
            this.btn_ExportPO.UseVisualStyleBackColor = true;
            // 
            // txt_PONo
            // 
            this.txt_PONo.Location = new System.Drawing.Point(69, 7);
            this.txt_PONo.Name = "txt_PONo";
            this.txt_PONo.Size = new System.Drawing.Size(96, 20);
            this.txt_PONo.TabIndex = 23;
            // 
            // SNoProductDetails
            // 
            this.SNoProductDetails.HeaderText = "Sr. No.";
            this.SNoProductDetails.Name = "SNoProductDetails";
            this.SNoProductDetails.ReadOnly = true;
            // 
            // ColorCode
            // 
            this.ColorCode.HeaderText = "Color Code";
            this.ColorCode.Name = "ColorCode";
            // 
            // ColorProduct
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.ColorProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColorProduct.HeaderText = "Color";
            this.ColorProduct.Name = "ColorProduct";
            this.ColorProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            // 
            // SizeProduct
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.SizeProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.SizeProduct.HeaderText = "Size";
            this.SizeProduct.Name = "SizeProduct";
            this.SizeProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SizeProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QualityCode
            // 
            this.QualityCode.HeaderText = "Quality Code";
            this.QualityCode.Name = "QualityCode";
            // 
            // QualityProduct
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            this.QualityProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.QualityProduct.HeaderText = "Quality";
            this.QualityProduct.Name = "QualityProduct";
            this.QualityProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QualityProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LotProduct
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.LotProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.LotProduct.HeaderText = "Lot";
            this.LotProduct.Name = "LotProduct";
            // 
            // QuantityProduct
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            this.QuantityProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.QuantityProduct.HeaderText = "Quantity";
            this.QuantityProduct.Name = "QuantityProduct";
            // 
            // RateProduct
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            this.RateProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.RateProduct.HeaderText = "Rate";
            this.RateProduct.Name = "RateProduct";
            // 
            // RateConvProduct
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            this.RateConvProduct.DefaultCellStyle = dataGridViewCellStyle7;
            this.RateConvProduct.HeaderText = "Conv. Rate";
            this.RateConvProduct.Name = "RateConvProduct";
            // 
            // AmountProduct
            // 
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            this.AmountProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.AmountProduct.HeaderText = "Amount";
            this.AmountProduct.Name = "AmountProduct";
            // 
            // Discount1
            // 
            this.Discount1.HeaderText = "Discount 1";
            this.Discount1.Name = "Discount1";
            // 
            // Discount1Amount
            // 
            this.Discount1Amount.HeaderText = "Discount 1 Amount";
            this.Discount1Amount.Name = "Discount1Amount";
            // 
            // Discount2
            // 
            this.Discount2.HeaderText = "Discount 2";
            this.Discount2.Name = "Discount2";
            // 
            // Discount2Amount
            // 
            this.Discount2Amount.HeaderText = "Discount 2 Amount";
            this.Discount2Amount.Name = "Discount2Amount";
            // 
            // Discount3
            // 
            this.Discount3.HeaderText = "Discount 3";
            this.Discount3.Name = "Discount3";
            // 
            // Discount3Amount
            // 
            this.Discount3Amount.HeaderText = "Discount 3 Amount";
            this.Discount3Amount.Name = "Discount3Amount";
            // 
            // finalAmount
            // 
            this.finalAmount.HeaderText = "Final Amount";
            this.finalAmount.Name = "finalAmount";
            // 
            // pri_No
            // 
            this.pri_No.HeaderText = "priNo";
            this.pri_No.Name = "pri_No";
            this.pri_No.ReadOnly = true;
            this.pri_No.Visible = false;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.Controls.Add(this.txt_PONo);
            this.Controls.Add(this.btn_ExportPO);
            this.Controls.Add(this.btn_ImportPO);
            this.Controls.Add(this.btn_AddNewPO);
            this.Controls.Add(this.btn_OKPO);
            this.Controls.Add(this.btn_DeletePO);
            this.Controls.Add(this.lbl_PurchaseCurrency);
            this.Controls.Add(this.cbo_PurchaseCurrency);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_POEdit);
            this.Controls.Add(this.lbl_POTotalAmount);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.btn_InsertNewPO);
            this.Controls.Add(this.rt_PONarration);
            this.Controls.Add(this.lbl_PONarration);
            this.Controls.Add(this.btn_SelectMS);
            this.Controls.Add(this.txt_POMS);
            this.Controls.Add(this.txt_POSC);
            this.Controls.Add(this.lbl_POMS);
            this.Controls.Add(this.lbl_datePO);
            this.Controls.Add(this.dt_PONo);
            this.Controls.Add(this.dg_POReport);
            this.Controls.Add(this.lbl_PONo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_POClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_ProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_PDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_POReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_OrderDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_POClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_ProductDetails;
        private System.Windows.Forms.Label lbl_PONo;
        public System.Windows.Forms.DataGridView dg_PDetails;
        private System.Windows.Forms.DataGridView dg_POReport;
        private Purchase_OrderDBDataSet purchase_OrderDBDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderDBBindingSource;
        private Purchase_OrderDBDataSetTableAdapters.PurchaseOrderDBTableAdapter purchaseOrderDBTableAdapter;
        private System.Windows.Forms.DateTimePicker dt_PONo;
        private System.Windows.Forms.Label lbl_datePO;
        private System.Windows.Forms.Label lbl_POMS;
        private System.Windows.Forms.Label lbl_PONarration;
        private System.Windows.Forms.RichTextBox rt_PONarration;
        public System.Windows.Forms.TextBox txt_POSC;
        public System.Windows.Forms.TextBox txt_POMS;
        private System.Windows.Forms.Button btn_InsertNewPO;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Label lbl_POTotalAmount;
        private System.Windows.Forms.Button btn_POEdit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbo_PurchaseCurrency;
        private System.Windows.Forms.Label lbl_PurchaseCurrency;
        private System.Windows.Forms.Button btn_DeletePO;
        private System.Windows.Forms.Button btn_OKPO;
        private System.Windows.Forms.Button btn_AddNewPO;
        private System.Windows.Forms.Button btn_ImportPO;
        private System.Windows.Forms.Button btn_ExportPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoPurchaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseCurrency;
        public System.Windows.Forms.Button btn_SelectMS;
        private System.Windows.Forms.TextBox txt_PONo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateConvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pri_No;
    }
}