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
    public partial class AddSize : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddSize()
        {
            InitializeComponent();
        }
        private void submitSize()
        {
            if (txt_SizeCode.Text == "")
            {
                MessageBox.Show("Size Code cannot be Empty");
            }
            else if (txt_Size.Text == "")
            {
                MessageBox.Show("Size cannot be Empty");
            }
            else
            {
                using (SqlConnection conCheck = new SqlConnection(conClient))
                {
                    conCheck.Open();
                    using (SqlCommand command = conCheck.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT (SizeCode) FROM ProductSizeDB WHERE SizeCode=@sizeCheck";
                        command.Parameters.AddWithValue("@sizeCheck", txt_SizeCode.Text.Trim());
                        int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                        if (temp > 0)
                        {
                            MessageBox.Show("Size Code - " + txt_SizeCode.Text.Trim() + " is already Registered");
                            txt_SizeCode.Text = String.Empty;
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
                                        cmd.CommandText = "INSERT INTO ProductSizeDB (ProductSize,SizeCode) VALUES (@cSize,@cCode)";
                                        cmd.Parameters.AddWithValue("@cSize", txt_Size.Text.Trim());
                                        cmd.Parameters.AddWithValue("@cCode", txt_SizeCode.Text.Trim());
                                        cmd.ExecuteNonQuery();
                                    }
                                    conC.Close();
                                }
                                this.Close();
                                ButtonClicked.addNewSizeButton = String.Empty;
                            }
                        }
                    }
                    conCheck.Close();
                }
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            submitSize();
        }

            private void AddSize_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.addNewSizeButton))
            {
                btn_Submit.Visible = true;
                btn_SaveSize.Visible = false;
                btn_DisplaySize.Visible = false;
                
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editSizeButton))
            {
                btn_Submit.Visible = false;
                btn_SaveSize.Visible = true;
                btn_DisplaySize.Visible = false;
                
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displaySizeButton))
            {
                btn_Submit.Visible = false;
                btn_SaveSize.Visible = false;
                btn_DisplaySize.Visible = true;
               
            }
        }

        private void btn_Submit_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addNewColorButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    submitSize();
                }
            }
        }

        private void btn_DisplaySize_Click(object sender, EventArgs e)
        {
            this.Close();
            ButtonClicked.displaySizeButton = String.Empty;
        }

        private void btn_DisplaySize_KeyDown(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.displaySizeButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displaySizeButton = String.Empty;
                }
            }
        }
        private void saveSize()
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conC = new SqlConnection(conClient))
                {
                    conC.Open();
                    using (SqlCommand cmd = conC.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE ProductSizeDB SET ProductSize=@cSize,SizeCode=@cCode WHERE SrNo=@sID";
                        cmd.Parameters.AddWithValue("@sID", lbl_SizeID.Text);
                        cmd.Parameters.AddWithValue("@cSize", txt_Size.Text.Trim());
                        cmd.Parameters.AddWithValue("@cCode", txt_SizeCode.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conC.Close();
                }
                this.Close();
                ButtonClicked.editSizeButton = String.Empty;
            }
        }
        private void btn_SaveSize_Click(object sender, EventArgs e)
        {
            saveSize();
        }

        private void btn_SaveSize_KeyDown(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.editSizeButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveSize();
                }
            }
        }
    }
}
