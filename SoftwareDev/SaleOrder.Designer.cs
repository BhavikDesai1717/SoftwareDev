namespace SoftwareDev
{
    partial class SaleOrder
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
            this.lbl_SaleOrder = new System.Windows.Forms.Label();
            this.lbl_SaleOrderDate = new System.Windows.Forms.Label();
            this.dt_SaleOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_SaleOrderCurrency = new System.Windows.Forms.Label();
            this.cbo_SaleOrderCurrency = new System.Windows.Forms.ComboBox();
            this.lbl_SaleOrderMS = new System.Windows.Forms.Label();
            this.txt_SaleOrderSC = new System.Windows.Forms.TextBox();
            this.txt_SaleOrderMS = new System.Windows.Forms.TextBox();
            this.btn_SelectMSSaleOrder = new System.Windows.Forms.Button();
            this.lbl_Narration = new System.Windows.Forms.Label();
            this.rt_Narration = new System.Windows.Forms.RichTextBox();
            this.tb_SaleProductDetails = new System.Windows.Forms.TabControl();
            this.tb_ProductDetails = new System.Windows.Forms.TabPage();
            this.dg_ProductDetailsSO = new System.Windows.Forms.DataGridView();
            this.SNoSaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCodeSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCodeSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityCodeSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualitySO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateConvSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount1SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmountSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount2AmountSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount3AmountSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalDiscountedAmountSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPrimaryOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_SaleOrderReport = new System.Windows.Forms.DataGridView();
            this.SrNOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleOrderDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sale_OrderDBDataSet = new SoftwareDev.Sale_OrderDBDataSet();
            this.lbl_TotalAmountSO = new System.Windows.Forms.Label();
            this.txt_TotalAmountSO = new System.Windows.Forms.TextBox();
            this.btn_AddNewSO = new System.Windows.Forms.Button();
            this.btn_SubmitNewSO = new System.Windows.Forms.Button();
            this.btn_UpdateSO = new System.Windows.Forms.Button();
            this.btn_DisplaySO = new System.Windows.Forms.Button();
            this.btn_CloseSO = new System.Windows.Forms.Button();
            this.btn_ExportSO = new System.Windows.Forms.Button();
            this.btn_ImportSO = new System.Windows.Forms.Button();
            this.btn_DeleteSO = new System.Windows.Forms.Button();
            this.btn_EditSO = new System.Windows.Forms.Button();
            this.saleOrderDBTableAdapter = new SoftwareDev.Sale_OrderDBDataSetTableAdapters.SaleOrderDBTableAdapter();
            this.txt_SoNo = new System.Windows.Forms.TextBox();
            this.tb_SaleProductDetails.SuspendLayout();
            this.tb_ProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductDetailsSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SaleOrderReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_OrderDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SaleOrder
            // 
            this.lbl_SaleOrder.AutoSize = true;
            this.lbl_SaleOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleOrder.Location = new System.Drawing.Point(13, 13);
            this.lbl_SaleOrder.Name = "lbl_SaleOrder";
            this.lbl_SaleOrder.Size = new System.Drawing.Size(100, 16);
            this.lbl_SaleOrder.TabIndex = 0;
            this.lbl_SaleOrder.Text = "Sale Order No.:";
            // 
            // lbl_SaleOrderDate
            // 
            this.lbl_SaleOrderDate.AutoSize = true;
            this.lbl_SaleOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleOrderDate.Location = new System.Drawing.Point(220, 13);
            this.lbl_SaleOrderDate.Name = "lbl_SaleOrderDate";
            this.lbl_SaleOrderDate.Size = new System.Drawing.Size(43, 16);
            this.lbl_SaleOrderDate.TabIndex = 2;
            this.lbl_SaleOrderDate.Text = "Date :";
            // 
            // dt_SaleOrderDate
            // 
            this.dt_SaleOrderDate.Location = new System.Drawing.Point(269, 12);
            this.dt_SaleOrderDate.Name = "dt_SaleOrderDate";
            this.dt_SaleOrderDate.Size = new System.Drawing.Size(117, 20);
            this.dt_SaleOrderDate.TabIndex = 3;
            // 
            // lbl_SaleOrderCurrency
            // 
            this.lbl_SaleOrderCurrency.AutoSize = true;
            this.lbl_SaleOrderCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleOrderCurrency.Location = new System.Drawing.Point(392, 13);
            this.lbl_SaleOrderCurrency.Name = "lbl_SaleOrderCurrency";
            this.lbl_SaleOrderCurrency.Size = new System.Drawing.Size(98, 16);
            this.lbl_SaleOrderCurrency.TabIndex = 4;
            this.lbl_SaleOrderCurrency.Text = "Sale Currency :";
            // 
            // cbo_SaleOrderCurrency
            // 
            this.cbo_SaleOrderCurrency.FormattingEnabled = true;
            this.cbo_SaleOrderCurrency.Items.AddRange(new object[] {
            "₹ Sale",
            "$ Sale"});
            this.cbo_SaleOrderCurrency.Location = new System.Drawing.Point(496, 13);
            this.cbo_SaleOrderCurrency.Name = "cbo_SaleOrderCurrency";
            this.cbo_SaleOrderCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbo_SaleOrderCurrency.TabIndex = 5;
            this.cbo_SaleOrderCurrency.SelectedIndexChanged += new System.EventHandler(this.cbo_SaleOrderCurrency_SelectedIndexChanged);
            // 
            // lbl_SaleOrderMS
            // 
            this.lbl_SaleOrderMS.AutoSize = true;
            this.lbl_SaleOrderMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaleOrderMS.Location = new System.Drawing.Point(80, 45);
            this.lbl_SaleOrderMS.Name = "lbl_SaleOrderMS";
            this.lbl_SaleOrderMS.Size = new System.Drawing.Size(33, 16);
            this.lbl_SaleOrderMS.TabIndex = 6;
            this.lbl_SaleOrderMS.Text = "M/s:";
            // 
            // txt_SaleOrderSC
            // 
            this.txt_SaleOrderSC.Location = new System.Drawing.Point(120, 45);
            this.txt_SaleOrderSC.Name = "txt_SaleOrderSC";
            this.txt_SaleOrderSC.Size = new System.Drawing.Size(31, 20);
            this.txt_SaleOrderSC.TabIndex = 8;
            this.txt_SaleOrderSC.TextChanged += new System.EventHandler(this.txt_SaleOrderSC_TextChanged);
            // 
            // txt_SaleOrderMS
            // 
            this.txt_SaleOrderMS.Location = new System.Drawing.Point(157, 45);
            this.txt_SaleOrderMS.Name = "txt_SaleOrderMS";
            this.txt_SaleOrderMS.Size = new System.Drawing.Size(100, 20);
            this.txt_SaleOrderMS.TabIndex = 8;
            // 
            // btn_SelectMSSaleOrder
            // 
            this.btn_SelectMSSaleOrder.Location = new System.Drawing.Point(264, 45);
            this.btn_SelectMSSaleOrder.Name = "btn_SelectMSSaleOrder";
            this.btn_SelectMSSaleOrder.Size = new System.Drawing.Size(25, 20);
            this.btn_SelectMSSaleOrder.TabIndex = 9;
            this.btn_SelectMSSaleOrder.Text = "...";
            this.btn_SelectMSSaleOrder.UseVisualStyleBackColor = true;
            this.btn_SelectMSSaleOrder.Click += new System.EventHandler(this.btn_SelectMSSaleOrder_Click);
            // 
            // lbl_Narration
            // 
            this.lbl_Narration.AutoSize = true;
            this.lbl_Narration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Narration.Location = new System.Drawing.Point(44, 79);
            this.lbl_Narration.Name = "lbl_Narration";
            this.lbl_Narration.Size = new System.Drawing.Size(69, 16);
            this.lbl_Narration.TabIndex = 6;
            this.lbl_Narration.Text = "Narration :";
            // 
            // rt_Narration
            // 
            this.rt_Narration.Location = new System.Drawing.Point(120, 79);
            this.rt_Narration.Name = "rt_Narration";
            this.rt_Narration.Size = new System.Drawing.Size(169, 45);
            this.rt_Narration.TabIndex = 10;
            this.rt_Narration.Text = "";
            // 
            // tb_SaleProductDetails
            // 
            this.tb_SaleProductDetails.Controls.Add(this.tb_ProductDetails);
            this.tb_SaleProductDetails.Location = new System.Drawing.Point(16, 130);
            this.tb_SaleProductDetails.Name = "tb_SaleProductDetails";
            this.tb_SaleProductDetails.SelectedIndex = 0;
            this.tb_SaleProductDetails.Size = new System.Drawing.Size(601, 179);
            this.tb_SaleProductDetails.TabIndex = 11;
            // 
            // tb_ProductDetails
            // 
            this.tb_ProductDetails.Controls.Add(this.dg_ProductDetailsSO);
            this.tb_ProductDetails.Location = new System.Drawing.Point(4, 22);
            this.tb_ProductDetails.Name = "tb_ProductDetails";
            this.tb_ProductDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ProductDetails.Size = new System.Drawing.Size(593, 153);
            this.tb_ProductDetails.TabIndex = 0;
            this.tb_ProductDetails.Text = "Product_Details";
            this.tb_ProductDetails.UseVisualStyleBackColor = true;
            // 
            // dg_ProductDetailsSO
            // 
            this.dg_ProductDetailsSO.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_ProductDetailsSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ProductDetailsSO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNoSaleOrder,
            this.ColorCodeSO,
            this.ColorSO,
            this.SizeCodeSO,
            this.SizeSO,
            this.QualityCodeSO,
            this.QualitySO,
            this.LotSO,
            this.QuantitySO,
            this.RateSO,
            this.RateConvSO,
            this.AmountSO,
            this.Discount1SO,
            this.DiscountAmountSO,
            this.Discount2SO,
            this.Discount2AmountSO,
            this.Discount3SO,
            this.Discount3AmountSO,
            this.FinalDiscountedAmountSO,
            this.proPrimaryOrder});
            this.dg_ProductDetailsSO.Location = new System.Drawing.Point(0, 0);
            this.dg_ProductDetailsSO.Name = "dg_ProductDetailsSO";
            this.dg_ProductDetailsSO.Size = new System.Drawing.Size(593, 150);
            this.dg_ProductDetailsSO.TabIndex = 0;
            this.dg_ProductDetailsSO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ProductDetailsSO_CellEndEdit);
            this.dg_ProductDetailsSO.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_ProductDetailsSO_CellFormatting);
            this.dg_ProductDetailsSO.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ProductDetailsSO_CellValueChanged);
            this.dg_ProductDetailsSO.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_ProductDetailsSO_EditingControlShowing);
            this.dg_ProductDetailsSO.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_ProductDetailsSO_RowPostPaint);
            this.dg_ProductDetailsSO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dg_ProductDetailsSO_KeyDown);
            // 
            // SNoSaleOrder
            // 
            this.SNoSaleOrder.HeaderText = "Sr. No.";
            this.SNoSaleOrder.Name = "SNoSaleOrder";
            this.SNoSaleOrder.ReadOnly = true;
            // 
            // ColorCodeSO
            // 
            this.ColorCodeSO.HeaderText = "Color Code";
            this.ColorCodeSO.Name = "ColorCodeSO";
            // 
            // ColorSO
            // 
            this.ColorSO.HeaderText = "Color";
            this.ColorSO.Name = "ColorSO";
            // 
            // SizeCodeSO
            // 
            this.SizeCodeSO.HeaderText = "Size Code";
            this.SizeCodeSO.Name = "SizeCodeSO";
            // 
            // SizeSO
            // 
            this.SizeSO.HeaderText = "Size";
            this.SizeSO.Name = "SizeSO";
            // 
            // QualityCodeSO
            // 
            this.QualityCodeSO.HeaderText = "Quality Code";
            this.QualityCodeSO.Name = "QualityCodeSO";
            // 
            // QualitySO
            // 
            this.QualitySO.HeaderText = "Quality";
            this.QualitySO.Name = "QualitySO";
            // 
            // LotSO
            // 
            this.LotSO.HeaderText = "Lot";
            this.LotSO.Name = "LotSO";
            // 
            // QuantitySO
            // 
            this.QuantitySO.HeaderText = "Quantity";
            this.QuantitySO.Name = "QuantitySO";
            // 
            // RateSO
            // 
            this.RateSO.HeaderText = "Rate";
            this.RateSO.Name = "RateSO";
            // 
            // RateConvSO
            // 
            this.RateConvSO.HeaderText = "Rate Conv.";
            this.RateConvSO.Name = "RateConvSO";
            // 
            // AmountSO
            // 
            this.AmountSO.HeaderText = "Amount";
            this.AmountSO.Name = "AmountSO";
            // 
            // Discount1SO
            // 
            this.Discount1SO.HeaderText = "Discount 1";
            this.Discount1SO.Name = "Discount1SO";
            // 
            // DiscountAmountSO
            // 
            this.DiscountAmountSO.HeaderText = "Discount Amount";
            this.DiscountAmountSO.Name = "DiscountAmountSO";
            // 
            // Discount2SO
            // 
            this.Discount2SO.HeaderText = "Discount 2";
            this.Discount2SO.Name = "Discount2SO";
            // 
            // Discount2AmountSO
            // 
            this.Discount2AmountSO.HeaderText = "Discount 2 Amount";
            this.Discount2AmountSO.Name = "Discount2AmountSO";
            // 
            // Discount3SO
            // 
            this.Discount3SO.HeaderText = "Discount 3";
            this.Discount3SO.Name = "Discount3SO";
            // 
            // Discount3AmountSO
            // 
            this.Discount3AmountSO.HeaderText = "Discount 3 Amount";
            this.Discount3AmountSO.Name = "Discount3AmountSO";
            // 
            // FinalDiscountedAmountSO
            // 
            this.FinalDiscountedAmountSO.HeaderText = "Amount";
            this.FinalDiscountedAmountSO.Name = "FinalDiscountedAmountSO";
            // 
            // proPrimaryOrder
            // 
            this.proPrimaryOrder.HeaderText = "proPrimary";
            this.proPrimaryOrder.Name = "proPrimaryOrder";
            this.proPrimaryOrder.ReadOnly = true;
            this.proPrimaryOrder.Visible = false;
            // 
            // dg_SaleOrderReport
            // 
            this.dg_SaleOrderReport.AllowUserToAddRows = false;
            this.dg_SaleOrderReport.AllowUserToDeleteRows = false;
            this.dg_SaleOrderReport.AutoGenerateColumns = false;
            this.dg_SaleOrderReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SaleOrderReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNOSO,
            this.sONoDataGridViewTextBoxColumn,
            this.sODateDataGridViewTextBoxColumn,
            this.saleCurrencyDataGridViewTextBoxColumn,
            this.mSDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.narrationDataGridViewTextBoxColumn,
            this.shortCodeDataGridViewTextBoxColumn});
            this.dg_SaleOrderReport.DataSource = this.saleOrderDBBindingSource;
            this.dg_SaleOrderReport.Location = new System.Drawing.Point(624, 13);
            this.dg_SaleOrderReport.Name = "dg_SaleOrderReport";
            this.dg_SaleOrderReport.ReadOnly = true;
            this.dg_SaleOrderReport.Size = new System.Drawing.Size(743, 292);
            this.dg_SaleOrderReport.TabIndex = 12;
            this.dg_SaleOrderReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_SaleOrderReport_CellDoubleClick);
            this.dg_SaleOrderReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dg_SaleOrderReport_RowPostPaint);
            // 
            // SrNOSO
            // 
            this.SrNOSO.HeaderText = "Sr. No.";
            this.SrNOSO.Name = "SrNOSO";
            this.SrNOSO.ReadOnly = true;
            // 
            // sONoDataGridViewTextBoxColumn
            // 
            this.sONoDataGridViewTextBoxColumn.DataPropertyName = "SO_No";
            this.sONoDataGridViewTextBoxColumn.HeaderText = "SO No";
            this.sONoDataGridViewTextBoxColumn.Name = "sONoDataGridViewTextBoxColumn";
            this.sONoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sODateDataGridViewTextBoxColumn
            // 
            this.sODateDataGridViewTextBoxColumn.DataPropertyName = "SO_Date";
            this.sODateDataGridViewTextBoxColumn.HeaderText = "SO Date";
            this.sODateDataGridViewTextBoxColumn.Name = "sODateDataGridViewTextBoxColumn";
            this.sODateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleCurrencyDataGridViewTextBoxColumn
            // 
            this.saleCurrencyDataGridViewTextBoxColumn.DataPropertyName = "SaleCurrency";
            this.saleCurrencyDataGridViewTextBoxColumn.HeaderText = "Sale Currency";
            this.saleCurrencyDataGridViewTextBoxColumn.Name = "saleCurrencyDataGridViewTextBoxColumn";
            this.saleCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
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
            // shortCodeDataGridViewTextBoxColumn
            // 
            this.shortCodeDataGridViewTextBoxColumn.DataPropertyName = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.HeaderText = "ShortCode";
            this.shortCodeDataGridViewTextBoxColumn.Name = "shortCodeDataGridViewTextBoxColumn";
            this.shortCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleOrderDBBindingSource
            // 
            this.saleOrderDBBindingSource.DataMember = "SaleOrderDB";
            this.saleOrderDBBindingSource.DataSource = this.sale_OrderDBDataSet;
            // 
            // sale_OrderDBDataSet
            // 
            this.sale_OrderDBDataSet.DataSetName = "Sale_OrderDBDataSet";
            this.sale_OrderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_TotalAmountSO
            // 
            this.lbl_TotalAmountSO.AutoSize = true;
            this.lbl_TotalAmountSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmountSO.Location = new System.Drawing.Point(414, 316);
            this.lbl_TotalAmountSO.Name = "lbl_TotalAmountSO";
            this.lbl_TotalAmountSO.Size = new System.Drawing.Size(93, 16);
            this.lbl_TotalAmountSO.TabIndex = 13;
            this.lbl_TotalAmountSO.Text = "Total Amount :";
            // 
            // txt_TotalAmountSO
            // 
            this.txt_TotalAmountSO.Location = new System.Drawing.Point(513, 315);
            this.txt_TotalAmountSO.Name = "txt_TotalAmountSO";
            this.txt_TotalAmountSO.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalAmountSO.TabIndex = 8;
            // 
            // btn_AddNewSO
            // 
            this.btn_AddNewSO.Location = new System.Drawing.Point(20, 351);
            this.btn_AddNewSO.Name = "btn_AddNewSO";
            this.btn_AddNewSO.Size = new System.Drawing.Size(75, 40);
            this.btn_AddNewSO.TabIndex = 14;
            this.btn_AddNewSO.Text = "Add New";
            this.btn_AddNewSO.UseVisualStyleBackColor = true;
            this.btn_AddNewSO.Click += new System.EventHandler(this.btn_AddNewSO_Click);
            // 
            // btn_SubmitNewSO
            // 
            this.btn_SubmitNewSO.Location = new System.Drawing.Point(150, 351);
            this.btn_SubmitNewSO.Name = "btn_SubmitNewSO";
            this.btn_SubmitNewSO.Size = new System.Drawing.Size(75, 40);
            this.btn_SubmitNewSO.TabIndex = 14;
            this.btn_SubmitNewSO.Text = "Submit";
            this.btn_SubmitNewSO.UseVisualStyleBackColor = true;
            this.btn_SubmitNewSO.Click += new System.EventHandler(this.btn_SubmitNewSO_Click);
            // 
            // btn_UpdateSO
            // 
            this.btn_UpdateSO.Location = new System.Drawing.Point(280, 351);
            this.btn_UpdateSO.Name = "btn_UpdateSO";
            this.btn_UpdateSO.Size = new System.Drawing.Size(75, 40);
            this.btn_UpdateSO.TabIndex = 14;
            this.btn_UpdateSO.Text = "Save";
            this.btn_UpdateSO.UseVisualStyleBackColor = true;
            this.btn_UpdateSO.Click += new System.EventHandler(this.btn_UpdateSO_Click);
            // 
            // btn_DisplaySO
            // 
            this.btn_DisplaySO.Location = new System.Drawing.Point(410, 351);
            this.btn_DisplaySO.Name = "btn_DisplaySO";
            this.btn_DisplaySO.Size = new System.Drawing.Size(75, 40);
            this.btn_DisplaySO.TabIndex = 14;
            this.btn_DisplaySO.Text = "OK";
            this.btn_DisplaySO.UseVisualStyleBackColor = true;
            // 
            // btn_CloseSO
            // 
            this.btn_CloseSO.Location = new System.Drawing.Point(540, 351);
            this.btn_CloseSO.Name = "btn_CloseSO";
            this.btn_CloseSO.Size = new System.Drawing.Size(75, 40);
            this.btn_CloseSO.TabIndex = 14;
            this.btn_CloseSO.Text = "Close";
            this.btn_CloseSO.UseVisualStyleBackColor = true;
            this.btn_CloseSO.Click += new System.EventHandler(this.btn_CloseSO_Click);
            // 
            // btn_ExportSO
            // 
            this.btn_ExportSO.Location = new System.Drawing.Point(624, 351);
            this.btn_ExportSO.Name = "btn_ExportSO";
            this.btn_ExportSO.Size = new System.Drawing.Size(75, 40);
            this.btn_ExportSO.TabIndex = 14;
            this.btn_ExportSO.Text = "Export";
            this.btn_ExportSO.UseVisualStyleBackColor = true;
            // 
            // btn_ImportSO
            // 
            this.btn_ImportSO.Location = new System.Drawing.Point(846, 351);
            this.btn_ImportSO.Name = "btn_ImportSO";
            this.btn_ImportSO.Size = new System.Drawing.Size(75, 40);
            this.btn_ImportSO.TabIndex = 14;
            this.btn_ImportSO.Text = "Import";
            this.btn_ImportSO.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteSO
            // 
            this.btn_DeleteSO.Location = new System.Drawing.Point(1068, 351);
            this.btn_DeleteSO.Name = "btn_DeleteSO";
            this.btn_DeleteSO.Size = new System.Drawing.Size(75, 40);
            this.btn_DeleteSO.TabIndex = 14;
            this.btn_DeleteSO.Text = "Delete";
            this.btn_DeleteSO.UseVisualStyleBackColor = true;
            this.btn_DeleteSO.Click += new System.EventHandler(this.btn_DeleteSO_Click);
            // 
            // btn_EditSO
            // 
            this.btn_EditSO.Location = new System.Drawing.Point(1290, 351);
            this.btn_EditSO.Name = "btn_EditSO";
            this.btn_EditSO.Size = new System.Drawing.Size(75, 40);
            this.btn_EditSO.TabIndex = 14;
            this.btn_EditSO.Text = "Edit";
            this.btn_EditSO.UseVisualStyleBackColor = true;
            this.btn_EditSO.Click += new System.EventHandler(this.btn_EditSO_Click);
            // 
            // saleOrderDBTableAdapter
            // 
            this.saleOrderDBTableAdapter.ClearBeforeFill = true;
            // 
            // txt_SoNo
            // 
            this.txt_SoNo.Location = new System.Drawing.Point(119, 12);
            this.txt_SoNo.Name = "txt_SoNo";
            this.txt_SoNo.Size = new System.Drawing.Size(95, 20);
            this.txt_SoNo.TabIndex = 15;
            // 
            // SaleOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.txt_SoNo);
            this.Controls.Add(this.btn_EditSO);
            this.Controls.Add(this.btn_DeleteSO);
            this.Controls.Add(this.btn_ImportSO);
            this.Controls.Add(this.btn_ExportSO);
            this.Controls.Add(this.btn_CloseSO);
            this.Controls.Add(this.btn_DisplaySO);
            this.Controls.Add(this.btn_UpdateSO);
            this.Controls.Add(this.btn_SubmitNewSO);
            this.Controls.Add(this.btn_AddNewSO);
            this.Controls.Add(this.lbl_TotalAmountSO);
            this.Controls.Add(this.dg_SaleOrderReport);
            this.Controls.Add(this.tb_SaleProductDetails);
            this.Controls.Add(this.rt_Narration);
            this.Controls.Add(this.btn_SelectMSSaleOrder);
            this.Controls.Add(this.txt_TotalAmountSO);
            this.Controls.Add(this.txt_SaleOrderMS);
            this.Controls.Add(this.txt_SaleOrderSC);
            this.Controls.Add(this.lbl_Narration);
            this.Controls.Add(this.lbl_SaleOrderMS);
            this.Controls.Add(this.cbo_SaleOrderCurrency);
            this.Controls.Add(this.lbl_SaleOrderCurrency);
            this.Controls.Add(this.dt_SaleOrderDate);
            this.Controls.Add(this.lbl_SaleOrderDate);
            this.Controls.Add(this.lbl_SaleOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleOrder";
            this.Load += new System.EventHandler(this.SaleOrder_Load);
            this.tb_SaleProductDetails.ResumeLayout(false);
            this.tb_ProductDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ProductDetailsSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SaleOrderReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleOrderDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sale_OrderDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SaleOrder;
        private System.Windows.Forms.Label lbl_SaleOrderDate;
        private System.Windows.Forms.DateTimePicker dt_SaleOrderDate;
        private System.Windows.Forms.Label lbl_SaleOrderCurrency;
        private System.Windows.Forms.ComboBox cbo_SaleOrderCurrency;
        private System.Windows.Forms.Label lbl_SaleOrderMS;
        private System.Windows.Forms.Button btn_SelectMSSaleOrder;
        private System.Windows.Forms.Label lbl_Narration;
        private System.Windows.Forms.RichTextBox rt_Narration;
        private System.Windows.Forms.TabControl tb_SaleProductDetails;
        private System.Windows.Forms.TabPage tb_ProductDetails;
        private System.Windows.Forms.DataGridView dg_ProductDetailsSO;
        private System.Windows.Forms.DataGridView dg_SaleOrderReport;
        private Sale_OrderDBDataSet sale_OrderDBDataSet;
        private System.Windows.Forms.BindingSource saleOrderDBBindingSource;
        private Sale_OrderDBDataSetTableAdapters.SaleOrderDBTableAdapter saleOrderDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_TotalAmountSO;
        private System.Windows.Forms.TextBox txt_TotalAmountSO;
        private System.Windows.Forms.Button btn_AddNewSO;
        private System.Windows.Forms.Button btn_SubmitNewSO;
        private System.Windows.Forms.Button btn_UpdateSO;
        private System.Windows.Forms.Button btn_DisplaySO;
        private System.Windows.Forms.Button btn_CloseSO;
        private System.Windows.Forms.Button btn_ExportSO;
        private System.Windows.Forms.Button btn_ImportSO;
        private System.Windows.Forms.Button btn_DeleteSO;
        private System.Windows.Forms.Button btn_EditSO;
        public System.Windows.Forms.TextBox txt_SaleOrderSC;
        public System.Windows.Forms.TextBox txt_SaleOrderMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNoSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCodeSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCodeSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityCodeSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualitySO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateConvSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount1SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmountSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount2AmountSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3SO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount3AmountSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalDiscountedAmountSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPrimaryOrder;
        private System.Windows.Forms.TextBox txt_SoNo;
    }
}