namespace SoftwareDev
{
    partial class Assortment
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
            this.lbl_ColorCode = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Assort = new System.Windows.Forms.Button();
            this.lbl_Lot = new System.Windows.Forms.Label();
            this.lbl_SizeCode = new System.Windows.Forms.Label();
            this.lbl_QualityCode = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_AvgRate = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productColorDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productColorDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter();
            this.productSizeDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSizeDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter();
            this.productQualityDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productQualityDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter();
            this.txt_Lot = new System.Windows.Forms.TextBox();
            this.btn_Fetch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FinalQuantity = new System.Windows.Forms.TextBox();
            this.txt_AvgRate = new System.Windows.Forms.TextBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Quality = new System.Windows.Forms.Label();
            this.txt_ColorCode = new System.Windows.Forms.TextBox();
            this.txt_SizeCode = new System.Windows.Forms.TextBox();
            this.txt_QualityCode = new System.Windows.Forms.TextBox();
            this.txt_Quality = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ColorCode
            // 
            this.lbl_ColorCode.AutoSize = true;
            this.lbl_ColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorCode.Location = new System.Drawing.Point(12, 9);
            this.lbl_ColorCode.Name = "lbl_ColorCode";
            this.lbl_ColorCode.Size = new System.Drawing.Size(82, 16);
            this.lbl_ColorCode.TabIndex = 0;
            this.lbl_ColorCode.Text = "Color Code :";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Location = new System.Drawing.Point(100, 124);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantity.TabIndex = 2;
            this.txt_Quantity.TabStop = false;
            // 
            // btn_Assort
            // 
            this.btn_Assort.Location = new System.Drawing.Point(990, 415);
            this.btn_Assort.Name = "btn_Assort";
            this.btn_Assort.Size = new System.Drawing.Size(75, 23);
            this.btn_Assort.TabIndex = 9;
            this.btn_Assort.Text = "Assort";
            this.btn_Assort.UseVisualStyleBackColor = true;
            this.btn_Assort.Click += new System.EventHandler(this.btn_Assort_Click);
            // 
            // lbl_Lot
            // 
            this.lbl_Lot.AutoSize = true;
            this.lbl_Lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lot.Location = new System.Drawing.Point(528, 9);
            this.lbl_Lot.Name = "lbl_Lot";
            this.lbl_Lot.Size = new System.Drawing.Size(32, 16);
            this.lbl_Lot.TabIndex = 0;
            this.lbl_Lot.Text = "Lot :";
            // 
            // lbl_SizeCode
            // 
            this.lbl_SizeCode.AutoSize = true;
            this.lbl_SizeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeCode.Location = new System.Drawing.Point(183, 9);
            this.lbl_SizeCode.Name = "lbl_SizeCode";
            this.lbl_SizeCode.Size = new System.Drawing.Size(76, 16);
            this.lbl_SizeCode.TabIndex = 0;
            this.lbl_SizeCode.Text = "Size Code :";
            // 
            // lbl_QualityCode
            // 
            this.lbl_QualityCode.AutoSize = true;
            this.lbl_QualityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QualityCode.Location = new System.Drawing.Point(348, 9);
            this.lbl_QualityCode.Name = "lbl_QualityCode";
            this.lbl_QualityCode.Size = new System.Drawing.Size(91, 16);
            this.lbl_QualityCode.TabIndex = 0;
            this.lbl_QualityCode.Text = "Quality Code :";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(32, 125);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(62, 16);
            this.lbl_Quantity.TabIndex = 0;
            this.lbl_Quantity.Text = "Quantity :";
            // 
            // lbl_AvgRate
            // 
            this.lbl_AvgRate.AutoSize = true;
            this.lbl_AvgRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AvgRate.Location = new System.Drawing.Point(206, 125);
            this.lbl_AvgRate.Name = "lbl_AvgRate";
            this.lbl_AvgRate.Size = new System.Drawing.Size(70, 16);
            this.lbl_AvgRate.TabIndex = 0;
            this.lbl_AvgRate.Text = "Avg Rate :";
            // 
            // txt_Rate
            // 
            this.txt_Rate.Enabled = false;
            this.txt_Rate.Location = new System.Drawing.Point(282, 124);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(100, 20);
            this.txt_Rate.TabIndex = 2;
            this.txt_Rate.TabStop = false;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productColorDBBindingSource
            // 
            this.productColorDBBindingSource.DataMember = "ProductColorDB";
            this.productColorDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // productColorDBTableAdapter
            // 
            this.productColorDBTableAdapter.ClearBeforeFill = true;
            // 
            // productSizeDBBindingSource
            // 
            this.productSizeDBBindingSource.DataMember = "ProductSizeDB";
            this.productSizeDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // productSizeDBTableAdapter
            // 
            this.productSizeDBTableAdapter.ClearBeforeFill = true;
            // 
            // productQualityDBBindingSource
            // 
            this.productQualityDBBindingSource.DataMember = "ProductQualityDB";
            this.productQualityDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // productQualityDBTableAdapter
            // 
            this.productQualityDBTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Lot
            // 
            this.txt_Lot.Location = new System.Drawing.Point(566, 8);
            this.txt_Lot.Name = "txt_Lot";
            this.txt_Lot.Size = new System.Drawing.Size(77, 20);
            this.txt_Lot.TabIndex = 6;
            this.txt_Lot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Lot_KeyDown);
            // 
            // btn_Fetch
            // 
            this.btn_Fetch.Location = new System.Drawing.Point(649, 6);
            this.btn_Fetch.Name = "btn_Fetch";
            this.btn_Fetch.Size = new System.Drawing.Size(76, 23);
            this.btn_Fetch.TabIndex = 7;
            this.btn_Fetch.Text = "Fetch";
            this.btn_Fetch.UseVisualStyleBackColor = true;
            this.btn_Fetch.Click += new System.EventHandler(this.btn_Fetch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ColorCode,
            this.Color,
            this.SizeCode,
            this.Size,
            this.QualityCode,
            this.Quality,
            this.Lot,
            this.Quantity,
            this.Rate});
            this.dataGridView1.Location = new System.Drawing.Point(15, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 233);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            // 
            // ColorCode
            // 
            this.ColorCode.HeaderText = "Color Code";
            this.ColorCode.Name = "ColorCode";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SizeCode
            // 
            this.SizeCode.HeaderText = "Size Code";
            this.SizeCode.Name = "SizeCode";
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QualityCode
            // 
            this.QualityCode.HeaderText = "Quality Code";
            this.QualityCode.Name = "QualityCode";
            // 
            // Quality
            // 
            this.Quality.HeaderText = "Quality";
            this.Quality.Name = "Quality";
            this.Quality.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lot
            // 
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Rate
            // 
            dataGridViewCellStyle1.NullValue = "0.00";
            this.Rate.DefaultCellStyle = dataGridViewCellStyle1;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(892, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Avg Rate :";
            // 
            // txt_FinalQuantity
            // 
            this.txt_FinalQuantity.Enabled = false;
            this.txt_FinalQuantity.Location = new System.Drawing.Point(786, 389);
            this.txt_FinalQuantity.Name = "txt_FinalQuantity";
            this.txt_FinalQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt_FinalQuantity.TabIndex = 2;
            this.txt_FinalQuantity.TabStop = false;
            // 
            // txt_AvgRate
            // 
            this.txt_AvgRate.Enabled = false;
            this.txt_AvgRate.Location = new System.Drawing.Point(968, 389);
            this.txt_AvgRate.Name = "txt_AvgRate";
            this.txt_AvgRate.Size = new System.Drawing.Size(97, 20);
            this.txt_AvgRate.TabIndex = 2;
            this.txt_AvgRate.TabStop = false;
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color.Location = new System.Drawing.Point(48, 35);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(46, 16);
            this.lbl_Color.TabIndex = 0;
            this.lbl_Color.Text = "Color :";
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.Location = new System.Drawing.Point(219, 35);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(40, 16);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size :";
            // 
            // lbl_Quality
            // 
            this.lbl_Quality.AutoSize = true;
            this.lbl_Quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quality.Location = new System.Drawing.Point(384, 35);
            this.lbl_Quality.Name = "lbl_Quality";
            this.lbl_Quality.Size = new System.Drawing.Size(55, 16);
            this.lbl_Quality.TabIndex = 0;
            this.lbl_Quality.Text = "Quality :";
            // 
            // txt_ColorCode
            // 
            this.txt_ColorCode.Location = new System.Drawing.Point(100, 8);
            this.txt_ColorCode.Name = "txt_ColorCode";
            this.txt_ColorCode.Size = new System.Drawing.Size(77, 20);
            this.txt_ColorCode.TabIndex = 0;
            this.txt_ColorCode.TextChanged += new System.EventHandler(this.txt_ColorCode_TextChanged);
            this.txt_ColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ColorCode_KeyDown);
            // 
            // txt_SizeCode
            // 
            this.txt_SizeCode.Location = new System.Drawing.Point(265, 8);
            this.txt_SizeCode.Name = "txt_SizeCode";
            this.txt_SizeCode.Size = new System.Drawing.Size(77, 20);
            this.txt_SizeCode.TabIndex = 2;
            this.txt_SizeCode.TextChanged += new System.EventHandler(this.txt_SizeCode_TextChanged);
            this.txt_SizeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SizeCode_KeyDown);
            // 
            // txt_QualityCode
            // 
            this.txt_QualityCode.Location = new System.Drawing.Point(445, 8);
            this.txt_QualityCode.Name = "txt_QualityCode";
            this.txt_QualityCode.Size = new System.Drawing.Size(77, 20);
            this.txt_QualityCode.TabIndex = 4;
            this.txt_QualityCode.TextChanged += new System.EventHandler(this.txt_QualityCode_TextChanged);
            this.txt_QualityCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_QualityCode_KeyDown);
            // 
            // txt_Quality
            // 
            this.txt_Quality.Location = new System.Drawing.Point(445, 34);
            this.txt_Quality.Name = "txt_Quality";
            this.txt_Quality.Size = new System.Drawing.Size(77, 20);
            this.txt_Quality.TabIndex = 5;
            this.txt_Quality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quality_KeyDown);
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(100, 34);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(77, 20);
            this.txt_Color.TabIndex = 1;
            this.txt_Color.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Color_KeyDown);
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(265, 34);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(77, 20);
            this.txt_Size.TabIndex = 3;
            this.txt_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Size_KeyDown);
            // 
            // Assortment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Fetch);
            this.Controls.Add(this.btn_Assort);
            this.Controls.Add(this.txt_Quality);
            this.Controls.Add(this.txt_QualityCode);
            this.Controls.Add(this.txt_SizeCode);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_ColorCode);
            this.Controls.Add(this.txt_Lot);
            this.Controls.Add(this.txt_AvgRate);
            this.Controls.Add(this.txt_Rate);
            this.Controls.Add(this.txt_FinalQuantity);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Quality);
            this.Controls.Add(this.lbl_QualityCode);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.lbl_SizeCode);
            this.Controls.Add(this.lbl_Lot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_AvgRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.lbl_ColorCode);
            this.Name = "Assortment";
            this.Text = "Assortment";
            this.Load += new System.EventHandler(this.Assortment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQualityDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ColorCode;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Assort;
        private System.Windows.Forms.Label lbl_Lot;
        private System.Windows.Forms.Label lbl_SizeCode;
        private System.Windows.Forms.Label lbl_QualityCode;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_AvgRate;
        private System.Windows.Forms.TextBox txt_Rate;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productColorDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter productColorDBTableAdapter;
        private System.Windows.Forms.BindingSource productSizeDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductSizeDBTableAdapter productSizeDBTableAdapter;
        private System.Windows.Forms.BindingSource productQualityDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductQualityDBTableAdapter productQualityDBTableAdapter;
        private System.Windows.Forms.TextBox txt_Lot;
        private System.Windows.Forms.Button btn_Fetch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FinalQuantity;
        private System.Windows.Forms.TextBox txt_AvgRate;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Quality;
        private System.Windows.Forms.TextBox txt_ColorCode;
        private System.Windows.Forms.TextBox txt_SizeCode;
        private System.Windows.Forms.TextBox txt_QualityCode;
        private System.Windows.Forms.TextBox txt_Quality;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}