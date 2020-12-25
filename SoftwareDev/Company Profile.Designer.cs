namespace SoftwareDev
{
    partial class Company_Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_ContactPerson = new System.Windows.Forms.TextBox();
            this.txt_ContactNumber = new System.Windows.Forms.TextBox();
            this.rt_Address = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_financial_Year = new System.Windows.Forms.DateTimePicker();
            this.dt_BooksYear = new System.Windows.Forms.DateTimePicker();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact Person :";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(200, 6);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(304, 20);
            this.txt_CompanyName.TabIndex = 1;
            // 
            // txt_ContactPerson
            // 
            this.txt_ContactPerson.Location = new System.Drawing.Point(200, 176);
            this.txt_ContactPerson.Name = "txt_ContactPerson";
            this.txt_ContactPerson.Size = new System.Drawing.Size(304, 20);
            this.txt_ContactPerson.TabIndex = 1;
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.Location = new System.Drawing.Point(200, 122);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.Size = new System.Drawing.Size(304, 20);
            this.txt_ContactNumber.TabIndex = 1;
            // 
            // rt_Address
            // 
            this.rt_Address.Location = new System.Drawing.Point(200, 48);
            this.rt_Address.Name = "rt_Address";
            this.rt_Address.Size = new System.Drawing.Size(304, 52);
            this.rt_Address.TabIndex = 2;
            this.rt_Address.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Financial Year Starting From :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Books Beginning From :";
            // 
            // dt_financial_Year
            // 
            this.dt_financial_Year.Location = new System.Drawing.Point(200, 222);
            this.dt_financial_Year.Name = "dt_financial_Year";
            this.dt_financial_Year.Size = new System.Drawing.Size(126, 20);
            this.dt_financial_Year.TabIndex = 3;
            // 
            // dt_BooksYear
            // 
            this.dt_BooksYear.Location = new System.Drawing.Point(200, 269);
            this.dt_BooksYear.Name = "dt_BooksYear";
            this.dt_BooksYear.Size = new System.Drawing.Size(126, 20);
            this.dt_BooksYear.TabIndex = 3;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(405, 305);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(99, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update Details";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(429, 252);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Visible = false;
            // 
            // Company_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 340);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dt_BooksYear);
            this.Controls.Add(this.dt_financial_Year);
            this.Controls.Add(this.rt_Address);
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(this.txt_ContactPerson);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Company_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Profile";
            this.Load += new System.EventHandler(this.Company_Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.TextBox txt_ContactPerson;
        private System.Windows.Forms.TextBox txt_ContactNumber;
        private System.Windows.Forms.RichTextBox rt_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_financial_Year;
        private System.Windows.Forms.DateTimePicker dt_BooksYear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_ID;
    }
}