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
    public partial class Add_Broker : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public Add_Broker()
        {
            InitializeComponent();
        }
        private void addBroker()
        {
            using (SqlConnection conCheck = new SqlConnection(conClient))
            {
                conCheck.Open();
                using (SqlCommand command = conCheck.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT (Name) FROM BrokerDB WHERE Name=@bName";
                    command.Parameters.AddWithValue("@bName", txt_Name.Text.Trim());
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (temp > 0)
                    {
                        MessageBox.Show("Broker Name - " + txt_Name.Text.Trim() + " is already Registered");
                        txt_Name.Text = String.Empty;
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
                                    cmd.CommandText = "INSERT INTO BrokerDB (Name,Address_Line_1,Country,State,Postal_Code,Contact_No) VALUES (@bName,@bAddress,@bCountry,@bState,@bPostal,@bContact)";
                                    cmd.Parameters.AddWithValue("@bName", txt_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bAddress", rt_Address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bCountry", txt_Country.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bState", txt_State.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bPostal", txt_PostalCode.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bContact", txt_ContactNo.Text.Trim());
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
            addBroker();
        }

        private void Add_Broker_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addBrokerMaster))
            {
                btn_Add.Visible = true;
                btn_Edit.Visible = false;
                btn_Ok.Visible = false;
                ButtonClicked.addBrokerMaster = String.Empty;
            }
            else if (!string.IsNullOrEmpty(ButtonClicked.editBrokerMaster))
            {
                btn_Add.Visible = false;
                btn_Edit.Visible = true;
                btn_Ok.Visible = false;
                ButtonClicked.editBrokerMaster = String.Empty;
            }
            else if (!string.IsNullOrEmpty(ButtonClicked.displayBrokerMaster))
            {
                btn_Add.Visible = false;
                btn_Edit.Visible = false;
                btn_Ok.Visible = true;
                ButtonClicked.displayBrokerMaster = String.Empty;
            }
            
        }
        private void editData()
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conC = new SqlConnection(conClient))
                {
                    conC.Open();
                    using (SqlCommand cmd = conC.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE BrokerDB SET Name=@bName,Address_Line_1=@bAddress,Country=@bCountry,State=@bState,Postal_Code=@bPostal,@Contact_No=@bContact WHERE BrokerID=@bID";
                        cmd.Parameters.AddWithValue("@bName", txt_Name.Text.Trim());
                        cmd.Parameters.AddWithValue("@bID", lbl_ID.Text.Trim());
                        cmd.Parameters.AddWithValue("@bAddress", rt_Address.Text.Trim());
                        cmd.Parameters.AddWithValue("@bCountry", txt_Country.Text.Trim());
                        cmd.Parameters.AddWithValue("@bState", txt_State.Text.Trim());
                        cmd.Parameters.AddWithValue("@bPostal", txt_PostalCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@bContact", txt_ContactNo.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conC.Close();
                }
                this.Close();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
