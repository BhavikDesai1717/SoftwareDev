using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Configuration;
using System.Data.SqlClient;

namespace SoftwareDev
{
    public partial class Ledger_Details : Form
    {
        string accName;
        static string conLedger = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.SalesInvoiceConnectionString"].ConnectionString;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        static string conPurchase = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.PurchaseInvoiceDBConnectionString"].ConnectionString;
        static string conSales = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.SalesInvoiceConnectionString"].ConnectionString;
        int year = ButtonClicked.financialYearStart.Year;
        public Ledger_Details()
        {
            InitializeComponent();
        }

        private void Ledger_Details_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'salesInvoiceDataSet.SaleInvoiceDB' table. You can move, or remove it, as needed.
            this.saleInvoiceDBTableAdapter.Fill(this.salesInvoiceDataSet.SaleInvoiceDB);
            lbl_ClientName.Text = ButtonClicked.clientName;
            loadDgData();
            openingBalanceDetails();
            purchaseDetails();
        }
        private void loadDgData()
        {
           
            for (int i =0; i<=12;i++)
            {
                dg_LedgerDetails.Rows.Add();
            }
            dg_LedgerDetails.Rows[0].Cells[0].Value = "Opening Balance";
            dg_LedgerDetails.Rows[1].Cells[0].Value = "April";
            dg_LedgerDetails.Rows[2].Cells[0].Value = "May";
            dg_LedgerDetails.Rows[3].Cells[0].Value = "June";
            dg_LedgerDetails.Rows[4].Cells[0].Value = "July";
            dg_LedgerDetails.Rows[5].Cells[0].Value = "August";
            dg_LedgerDetails.Rows[6].Cells[0].Value = "September";
            dg_LedgerDetails.Rows[7].Cells[0].Value = "October";
            dg_LedgerDetails.Rows[8].Cells[0].Value = "November";
            dg_LedgerDetails.Rows[9].Cells[0].Value = "December";
            dg_LedgerDetails.Rows[10].Cells[0].Value = "January";
            dg_LedgerDetails.Rows[11].Cells[0].Value = "February";
            dg_LedgerDetails.Rows[12].Cells[0].Value = "March";
            using(SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                using(SqlCommand cmd = conC.CreateCommand())
                {
                    cmd.CommandText = "Select Account from ClientDB Where Name=@cName";
                    cmd.Parameters.AddWithValue("@cName", lbl_ClientName.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    accName = dt.Rows[0]["Account"].ToString();
                }
                conC.Close();
            }
            
        }
        private void openingBalanceDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate < @inDate AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.Parameters.AddWithValue("@inDate", ButtonClicked.financialYearStart.Date);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[0].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        dg_LedgerDetails.Rows[0].Cells[3].Value = dt.Rows[0]["Column1"].ToString();
                    }
                    conP.Close();
                }
            }
            if(accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date < @inDate AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.Parameters.AddWithValue("@inDate", ButtonClicked.financialYearStart.Date);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[0].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        dg_LedgerDetails.Rows[0].Cells[3].Value = dt.Rows[0]["Column1"].ToString();
                    }
                    conS.Close();
                }
            }
        }
        private void purchaseDetails()
        {
            januaryDetails();
        }
        private void januaryDetails()
        {
            int year_jan = year + 1;
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '01-01-"+year_jan+"' and '01-31-"+year_jan+"' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[10].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance,debit,credit,openingPurchase,totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[10].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '01-01-" + year_jan + "' and '01-31-" + year_jan + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[10].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[10].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void februaryDetails()
        {
            int year_jan = year + 1;
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '02-01-" + year_jan + "' and '02-29-" + year_jan + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[11].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[11].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '02-01-" + year_jan + "' and '02-29-" + year_jan + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[11].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[10].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[11].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void marchDetails()
        {
            int year_jan = year + 1;
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '03-01-" + year_jan + "' and '03-31-" + year_jan + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[12].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[12].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[12].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[12].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '03-01-" + year_jan + "' and '03-31-" + year_jan + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[11].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[12].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[12].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[11].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[12].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void aprilDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '04-01-" + year + "' and '04-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[1].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[0].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[1].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '04-01-" + year + "' and '04-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[1].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[0].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[1].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void mayDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '05-01-" + year + "' and '05-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[2].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[2].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '05-01-" + year + "' and '05-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[2].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[1].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[2].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void juneDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '06-01-" + year + "' and '06-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[3].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[3].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '06-01-" + year + "' and '06-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[3].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[2].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[3].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void julyDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '07-01-" + year + "' and '07-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[4].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[4].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '07-01-" + year + "' and '07-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[4].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[3].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[4].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void augustDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '08-01-" + year + "' and '08-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[5].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[5].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '08-01-" + year + "' and '08-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[5].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[4].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[5].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void septemberDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '09-01-" + year + "' and '09-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[6].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[6].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '09-01-" + year + "' and '09-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[6].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[5].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[6].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void octoberDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '10-01-" + year + "' and '10-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[7].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[7].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '10-01-" + year + "' and '10-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[7].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[6].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[7].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void novemberDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '11-01-" + year + "' and '11-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[8].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[8].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '11-01-" + year + "' and '11-30-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[8].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[7].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[8].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
        private void decemberDetails()
        {
            if (accName == "Purchase A/C")
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(TotalAmount) from InvoiceDB where InvoiceDate BETWEEN '12-01-" + year + "' and '12-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[9].Cells[2].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[9].Cells[3].Value = balance;
                    }
                    conP.Close();
                }
            }
            if (accName == "Sales A/C")
            {
                using (SqlConnection conS = new SqlConnection(conSales))
                {
                    conS.Open();
                    using (SqlCommand cmd = conS.CreateCommand())
                    {
                        cmd.CommandText = "Select SUM(Total_Amount) from SaleInvoiceDB where Invoice_Date BETWEEN '12-01-" + year + "' and '12-31-" + year + "' AND MS=@clientName";
                        cmd.Parameters.AddWithValue("@clientName", lbl_ClientName.Text);

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dg_LedgerDetails.Rows[9].Cells[1].Value = dt.Rows[0]["Column1"].ToString();
                        double balance, debit, credit, openingPurchase, totalCredit;
                        debit = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[1].Value);
                        credit = Convert.ToDouble(dg_LedgerDetails.Rows[9].Cells[2].Value);
                        openingPurchase = Convert.ToDouble(dg_LedgerDetails.Rows[8].Cells[3].Value);
                        totalCredit = openingPurchase + credit;
                        balance = totalCredit - debit;
                        dg_LedgerDetails.Rows[9].Cells[3].Value = balance;
                    }
                    conS.Close();
                }
            }
        }
    }
}
