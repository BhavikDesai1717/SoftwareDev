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
    public partial class PurchaseInvoice : Form
    {
        public string varInv;
        static string conPurchase = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Purchase_OrderDBConnectionString"].ConnectionString;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        static string conPInvoice = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.PurchaseInvoiceDBConnectionString"].ConnectionString;
        static string conWarehouse = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.WarehouseConnectionString"].ConnectionString;
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchaseInvoiceDBDataSet.InvoiceDB' table. You can move, or remove it, as needed.
            this.invoiceDBTableAdapter.Fill(this.purchaseInvoiceDBDataSet.InvoiceDB);
            // TODO: This line of code loads data into the 'purchase_OrderDBDataSet.PurchaseOrderDB' table. You can move, or remove it, as needed.
            this.purchaseOrderDBTableAdapter.Fill(this.purchase_OrderDBDataSet.PurchaseOrderDB);
            this.FormBorderStyle = FormBorderStyle.None;
            this.dt_InvoiceDate.Value = DateTime.Today;
            btn_OKInvoice.Enabled = false;
            btn_SaveInvoiceData.Enabled = false;
           
        }
        
        private void btn_SelectMSInvoice_Click(object sender, EventArgs e)
        {
            ButtonClicked.invoiceButtonClick = (sender as Button).Text;
            SearchClient selectClient = new SearchClient();
            selectClient.ShowDialog();
            this.txt_InvSC.Text = selectClient.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_CloseInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_InvSC_TextChanged(object sender, EventArgs e)
        {
            if (txt_InvSC.Text == String.Empty)
            {
                txt_InvMS.Text = String.Empty;
            }
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT Name FROM ClientDB WHERE ShortCode='" + this.txt_InvSC.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_InvMS.Text = dtaRead["Name"].ToString();
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

        private void btn_AddNewInvoice_Click(object sender, EventArgs e)
        {
            //Clear Fields
            dt_InvoiceDate.Value = DateTime.Today;
            cbo_InvoiceCurrency.Text = String.Empty;
            txt_InvSC.Text = String.Empty;
            txt_InvMS.Text = String.Empty;
            rt_InvoiceNarration.Text = String.Empty;
            txt_InvoiceTotalAmount.Text = String.Empty;
            dg_ProductDetails.Rows.Clear();

            //Buttons Disabling
            btn_InsertNewInvoice.Enabled = true;
            btn_SaveInvoiceData.Enabled = false;
            btn_OKInvoice.Enabled = false;
        }

        private void btn_InsertNewInvoice_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conPO = new SqlConnection(conPInvoice))
                {
                    conPO.Open();
                    using (SqlCommand cmd = conPO.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO InvoiceDB (InvoiceDate,ShortCode,MS,Narration,TotalAmount,InvoiceCurrency) VALUES(@inDate,@inSC,@inMS,@inNarration,@intotal,@inCurrency)";
                        cmd.Parameters.AddWithValue("@inDate", this.dt_InvoiceDate.Value);
                        cmd.Parameters.AddWithValue("@inSC", this.txt_InvSC.Text.Trim());
                        cmd.Parameters.AddWithValue("@inMS", this.txt_InvMS.Text.Trim());
                        cmd.Parameters.AddWithValue("@inNarration", this.rt_InvoiceNarration.Text.Trim());
                        cmd.Parameters.AddWithValue("@intotal", this.txt_InvoiceTotalAmount.Text.Trim());
                        cmd.Parameters.AddWithValue("@inCurrency", this.cbo_InvoiceCurrency.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conPO.Close();
                }

                for (int i = 0; i < dg_ProductDetails.Rows.Count - 1; i++)
                {
                    using (SqlConnection conPro = new SqlConnection(conPInvoice))
                    {
                        conPro.Open();
                        using (SqlCommand cmd = conPro.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO InvoiceProductDB (ColorCode,Color,SizeCode,Size,QualityCode,Quality,Lot,Quantity,Rate,RateConv,Amount,InvoiceNo,discount1,discount1Amount,discount2,discount2Amount,discount3,discount3Amount,finalAmount) VALUES(@inColorCode,@inColor,@inSizeCode,@inSize,@inQualityCode,@inQuality,@inLot,@inQuantity,@inRate,@inRateConv,@inAmount,@inInvoiceNO,@indiscount1,@indiscount1Amount,@indiscount2,@indiscount2Amount,@indiscount3,@indiscount3Amount,@inFinalAmount)";
                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_ProductDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_ProductDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_ProductDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_ProductDetails.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_ProductDetails.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_ProductDetails.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_ProductDetails.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[13].Value));
                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_ProductDetails.Rows[i].Cells[14].Value));
                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[15].Value));
                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_ProductDetails.Rows[i].Cells[16].Value));
                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[17].Value));
                            cmd.Parameters.AddWithValue("@inFinalAmount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[18].Value));
                            cmd.Parameters.AddWithValue("@inInvoiceNO", txt_Invoice_No.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        conPro.Close();
                    }
                    using(SqlConnection conW = new SqlConnection(conWarehouse))
                    {
                        conW.Open();
                        using(SqlCommand cmd = conW.CreateCommand())
                        {

                            cmd.CommandText = "IF EXISTS(select Inward_Quantity,Balance_Quantity,Rate from Warehouse where Color=@colorWarehouse AND Size=@sizeWarehouse AND Quality=@qualityWarehouse AND Lot=@lotWarehouse) Update Warehouse SET Rate=((Inward_Quantity*Rate)+(@inQuantityWarehouse*@rateWarehouse))/(Inward_Quantity+@inQuantityWarehouse),Inward_Quantity=Inward_Quantity+@inQuantityWarehouse,Balance_Quantity=Balance_Quantity+@balQuantityWarehouse where Color=@colorWarehouse AND Size=@sizeWarehouse AND Quality=@qualityWarehouse AND Lot=@lotWarehouse ELSE insert into Warehouse(Color,Size,Quality,Lot,Inward_Quantity,Balance_Quantity,Rate) values(@colorWarehouse,@sizeWarehouse,@qualityWarehouse,@lotWarehouse,@newinQuantityWarehouse,@newbalQuantityWarehouse,@rateWarehouse)";
                            cmd.Parameters.AddWithValue("@colorWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@sizeWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@qualityWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@lotWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@newinQuantityWarehouse", Convert.ToInt32(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@newbalQuantityWarehouse", Convert.ToInt32(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inQuantityWarehouse", Convert.ToInt32(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@balQuantityWarehouse", Convert.ToInt32(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@rateWarehouse", Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[9].Value));
                            cmd.ExecuteNonQuery();
                        }
                        conW.Close();
                    }
                }
                refreshGridInvoiceReport();
                dg_ProductDetails.Rows.Clear();
                this.txt_InvSC.Text = String.Empty;
                this.txt_InvMS.Text = String.Empty;
                this.dt_InvoiceDate.Value = DateTime.Today;
                this.rt_InvoiceNarration.Text = String.Empty;
                this.txt_InvoiceTotalAmount.Text = String.Empty;
            }
        }
        private void refreshGridInvoiceReport()
        {
            SqlConnection conP = new SqlConnection(conPInvoice);
            conP.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM InvoiceDB";
            cmd = new SqlCommand(query, conP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_InvoiceReport.DataSource = dt;
            conP.Close();
        }

        private void dg_ProductDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_ProductDetails.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_InvoiceReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_InvoiceReport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_InvoiceReport_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Disabling buttons
            btn_SaveInvoiceData.Enabled = false;
            btn_InsertNewInvoice.Enabled = false;
            btn_OKInvoice.Enabled = true;
            //Data Fetching
            txt_InvMS.Text = dg_InvoiceReport.CurrentRow.Cells[4].Value.ToString();
            txt_InvSC.Text = dg_InvoiceReport.CurrentRow.Cells[7].Value.ToString();
            txt_Invoice_No.Text = dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString();
            dt_InvoiceDate.Text = dg_InvoiceReport.CurrentRow.Cells[2].Value.ToString();
            rt_InvoiceNarration.Text = dg_InvoiceReport.CurrentRow.Cells[6].Value.ToString();
            txt_InvoiceTotalAmount.Text = dg_InvoiceReport.CurrentRow.Cells[5].Value.ToString();
            cbo_InvoiceCurrency.Text = dg_InvoiceReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conPInvoice))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM InvoiceProductDB WHERE InvoiceNo=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_Invoice_No.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "InvoiceProductDB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_ProductDetails.Rows.Add(dr);
                        dg_ProductDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                        dg_ProductDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                        dg_ProductDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                        dg_ProductDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                        dg_ProductDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                        dg_ProductDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                        dg_ProductDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                        dg_ProductDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                        dg_ProductDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                        dg_ProductDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConv"]);
                        dg_ProductDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                        dg_ProductDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["discount1"]);
                        dg_ProductDetails.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["discount1Amount"]);
                        dg_ProductDetails.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["discount2"]);
                        dg_ProductDetails.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["discount2Amount"]);
                        dg_ProductDetails.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["discount3"]);
                        dg_ProductDetails.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["discount3Amount"]);
                        dg_ProductDetails.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalAmount"]);
                        dg_ProductDetails.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["productPrimary"]);
                        dg_ProductDetails.Rows[i].ReadOnly = true;
                    }
                }
                conP.Close();
            }
            //Disabling fields
            txt_InvMS.Enabled = false;
            txt_InvSC.Enabled = false;
            dt_InvoiceDate.Enabled = false;
            rt_InvoiceNarration.Enabled = false;
            txt_InvoiceTotalAmount.Enabled = false;

            //btnControl
            this.ActiveControl = btn_EditInvoice;
        }

        private void btn_DeleteInvoice_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conPInvoice))
                {
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        cmd.CommandText = "DELETE InvoiceDB WHERE InvoiceNo=@iID";
                        cmd.Parameters.AddWithValue("@iID", dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        refreshGridInvoiceReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conPInvoice))
                {
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        conPro.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE InvoiceProductDB WHERE InvoiceNo=@inID";
                        cmd.Parameters.AddWithValue("@inID", dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conPro.Close();
                    }
                }
            }
        }

        private void btn_EditInvoice_Click(object sender, EventArgs e)
        {
            btn_InsertNewInvoice.Enabled = false;
            btn_SaveInvoiceData.Enabled = true;
            btn_OKInvoice.Enabled = false;

            //fetch Selected Data
            txt_InvMS.Text = dg_InvoiceReport.CurrentRow.Cells[4].Value.ToString();
            txt_InvSC.Text = dg_InvoiceReport.CurrentRow.Cells[7].Value.ToString();
            txt_Invoice_No.Text = dg_InvoiceReport.CurrentRow.Cells[1].Value.ToString();
            dt_InvoiceDate.Text = dg_InvoiceReport.CurrentRow.Cells[2].Value.ToString();
            rt_InvoiceNarration.Text = dg_InvoiceReport.CurrentRow.Cells[6].Value.ToString();
            txt_InvoiceTotalAmount.Text = dg_InvoiceReport.CurrentRow.Cells[5].Value.ToString();
            cbo_InvoiceCurrency.Text = dg_InvoiceReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conPInvoice))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM InvoiceProductDB WHERE InvoiceNo=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_Invoice_No.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "InvoiceProductDB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_ProductDetails.Rows.Add(dr);
                        dg_ProductDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                        dg_ProductDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                        dg_ProductDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                        dg_ProductDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                        dg_ProductDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                        dg_ProductDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                        dg_ProductDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                        dg_ProductDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                        dg_ProductDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                        dg_ProductDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConv"]);
                        dg_ProductDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                        dg_ProductDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["discount1"]);
                        dg_ProductDetails.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["discount1Amount"]);
                        dg_ProductDetails.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["discount2"]);
                        dg_ProductDetails.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["discount2Amount"]);
                        dg_ProductDetails.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["discount3"]);
                        dg_ProductDetails.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["discount3Amount"]);
                        dg_ProductDetails.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalAmount"]);
                        dg_ProductDetails.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["productPrimary"]);
                        dg_ProductDetails.Rows[i].ReadOnly = false;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_InvMS.Enabled = true;
            txt_InvSC.Enabled = true;
            dt_InvoiceDate.Enabled = true;
            rt_InvoiceNarration.Enabled = true;
            txt_InvoiceTotalAmount.Enabled = true;

        }

        private void btn_SaveInvoiceData_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conPInvoice))
                {

                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        //Save All CLient Data of PO
                        cmd.CommandText = "UPDATE InvoiceDB SET InvoiceDate=@inDate,ShortCode=@inSC,MS=@inMS,Narration=@inNarration,TotalAmount=@inTAmount,InvoiceCurrency=@inCurrency WHERE InvoiceNo=@inNO";
                        cmd.Parameters.AddWithValue("@inNO", txt_Invoice_No.Text);
                        cmd.Parameters.AddWithValue("@inDate", dt_InvoiceDate.Value);
                        cmd.Parameters.AddWithValue("@inSC", txt_InvSC.Text);
                        cmd.Parameters.AddWithValue("@inMS", txt_InvMS.Text);
                        cmd.Parameters.AddWithValue("@inNarration", rt_InvoiceNarration.Text);
                        cmd.Parameters.AddWithValue("@inTAmount", txt_InvoiceTotalAmount.Text);
                        cmd.Parameters.AddWithValue("@inCurrency", cbo_InvoiceCurrency.Text);
                        cmd.ExecuteNonQuery();
                        refreshGridInvoiceReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conPInvoice))
                {
                    conPro.Open();
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        for (int i = 0; i < dg_ProductDetails.Rows.Count - 1; i++)
                        {
                            cmd.Parameters.Clear();
                            //Save All Product Data of PO
                            cmd.CommandText = "UPDATE InvoiceProductDB SET ColorCode=@inColorCode,Color=@inColor,SizeCode=@inSizeCode,Size=@inSize,QualityCode=@inQualityCode,Quality=@inQuality,Lot=@inLot,Quantity=@inQuantity,Rate=@inRate,RateConv=@inRateConv,Amount=@inAmount,InvoiceNo=@inNo,discount1=@indiscount1,discount1Amount=@indiscount1Amount,discount2=@indiscount2,discount2Amount=@indiscount2Amount,discount3=@indiscount3,discount3Amount=@indiscount3Amount,FinalAmount=@inFinalAmount WHERE productPrimary=@inPri";
                            cmd.Parameters.AddWithValue("@inPri", Convert.ToString(dg_ProductDetails.Rows[i].Cells[19].Value));
                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_ProductDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_ProductDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_ProductDetails.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_ProductDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_ProductDetails.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_ProductDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_ProductDetails.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_ProductDetails.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_ProductDetails.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[13].Value));
                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_ProductDetails.Rows[i].Cells[14].Value));
                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[15].Value));
                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_ProductDetails.Rows[i].Cells[16].Value));
                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[17].Value));
                            cmd.Parameters.AddWithValue("@inFinalAmount", Convert.ToString(dg_ProductDetails.Rows[i].Cells[18].Value));
                            cmd.Parameters.AddWithValue("@inNo", txt_Invoice_No.Text);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    conPro.Close();
                }
                using(SqlConnection conSW = new SqlConnection(conWarehouse))
                {
                    conSW.Open();
                    using(SqlCommand cmd = conSW.CreateCommand())
                    {
                        for (int i = 0; i < dg_ProductDetails.Rows.Count - 1; i++)
                        {
                            string inwardQuantity, balanceQuantity;
                            cmd.Parameters.Clear();
                            cmd.CommandText = "SELECT Inward_Quantity,Balance_Quantity FROM Warehouse WHERE Color=@cWarehouse AND Size=@sWarehouse AND Quality=@qWarehouse AND Lot=@lWarehouse";
                            cmd.Parameters.AddWithValue("@cWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@sWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@qWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@lWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[7].Value));
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            sda.Fill(ds, "Warehouse");
                            DataTable dt = new DataTable();
                            dt = ds.Tables[0];
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                inwardQuantity = Convert.ToString(dt.Rows[j]["Inward_Quantity"]);
                                balanceQuantity = Convert.ToString(dt.Rows[j]["Balance_Quantity"]);
                                //Save All Product Data of Warehouse
                                cmd.CommandText = "UPDATE Warehouse SET Inward_Quantity=@inQuantityWarehouse,Balance_Quantity=@balQuantityWarehouse WHERE Color=@colorWarehouse AND Size=@sizeWarehouse AND Quality=@qualityWarehouse AND Lot=@lotWarehouse";
                                cmd.Parameters.AddWithValue("@inQuantityWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[8].Value));
                                cmd.Parameters.AddWithValue("@balQuantityWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[8].Value));
                                cmd.Parameters.AddWithValue("@colorWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[2].Value));
                                cmd.Parameters.AddWithValue("@sizeWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[4].Value));
                                cmd.Parameters.AddWithValue("@qualityWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[6].Value));
                                cmd.Parameters.AddWithValue("@lotWarehouse", Convert.ToString(dg_ProductDetails.Rows[i].Cells[7].Value));
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    conSW.Close();
                }
                dg_ProductDetails.Rows.Clear();
                txt_InvSC.Text = String.Empty;
                txt_InvMS.Text = String.Empty;
                txt_InvoiceTotalAmount.Text = String.Empty;
                rt_InvoiceNarration.Text = String.Empty;
                dt_InvoiceDate.Value = DateTime.Today;

            }
        }

        private void dg_ProductDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dg_ProductDetails.CurrentCell.ColumnIndex == 8 || dg_ProductDetails.CurrentCell.ColumnIndex == 9 || dg_ProductDetails.CurrentCell.ColumnIndex == 10 || dg_ProductDetails.CurrentCell.ColumnIndex == 11 || dg_ProductDetails.CurrentCell.ColumnIndex == 12 || dg_ProductDetails.CurrentCell.ColumnIndex == 13 || dg_ProductDetails.CurrentCell.ColumnIndex == 14 || dg_ProductDetails.CurrentCell.ColumnIndex == 15 || dg_ProductDetails.CurrentCell.ColumnIndex == 16 || dg_ProductDetails.CurrentCell.ColumnIndex == 17) //Desired Column
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

        private void dg_ProductDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total_Amount = 0;
            for (int i = 0; i < dg_ProductDetails.Rows.Count - 1; i++)
            {
                double quan = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[8].Value);
                double ra = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[9].Value);
                double subAmount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[11].Value);
                double rConv = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[10].Value);
                double discount1 = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[12].Value);
                double discount2 = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[14].Value);
                double discount3 = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[16].Value);
                if (dg_ProductDetails.Columns[e.ColumnIndex].Name == "RateInvoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "RateConvInvoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount1Invoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount2Invoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount3Invoice")
                {
                    if (dg_ProductDetails.Rows[i].Cells[10].Value == null)
                    {
                        subAmount = quan * ra;
                        dg_ProductDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[17].Value);
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        subAmount = quan * ra * rConv;
                        dg_ProductDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[17].Value);
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                }
                else if (dg_ProductDetails.Columns[e.ColumnIndex].Name == "AmountInvoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount1Invoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount2Invoice" || dg_ProductDetails.Columns[e.ColumnIndex].Name == "discount3Invoice")
                {
                    if (dg_ProductDetails.Rows[i].Cells[10].Value == null)
                    {
                        ra = subAmount / quan;
                        dg_ProductDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[17].Value);
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        ra = subAmount / (quan * rConv);
                        dg_ProductDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[17].Value);
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_ProductDetails.Rows[i].Cells[18].Value));
                            txt_InvoiceTotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                }
            }
        }

        private void dg_ProductDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dg_ProductDetails.Rows.Count - 1; i++)
            {
                if (dg_ProductDetails.Columns[e.ColumnIndex].Name == "ColorCodeInvoice")
                {
                    if (dg_ProductDetails.Rows[i].Cells[1].Value == String.Empty)
                    {
                        dg_ProductDetails.Rows[i].Cells[2].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + dg_ProductDetails.Rows[i].Cells[1].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetails.Rows[i].Cells[2].Value = dtaRead["ProductColor"].ToString();
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
                else if (dg_ProductDetails.Columns[e.ColumnIndex].Name == "SizeCodeInvoice")
                {
                    if (dg_ProductDetails.Rows[i].Cells[3].Value == String.Empty)
                    {
                        dg_ProductDetails.Rows[i].Cells[4].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + dg_ProductDetails.Rows[i].Cells[3].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetails.Rows[i].Cells[4].Value = dtaRead["ProductSize"].ToString();
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
                else if (dg_ProductDetails.Columns[e.ColumnIndex].Name == "QualityCodeInvoice")
                {
                    if (dg_ProductDetails.Rows[i].Cells[5].Value == String.Empty)
                    {
                        dg_ProductDetails.Rows[i].Cells[6].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + dg_ProductDetails.Rows[i].Cells[5].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetails.Rows[i].Cells[6].Value = dtaRead["ProductQuality"].ToString();
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

        private void dg_ProductDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void cbo_InvoiceCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_InvoiceCurrency.Text == "₹ Purchase")
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = "₹ ";
                dg_ProductDetails.Columns["AmountInvoice"].DefaultCellStyle.FormatProvider = format;
                dg_ProductDetails.Columns["AmountInvoice"].DefaultCellStyle.Format = "c";
                dg_ProductDetails.Columns["RateInvoice"].DefaultCellStyle.FormatProvider = format;
                dg_ProductDetails.Columns["RateInvoice"].DefaultCellStyle.Format = "c";
                for(int i = 0;i<dg_ProductDetails.Rows.Count;i++)
                {
                    dg_ProductDetails.Rows[i].Cells[10].ReadOnly = false;
                    dg_ProductDetails.Rows[i].Cells[10].Style.BackColor = Color.White;

                }
            }
            else if (cbo_InvoiceCurrency.Text == "$ Purchase")
            {
                var formats = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                formats.CurrencySymbol = "$ ";
                dg_ProductDetails.Columns["AmountInvoice"].DefaultCellStyle.FormatProvider = formats;
                dg_ProductDetails.Columns["AmountInvoice"].DefaultCellStyle.Format = "c";
                dg_ProductDetails.Columns["RateInvoice"].DefaultCellStyle.FormatProvider = formats;
                dg_ProductDetails.Columns["RateInvoice"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_ProductDetails.Rows.Count; i++)
                {
                    dg_ProductDetails.Rows[i].Cells[10].ReadOnly = true;
                    dg_ProductDetails.Rows[i].Cells[10].Style.BackColor = Color.Gray;
                }
            }
        }

        private void dg_ProductDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (dg_ProductDetails.CurrentCell.ColumnIndex == 1)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    ColorAdd cA = new ColorAdd();
                    cA.ShowDialog();
                    this.dg_ProductDetails.CurrentRow.Cells[1].Value = cA.cCode;
                    this.dg_ProductDetails.CurrentRow.Cells[2].Value = cA.cColor;
                }
            }
            if (dg_ProductDetails.CurrentCell.ColumnIndex == 3)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchSize ss = new SearchSize();
                    ss.ShowDialog();
                    this.dg_ProductDetails.CurrentRow.Cells[3].Value = ss.sCode;
                    this.dg_ProductDetails.CurrentRow.Cells[4].Value = ss.sSize;
                }
            }
            if (dg_ProductDetails.CurrentCell.ColumnIndex == 5)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchQuality searchQuality = new SearchQuality();
                    searchQuality.ShowDialog();
                    this.dg_ProductDetails.CurrentRow.Cells[5].Value = searchQuality.qCode;
                    this.dg_ProductDetails.CurrentRow.Cells[6].Value = searchQuality.qQuality;
                }
            }
        }

        private void cbo_SelectPO_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(SqlConnection conPO = new SqlConnection(conPurchase))
            {
                conPO.Open();
                using(SqlCommand cmd = conPO.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM PurchaseOrderDB WHERE PO_No=@pPONO";
                    cmd.Parameters.AddWithValue("@pPONO", cbo_SelectPO.Text.Trim());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "PurchaseOrderDB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    dt_InvoiceDate.Value = DateTime.Today;
                    cbo_InvoiceCurrency.Text = Convert.ToString(dt.Rows[0]["PurchaseCurrency"]);
                    rt_InvoiceNarration.Text = Convert.ToString(dt.Rows[0]["Narration"]);
                    txt_InvSC.Text = Convert.ToString(dt.Rows[0]["ShortCode"]);
                    txt_InvMS.Text = Convert.ToString(dt.Rows[0]["MS"]);
                    txt_InvoiceTotalAmount.Text = Convert.ToString(dt.Rows[0]["Total_Amount"]);
                }
                conPO.Close();
            }
            using (SqlConnection conPro = new SqlConnection(conPurchase))
            {
                conPro.Open();
                using (SqlCommand cmd = conPro.CreateCommand())
                {
                    cmd.CommandText = "Select * FROM Product_PODB WHERE PO_NO=@pPNo";
                    cmd.Parameters.AddWithValue("@pPNo", cbo_SelectPO.Text.Trim());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Product_PODB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for(int i =0;i<dt.Rows.Count;i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_ProductDetails.Rows.Add(dr);
                        dg_ProductDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                        dg_ProductDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                        dg_ProductDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                        dg_ProductDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                        dg_ProductDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                        dg_ProductDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                        dg_ProductDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                        dg_ProductDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                        dg_ProductDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                        dg_ProductDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["Rate_Conv"]);
                        dg_ProductDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                        dg_ProductDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["discount1"]);
                        dg_ProductDetails.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["discount1Amount"]);
                        dg_ProductDetails.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["discount2"]);
                        dg_ProductDetails.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["discount2Amount"]);
                        dg_ProductDetails.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["discount3"]);
                        dg_ProductDetails.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["discount3Amount"]);
                        dg_ProductDetails.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalAmount"]);
                        dg_ProductDetails.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["productPrimary"]);
                    }
                }
                conPro.Close();
            }
            //disabling and enabling fields
            btn_SaveInvoiceData.Enabled = false;
            btn_InsertNewInvoice.Enabled = true;
            btn_OKInvoice.Enabled = false;
        }

        private void btn_OKInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
