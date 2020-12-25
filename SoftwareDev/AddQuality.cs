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
    public partial class AddQuality : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddQuality()
        {
            InitializeComponent();
        }
        private void addQuality()
        {
            using(SqlConnection conCheck = new SqlConnection(conClient))
            {
                conCheck.Open();
                using(SqlCommand command = conCheck.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(QualityCode) FROM ProductQualityDB WHERE QualityCode=@qualityCheck";
                    command.Parameters.AddWithValue("@qualityCheck", txt_QualityCode.Text.Trim());
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if(temp>0)
                    {
                        MessageBox.Show("Quality Code - " + txt_QualityCode.Text + " is already Registered");
                        txt_QualityCode.Text = String.Empty;
                    }else
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            using (SqlConnection conC = new SqlConnection(conClient))
                            {
                                conC.Open();
                                using (SqlCommand cmd = conC.CreateCommand())
                                {
                                    cmd.CommandText = "INSERT INTO ProductQualityDB (ProductQuality,QualityCode) VALUES (@qQuality,@qCode)";
                                    cmd.Parameters.AddWithValue("@qQuality", txt_Quality.Text.Trim());
                                    cmd.Parameters.AddWithValue("@qCode", txt_QualityCode.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                }
                                conC.Close();
                            }
                            this.Close();
                            ButtonClicked.addNewQualityButton = String.Empty;
                        }
                    }
                }
                conCheck.Close();
            }
        }
        private void btn_SubmitQuality_Click(object sender, EventArgs e)
        {
            addQuality();
        }

        private void AddQuality_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.addNewQualityButton))
            {
                btn_SubmitQuality.Visible = true;
                btn_Save.Visible = false;
                btn_Display.Visible = false;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editQualityButton))
            {
                btn_SubmitQuality.Visible = false;
                btn_Save.Visible = true;
                btn_Display.Visible = false;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displayQualityButton))
            {
                btn_SubmitQuality.Visible = false;
                btn_Save.Visible = false;
                btn_Display.Visible = true;
            }
        }

        private void btn_SubmitQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.addNewQualityButton))
            {
                if(e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    addQuality();
                }
            }
        }
        private void saveQuality()
        {
            if (txt_Quality.Text == "" || txt_Quality.Text == null)
            {
                MessageBox.Show("Field cannot be empty");
            }
            else
            {
                using (SqlConnection conSize = new SqlConnection(conClient))
                {
                    conSize.Open();
                    using (SqlCommand cmd = conSize.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE ProductQualityDB SET ProductQuality = @qQuality,QualityCode=@qCode WHERE SrNo = @qID";
                        cmd.Parameters.AddWithValue("@qQuality", txt_Quality.Text.Trim());
                        cmd.Parameters.AddWithValue("@qCode", txt_QualityCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@qID", lbl_QualityID.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conSize.Close();
                }
                this.Close();
                ButtonClicked.editQualityButton = String.Empty;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveQuality();
        }

        private void btn_Save_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.editQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveQuality();
                }
            }
        }
       
        private void btn_Display_Click(object sender, EventArgs e)
        {
            this.Close();
            ButtonClicked.displayQualityButton = String.Empty;
        }

        private void btn_Display_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.displayQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displayQualityButton = String.Empty;
                }
            }
        }

        private void txt_QualityCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addNewQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    addQuality();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveQuality();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displayQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displayQualityButton = String.Empty;
                }
            }
        }

        private void txt_Quality_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(ButtonClicked.addNewQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    addQuality();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.editQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    saveQuality();
                }
            }
            if (!string.IsNullOrEmpty(ButtonClicked.displayQualityButton))
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
                {
                    this.Close();
                    ButtonClicked.displayQualityButton = String.Empty;
                }
            }
        }
    }
}
