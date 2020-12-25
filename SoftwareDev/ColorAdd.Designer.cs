namespace SoftwareDev
{
    partial class ColorAdd
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
            this.dgColorSelect = new System.Windows.Forms.DataGridView();
            this.srNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColorDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.productColorDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgColorSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgColorSelect
            // 
            this.dgColorSelect.AllowUserToAddRows = false;
            this.dgColorSelect.AllowUserToDeleteRows = false;
            this.dgColorSelect.AutoGenerateColumns = false;
            this.dgColorSelect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgColorSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgColorSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srNoDataGridViewTextBoxColumn,
            this.ColorCode,
            this.productColorDataGridViewTextBoxColumn});
            this.dgColorSelect.DataSource = this.productColorDBBindingSource;
            this.dgColorSelect.Location = new System.Drawing.Point(12, 38);
            this.dgColorSelect.Name = "dgColorSelect";
            this.dgColorSelect.ReadOnly = true;
            this.dgColorSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgColorSelect.Size = new System.Drawing.Size(343, 235);
            this.dgColorSelect.TabIndex = 0;
            this.dgColorSelect.TabStop = false;
            this.dgColorSelect.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dgColorSelect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgColorSelect_KeyDown);
            // 
            // srNoDataGridViewTextBoxColumn
            // 
            this.srNoDataGridViewTextBoxColumn.DataPropertyName = "SrNo";
            this.srNoDataGridViewTextBoxColumn.HeaderText = "SrNo";
            this.srNoDataGridViewTextBoxColumn.Name = "srNoDataGridViewTextBoxColumn";
            this.srNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColorCode
            // 
            this.ColorCode.DataPropertyName = "ColorCode";
            this.ColorCode.HeaderText = "ColorCode";
            this.ColorCode.Name = "ColorCode";
            this.ColorCode.ReadOnly = true;
            // 
            // productColorDataGridViewTextBoxColumn
            // 
            this.productColorDataGridViewTextBoxColumn.DataPropertyName = "ProductColor";
            this.productColorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.productColorDataGridViewTextBoxColumn.Name = "productColorDataGridViewTextBoxColumn";
            this.productColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productColorDBBindingSource
            // 
            this.productColorDBBindingSource.DataMember = "ProductColorDB";
            this.productColorDBBindingSource.DataSource = this.client_DatabaseDataSet;
            // 
            // client_DatabaseDataSet
            // 
            this.client_DatabaseDataSet.DataSetName = "Client_DatabaseDataSet";
            this.client_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productColorDBTableAdapter
            // 
            this.productColorDBTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(280, 279);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNew.TabIndex = 2;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            this.btn_AddNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_AddNew_KeyDown);
            // 
            // ColorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 317);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgColorSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorAdd";
            this.Load += new System.EventHandler(this.ColorAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgColorSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productColorDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productColorDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.ProductColorDBTableAdapter productColorDBTableAdapter;
        public System.Windows.Forms.DataGridView dgColorSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AddNew;
    }
}