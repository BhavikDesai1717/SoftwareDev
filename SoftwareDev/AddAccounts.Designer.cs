namespace SoftwareDev
{
    partial class AddAccounts
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
            this.lbl_AccountID = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AccountID
            // 
            this.lbl_AccountID.AutoSize = true;
            this.lbl_AccountID.Location = new System.Drawing.Point(107, 22);
            this.lbl_AccountID.Name = "lbl_AccountID";
            this.lbl_AccountID.Size = new System.Drawing.Size(0, 13);
            this.lbl_AccountID.TabIndex = 0;
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(30, 47);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(93, 15);
            this.lbl_Account.TabIndex = 0;
            this.lbl_Account.Text = "Account Name :";
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(129, 46);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(100, 20);
            this.txt_Account.TabIndex = 1;
            this.txt_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Account_KeyDown);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(90, 72);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            this.btn_Submit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Submit_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(90, 72);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(56, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Save_KeyDown);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(90, 72);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(40, 23);
            this.btn_Display.TabIndex = 2;
            this.btn_Display.Text = "OK";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            this.btn_Display.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Display_KeyDown);
            // 
            // AddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 116);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.lbl_AccountID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccounts";
            this.Load += new System.EventHandler(this.AddAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Account;
        public System.Windows.Forms.Label lbl_AccountID;
        public System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Display;
    }
}