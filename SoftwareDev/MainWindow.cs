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
using System.Globalization;

namespace SoftwareDev
{
    public partial class MainWindow : Form
    {
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            assortmentToolStripMenuItem.Enabled = false;
            WarehouseToolStrip.Enabled = false;
            journalToolStripMenuItem.Enabled = false;
            ledgerToolStrip.Enabled = false;
            outstandingsToolStripMenuItem.Enabled = false;
            companyProfileToolStrip.Enabled = false;
            ClientMaster.Enabled = false;
            BrokerMaster.Enabled = false;
            AccountMaster.Enabled = false;
            ColorMaster.Enabled = false;
            SizeMaster.Enabled = false;
            QualityMaster.Enabled = false;
            PurchaseOrderToolStrip.Enabled = false;
            PurchaseInvoiceToolStrip.Enabled = false;
            purchaseOrderRegisterToolStripMenuItem.Enabled = false;
            purchaseRegisterToolStripMenuItem.Enabled = false;
            SaleOrderToolStrip.Enabled = false;
            SaleInvoiceToolStrip.Enabled = false;
            saleOrderRegisterToolStripMenuItem.Enabled = false;
            salesRegisterToolStripMenuItem.Enabled = false;
            menuStrip2.Visible = false;
           
        }
        private void colorMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddColorMaster addColorMaster = new AddColorMaster();
            addColorMaster.ShowDialog();
        }
        
        

        private void sizeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSizeMaster addSizeMaster = new AddSizeMaster();
            addSizeMaster.ShowDialog();
        }
        private void qualityMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQualityMaster addQualityMaster = new AddQualityMaster();
            addQualityMaster.ShowDialog();
        }

       
        private void accountMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.ShowDialog();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder PO = new PurchaseOrder();
            PO.ShowDialog();
        }

        

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseInvoice PI = new PurchaseInvoice();
            PI.ShowDialog();
        }

        private void saleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleOrder saleOrder = new SaleOrder();
            saleOrder.ShowDialog();
        }

        private void saleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleInvoice saleInvoice = new SaleInvoice();
            saleInvoice.ShowDialog();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void assignUserRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignRoles assignRoles = new AssignRoles();
            assignRoles.ShowDialog();
        }

        private void manualJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journals journals = new Journals();
            journals.ShowDialog();
        }

        private void warehouseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Warehouse_Report warehouse_Report = new Warehouse_Report();
            warehouse_Report.ShowDialog();
        }

        private void companyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Profile company_Profile = new Company_Profile();
            company_Profile.ShowDialog();
        }

        private void salesMoMReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Report sales_Report = new Sales_Report();
            sales_Report.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger();
            ledger.ShowDialog();
        }

        private void outstandingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outstanding_Report outstanding_Report = new Outstanding_Report();
            outstanding_Report.ShowDialog();
        }

        private void ClientMaster_Click(object sender, EventArgs e)
        {
            Client_Master client_Master = new Client_Master();
            client_Master.ShowDialog();
        }

        private void BrokerMaster_Click(object sender, EventArgs e)
        {
            Broker_Master broker_Master = new Broker_Master();
            broker_Master.ShowDialog();
        }

        private void openCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanySelect companySelect = new CompanySelect();
            companySelect.ShowDialog();
            if(!string.IsNullOrEmpty(ButtonClicked.softwareStart))
            {
                menuStrip2.Visible = true;
                menuStrip3.Visible = false;
                openCompanyToolStripMenuItem.Enabled = false;
                assortmentToolStripMenuItem.Enabled = true;
                WarehouseToolStrip.Enabled = true;
                journalToolStripMenuItem.Enabled = true;
                ledgerToolStrip.Enabled = true;
                outstandingsToolStripMenuItem.Enabled = true;
                companyProfileToolStrip.Enabled = true;
                ClientMaster.Enabled = true;
                BrokerMaster.Enabled = true;
                AccountMaster.Enabled = true;
                ColorMaster.Enabled = true;
                SizeMaster.Enabled = true;
                QualityMaster.Enabled = true;
                PurchaseOrderToolStrip.Enabled = true;
                PurchaseInvoiceToolStrip.Enabled = true;
                purchaseOrderRegisterToolStripMenuItem.Enabled = true;
                purchaseRegisterToolStripMenuItem.Enabled = true;
                SaleOrderToolStrip.Enabled = true;
                SaleInvoiceToolStrip.Enabled = true;
                saleOrderRegisterToolStripMenuItem.Enabled = true;
                salesRegisterToolStripMenuItem.Enabled = true;
                ButtonClicked.softwareStart = String.Empty;
            }
        }

        private void assortmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assortment assortment = new Assortment();
            assortment.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}