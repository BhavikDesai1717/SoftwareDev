using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SoftwareDev
{
    public partial class UserRoles : Form
    {
        static string conRole = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.RoleLoginConnectionString"].ConnectionString;
        public UserRoles()
        {
            InitializeComponent();
        }

        private void UserRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roleLoginDataSet.roleLoginDB' table. You can move, or remove it, as needed.
            this.roleLoginDBTableAdapter.Fill(this.roleLoginDataSet.roleLoginDB);

        }

        private void cbo_POFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if(cbo_POFullAccess.CheckState == CheckState.Checked)
            {
                cbo_POView.CheckState = CheckState.Checked;
                cbo_POCreate.CheckState = CheckState.Checked;
                cbo_POEdit.CheckState = CheckState.Checked;
                cbo_PODelete.CheckState = CheckState.Checked;
                cbo_POView.Enabled = false;
                cbo_POCreate.Enabled = false;
                cbo_POEdit.Enabled = false;
                cbo_PODelete.Enabled = false;
            }else if(cbo_POFullAccess.CheckState == CheckState.Unchecked)
            {
                cbo_POView.CheckState = CheckState.Unchecked;
                cbo_POCreate.CheckState = CheckState.Unchecked;
                cbo_POEdit.CheckState = CheckState.Unchecked;
                cbo_PODelete.CheckState = CheckState.Unchecked;
                cbo_POView.Enabled = true;
                cbo_POCreate.Enabled = true;
                cbo_POEdit.Enabled = true;
                cbo_PODelete.Enabled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text == "")
            {
                MessageBox.Show("Enter Role Name field");
            }else
            {
                string poFullAccess = cbo_POFullAccess.Checked ? "Yes" : "No";
                string poView = cbo_POView.Checked ? "Yes" : "No";
                string poCreate = cbo_POCreate.Checked ? "Yes" : "No";
                string poEdit = cbo_POEdit.Checked ? "Yes" : "No";
                string poDelete = cbo_PODelete.Checked ? "Yes" : "No";
                using (SqlConnection conR = new SqlConnection(conRole))
                {
                    conR.Open();
                    using(SqlCommand cmd = conR.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO rolePermissionsDB(Role_Name,POFullAccess,POView,POCreate,POEdit,PODelete) VALUES(@roleName,@poFullAccess,@poView,@poCreate,@poEdit,@poDelete)";
                        cmd.Parameters.AddWithValue("@roleName", txt_RoleName.Text);
                        cmd.Parameters.AddWithValue("@poFullAccess", poFullAccess);
                        cmd.Parameters.AddWithValue("@poView", poView);
                        cmd.Parameters.AddWithValue("@poCreate", poCreate);
                        cmd.Parameters.AddWithValue("@poEdit", poEdit);
                        cmd.Parameters.AddWithValue("@poDelete", poDelete);
                        cmd.ExecuteNonQuery();
                    }
                    conR.Close();
                }
                this.Close();
            }
        }
    }
}
