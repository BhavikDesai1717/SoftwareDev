namespace SoftwareDev
{
    partial class UserRoles
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
            this.roleLoginDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleLoginDataSet = new SoftwareDev.RoleLoginDataSet();
            this.gb_UserRoles = new System.Windows.Forms.GroupBox();
            this.lbl_PurchaseOrder = new System.Windows.Forms.Label();
            this.cbo_PODelete = new System.Windows.Forms.CheckBox();
            this.cbo_POEdit = new System.Windows.Forms.CheckBox();
            this.cbo_POCreate = new System.Windows.Forms.CheckBox();
            this.cbo_POView = new System.Windows.Forms.CheckBox();
            this.cbo_POFullAccess = new System.Windows.Forms.CheckBox();
            this.lbl_Delete = new System.Windows.Forms.Label();
            this.lbl_Edit = new System.Windows.Forms.Label();
            this.lbl_Create = new System.Windows.Forms.Label();
            this.lbl_View = new System.Windows.Forms.Label();
            this.lbl_FullAccess = new System.Windows.Forms.Label();
            this.roleLoginDBTableAdapter = new SoftwareDev.RoleLoginDataSetTableAdapters.roleLoginDBTableAdapter();
            this.lbl_UserRoleName = new System.Windows.Forms.Label();
            this.txt_RoleName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDataSet)).BeginInit();
            this.gb_UserRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // roleLoginDBBindingSource
            // 
            this.roleLoginDBBindingSource.DataMember = "roleLoginDB";
            this.roleLoginDBBindingSource.DataSource = this.roleLoginDataSet;
            // 
            // roleLoginDataSet
            // 
            this.roleLoginDataSet.DataSetName = "RoleLoginDataSet";
            this.roleLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb_UserRoles
            // 
            this.gb_UserRoles.Controls.Add(this.lbl_PurchaseOrder);
            this.gb_UserRoles.Controls.Add(this.cbo_PODelete);
            this.gb_UserRoles.Controls.Add(this.cbo_POEdit);
            this.gb_UserRoles.Controls.Add(this.cbo_POCreate);
            this.gb_UserRoles.Controls.Add(this.cbo_POView);
            this.gb_UserRoles.Controls.Add(this.cbo_POFullAccess);
            this.gb_UserRoles.Controls.Add(this.lbl_Delete);
            this.gb_UserRoles.Controls.Add(this.lbl_Edit);
            this.gb_UserRoles.Controls.Add(this.lbl_Create);
            this.gb_UserRoles.Controls.Add(this.lbl_View);
            this.gb_UserRoles.Controls.Add(this.lbl_FullAccess);
            this.gb_UserRoles.Location = new System.Drawing.Point(15, 41);
            this.gb_UserRoles.Name = "gb_UserRoles";
            this.gb_UserRoles.Size = new System.Drawing.Size(775, 320);
            this.gb_UserRoles.TabIndex = 1;
            this.gb_UserRoles.TabStop = false;
            this.gb_UserRoles.Text = "User Roles";
            // 
            // lbl_PurchaseOrder
            // 
            this.lbl_PurchaseOrder.AutoSize = true;
            this.lbl_PurchaseOrder.Location = new System.Drawing.Point(6, 56);
            this.lbl_PurchaseOrder.Name = "lbl_PurchaseOrder";
            this.lbl_PurchaseOrder.Size = new System.Drawing.Size(81, 13);
            this.lbl_PurchaseOrder.TabIndex = 2;
            this.lbl_PurchaseOrder.Text = "Purchase Order";
            // 
            // cbo_PODelete
            // 
            this.cbo_PODelete.AutoSize = true;
            this.cbo_PODelete.Location = new System.Drawing.Point(610, 55);
            this.cbo_PODelete.Name = "cbo_PODelete";
            this.cbo_PODelete.Size = new System.Drawing.Size(15, 14);
            this.cbo_PODelete.TabIndex = 1;
            this.cbo_PODelete.UseVisualStyleBackColor = true;
            // 
            // cbo_POEdit
            // 
            this.cbo_POEdit.AutoSize = true;
            this.cbo_POEdit.Location = new System.Drawing.Point(497, 55);
            this.cbo_POEdit.Name = "cbo_POEdit";
            this.cbo_POEdit.Size = new System.Drawing.Size(15, 14);
            this.cbo_POEdit.TabIndex = 1;
            this.cbo_POEdit.UseVisualStyleBackColor = true;
            // 
            // cbo_POCreate
            // 
            this.cbo_POCreate.AutoSize = true;
            this.cbo_POCreate.Location = new System.Drawing.Point(384, 55);
            this.cbo_POCreate.Name = "cbo_POCreate";
            this.cbo_POCreate.Size = new System.Drawing.Size(15, 14);
            this.cbo_POCreate.TabIndex = 1;
            this.cbo_POCreate.UseVisualStyleBackColor = true;
            // 
            // cbo_POView
            // 
            this.cbo_POView.AutoSize = true;
            this.cbo_POView.Location = new System.Drawing.Point(271, 55);
            this.cbo_POView.Name = "cbo_POView";
            this.cbo_POView.Size = new System.Drawing.Size(15, 14);
            this.cbo_POView.TabIndex = 1;
            this.cbo_POView.UseVisualStyleBackColor = true;
            // 
            // cbo_POFullAccess
            // 
            this.cbo_POFullAccess.AutoSize = true;
            this.cbo_POFullAccess.Location = new System.Drawing.Point(158, 55);
            this.cbo_POFullAccess.Name = "cbo_POFullAccess";
            this.cbo_POFullAccess.Size = new System.Drawing.Size(15, 14);
            this.cbo_POFullAccess.TabIndex = 1;
            this.cbo_POFullAccess.UseVisualStyleBackColor = true;
            this.cbo_POFullAccess.CheckedChanged += new System.EventHandler(this.cbo_POFullAccess_CheckedChanged);
            // 
            // lbl_Delete
            // 
            this.lbl_Delete.AutoSize = true;
            this.lbl_Delete.Location = new System.Drawing.Point(601, 16);
            this.lbl_Delete.Name = "lbl_Delete";
            this.lbl_Delete.Size = new System.Drawing.Size(38, 13);
            this.lbl_Delete.TabIndex = 0;
            this.lbl_Delete.Text = "Delete";
            // 
            // lbl_Edit
            // 
            this.lbl_Edit.AutoSize = true;
            this.lbl_Edit.Location = new System.Drawing.Point(487, 16);
            this.lbl_Edit.Name = "lbl_Edit";
            this.lbl_Edit.Size = new System.Drawing.Size(25, 13);
            this.lbl_Edit.TabIndex = 0;
            this.lbl_Edit.Text = "Edit";
            // 
            // lbl_Create
            // 
            this.lbl_Create.AutoSize = true;
            this.lbl_Create.Location = new System.Drawing.Point(381, 16);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(38, 13);
            this.lbl_Create.TabIndex = 0;
            this.lbl_Create.Text = "Create";
            // 
            // lbl_View
            // 
            this.lbl_View.AutoSize = true;
            this.lbl_View.Location = new System.Drawing.Point(268, 16);
            this.lbl_View.Name = "lbl_View";
            this.lbl_View.Size = new System.Drawing.Size(30, 13);
            this.lbl_View.TabIndex = 0;
            this.lbl_View.Text = "View";
            // 
            // lbl_FullAccess
            // 
            this.lbl_FullAccess.AutoSize = true;
            this.lbl_FullAccess.Location = new System.Drawing.Point(139, 16);
            this.lbl_FullAccess.Name = "lbl_FullAccess";
            this.lbl_FullAccess.Size = new System.Drawing.Size(61, 13);
            this.lbl_FullAccess.TabIndex = 0;
            this.lbl_FullAccess.Text = "Full Access";
            // 
            // roleLoginDBTableAdapter
            // 
            this.roleLoginDBTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_UserRoleName
            // 
            this.lbl_UserRoleName.AutoSize = true;
            this.lbl_UserRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserRoleName.Location = new System.Drawing.Point(12, 9);
            this.lbl_UserRoleName.Name = "lbl_UserRoleName";
            this.lbl_UserRoleName.Size = new System.Drawing.Size(76, 15);
            this.lbl_UserRoleName.TabIndex = 2;
            this.lbl_UserRoleName.Text = "Role Name :";
            // 
            // txt_RoleName
            // 
            this.txt_RoleName.Location = new System.Drawing.Point(95, 9);
            this.txt_RoleName.Name = "txt_RoleName";
            this.txt_RoleName.Size = new System.Drawing.Size(100, 20);
            this.txt_RoleName.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(714, 367);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 40);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UserRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_RoleName);
            this.Controls.Add(this.lbl_UserRoleName);
            this.Controls.Add(this.gb_UserRoles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRoles";
            this.Load += new System.EventHandler(this.UserRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLoginDataSet)).EndInit();
            this.gb_UserRoles.ResumeLayout(false);
            this.gb_UserRoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_UserRoles;
        private System.Windows.Forms.Label lbl_Delete;
        private System.Windows.Forms.Label lbl_Edit;
        private System.Windows.Forms.Label lbl_Create;
        private System.Windows.Forms.Label lbl_View;
        private System.Windows.Forms.Label lbl_PurchaseOrder;
        private System.Windows.Forms.CheckBox cbo_PODelete;
        private System.Windows.Forms.CheckBox cbo_POEdit;
        private System.Windows.Forms.CheckBox cbo_POCreate;
        private System.Windows.Forms.CheckBox cbo_POView;
        private System.Windows.Forms.CheckBox cbo_POFullAccess;
        private System.Windows.Forms.Label lbl_FullAccess;
        private RoleLoginDataSet roleLoginDataSet;
        private System.Windows.Forms.BindingSource roleLoginDBBindingSource;
        private RoleLoginDataSetTableAdapters.roleLoginDBTableAdapter roleLoginDBTableAdapter;
        private System.Windows.Forms.Label lbl_UserRoleName;
        private System.Windows.Forms.TextBox txt_RoleName;
        private System.Windows.Forms.Button btn_Save;
    }
}