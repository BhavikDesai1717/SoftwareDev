namespace SoftwareDev
{
    partial class Add_Broker
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.rt_Address = new System.Windows.Forms.RichTextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_ContactNo = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_ContactNo = new System.Windows.Forms.TextBox();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(39, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(51, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(96, 13);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(388, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // rt_Address
            // 
            this.rt_Address.Location = new System.Drawing.Point(96, 39);
            this.rt_Address.Name = "rt_Address";
            this.rt_Address.Size = new System.Drawing.Size(388, 44);
            this.rt_Address.TabIndex = 2;
            this.rt_Address.Text = "";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(409, 141);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(25, 52);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(65, 16);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address :";
            // 
            // lbl_ContactNo
            // 
            this.lbl_ContactNo.AutoSize = true;
            this.lbl_ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactNo.Location = new System.Drawing.Point(10, 116);
            this.lbl_ContactNo.Name = "lbl_ContactNo";
            this.lbl_ContactNo.Size = new System.Drawing.Size(80, 16);
            this.lbl_ContactNo.TabIndex = 0;
            this.lbl_ContactNo.Text = "Contact No.:";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(31, 90);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(59, 16);
            this.lbl_Country.TabIndex = 0;
            this.lbl_Country.Text = "Country :";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(179, 90);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(45, 16);
            this.lbl_State.TabIndex = 0;
            this.lbl_State.Text = "State :";
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PostalCode.Location = new System.Drawing.Point(313, 90);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(88, 16);
            this.lbl_PostalCode.TabIndex = 0;
            this.lbl_PostalCode.Text = "Postal Code :";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(444, 141);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(40, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(426, 141);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(58, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(96, 89);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(77, 20);
            this.txt_Country.TabIndex = 1;
            // 
            // txt_ContactNo
            // 
            this.txt_ContactNo.Location = new System.Drawing.Point(96, 115);
            this.txt_ContactNo.Name = "txt_ContactNo";
            this.txt_ContactNo.Size = new System.Drawing.Size(388, 20);
            this.txt_ContactNo.TabIndex = 1;
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(230, 89);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(77, 20);
            this.txt_State.TabIndex = 1;
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(407, 89);
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(77, 20);
            this.txt_PostalCode.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(10, 141);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Visible = false;
            // 
            // Add_Broker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 170);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rt_Address);
            this.Controls.Add(this.txt_ContactNo);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.txt_State);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_PostalCode);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_ContactNo);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Broker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Broker";
            this.Load += new System.EventHandler(this.Add_Broker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_ContactNo;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.TextBox txt_Name;
        public System.Windows.Forms.RichTextBox rt_Address;
        public System.Windows.Forms.TextBox txt_Country;
        public System.Windows.Forms.TextBox txt_ContactNo;
        public System.Windows.Forms.TextBox txt_State;
        public System.Windows.Forms.TextBox txt_PostalCode;
        public System.Windows.Forms.Label lbl_ID;
    }
}