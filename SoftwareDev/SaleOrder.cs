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
    public partial class SaleOrder : Form
    {
        static string conPurchase = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Purchase_OrderDBConnectionString"].ConnectionString;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        static string conPInvoice = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.PurchaseInvoiceDBConnectionString"].ConnectionString;
        static string conSOrder = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Sale_OrderDBConnectionString"].ConnectionString;
        public SaleOrder()
        {
            InitializeComponent();
        }

        private void SaleOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sale_OrderDBDataSet.SaleOrderDB' table. You can move, or remove it, as needed.
            this.saleOrderDBTableAdapter.Fill(this.sale_OrderDBDataSet.SaleOrderDB);
            this.FormBorderStyle = FormBorderStyle.None;
            this.dt_SaleOrderDate.Value = DateTime.Today;
            btn_DisplaySO.Enabled = false;
            btn_UpdateSO.Enabled = false;
            saleOrderAutoNo();
        }

        private void saleOrderAutoNo()
        {
           /* String query = "SELECT max (SO_No)+1 FROM SaleOrderDB";
            using (SqlConnection cons = new SqlConnection(conSOrder))
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
                                lbl_SaleOrderNo.Text = dtr[0].ToString();
                                if (lbl_SaleOrderNo.Text == "")
                                {
                                    lbl_SaleOrderNo.Text = "1";
                                }
                            }
                        }
                        else
                        {
                            lbl_SaleOrderNo.Text = "1";
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
        private void btn_SelectMSSaleOrder_Click(object sender, EventArgs e)
        {
            ButtonClicked.saleOrderButtonClick = (sender as Button).Text;
            SearchClient searchClient = new SearchClient();
            searchClient.ShowDialog();
            this.txt_SaleOrderSC.Text = searchClient.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
        }

        private void txt_SaleOrderSC_TextChanged(object sender, EventArgs e)
        {
            if (txt_SaleOrderSC.Text == String.Empty)
            {
                txt_SaleOrderMS.Text = String.Empty;
            }
            using (SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT Name FROM ClientDB WHERE ShortCode='" + this.txt_SaleOrderSC.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_SaleOrderMS.Text = dtaRead["Name"].ToString();
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

        private void btn_CloseSO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_ProductDetailsSO_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_ProductDetailsSO.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dg_SaleOrderReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_SaleOrderReport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_AddNewSO_Click(object sender, EventArgs e)
        {
            //Clear Fields
            saleOrderAutoNo();
            dt_SaleOrderDate.Value = DateTime.Today;
            cbo_SaleOrderCurrency.Text = String.Empty;
            txt_SaleOrderSC.Text = String.Empty;
            txt_SaleOrderMS.Text = String.Empty;
            rt_Narration.Text = String.Empty;
            txt_TotalAmountSO.Text = String.Empty;
            dg_ProductDetailsSO.Rows.Clear();

            //Buttons Disabling
            btn_SubmitNewSO.Enabled = true;
            btn_UpdateSO.Enabled = false;
            btn_DisplaySO.Enabled = false;
        }

        private void btn_SubmitNewSO_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conPO = new SqlConnection(conSOrder))
                {
                    conPO.Open();
                    using (SqlCommand cmd = conPO.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO SaleOrderDB (SO_Date,ShortCode,MS,Narration,Total_Amount,SaleCurrency) VALUES(@inDate,@inSC,@inMS,@inNarration,@intotal,@inCurrency)";
                        cmd.Parameters.AddWithValue("@inDate", this.dt_SaleOrderDate.Value);
                        cmd.Parameters.AddWithValue("@inSC", this.txt_SaleOrderSC.Text.Trim());
                        cmd.Parameters.AddWithValue("@inMS", this.txt_SaleOrderMS.Text.Trim());
                        cmd.Parameters.AddWithValue("@inNarration", this.rt_Narration.Text.Trim());
                        cmd.Parameters.AddWithValue("@intotal", this.txt_TotalAmountSO.Text.Trim());
                        cmd.Parameters.AddWithValue("@inCurrency", this.cbo_SaleOrderCurrency.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    conPO.Close();
                }

                for (int i = 0; i < dg_ProductDetailsSO.Rows.Count - 1; i++)
                {
                    using (SqlConnection conPro = new SqlConnection(conSOrder))
                    {
                        conPro.Open();
                        using (SqlCommand cmd = conPro.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Product_SODB (ColorCode,Color,SizeCode,Size,QualityCode,Quality,Lot,Quantity,Rate,RateConv,Amount,SO_No,discount1,discount1_Amount,discount2,discount2_Amount,discount3,discount3_Amount,FinalAmount) VALUES(@inColorCode,@inColor,@inSizeCode,@inSize,@inQualityCode,@inQuality,@inLot,@inQuantity,@inRate,@inRateConv,@inAmount,@inInvoiceNO,@indiscount1,@indiscount1Amount,@indiscount2,@indiscount2Amount,@indiscount3,@indiscount3Amount,@infinalAmount)";
                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[13].Value));
                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[14].Value));
                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[15].Value));
                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[16].Value));
                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[17].Value));
                            cmd.Parameters.AddWithValue("@infinalAmount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            cmd.Parameters.AddWithValue("@inInvoiceNO", txt_SoNo.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        conPro.Close();
                    }
                }
                refreshSaleOrderReport();
                dg_ProductDetailsSO.Rows.Clear();
                this.txt_SaleOrderSC.Text = String.Empty;
                this.txt_SaleOrderMS.Text = String.Empty;
                this.dt_SaleOrderDate.Value = DateTime.Today;
                this.rt_Narration.Text = String.Empty;
                this.txt_TotalAmountSO.Text = String.Empty;
                saleOrderAutoNo();
            }
        }
        private void refreshSaleOrderReport()
        {
            SqlConnection conS = new SqlConnection(conSOrder);
            conS.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM SaleOrderDB";
            cmd = new SqlCommand(query, conS);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_SaleOrderReport.DataSource = dt;
            conS.Close();
        }

        private void dg_ProductDetailsSO_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dg_ProductDetailsSO.CurrentCell.ColumnIndex == 8 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 9 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 10 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 11 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 12 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 13 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 14 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 15 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 16 || dg_ProductDetailsSO.CurrentCell.ColumnIndex == 17) //Desired Column
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

        private void dg_ProductDetailsSO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double finalTotalAmount = 0;
            for (int i = 0; i < dg_ProductDetailsSO.Rows.Count - 1; i++)
            {
                double quan = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[8].Value);
                double ra = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[9].Value);
                double subAmount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[11].Value);
                double rConv = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[10].Value);
                double discount1 = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[12].Value);
                double discount2 = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[14].Value);
                double discount3 = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[16].Value);
                if (dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "RateSO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "RateConvSO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount1SO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount2SO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount3SO")
                {
                    if (dg_ProductDetailsSO.Rows[i].Cells[10].Value == null)
                    {
                        subAmount = quan * ra;
                        dg_ProductDetailsSO.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetailsSO.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetailsSO.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetailsSO.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[17].Value);
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                    }
                    else
                    {
                        subAmount = quan * ra * rConv;
                        dg_ProductDetailsSO.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetailsSO.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetailsSO.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetailsSO.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[17].Value);
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                    }
                }
                else if (dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "AmountSO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount1SO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount2SO" || dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "Discount3SO")
                {
                    if (dg_ProductDetailsSO.Rows[i].Cells[10].Value == null)
                    {
                        
                        ra = subAmount / quan;
                        dg_ProductDetailsSO.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetailsSO.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetailsSO.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetailsSO.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[17].Value);
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                    }
                    else
                    {
                        ra = subAmount / (quan * rConv);
                        dg_ProductDetailsSO.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_ProductDetailsSO.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_ProductDetailsSO.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_ProductDetailsSO.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[17].Value);
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_ProductDetailsSO.Rows[i].Cells[18].Value = subAmount;
                            finalTotalAmount += Math.Round(Convert.ToDouble(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            txt_TotalAmountSO.Text = Convert.ToString(finalTotalAmount);
                        }
                    }
                }
            }
        }

        private void dg_ProductDetailsSO_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dg_ProductDetailsSO.Rows.Count - 1; i++)
            {
                if (dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "ColorCodeSO")
                {
                    if (dg_ProductDetailsSO.Rows[i].Cells[1].Value == String.Empty)
                    {
                        dg_ProductDetailsSO.Rows[i].Cells[2].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + dg_ProductDetailsSO.Rows[i].Cells[1].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetailsSO.Rows[i].Cells[2].Value = dtaRead["ProductColor"].ToString();
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
                else if (dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "SizeCodeSO")
                {
                    if (dg_ProductDetailsSO.Rows[i].Cells[3].Value == String.Empty)
                    {
                        dg_ProductDetailsSO.Rows[i].Cells[4].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + dg_ProductDetailsSO.Rows[i].Cells[3].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetailsSO.Rows[i].Cells[4].Value = dtaRead["ProductSize"].ToString();
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
                else if (dg_ProductDetailsSO.Columns[e.ColumnIndex].Name == "QualityCodeSO")
                {
                    if (dg_ProductDetailsSO.Rows[i].Cells[5].Value == String.Empty)
                    {
                        dg_ProductDetailsSO.Rows[i].Cells[6].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + dg_ProductDetailsSO.Rows[i].Cells[5].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_ProductDetailsSO.Rows[i].Cells[6].Value = dtaRead["ProductQuality"].ToString();
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

        private void dg_ProductDetailsSO_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void cbo_SaleOrderCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SaleOrderCurrency.Text == "₹ Sale")
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = "₹ ";
                dg_ProductDetailsSO.Columns["AmountSO"].DefaultCellStyle.FormatProvider = format;
                dg_ProductDetailsSO.Columns["AmountSO"].DefaultCellStyle.Format = "c";
                dg_ProductDetailsSO.Columns["RateSO"].DefaultCellStyle.FormatProvider = format;
                dg_ProductDetailsSO.Columns["RateSO"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_ProductDetailsSO.Rows.Count; i++)
                {
                    dg_ProductDetailsSO.Rows[i].Cells[10].ReadOnly = false;
                    dg_ProductDetailsSO.Rows[i].Cells[10].Style.BackColor = Color.White;

                }
            }
            else if (cbo_SaleOrderCurrency.Text == "$ Sale")
            {
                var formats = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                formats.CurrencySymbol = "$ ";
                dg_ProductDetailsSO.Columns["AmountSO"].DefaultCellStyle.FormatProvider = formats;
                dg_ProductDetailsSO.Columns["AmountSO"].DefaultCellStyle.Format = "c";
                dg_ProductDetailsSO.Columns["RateSO"].DefaultCellStyle.FormatProvider = formats;
                dg_ProductDetailsSO.Columns["RateSO"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_ProductDetailsSO.Rows.Count; i++)
                {
                    dg_ProductDetailsSO.Rows[i].Cells[10].ReadOnly = true;
                    dg_ProductDetailsSO.Rows[i].Cells[10].Style.BackColor = Color.Gray;

                }
            }
        }

        private void dg_ProductDetailsSO_KeyDown(object sender, KeyEventArgs e)
        {
            if (dg_ProductDetailsSO.CurrentCell.ColumnIndex == 1)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    ColorAdd cA = new ColorAdd();
                    cA.ShowDialog();
                    this.dg_ProductDetailsSO.CurrentRow.Cells[1].Value = cA.cCode;
                    this.dg_ProductDetailsSO.CurrentRow.Cells[2].Value = cA.cColor;
                }
            }
            if (dg_ProductDetailsSO.CurrentCell.ColumnIndex == 3)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchSize ss = new SearchSize();
                    ss.ShowDialog();
                    this.dg_ProductDetailsSO.CurrentRow.Cells[3].Value = ss.sCode;
                    this.dg_ProductDetailsSO.CurrentRow.Cells[4].Value = ss.sSize;
                }
            }
            if (dg_ProductDetailsSO.CurrentCell.ColumnIndex == 5)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    SearchQuality searchQuality = new SearchQuality();
                    searchQuality.ShowDialog();
                    this.dg_ProductDetailsSO.CurrentRow.Cells[5].Value = searchQuality.qCode;
                    this.dg_ProductDetailsSO.CurrentRow.Cells[6].Value = searchQuality.qQuality;
                }
            }
        }

        private void btn_UpdateSO_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conSOrder))
                {

                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        //Save All CLient Data of PO
                        cmd.CommandText = "UPDATE SaleOrderDB SET SO_Date=@inDate,ShortCode=@inSC,MS=@inMS,Narration=@inNarration,Total_Amount=@inTAmount,SaleCurrency=@inCurrency WHERE SO_No=@inNO";
                        cmd.Parameters.AddWithValue("@inNO", txt_SoNo.Text);
                        cmd.Parameters.AddWithValue("@inDate", dt_SaleOrderDate.Value);
                        cmd.Parameters.AddWithValue("@inSC", txt_SaleOrderSC.Text);
                        cmd.Parameters.AddWithValue("@inMS", txt_SaleOrderMS.Text);
                        cmd.Parameters.AddWithValue("@inNarration", rt_Narration.Text);
                        cmd.Parameters.AddWithValue("@inTAmount", txt_TotalAmountSO.Text);
                        cmd.Parameters.AddWithValue("@inCurrency", cbo_SaleOrderCurrency.Text);
                        cmd.ExecuteNonQuery();
                        refreshSaleOrderReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conSOrder))
                {
                    conPro.Open();
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        for (int i = 0; i < dg_ProductDetailsSO.Rows.Count - 1; i++)
                        {
                            cmd.Parameters.Clear();
                            //Save All Product Data of PO
                            cmd.CommandText = "UPDATE Product_SODB SET ColorCode=@inColorCode,Color=@inColor,SizeCode=@inSizeCode,Size=@inSize,QualityCode=@inQualityCode,Quality=@inQuality,Lot=@inLot,Quantity=@inQuantity,Rate=@inRate,RateConv=@inRateConv,Amount=@inAmount,SO_No=@inNo,discount1=@indiscount1,discount1_Amount=@indiscount1Amount,discount2=@indiscount2,discount2_Amount=@indiscount2Amount,discount3=@indiscount3,discount3_Amount=@indiscount3Amount,FinalAmount=@infinalAmount WHERE product_Primary=@inPri";
                            cmd.Parameters.AddWithValue("@inPri", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[19].Value));
                            cmd.Parameters.AddWithValue("@inColorCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@inColor", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@inSizeCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@inSize", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@inQualityCode", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@inQuality", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@inLot", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@inQuantity", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@inRate", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@inRateConv", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@inAmount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@indiscount1", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@indiscount1Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[13].Value));
                            cmd.Parameters.AddWithValue("@indiscount2", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[14].Value));
                            cmd.Parameters.AddWithValue("@indiscount2Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[15].Value));
                            cmd.Parameters.AddWithValue("@indiscount3", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[16].Value));
                            cmd.Parameters.AddWithValue("@indiscount3Amount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[17].Value));
                            cmd.Parameters.AddWithValue("@infinalAmount", Convert.ToString(dg_ProductDetailsSO.Rows[i].Cells[18].Value));
                            cmd.Parameters.AddWithValue("@inNo", txt_SoNo.Text);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    conPro.Close();
                }
                dg_ProductDetailsSO.Rows.Clear();
                txt_SaleOrderSC.Text = String.Empty;
                txt_SaleOrderMS.Text = String.Empty;
                txt_TotalAmountSO.Text = String.Empty;
                rt_Narration.Text = String.Empty;
                dt_SaleOrderDate.Value = DateTime.Today;

                saleOrderAutoNo();
            }
        }

        private void btn_DeleteSO_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conSOrder))
                {
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        cmd.CommandText = "DELETE SaleOrderDB WHERE SO_No=@iID";
                        cmd.Parameters.AddWithValue("@iID", dg_SaleOrderReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        refreshSaleOrderReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conSOrder))
                {
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        conPro.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE Product_SODB WHERE SO_No=@inID";
                        cmd.Parameters.AddWithValue("@inID", dg_SaleOrderReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conPro.Close();
                    }
                }
            }
        }

        private void btn_EditSO_Click(object sender, EventArgs e)
        {
            btn_SubmitNewSO.Enabled = false;
            btn_UpdateSO.Enabled = true;
            btn_DisplaySO.Enabled = false;

            //fetch Selected Data
            txt_SaleOrderMS.Text = dg_SaleOrderReport.CurrentRow.Cells[4].Value.ToString();
            txt_SaleOrderSC.Text = dg_SaleOrderReport.CurrentRow.Cells[7].Value.ToString();
            txt_SoNo.Text = dg_SaleOrderReport.CurrentRow.Cells[1].Value.ToString();
            dt_SaleOrderDate.Text = dg_SaleOrderReport.CurrentRow.Cells[2].Value.ToString();
            rt_Narration.Text = dg_SaleOrderReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmountSO.Text = dg_SaleOrderReport.CurrentRow.Cells[5].Value.ToString();
            cbo_SaleOrderCurrency.Text = dg_SaleOrderReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conSOrder))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product_SODB WHERE SO_No=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_SoNo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Product_SODB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_ProductDetailsSO.Rows.Add(dr);
                        dg_ProductDetailsSO.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["ColorSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["SizeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["QualitySO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["LotSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["QuantitySO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["RateSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConvSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["Discount1SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["Discount1AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["Discount2SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["Discount2AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["Discount3SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["Discount3AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalDiscountedAmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["proPrimaryOrder"]);
                        dg_ProductDetailsSO.Rows[i].ReadOnly = false;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_SaleOrderMS.Enabled = true;
            txt_SaleOrderSC.Enabled = true;
            dt_SaleOrderDate.Enabled = true;
            rt_Narration.Enabled = true;
            txt_TotalAmountSO.Enabled = true;
        }

        private void dg_SaleOrderReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_SubmitNewSO.Enabled = false;
            btn_UpdateSO.Enabled = false;
            btn_DisplaySO.Enabled = true;

            //fetch Selected Data
            txt_SaleOrderMS.Text = dg_SaleOrderReport.CurrentRow.Cells[4].Value.ToString();
            txt_SaleOrderSC.Text = dg_SaleOrderReport.CurrentRow.Cells[7].Value.ToString();
            txt_SoNo.Text = dg_SaleOrderReport.CurrentRow.Cells[1].Value.ToString();
            dt_SaleOrderDate.Text = dg_SaleOrderReport.CurrentRow.Cells[2].Value.ToString();
            rt_Narration.Text = dg_SaleOrderReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmountSO.Text = dg_SaleOrderReport.CurrentRow.Cells[5].Value.ToString();
            cbo_SaleOrderCurrency.Text = dg_SaleOrderReport.CurrentRow.Cells[3].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conSOrder))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product_SODB WHERE SO_No=@inNO";
                    cmd.Parameters.AddWithValue("@inNO", txt_SoNo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Product_SODB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_ProductDetailsSO.Rows.Add(dr);
                        dg_ProductDetailsSO.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["ColorSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["SizeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCodeSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["QualitySO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["LotSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["QuantitySO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["RateSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["RateConvSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["Discount1SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[13].Value = Convert.ToString(dt.Rows[i]["Discount1AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[14].Value = Convert.ToString(dt.Rows[i]["Discount2SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[15].Value = Convert.ToString(dt.Rows[i]["Discount2AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[16].Value = Convert.ToString(dt.Rows[i]["Discount3SO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[17].Value = Convert.ToString(dt.Rows[i]["Discount3AmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[18].Value = Convert.ToString(dt.Rows[i]["FinalDiscountedAmountSO"]);
                        dg_ProductDetailsSO.Rows[i].Cells[19].Value = Convert.ToString(dt.Rows[i]["proPrimaryOrder"]);
                        dg_ProductDetailsSO.Rows[i].ReadOnly = true;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_SaleOrderMS.Enabled = false;
            txt_SaleOrderSC.Enabled = false;
            dt_SaleOrderDate.Enabled = false;
            rt_Narration.Enabled = false;
            txt_TotalAmountSO.Enabled = false;

            //Active Control
            this.ActiveControl = btn_EditSO;
        }
    }
}
