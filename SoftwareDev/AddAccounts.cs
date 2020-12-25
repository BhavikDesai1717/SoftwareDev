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
    public partial class AddAccounts : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddAccounts()
        {
            InitializeComponent();
        }

        private void AddAccounts_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.addAccountMaster))
            {
                btn_Submit.Visible = true;
                btn_Save.Visible = false;
                btn_Display.Visible = false;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editAccountMaster))
            {
                btn_Submit.Visible = false;
                btn_Save.Visible = true;
                btn_Display.Visible = false;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displayAccountMaster))
            {
                btn_Submit.Visible = false;
                btn_Save.Visible = false;
                btn_Display.Visible = true;
            }
        }
        private void submitAccount()
        {
            using(SqlConnection conCheck = new SqlConnection(conClient))
            {
                conCheck.Open();
                using(SqlCommand command = conCheck.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT (Account) FROM AccountDB WHERE Account=@aName";
                    command.Parameters.AddWithValue("@aName", txt_Account.Text.Trim());
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if(temp>0)
                    {
                        MessageBox.Show("Account Name - " + txt_Account.Text + " is already Registered");
                        txt_Account.Text = String.Empty;
                    }else
                    {
                        if (txt_Account.Text == "" || txt_Account.Text == null)
                        {
                            MessageBox.Show("Account Name field cannot be Empty");
                            txt_Account.Focus();
                        }
                        else
                        {
                            using (SqlConnection conA = new SqlConnection(conClient))
                            {
                                conA.Open();
                                using (SqlCommand cmd = conA.CreateCommand())
                                {
                                    cmd.CommandText = "INSERT INTO AccountDB (Account) VALUES (@accName)";
                                    cmd.Parameters.AddWithValue("@accName", txt_Account.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                }
                                conA.Close();
                            }
                            this.Close();
                            ButtonClicked.addAccountMaster = String.Empty;
                        }
                    }
                }
                conCheck.Close();
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            submitAccount();
        }
        private void saveAccount()
        {
            if (txt_Account.Text == "" || txt_Account.Text == null)
            {
                MessageBox.Show("Account Name field cannot be Empty");
                txt_Account.Focus();
            }
            else
            {
                using (SqlConnection conA = new SqlConnection(conClient))
                {
                    conA.Open();
                    using (SqlCommand cmd = conA.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE AccountDB SET Account=@aName WHERE SrNo=@aID";
                        cmd.Parameters.AddWithValue("@aName", txt_Account.Text.Trim());
                        cmd.Parameters.AddWithValue("@aID", lbl_AccountID.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conA.Close();
                }
                this.Close();
                ButtonClicked.editAccountMaster = String.Empty;
            }
        }
        private void txt_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    submitAccount();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveAccount();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displayAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displayAccountMaster = String.Empty;
                }
            }
        }

        private void btn_Submit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    submitAccount();
                }
            }
        }

        private void btn_Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.editAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveAccount();
                }
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            this.Close();
            ButtonClicked.displayAccountMaster = String.Empty;
        }

        private void btn_Display_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.displayAccountMaster))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displayAccountMaster = String.Empty;
                }
            }
        }
    }
}
