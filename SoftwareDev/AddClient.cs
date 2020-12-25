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
    public partial class AddClient : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.AccountDB' table. You can move, or remove it, as needed.
            this.accountDBTableAdapter.Fill(this.client_DatabaseDataSet.AccountDB);
            if(!string.IsNullOrEmpty(ButtonClicked.addClientMaster))
            {
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_Ok.Visible = false;
                ButtonClicked.addClientMaster = String.Empty;
            }
            else if (!string.IsNullOrEmpty(ButtonClicked.editClientMaster))
            {
                btn_Add.Visible = false;
                btn_Edit.Visible = true;
                btn_Ok.Visible = false;
                ButtonClicked.editClientMaster = String.Empty;
            }
            else if (!string.IsNullOrEmpty(ButtonClicked.displayClientMaster))
            {
                btn_Add.Visible = false;
                btn_Edit.Visible = false;
                btn_Ok.Visible = true;
                ButtonClicked.displayClientMaster = String.Empty;
            }
        }
        private void addClient()
        {
            using (SqlConnection conCheck = new SqlConnection(conClient))
            {
                conCheck.Open();
                using (SqlCommand command = conCheck.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT (ShortCode) FROM ClientDB WHERE ShortCode=@codeCheck";
                    command.Parameters.AddWithValue("@codeCheck", txt_ShortCode.Text.Trim());
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (temp > 0)
                    {
                        MessageBox.Show("Short Code - " + txt_ShortCode.Text.Trim() + " is already Registered");
                        txt_ShortCode.Text = String.Empty;
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            using (SqlConnection conC = new SqlConnection(conClient))
                            {
                                conC.Open();
                                using (SqlCommand cmd = conC.CreateCommand())
                                {
                                    cmd.CommandText = "INSERT INTO ClientDB (Name,ShortCode,Country,Account) VALUES (@cName,@cCode,@cCountry,@cAccount)";
                                    cmd.Parameters.AddWithValue("@cName", txt_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cCode", txt_ShortCode.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cCountry", txt_Country.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cAccount", cmb_Account.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                }
                                conC.Close();
                            }
                            this.Close();
                        }
                    }
                }
                conCheck.Close();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            addClient();
        }
        private void saveData()
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conC = new SqlConnection(conClient))
                {
                    conC.Open();
                    using (SqlCommand cmd = conC.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE ClientDB SET Name=@cName,ShortCode=@cCode,Country=@cCountry,Account=@cAccount WHERE Client_ID=@cID";
                        cmd.Parameters.AddWithValue("@cName", txt_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@cID", lbl_ID.Text.Trim());
                        cmd.Parameters.AddWithValue("@cCode", txt_ShortCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@cCountry", txt_Country.Text.Trim());
                        cmd.Parameters.AddWithValue("@cAccount", cmb_Account.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conC.Close();
                }
                this.Close();
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
