using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SoftwareDev
{
    public partial class LoginPage : Form
    {
        static string conRole = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.RoleLoginConnectionString"].ConnectionString;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
                using(SqlConnection conR = new SqlConnection(conRole))
                {
                    conR.Open();
                    SqlCommand cmd = conR.CreateCommand();
                    cmd.CommandText = "SELECT * FROM roleLoginDB WHERE username=@uName AND password=@uPass";
                    cmd.Parameters.AddWithValue("@uName", txt_Username.Text.Trim());
                    cmd.Parameters.AddWithValue("@uPass", txt_Password.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        dr.Read();
                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Hide();
                    }else
                    {
                        MessageBox.Show("Invalid ID or Password");
                    }
                    conR.Close();
                }
        
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
