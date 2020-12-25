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
using System.Globalization;

namespace SoftwareDev
{
    public partial class SaleInvoice : Form
    {
        static string conPurchase = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Purchase_OrderDBConnectionString"].ConnectionString;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        static string conPInvoice = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.PurchaseInvoiceDBConnectionString"].ConnectionString;
        static string conSOrder = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Sale_OrderDBConnectionString"].ConnectionString;
        static string conSInvoice = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.SalesInvoiceConnectionString"].ConnectionString;
        static string conWarehouse = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.WarehouseConnectionString"].ConnectionString;
        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesInvoiceDataSet.SaleInvoiceDB' table. You can move, or remove it, as needed.
            this.saleInvoiceDBTableAdapter.Fill(this.salesInvoiceDataSet.SaleInvoiceDB);
            // TODO: This line of code loads data into the 'sale_OrderDBDataSet.SaleOrderDB' table. You can move, or remove it, as needed.
            this.saleOrderDBTableAdapter.Fill(this.sale_OrderDBDataSet.SaleOrderDB);
            this.FormBorderStyle = FormBorderStyle.None;
            this.dt_SaleInvoice.Value = DateTime.Today;
            btn_DisplaySI.Enabled = false;
            btn_UpdateSI.Enabled = false;
            saleInvoiceAutoNo();
        }
        private void saleInvoiceAutoNo()
        {
            /*String query = "SELECT max (InvoiceNo)+1 FROM SaleInvoiceDB";
            using (SqlConnection cons = new SqlConnection(conSInvoice))
            {
                using (SqlCommand cmd_Auto = new SqlCommand(query, cons))
                {
                    SqlDataReader dtr;
                    try
                    {
                        cons.Open();
                        dtr = cmd_Auto.ExecuteReader();
                        if (dtr.HasRows)
                        {
                            while (dtr.Read())
                            {
                                lbl_SaleInvoiceNo.Text = dtr[0].ToString();
                                if (lbl_SaleInvoiceNo.Text == "")
                                {
                                    lbl_SaleInvoiceNo.Text = "1";
                                }
                            }
                        }
                        else
                        {
                            lbl_SaleInvoiceNo.Text = "1";
                        }
                        cons.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }*/
        }
        private void refreshSaleInvoiceReport()
        {
            SqlConnection conS = new SqlConnection(conSInvoice);
            conS.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM SaleInvoiceDB";
            cmd = new SqlCommand(query, conS);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_InvoiceReport.DataSource = dt;
            conS.Close();
        }

        private void txt_InvoiceSC_TextChanged(object sender, EventArgs e)
        {
            if (txt_InvoiceSC.Text == String.Empty)
            {
                txt_InvoiceMS.Text = String.Empty;
            }
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT Name FROM ClientDB WHERE ShortCode='" + this.txt_InvoiceSC.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_InvoiceMS.Text = dtaRead["Name"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conC.Close();
            }
        }

        private void btn_SelectMS_Click(object sender, EventArgs e)
        {
            ButtonClicked.saleInvoiceButtonClick = (sender as Button).Text;
            SearchClient searchClient = new SearchClient();
            searchClient.ShowDialog();
            this.txt_InvoiceSC.Text = searchClient.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_CloseSI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_InvoiceProductDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_InvoiceProductDetails.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_InvoiceReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_InvoiceReport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_AddNewSI_Click(object sender, EventArgs e)
        {
            //Clear Fields
            saleInvoiceAutoNo();
            dt_SaleInvoice.Value = DateTime.Today;
            cbo_SaleCurrencySI.Text = String.Empty;
            txt_InvoiceSC.Text = String.Empty;
            txt_InvoiceMS.Text = String.Empty;
            rt_InvoiceNarration.Text = String.Empty;
            txt_TotalAmountSI.Text = String.Empty;
            dg_InvoiceProductDetails.Rows.Clear();

            //Buttons Disabling
            btn_SubmitSItoDB.Enabled = true;
            btn_UpdateSI.Enabled = false;
            btn_DisplaySI.Enabled = false;
        }
        private void warehouseUpdate()
        {
            
        }
        private void btn_SubmitSItoDB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count - 1; i++)
                {
                    if (validate())
                                {
                                    using (SqlConnection conPro = new SqlConnection(conSInvoice))
                                    {
                                        conPro.Open();
                                        using (SqlCommand cmd = conPro.CreateCommand())
                                        {
                                            cmd.CommandText = "INSERT INTO SaleInProductDB (ColorCode,Color,SizeCode,Size,QualityCode,Quality,Lot,Quantity,Rate,RateConv,Amount,InvoiceNo,discount1,discount1Amount,discount2,discount2Amount,discount3,discount3Amount,FinalAmount) VALUES(@inColorCode,@inColor,@inSizeCode,@inSize,@inQualityCode,@inQuality,@inLot,@inQuantity,@inRate,@inRateConv,@inAmount,@inInvoiceNO,@indiscount1,@indiscount1Amount,@indiscount2,@indiscount2Amount,@indiscount3,@indiscount3Amount,@infinalAmount)";
                                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[1].Value));
                                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value));
                                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[3].Value));
                                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value));
                                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[5].Value));
                                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value));
                                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value));
                                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[8].Value));
                                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[9].Value));
                                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[10].Value));
                                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[11].Value));
                                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[12].Value));
                                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[13].Value));
                                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[14].Value));
                                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[15].Value));
                                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[16].Value));
                                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[17].Value));
                                            cmd.Parameters.AddWithValue("@infinalAmount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                                            cmd.Parameters.AddWithValue("@inInvoiceNO", txt_SINo.Text.Trim());
                                            cmd.ExecuteNonQuery();
                                        }
                                        conPro.Close();
                                    }
                                    //warehouse Update
                                    using (SqlConnection conUp = new SqlConnection(conWarehouse))
                                    {
                                        conUp.Open();
                                        using (SqlCommand cmd = conUp.CreateCommand())
                                        {
                                            cmd.CommandText = "select * from Warehouse where Color=@color AND Size=@size AND Quality=@quality AND Lot=@lot";
                                            cmd.Parameters.AddWithValue("@color", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value));
                                            cmd.Parameters.AddWithValue("@size", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value));
                                            cmd.Parameters.AddWithValue("@quality", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value));
                                            cmd.Parameters.AddWithValue("@lot", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value));
                                            cmd.ExecuteNonQuery();
                                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                            DataSet ds = new DataSet();
                                            DataTable dt = new DataTable();
                                            sda.Fill(ds, "Warehouse");
                                            dt = ds.Tables[0];
                                            for (int w = 0; w < dt.Rows.Count; w++)
                                            {
                                                if (Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value) == Convert.ToString(dt.Rows[w]["Color"])
                                                    && Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value) == Convert.ToString(dt.Rows[w]["Size"])
                                                    && Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value) == Convert.ToString(dt.Rows[w]["Quality"])
                                                    && Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value) == Convert.ToString(dt.Rows[w]["Lot"]))
                                                {

                                                    int balanceQuantity = Convert.ToInt32(dt.Rows[w]["Balance_Quantity"]);
                                                    if (balanceQuantity < Convert.ToInt32(dg_InvoiceProductDetails.Rows[i].Cells[8].Value))
                                                    {
                                                        MessageBox.Show("Entered Quantity is more than the Stock in Color: " + dg_InvoiceProductDetails.Rows[i].Cells[2].Value.ToString()
                                                            + " ,Size: " + dg_InvoiceProductDetails.Rows[i].Cells[4].Value.ToString()
                                                            + " ,Quality: " + dg_InvoiceProductDetails.Rows[i].Cells[6].Value.ToString()
                                                            + " ,Lot: " + dg_InvoiceProductDetails.Rows[i].Cells[7].Value.ToString());
                                                    }
                                                    else
                                                    {
                                                        int inQuantity = Convert.ToInt32(dt.Rows[w]["Inward_Quantity"]);
                                                        int outQuantity;
                                                        outQuantity = Convert.ToInt32(dt.Rows[w]["Outward_Quantity"]) + Convert.ToInt32(dg_InvoiceProductDetails.Rows[i].Cells[8].Value);
                                                        balanceQuantity = inQuantity - outQuantity;
                                                        cmd.CommandText = "Update Warehouse Set Outward_Quantity=@out,Balance_Quantity=@balQuantity where Color=@cColor AND Size=@cSize AND Quality=@cQuality AND Lot=@cLot";
                                                        cmd.Parameters.AddWithValue("@out", outQuantity);
                                                        cmd.Parameters.AddWithValue("@balQuantity", balanceQuantity);
                                                        cmd.Parameters.AddWithValue("@cColor", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value));
                                                        cmd.Parameters.AddWithValue("@cSize", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value));
                                                        cmd.Parameters.AddWithValue("@cQuality", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value));
                                                        cmd.Parameters.AddWithValue("@cLot", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value));
                                                        cmd.ExecuteNonQuery();
                                                    }
                                                }
                                            }
                                        }
                                        conUp.Close();
                                    }

                                    using (SqlConnection conPO = new SqlConnection(conSInvoice))
                                    {
                                        conPO.Open();
                                        using (SqlCommand cmd = conPO.CreateCommand())
                                        {
                                            cmd.CommandText = "INSERT INTO SaleInvoiceDB (Invoice_Date,ShortCode,MS,Narration,Total_Amount,SaleCurrency) VALUES(@inDate,@inSC,@inMS,@inNarration,@intotal,@inCurrency)";
                                            cmd.Parameters.AddWithValue("@inDate", this.dt_SaleInvoice.Value);
                                            cmd.Parameters.AddWithValue("@inSC", this.txt_InvoiceSC.Text.Trim());
                                            cmd.Parameters.AddWithValue("@inMS", this.txt_InvoiceMS.Text.Trim());
                                            cmd.Parameters.AddWithValue("@inNarration", this.rt_InvoiceNarration.Text.Trim());
                                            cmd.Parameters.AddWithValue("@intotal", this.txt_TotalAmountSI.Text.Trim());
                                            cmd.Parameters.AddWithValue("@inCurrency", this.cbo_SaleCurrencySI.Text.Trim());
                                            cmd.ExecuteNonQuery();
                                        }
                                        conPO.Close();
                                    }
                                    refreshSaleInvoiceReport();
                                    dg_InvoiceProductDetails.Rows.Clear();
                                    this.txt_InvoiceSC.Text = String.Empty;
                                    this.txt_InvoiceMS.Text = String.Empty;
                                    this.dt_SaleInvoice.Value = DateTime.Today;
                                    this.rt_InvoiceNarration.Text = String.Empty;
                                    this.txt_TotalAmountSI.Text = String.Empty;
                                    saleInvoiceAutoNo();
                                } else
                                {
                                    MessageBox.Show("Please Check the Stock in Color:" +
                                        dg_InvoiceProductDetails.Rows[i].Cells[2].Value.ToString() +
                                        " ,Size:" + dg_InvoiceProductDetails.Rows[i].Cells[4].Value.ToString() +
                                        " ,Quality:" + dg_InvoiceProductDetails.Rows[i].Cells[6].Value.ToString() +
                                        " ,Lot:" + dg_InvoiceProductDetails.Rows[i].Cells[7].Value.ToString());
                                }
                               
                    }
            }
        }
        private bool validate()
        {
            bool result = false;
            for(int i =0;i<dg_InvoiceProductDetails.Rows.Count-1;i++)
            {
                using(SqlConnection conW = new SqlConnection(conWarehouse))
                {
                    conW.Open();
                    using (SqlCommand cmd = conW.CreateCommand())
                    {
                        cmd.CommandText = "select * from Warehouse where Color=@checkColor AND Size=@checkSize AND Quality=@checkQuality AND Lot=@checkLot";
                        cmd.Parameters.AddWithValue("@checkColor", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value));
                        cmd.Parameters.AddWithValue("@checkSize", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value));
                        cmd.Parameters.AddWithValue("@checkQuality", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value));
                        cmd.Parameters.AddWithValue("@checkLot", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value));
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            result = true;
                        }else
                        {
                            result = false;
                        }
                    }
                    conW.Close();
                }
            }
            return result;
        }
        private void dg_InvoiceProductDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 8 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 9 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 10 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 11 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 12 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 13 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 14 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 15 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 16 || dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 17) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Text = ((System.Windows.Forms.TextBox)sender).Text;
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.'))
            {
                Keys key = (Keys)e.KeyChar;
                if (!(key == Keys.Back || key == Keys.Delete))
                {
                    e.Handled = true;
                }
            }
            else
            if (Text.Contains("."))
            {
                if (e.KeyChar == '.')
                    e.Handled = true;
                else
                if (Text.Length - Text.IndexOf(".") > 5)
                    e.Handled = true;

            }
        }

        private void dg_InvoiceProductDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total_Amount = 0;
            for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count - 1; i++)
            {
                double quan = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[8].Value);
                double ra = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[9].Value);
                double subAmount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[11].Value);
                double rConv = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[10].Value);
                double discount1 = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[12].Value);
                double discount2 = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[14].Value);
                double discount3 = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[16].Value);
                if (dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "RateInvoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "RateConvInvoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount1Invoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount2Invoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount3Invoice")
                {
                    if (dg_InvoiceProductDetails.Rows[i].Cells[10].Value == null)
                    {
                        subAmount = quan * ra;
                        dg_InvoiceProductDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_InvoiceProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_InvoiceProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_InvoiceProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[17].Value);
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        subAmount = quan * ra * rConv;
                        dg_InvoiceProductDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_InvoiceProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_InvoiceProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_InvoiceProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[17].Value);
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                    }
                }
                else if (dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "AmountInvoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount1Invoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount2Invoice" || dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "Discount3Invoice")
                {
                    if (dg_InvoiceProductDetails.Rows[i].Cells[10].Value == null)
                    {
                        ra = subAmount / quan;
                        dg_InvoiceProductDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_InvoiceProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_InvoiceProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_InvoiceProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[17].Value);
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        ra = subAmount / (quan * rConv);
                        dg_InvoiceProductDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_InvoiceProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_InvoiceProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_InvoiceProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[17].Value);
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_InvoiceProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmountSI.Text = Convert.ToString(total_Amount);
                        }
                    }
                }
            }
        }

        private void dg_InvoiceProductDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count - 1; i++)
            {
                if (dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "ColorCodeInvoice")
                {
                    if (dg_InvoiceProductDetails.Rows[i].Cells[1].Value == String.Empty)
                    {
                        dg_InvoiceProductDetails.Rows[i].Cells[2].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + dg_InvoiceProductDetails.Rows[i].Cells[1].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_InvoiceProductDetails.Rows[i].Cells[2].Value = dtaRead["ProductColor"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
                else if (dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "SizeCodeInvoice")
                {
                    if (dg_InvoiceProductDetails.Rows[i].Cells[3].Value == String.Empty)
                    {
                        dg_InvoiceProductDetails.Rows[i].Cells[4].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + dg_InvoiceProductDetails.Rows[i].Cells[3].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_InvoiceProductDetails.Rows[i].Cells[4].Value = dtaRead["ProductSize"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
                else if (dg_InvoiceProductDetails.Columns[e.ColumnIndex].Name == "QualityCodeInvoice")
                {
                    if (dg_InvoiceProductDetails.Rows[i].Cells[5].Value == String.Empty)
                    {
                        dg_InvoiceProductDetails.Rows[i].Cells[6].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + dg_InvoiceProductDetails.Rows[i].Cells[5].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_InvoiceProductDetails.Rows[i].Cells[6].Value = dtaRead["ProductQuality"].ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        conC.Close();
                    }
                }
            }
        }

        private void dg_InvoiceProductDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void cbo_SaleCurrencySI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SaleCurrencySI.Text == "₹ Sale")
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = "₹ ";
                dg_InvoiceProductDetails.Columns["AmountInvoice"].DefaultCellStyle.FormatProvider = format;
                dg_InvoiceProductDetails.Columns["AmountInvoice"].DefaultCellStyle.Format = "c";
                dg_InvoiceProductDetails.Columns["RateInvoice"].DefaultCellStyle.FormatProvider = format;
                dg_InvoiceProductDetails.Columns["RateInvoice"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count; i++)
                {
                    dg_InvoiceProductDetails.Rows[i].Cells[10].ReadOnly = false;
                    dg_InvoiceProductDetails.Rows[i].Cells[10].Style.BackColor = Color.White;

                }
            }
            else if (cbo_SaleCurrencySI.Text == "$ Sale")
            {
                var formats = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                formats.CurrencySymbol = "$ ";
                dg_InvoiceProductDetails.Columns["AmountInvoice"].DefaultCellStyle.FormatProvider = formats;
                dg_InvoiceProductDetails.Columns["AmountInvoice"].DefaultCellStyle.Format = "c";
                dg_InvoiceProductDetails.Columns["RateInvoice"].DefaultCellStyle.FormatProvider = formats;
                dg_InvoiceProductDetails.Columns["RateInvoice"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count; i++)
                {
                    dg_InvoiceProductDetails.Rows[i].Cells[10].ReadOnly = true;
                    dg_InvoiceProductDetails.Rows[i].Cells[10].Style.BackColor = Color.Gray;

                }
            }
        }

        private void dg_InvoiceProductDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 1)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    ColorAdd cA = new ColorAdd();
                    cA.ShowDialog();
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[1].Value = cA.cCode;
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[2].Value = cA.cColor;
                }
            }
            if (dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 3)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchSize ss = new SearchSize();
                    ss.ShowDialog();
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[3].Value = ss.sCode;
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[4].Value = ss.sSize;
                }
            }
            if (dg_InvoiceProductDetails.CurrentCell.ColumnIndex == 5)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchQuality searchQuality = new SearchQuality();
                    searchQuality.ShowDialog();
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[5].Value = searchQuality.qCode;
                    this.dg_InvoiceProductDetails.CurrentRow.Cells[6].Value = searchQuality.qQuality;
                }
            }
        }

        private void btn_UpdateSI_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conSInvoice))
                {

                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        //Save All CLient Data of PO
                        cmd.CommandText = "UPDATE SaleInvoiceDB SET Invoice_Date=@inDate,ShortCode=@inSC,MS=@inMS,Narration=@inNarration,Total_Amount=@inTAmount,SaleCurrency=@inCurrency WHERE InvoiceNo=@inNO";
                        cmd.Parameters.AddWithValue("@inNO", txt_SINo.Text);
                        cmd.Parameters.AddWithValue("@inDate", dt_SaleInvoice.Value);
                        cmd.Parameters.AddWithValue("@inSC", txt_InvoiceSC.Text);
                        cmd.Parameters.AddWithValue("@inMS", txt_InvoiceMS.Text);
                        cmd.Parameters.AddWithValue("@inNarration", rt_InvoiceNarration.Text);
                        cmd.Parameters.AddWithValue("@inTAmount", txt_TotalAmountSI.Text);
                        cmd.Parameters.AddWithValue("@inCurrency", cbo_SaleCurrencySI.Text);
                        cmd.ExecuteNonQuery();
                        refreshSaleInvoiceReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conSInvoice))
                {
                    conPro.Open();
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        for (int i = 0; i < dg_InvoiceProductDetails.Rows.Count - 1; i++)
                        {
                            cmd.Parameters.Clear();
                            //Save All Product Data of PO
                            cmd.CommandText = "UPDATE SaleInProductDB SET ColorCode=@inColorCode,Color=@inColor,SizeCode=@inSizeCode,Size=@inSize,QualityCode=@inQualityCode,Quality=@inQuality,Lot=@inLot,Quantity=@inQuantity,Rate=@inRate,RateConv=@inRateConv,Amount=@inAmount,InvoiceNo=@inNo,discount1=@indiscount1,discount1Amount=@indiscount1Amount,discount2=@indiscount2,discount2Amount=@indiscount2Amount,discount3=@indiscount3,discount3Amount=@indiscount3Amount,FinalAmount=@infinalAmount WHERE productPrimary=@inPri";
                            cmd.Parameters.AddWithValue("@inPri", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[19].Value));
                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[13].Value));
                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[14].Value));
                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[15].Value));
                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[16].Value));
                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[17].Value));
                            cmd.Parameters.AddWithValue("@infinalAmount", Convert.ToString(dg_InvoiceProductDetails.Rows[i].Cells[18].Value));
                            cmd.Parameters.AddWithValue("@inNo", txt_SINo.Text);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    conPro.Close();
                }
                dg_InvoiceProductDetails.Rows.Clear();
                txt_InvoiceSC.Text = String.Empty;
                txt_InvoiceMS.Text = String.Empty;
                txt_TotalAmountSI.Text = String.Empty;
                rt_InvoiceNarration.Text = String.Empty;
                dt_SaleInvoice.Value = DateTime.Today;

                saleInvoiceAutoNo();
            }
        }

        private void btn_DeleteSI_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conSInvoice))
                {
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        cmd.CommandText = "DELETE SaleInvoiceDB WHERE InvoiceNo=@iID";
                        cmd.Parameters.AddWithValue("@iID", dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        refreshSaleInvoiceReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conSInvoice))
                {
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        conPro.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE SaleInProductDB WHERE InvoiceNo=@inID";
                        cmd.Parameters.AddWithValue("@inID", dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conPro.Close();
                    }
                }
            }
        }

        private void btn_EditSI_Click(object sender, EventArgs e)
        {
            btn_SubmitSItoDB.Enabled = false;
            btn_UpdateSI.Enabled = true;
            btn_DisplaySI.Enabled = false;

            //fetch Selected Data
            txt_InvoiceMS.Text = dg_InvoiceReport.CurrentRow.Cells[4].Value.ToString();
            txt_InvoiceSC.Text = dg_InvoiceReport.CurrentRow.Cells[7].Value.ToString();
            txt_SINo.Text = dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString();
            dt_SaleInvoice.Text = dg_InvoiceReport.CurrentRow.Cells[2].Value.ToString();
            rt_InvoiceNarration.Text = dg_InvoiceReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmountSI.Text = dg_InvoiceReport.CurrentRow.Cells[5].Value.ToString();
            cbo_SaleCurrencySI.Text = dg_InvoiceReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conSInvoice))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SaleInProductDB WHERE InvoiceNo=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_SINo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "SaleInProductDB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_InvoiceProductDetails.Rows.Add(dr);
                        dg_InvoiceProductDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["ColorInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["SizeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["QualityInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["LotInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["QuantityInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["RateInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConvInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["Discount1Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["Discount1AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["Discount2Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["Discount2AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["Discount3Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["Discount3AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalAmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["proPrimaryInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].ReadOnly = false;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_InvoiceSC.Enabled = true;
            txt_InvoiceMS.Enabled = true;
            dt_SaleInvoice.Enabled = true;
            rt_InvoiceNarration.Enabled = true;
            txt_TotalAmountSI.Enabled = true;
        }

        private void dg_InvoiceReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_SubmitSItoDB.Enabled = false;
            btn_UpdateSI.Enabled = true;
            btn_DisplaySI.Enabled = false;

            //fetch Selected Data
            txt_InvoiceMS.Text = dg_InvoiceReport.CurrentRow.Cells[4].Value.ToString();
            txt_InvoiceSC.Text = dg_InvoiceReport.CurrentRow.Cells[7].Value.ToString();
            txt_SINo.Text = dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString();
            dt_SaleInvoice.Text = dg_InvoiceReport.CurrentRow.Cells[2].Value.ToString();
            rt_InvoiceNarration.Text = dg_InvoiceReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmountSI.Text = dg_InvoiceReport.CurrentRow.Cells[5].Value.ToString();
            cbo_SaleCurrencySI.Text = dg_InvoiceReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conSInvoice))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SaleInProductDB WHERE InvoiceNo=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_SINo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "SaleInProductDB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_InvoiceProductDetails.Rows.Add(dr);
                        dg_InvoiceProductDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["ColorInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["SizeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCodeInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["QualityInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["LotInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["QuantityInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["RateInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConvInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["Discount1Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["Discount1AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["Discount2Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["Discount2AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["Discount3Invoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["Discount3AmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalAmountInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["proPrimaryInvoice"]);
                        dg_InvoiceProductDetails.Rows[i].ReadOnly = true;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_InvoiceSC.Enabled = false;
            txt_InvoiceMS.Enabled = false;
            dt_SaleInvoice.Enabled = false;
            rt_InvoiceNarration.Enabled = false;
            txt_TotalAmountSI.Enabled = false;
        }
    }
}
