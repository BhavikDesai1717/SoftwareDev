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
    public partial class Company_Profile : Form
    {
        static string conCompany = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.CompanyProfileConnectionString"].ConnectionString;
        public Company_Profile()
        {
            InitializeComponent();
            loadProfile();
        }
        private void loadProfile()
        {
            using (SqlConnection conC = new SqlConnection(conCompany))
            {
                conC.Open();
                using (SqlCommand cmd = conC.CreateCommand())
                {
                    cmd.CommandText = "select * from CompanyProfile where primaryKey=1";
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "CompanyProfile");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        txt_CompanyName.Text = Convert.ToString(dt.Rows[i]["companyName"]);
                        rt_Address.Text = Convert.ToString(dt.Rows[i]["companyAddress"]);
                        txt_ContactNumber.Text = Convert.ToString(dt.Rows[i]["contactNo"]);
                        txt_ContactPerson.Text = Convert.ToString(dt.Rows[i]["contactP"]);
                        dt_financial_Year.Value = Convert.ToDateTime(dt.Rows[i]["financialYear"]);
                        dt_financial_Year.Value = Convert.ToDateTime(dt.Rows[i]["bookYear"]);
                        lbl_ID.Text = Convert.ToString(dt.Rows[i]["primaryKey"]);
                    }
                }
                conC.Close();
            }
        }
        private void update_Details()
        {
            using (SqlConnection conC = new SqlConnection(conCompany))
            {
                conC.Open();
                using (SqlCommand cmd = conC.CreateCommand())
                {
                    cmd.CommandText = "Update CompanyProfile SET companyName=@cName,companyAddress=@cAddress,contactP=@cPerson,contactNo=@cNo,financialYear=@cFinancial,bookYear=@cBook WHERE primaryKey=@cID";
                    cmd.Parameters.AddWithValue("@cName", txt_CompanyName.Text.Trim());
                    cmd.Parameters.AddWithValue("@cAddress", rt_Address.Text);
                    cmd.Parameters.AddWithValue("@cPerson", txt_ContactPerson.Text.Trim());
                    cmd.Parameters.AddWithValue("@cNumber", txt_ContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@cFinancial", dt_financial_Year.Value);
                    cmd.Parameters.AddWithValue("@cBook", dt_BooksYear.Value);
                    cmd.Parameters.AddWithValue("@cID", lbl_ID.Text);
                    cmd.ExecuteNonQuery();
                }
                conC.Close();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            update_Details();
        }

        private void Company_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
