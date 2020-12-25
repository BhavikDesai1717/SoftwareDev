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
    public partial class Sales_Report : Form
    {
        static string conInvoice = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.SalesInvoiceConnectionString"].ConnectionString;
        
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesInvoiceDataSet.SaleInvoiceDB' table. You can move, or remove it, as needed.
            this.saleInvoiceDBTableAdapter.Fill(this.salesInvoiceDataSet.SaleInvoiceDB);

        }
        private void filterReport()
        {
            using(SqlConnection conIn = new SqlConnection(conInvoice))
            {
                conIn.Open();
                using(SqlCommand cmd = conIn.CreateCommand())
                {
                    cmd.CommandText = "select * from SaleInvoiceDB where Invoice_Date=@inDate";
                    cmd.Parameters.AddWithValue("@inDate",dt_Date.Value.Date);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dg_InvoiceReport.DataSource = dt;
                }
                conIn.Close();
            }
        }

        private void dt_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control)
            {
                filterReport();
            }
        }

        private void Sales_Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                filterReport();
            }
        }
    }
}
