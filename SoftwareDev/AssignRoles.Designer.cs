namespace SoftwareDev
{
    partial class AssignRoles
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_RoleAssigned = new System.Windows.Forms.Label();
            this.btn_SaveAssigned = new System.Windows.Forms.Button();
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.btn_NewRole = new System.Windows.Forms.Button();
            this.cbo_UserName = new System.Windows.Forms.ComboBox();
            this.cbo_RoleAssigned = new System.Windows.Forms.ComboBox();
            this.roleLoginDataSet = new SoftwareDev.RoleLoginDataSet();
            this.roleLoginDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleLoginDBTableAdapter = new SoftwareDev.RoleLoginDataSetTableAdapters.roleLoginDBTableAdapter();
            this.rolePermissionsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolePermissionsDBTableAdapter = new SoftwareDev.RoleLoginDataSetTableAdapters.rolePermissionsDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePermissionsDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(33, 53);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(71, 15);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "Username :";
            // 
            // lbl_RoleAssigned
            // 
            this.lbl_RoleAssigned.AutoSize = true;
            this.lbl_RoleAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoleAssigned.Location = new System.Drawing.Point(12, 94);
            this.lbl_RoleAssigned.Name = "lbl_RoleAssigned";
            this.lbl_RoleAssigned.Size = new System.Drawing.Size(92, 15);
            this.lbl_RoleAssigned.TabIndex = 0;
            this.lbl_RoleAssigned.Text = "Role Assigned :";
            // 
            // btn_SaveAssigned
            // 
            this.btn_SaveAssigned.Location = new System.Drawing.Point(36, 128);
            this.btn_SaveAssigned.Name = "btn_SaveAssigned";
            this.btn_SaveAssigned.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveAssigned.TabIndex = 2;
            this.btn_SaveAssigned.Text = "&Save";
            this.btn_SaveAssigned.UseVisualStyleBackColor = true;
            this.btn_SaveAssigned.Click += new System.EventHandler(this.btn_SaveAssigned_Click);
            this.btn_SaveAssigned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveAssigned_KeyDown);
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.Location = new System.Drawing.Point(138, 128);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(75, 23);
            this.btn_NewUser.TabIndex = 3;
            this.btn_NewUser.Text = "New &User";
            this.btn_NewUser.UseVisualStyleBackColor = true;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            this.btn_NewUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_NewUser_KeyDown);
            // 
            // btn_NewRole
            // 
            this.btn_NewRole.Location = new System.Drawing.Point(240, 128);
            this.btn_NewRole.Name = "btn_NewRole";
            this.btn_NewRole.Size = new System.Drawing.Size(75, 23);
            this.btn_NewRole.TabIndex = 4;
            this.btn_NewRole.Text = "New &Role";
            this.btn_NewRole.UseVisualStyleBackColor = true;
            this.btn_NewRole.Click += new System.EventHandler(this.btn_NewRole_Click);
            this.btn_NewRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_NewRole_KeyDown);
            // 
            // cbo_UserName
            // 
            this.cbo_UserName.FormattingEnabled = true;
            this.cbo_UserName.Location = new System.Drawing.Point(110, 52);
            this.cbo_UserName.Name = "cbo_UserName";
            this.cbo_UserName.Size = new System.Drawing.Size(205, 21);
            this.cbo_UserName.TabIndex = 0;
            this.cbo_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_UserName_KeyDown);
            // 
            // cbo_RoleAssigned
            // 
            this.cbo_RoleAssigned.FormattingEnabled = true;
            this.cbo_RoleAssigned.Location = new System.Drawing.Point(110, 93);
            this.cbo_RoleAssigned.Name = "cbo_RoleAssigned";
            this.cbo_RoleAssigned.Size = new System.Drawing.Size(205, 21);
            this.cbo_RoleAssigned.TabIndex = 1;
            this.cbo_RoleAssigned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_RoleAssigned_KeyDown);
            // 
            // roleLoginDataSet
            // 
            this.roleLoginDataSet.DataSetName = "RoleLoginDataSet";
            this.roleLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleLoginDBBindingSource
            // 
            this.roleLoginDBBindingSource.DataMember = "roleLoginDB";
            this.roleLoginDBBindingSource.DataSource = this.roleLoginDataSet;
            // 
            // roleLoginDBTableAdapter
            // 
            this.roleLoginDBTableAdapter.ClearBeforeFill = true;
            // 
            // rolePermissionsDBBindingSource
            // 
            this.rolePermissionsDBBindingSource.DataMember = "rolePermissionsDB";
            this.rolePermissionsDBBindingSource.DataSource = this.roleLoginDataSet;
            // 
            // rolePermissionsDBTableAdapter
            // 
            this.rolePermissionsDBTableAdapter.ClearBeforeFill = true;
            // 
            // AssignRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 238);
            this.Controls.Add(this.cbo_RoleAssigned);
            this.Controls.Add(this.cbo_UserName);
            this.Controls.Add(this.btn_NewRole);
            this.Controls.Add(this.btn_NewUser);
            this.Controls.Add(this.btn_SaveAssigned);
            this.Controls.Add(this.lbl_RoleAssigned);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "AssignRoles";
            this.Text = "AssignRoles";
            this.Load += new System.EventHandler(this.AssignRoles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssignRoles_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePermissionsDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_RoleAssigned;
        private System.Windows.Forms.Button btn_SaveAssigned;
        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.Button btn_NewRole;
        private System.Windows.Forms.ComboBox cbo_UserName;
        private System.Windows.Forms.ComboBox cbo_RoleAssigned;
        private RoleLoginDataSet roleLoginDataSet;
        private System.Windows.Forms.BindingSource roleLoginDBBindingSource;
        private RoleLoginDataSetTableAdapters.roleLoginDBTableAdapter roleLoginDBTableAdapter;
        private System.Windows.Forms.BindingSource rolePermissionsDBBindingSource;
        private RoleLoginDataSetTableAdapters.rolePermissionsDBTableAdapter rolePermissionsDBTableAdapter;
    }
}