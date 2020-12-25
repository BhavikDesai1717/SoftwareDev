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
    public partial class AddNewColor : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;

        public AddNewColor()
        {
            InitializeComponent();
        }
        private void addColor()
        {
            using (SqlConnection conCheck = new SqlConnection(conClient))
            {
                conCheck.Open();
                using (SqlCommand command = conCheck.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT (ColorCode) FROM ProductColorDB WHERE ColorCode=@colorCheck";
                    command.Parameters.AddWithValue("@colorCheck", txt_ColorCode.Text.Trim());
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
                    if (temp > 0)
                    {
                        MessageBox.Show("Color Code - " + txt_ColorCode.Text.Trim() + " is already Registered");
                        txt_ColorCode.Text = String.Empty;
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
                                    cmd.CommandText = "INSERT INTO ProductColorDB (ProductColor,ColorCode) VALUES (@cColor,@cCode)";
                                    cmd.Parameters.AddWithValue("@cColor", txt_ColorName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@cCode", txt_ColorCode.Text.Trim());
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
        private void btn_AddColor_Click(object sender, EventArgs e)
        {
            addColor();
        }

        private void AddNewColor_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.addNewColorButton))
            {
                btn_AddColor.Visible = true;
                btn_SaveDataToDB.Visible = false;
                btn_DisplayDataToDB.Visible = false;
                ButtonClicked.addNewColorButton = String.Empty;
            }
            if(!string.IsNullOrEmpty(ButtonClicked.editColorButton))
            {
                btn_AddColor.Visible = false;
                btn_SaveDataToDB.Visible = true;
                btn_DisplayDataToDB.Visible = false;
                ButtonClicked.editColorButton = String.Empty;
            }
            if(!string.IsNullOrEmpty(ButtonClicked.displayColorButton))
            {
                btn_AddColor.Visible = false;
                btn_SaveDataToDB.Visible = false;
                btn_DisplayDataToDB.Visible = true;
                ButtonClicked.displayColorButton = String.Empty;
            }
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
                        cmd.CommandText = "UPDATE ProductColorDB SET ProductColor=@cColor,ColorCode=@cCode WHERE SrNo=@cID";
                        cmd.Parameters.AddWithValue("@cColor", txt_ColorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@cID", lbl_ColorID.Text.Trim());
                        cmd.Parameters.AddWithValue("@cCode", txt_ColorCode.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conC.Close();
                }
                this.Close();
            }
        }
        private void btn_SaveDataToDB_Click(object sender, EventArgs e)
        {
            saveData();
        }
        private void displayData()
        {
            this.Close();
        }
        private void btn_DisplayDataToDB_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
