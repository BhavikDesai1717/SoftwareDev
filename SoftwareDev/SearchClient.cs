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
    public partial class SearchClient : Form
    {
        
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        
        public SearchClient()
        {
            InitializeComponent();
        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_DatabaseDataSet.ClientDB' table. You can move, or remove it, as needed.
            this.clientDBTableAdapter.Fill(this.client_DatabaseDataSet.ClientDB);
        }

        private void txt_searchClient_TextChanged(object sender, EventArgs e)
        {
            using(SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ClientDB WHERE Name like '" + txt_searchClient.Text + "%'", conC);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg_searchClient.DataSource = dt;
                conC.Close();
            }
        }

        private void dg_searchClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!string.IsNullOrEmpty(ButtonClicked.invoiceButtonClick))
            {
                PurchaseInvoice PI = new PurchaseInvoice();
                PI.txt_InvSC.Text = this.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
                PI.txt_InvMS.Text = this.dg_searchClient.CurrentRow.Cells[1].Value.ToString();
                this.Close();
                ButtonClicked.invoiceButtonClick = String.Empty;
                ButtonClicked.purchaseOrderButtonClick = String.Empty;
            }
            if (!string.IsNullOrEmpty(ButtonClicked.purchaseOrderButtonClick))
            {
                PurchaseOrder po = new PurchaseOrder();
                po.txt_POSC.Text = this.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
                po.txt_POMS.Text = this.dg_searchClient.CurrentRow.Cells[1].Value.ToString();
                this.Close();
                ButtonClicked.invoiceButtonClick = String.Empty;
                ButtonClicked.purchaseOrderButtonClick = String.Empty;
            }
            if(!string.IsNullOrEmpty(ButtonClicked.saleOrderButtonClick))
            {
                SaleOrder saleOrder = new SaleOrder();
                saleOrder.txt_SaleOrderSC.Text = this.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
                saleOrder.txt_SaleOrderMS.Text = this.dg_searchClient.CurrentRow.Cells[1].Value.ToString();
                this.Close();
                ButtonClicked.saleOrderButtonClick = String.Empty;
            }
            if(!string.IsNullOrEmpty(ButtonClicked.saleInvoiceButtonClick))
            {
                SaleInvoice saleInvoice = new SaleInvoice();
                saleInvoice.txt_InvoiceSC.Text = this.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
                saleInvoice.txt_InvoiceMS.Text = this.dg_searchClient.CurrentRow.Cells[1].Value.ToString();
                this.Close();
                ButtonClicked.saleInvoiceButtonClick = String.Empty;
            }
        }
    }
}
