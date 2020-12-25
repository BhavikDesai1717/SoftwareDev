namespace SoftwareDev
{
    partial class AddClient
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Account = new System.Windows.Forms.ComboBox();
            this.accountDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_DatabaseDataSet = new SoftwareDev.Client_DatabaseDataSet();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.accountDBTableAdapter = new SoftwareDev.Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter();
            this.lbl_ShortCode = new System.Windows.Forms.Label();
            this.txt_ShortCode = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(45, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(102, 9);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // cmb_Account
            // 
            this.cmb_Account.DataSource = this.accountDBBindingSource;
            this.cmb_Account.DisplayMember = "Account";
            this.cmb_Account.FormattingEnabled = true;
            this.cmb_Account.Location = new System.Drawing.Point(102, 108);
            this.cmb_Account.Name = "cmb_Account";
            this.cmb_Account.Size = new System.Drawing.Size(121, 21);
            this.cmb_Account.TabIndex = 2;
            this.cmb_Account.ValueMember = "Account";
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
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(61, 150);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(37, 74);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(59, 16);
            this.lbl_Country.TabIndex = 0;
            this.lbl_Country.Text = "Country :";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(34, 109);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(62, 16);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "Account :";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(102, 73);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 1;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(80, 150);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(56, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(102, 150);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(34, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Visible = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // accountDBTableAdapter
            // 
            this.accountDBTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_ShortCode
            // 
            this.lbl_ShortCode.AutoSize = true;
            this.lbl_ShortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShortCode.Location = new System.Drawing.Point(15, 42);
            this.lbl_ShortCode.Name = "lbl_ShortCode";
            this.lbl_ShortCode.Size = new System.Drawing.Size(81, 16);
            this.lbl_ShortCode.TabIndex = 0;
            this.lbl_ShortCode.Text = "Short Code :";
            // 
            // txt_ShortCode
            // 
            this.txt_ShortCode.Location = new System.Drawing.Point(102, 41);
            this.txt_ShortCode.Name = "txt_ShortCode";
            this.txt_ShortCode.Size = new System.Drawing.Size(100, 20);
            this.txt_ShortCode.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(15, 150);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Visible = false;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 178);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Account);
            this.Controls.Add(this.txt_ShortCode);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.lbl_ShortCode);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Ok;
        private Client_DatabaseDataSet client_DatabaseDataSet;
        private System.Windows.Forms.BindingSource accountDBBindingSource;
        private Client_DatabaseDataSetTableAdapters.AccountDBTableAdapter accountDBTableAdapter;
        private System.Windows.Forms.Label lbl_ShortCode;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.ComboBox cmb_Account;
        public System.Windows.Forms.TextBox txt_Country;
        public System.Windows.Forms.TextBox txt_ShortCode;
        public System.Windows.Forms.Label lbl_ID;
    }
}