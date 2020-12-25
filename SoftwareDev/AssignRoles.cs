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
    public partial class AssignRoles : Form
    {
        static string conRole = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.RoleLoginConnectionString"].ConnectionString;
        public AssignRoles()
        {
            InitializeComponent();
        }

        private void AssignRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roleLoginDataSet.rolePermissionsDB' table. You can move, or remove it, as needed.
            this.rolePermissionsDBTableAdapter.Fill(this.roleLoginDataSet.rolePermissionsDB);
            // TODO: This line of code loads data into the 'roleLoginDataSet.roleLoginDB' table. You can move, or remove it, as needed.
            this.roleLoginDBTableAdapter.Fill(this.roleLoginDataSet.roleLoginDB);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            refreshRoleCombo();
            refreshUserCombo();
        }
        private void refreshUserCombo()
        {
            using (SqlConnection conU = new SqlConnection(conRole))
            {
                conU.Open();
                using (SqlCommand cmd = conU.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM roleLoginDB";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbo_UserName.Items.Add(dr["username"].ToString());
                        cbo_UserName.ValueMember = dr["id"].ToString();
                        cbo_UserName.DisplayMember = dr["username"].ToString();
                    }
                }
                conU.Close();
            }
        }
        private void newUser()
        {
            UserSignUp userSignUp = new UserSignUp();
            userSignUp.ShowDialog();
            cbo_UserName.Items.Clear();
            refreshUserCombo();
        }
        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            newUser();
        }
        private void refreshRoleCombo()
        {
            using (SqlConnection conR = new SqlConnection(conRole))
            {
                conR.Open();
                using(SqlCommand cmd = conR.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM rolePermissionsDB";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        cbo_RoleAssigned.Items.Add(dr["Role_Name"].ToString());
                        cbo_RoleAssigned.ValueMember = dr["id"].ToString();
                        cbo_RoleAssigned.DisplayMember = dr["Role_Name"].ToString();
                    }
                }
                conR.Close();
            }
        }
        private void newRole()
        {
            UserRoles userRoles = new UserRoles();
            userRoles.ShowDialog();
            cbo_RoleAssigned.Items.Clear();
            refreshRoleCombo();
        }
        private void btn_NewRole_Click(object sender, EventArgs e)
        {
            newRole();
        }

        private void saveRoleAssigned()
        {
            if (cbo_UserName.Text == "")
            {
                MessageBox.Show("Please Enter the Username");
            }
            else if (cbo_RoleAssigned.Text == "")
            {
                MessageBox.Show("Please Assign a Role to the user");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    using (SqlConnection conUpdate = new SqlConnection(conRole))
                    {
                        conUpdate.Open();
                        using (SqlCommand cmd = conUpdate.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE roleLoginDB SET type=@roleAssigned WHERE username=@user";
                            cmd.Parameters.AddWithValue("@roleAssigned", cbo_RoleAssigned.Text.Trim());
                            cmd.Parameters.AddWithValue("@user", cbo_UserName.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        conUpdate.Close();
                    }
                    cbo_UserName.Text = String.Empty;
                    cbo_RoleAssigned.Text = String.Empty;
                }
            }
        }
        private void btn_SaveAssigned_Click(object sender, EventArgs e)
        {
            saveRoleAssigned();
        }

        private void AssignRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveRoleAssigned();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                newUser();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                newRole();
            }
        }

        private void btn_SaveAssigned_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveRoleAssigned();
            }
        }

        private void btn_NewUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                newUser();
            }
        }

        private void btn_NewRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                newRole();
            }
        }

        private void cbo_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveRoleAssigned();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                newUser();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                newRole();
            }
        }

        private void cbo_RoleAssigned_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveRoleAssigned();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                newUser();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                newRole();
            }
        }
    }
}
