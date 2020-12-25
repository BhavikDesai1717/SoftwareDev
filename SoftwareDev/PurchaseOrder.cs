using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace SoftwareDev
{
    public partial class PurchaseOrder : Form
    {
        public string var;
        public string poFullAccess, poView, poCreate, poEdit, poDelete;
        static string conPurchase = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Purchase_OrderDBConnectionString"].ConnectionString;
        static string conClient = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.Client_DatabaseConnectionString"].ConnectionString;
        static string conRole = ConfigurationManager.ConnectionStrings["SoftwareDev.Properties.Settings.RoleLoginConnectionString"].ConnectionString;
        public PurchaseOrder()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchase_OrderDBDataSet.PurchaseOrderDB' table. You can move, or remove it, as needed.
            this.purchaseOrderDBTableAdapter.Fill(this.purchase_OrderDBDataSet.PurchaseOrderDB);
            this.FormBorderStyle = FormBorderStyle.None;
            dt_PONo.Value = DateTime.Today;
            btn_OKPO.Enabled = false;
            btn_Save.Enabled = false;
            /*using(SqlConnection conR = new SqlConnection(conRole))
            {
                conR.Open();
                using(SqlCommand cmd = conR.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM rolePermissionsDB WHERE Role_Name=@roleName";
                    cmd.Parameters.AddWithValue("@roleName", MyConnection.type);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        poFullAccess = dr[2].ToString();
                        poView = dr[3].ToString();
                        poCreate = dr[4].ToString();
                        poEdit = dr[5].ToString();
                        poDelete = dr[6].ToString();
                    }
                }
                conR.Close();
            }
            if(poCreate == "Yes")
            {
                btn_InsertNewPO.Visible = true;
            }else if(poCreate == "No")
            {
                btn_InsertNewPO.Visible = false;
            }*/
        }

        private void btn_POClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dg_PDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_PDetails.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        
        private void dg_PDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_PDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dg_PDetails.CurrentCell.ColumnIndex == 8 || dg_PDetails.CurrentCell.ColumnIndex == 9 || dg_PDetails.CurrentCell.ColumnIndex == 10 || dg_PDetails.CurrentCell.ColumnIndex == 11) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            if (dg_PDetails.CurrentCell.ColumnIndex == 12)
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = " %";
                dg_PDetails.Columns["Discount1"].DefaultCellStyle.FormatProvider = format;
                dg_PDetails.Columns["Discount1"].DefaultCellStyle.Format = "c";
            }

        }
        
        private void dg_PDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total_Amount = 0;
            for (int i = 0; i < dg_PDetails.Rows.Count - 1; i++)
            {
                double quan = Convert.ToDouble(dg_PDetails.Rows[i].Cells[8].Value);
                double ra = Convert.ToDouble(dg_PDetails.Rows[i].Cells[9].Value);
                double subAmount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[11].Value);
                double rConv = Convert.ToDouble(dg_PDetails.Rows[i].Cells[10].Value);
                double discount1 = Convert.ToDouble(dg_PDetails.Rows[i].Cells[12].Value);
                double discount2 = Convert.ToDouble(dg_PDetails.Rows[i].Cells[14].Value);
                double discount3 = Convert.ToDouble(dg_PDetails.Rows[i].Cells[16].Value);
                if (dg_PDetails.Columns[e.ColumnIndex].Name == "RateProduct" || dg_PDetails.Columns[e.ColumnIndex].Name == "RateConvProduct" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount1" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount2" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount3")
                {
                    if (dg_PDetails.Rows[i].Cells[10].Value == null)
                    {
                        subAmount = quan * ra;
                        dg_PDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_PDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_PDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_PDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[17].Value);
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        subAmount = quan * ra * rConv;
                        dg_PDetails.Rows[i].Cells[11].Value = subAmount;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_PDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_PDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_PDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[17].Value);
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                }
                else if (dg_PDetails.Columns[e.ColumnIndex].Name == "AmountProduct" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount1" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount2" || dg_PDetails.Columns[e.ColumnIndex].Name == "Discount3")
                {
                    if (dg_PDetails.Rows[i].Cells[10].Value == null)
                    {
                        ra = subAmount / quan;
                        dg_PDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_PDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_PDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_PDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[17].Value);
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
                    else
                    {
                        ra = subAmount / (quan * rConv);
                        dg_PDetails.Rows[i].Cells[9].Value = ra;
                        if (discount1 != null || discount2 != null || discount3 != null)
                        {
                            double percent1 = discount1 / 100;
                            double percent2 = discount2 / 100;
                            double percent3 = discount3 / 100;
                            dg_PDetails.Rows[i].Cells[13].Value = subAmount * percent1;
                            dg_PDetails.Rows[i].Cells[15].Value = subAmount * percent2;
                            dg_PDetails.Rows[i].Cells[17].Value = subAmount * percent3;
                            double discount1Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[13].Value);
                            double discount2Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[15].Value);
                            double discount3Amount = Convert.ToDouble(dg_PDetails.Rows[i].Cells[17].Value);
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount - discount1Amount - discount2Amount - discount3Amount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                        else if (discount1 == null && discount2 == null && discount3 == null)
                        {
                            dg_PDetails.Rows[i].Cells[18].Value = subAmount;
                            total_Amount += Math.Round(Convert.ToDouble(dg_PDetails.Rows[i].Cells[18].Value));
                            txt_TotalAmount.Text = Convert.ToString(total_Amount);
                        }
                    }
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

        
        private void dg_PDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_PDetails.Columns[e.ColumnIndex].Name == "Discount1")
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = " %";
                dg_PDetails.Columns["Discount1"].DefaultCellStyle.FormatProvider = format;
                dg_PDetails.Columns["Discount1"].DefaultCellStyle.Format = "c";
            }
            for (int i = 0; i < dg_PDetails.Rows.Count - 1; i++)
            {
                if (dg_PDetails.Columns[e.ColumnIndex].Name == "ColorCode")
                {
                    if (dg_PDetails.Rows[i].Cells[1].Value == String.Empty)
                    {
                        dg_PDetails.Rows[i].Cells[2].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductColor FROM ProductColorDB WHERE ColorCode='" + dg_PDetails.Rows[i].Cells[1].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_PDetails.Rows[i].Cells[2].Value = dtaRead["ProductColor"].ToString();
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
                else if (dg_PDetails.Columns[e.ColumnIndex].Name == "SizeCode")
                {
                    if (dg_PDetails.Rows[i].Cells[3].Value == String.Empty)
                    {
                        dg_PDetails.Rows[i].Cells[4].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductSize FROM ProductSizeDB WHERE SizeCode='" + dg_PDetails.Rows[i].Cells[3].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_PDetails.Rows[i].Cells[4].Value = dtaRead["ProductSize"].ToString();
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
                else if (dg_PDetails.Columns[e.ColumnIndex].Name == "QualityCode")
                {
                    if (dg_PDetails.Rows[i].Cells[5].Value == String.Empty)
                    {
                        dg_PDetails.Rows[i].Cells[6].Value = String.Empty;
                    }
                    using (SqlConnection conC = new SqlConnection(conClient))
                    {
                        conC.Open();
                        string query = "SELECT ProductQuality FROM ProductQualityDB WHERE QualityCode='" + dg_PDetails.Rows[i].Cells[5].Value + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conC))
                        {
                            SqlDataReader dtaRead;
                            try
                            {
                                dtaRead = cmd.ExecuteReader();
                                while (dtaRead.Read())
                                {
                                    dg_PDetails.Rows[i].Cells[6].Value = dtaRead["ProductQuality"].ToString();
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

        private void dg_PDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void dg_POReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg_POReport.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txt_POSC_TextChanged(object sender, EventArgs e)
        {
            if (txt_POSC.Text == String.Empty)
            {
                txt_POMS.Text = String.Empty;
            }
            using(SqlConnection conC = new SqlConnection(conClient))
            {
                conC.Open();
                string query = "SELECT Name FROM ClientDB WHERE ShortCode='" + this.txt_POSC.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query,conC))
                {
                    SqlDataReader dtaRead;
                    try
                    {
                        dtaRead = cmd.ExecuteReader();
                        while (dtaRead.Read())
                        {
                            txt_POMS.Text = dtaRead["Name"].ToString();
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
            ButtonClicked.purchaseOrderButtonClick = (sender as Button).Text;
            SearchClient sc = new SearchClient();
            sc.ShowDialog();
            this.txt_POSC.Text = sc.dg_searchClient.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_InsertNewPO_Click(object sender, EventArgs e)
        {
            if (poCreate == "Yes")
            {
                if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Submit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    using (SqlConnection conPO = new SqlConnection(conPurchase))
                    {
                        conPO.Open();
                        using (SqlCommand cmd = conPO.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO PurchaseOrderDB (PO_Date,ShortCode,MS,Narration,Total_Amount,PurchaseCurrency) VALUES(@poDate,@poSC,@poMS,@poNarration,@pototal,@poPCurrency)";
                            cmd.Parameters.AddWithValue("@poDate", this.dt_PONo.Value);
                            cmd.Parameters.AddWithValue("@poSC", this.txt_POSC.Text.Trim());
                            cmd.Parameters.AddWithValue("@poMS", this.txt_POMS.Text.Trim());
                            cmd.Parameters.AddWithValue("@poNarration", this.rt_PONarration.Text.Trim());
                            cmd.Parameters.AddWithValue("@pototal", this.txt_TotalAmount.Text.Trim());
                            cmd.Parameters.AddWithValue("@poPCurrency", this.cbo_PurchaseCurrency.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        conPO.Close();
                    }

                    for (int i = 0; i < dg_PDetails.Rows.Count - 1; i++)
                    {
                        using (SqlConnection conPro = new SqlConnection(conPurchase))
                        {
                            conPro.Open();
                            using (SqlCommand cmd = conPro.CreateCommand())
                            {
                                cmd.CommandText = "INSERT INTO Product_PODB (ColorCode,Color,SizeCode,Size,QualityCode,Quality,Lot,Quantity,Rate,Rate_Conv,Amount,PO_NO) VALUES(@prColorCode,@prColor,@prSizeCode,@prSize,@prQualityCode,@prQuality,@prLot,@prQuantity,@prRate,@prRateConv,@prAmount,@prPONO)";
                                cmd.Parameters.AddWithValue("@prColorCode", Convert.ToString(dg_PDetails.Rows[i].Cells[1].Value));
                                cmd.Parameters.AddWithValue("@prColor", Convert.ToString(dg_PDetails.Rows[i].Cells[2].Value));
                                cmd.Parameters.AddWithValue("@prSizeCode", Convert.ToString(dg_PDetails.Rows[i].Cells[3].Value));
                                cmd.Parameters.AddWithValue("@prSize", Convert.ToString(dg_PDetails.Rows[i].Cells[4].Value));
                                cmd.Parameters.AddWithValue("@prQualityCode", Convert.ToString(dg_PDetails.Rows[i].Cells[5].Value));
                                cmd.Parameters.AddWithValue("@prQuality", Convert.ToString(dg_PDetails.Rows[i].Cells[6].Value));
                                cmd.Parameters.AddWithValue("@prLot", Convert.ToString(dg_PDetails.Rows[i].Cells[7].Value));
                                cmd.Parameters.AddWithValue("@prQuantity", Convert.ToString(dg_PDetails.Rows[i].Cells[8].Value));
                                cmd.Parameters.AddWithValue("@prRate", Convert.ToString(dg_PDetails.Rows[i].Cells[9].Value));
                                cmd.Parameters.AddWithValue("@prRateConv", Convert.ToString(dg_PDetails.Rows[i].Cells[10].Value));
                                cmd.Parameters.AddWithValue("@prAmount", Convert.ToString(dg_PDetails.Rows[i].Cells[11].Value));
                                cmd.Parameters.AddWithValue("@prPONO", txt_PONo.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }
                            conPro.Close();
                        }
                    }
                    refreshGrid_POReport();
                    dg_PDetails.Rows.Clear();
                    this.txt_POSC.Text = String.Empty;
                    this.txt_POMS.Text = String.Empty;
                    this.dt_PONo.Value = DateTime.Today;
                    this.rt_PONarration.Text = String.Empty;
                    this.txt_TotalAmount.Text = String.Empty;
                }
            }
           
        }
        private void refreshGrid_POReport()
        {
            SqlConnection conP = new SqlConnection(conPurchase);
            conP.Open();
            SqlCommand cmd;
            string query = "SELECT * FROM PurchaseOrderDB";
            cmd = new SqlCommand(query, conP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            dg_POReport.DataSource = dt;
            conP.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {

                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        //Save All CLient Data of PO
                        cmd.CommandText = "UPDATE PurchaseOrderDB SET PO_Date=@pDate,ShortCode=@pSC,MS=@pMS,Narration=@pNarration,Total_Amount=@pTAmount,PurchaseCurrency=@poPCurrency WHERE PO_No=@pPONO";
                        cmd.Parameters.AddWithValue("@pPONO", txt_PONo.Text);
                        cmd.Parameters.AddWithValue("@pDate", dt_PONo.Value);
                        cmd.Parameters.AddWithValue("@pSC", txt_POSC.Text);
                        cmd.Parameters.AddWithValue("@pMS", txt_POMS.Text);
                        cmd.Parameters.AddWithValue("@pNarration", rt_PONarration.Text);
                        cmd.Parameters.AddWithValue("@pTAmount", txt_TotalAmount.Text);
                        cmd.Parameters.AddWithValue("@poPCurrency", cbo_PurchaseCurrency.Text);
                        cmd.ExecuteNonQuery();
                        refreshGrid_POReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conPurchase))
                {
                    conPro.Open();
                    using (SqlCommand cmd = conPro.CreateCommand())
                    { 
                        for (int i = 0; i < dg_PDetails.Rows.Count - 1; i++)
                        {
                            cmd.Parameters.Clear();
                            //Save All Product Data of PO
                            cmd.CommandText = "UPDATE Product_PODB SET ColorCode=@pColorCode,Color=@pColor,SizeCode=@pSizeCode,Size=@pSize,QualityCode=@pQualityCode,Quality=@pQuality,Lot=@pLot,Quantity=@pQuantity,Rate=@pRate,Rate_Conv=@pRateConv,Amount=@pAmount,PO_NO=@pPO WHERE product_primary=@pPri";
                            cmd.Parameters.AddWithValue("@pPri", Convert.ToString(dg_PDetails.Rows[i].Cells[12].Value));
                            cmd.Parameters.AddWithValue("@pColorCode", Convert.ToString(dg_PDetails.Rows[i].Cells[1].Value));
                            cmd.Parameters.AddWithValue("@pColor", Convert.ToString(dg_PDetails.Rows[i].Cells[2].Value));
                            cmd.Parameters.AddWithValue("@pSizeCode", Convert.ToString(dg_PDetails.Rows[i].Cells[3].Value));
                            cmd.Parameters.AddWithValue("@pSize", Convert.ToString(dg_PDetails.Rows[i].Cells[4].Value));
                            cmd.Parameters.AddWithValue("@pQualityCode", Convert.ToString(dg_PDetails.Rows[i].Cells[5].Value));
                            cmd.Parameters.AddWithValue("@pQuality", Convert.ToString(dg_PDetails.Rows[i].Cells[6].Value));
                            cmd.Parameters.AddWithValue("@pLot", Convert.ToString(dg_PDetails.Rows[i].Cells[7].Value));
                            cmd.Parameters.AddWithValue("@pQuantity", Convert.ToString(dg_PDetails.Rows[i].Cells[8].Value));
                            cmd.Parameters.AddWithValue("@pRate", Convert.ToString(dg_PDetails.Rows[i].Cells[9].Value));
                            cmd.Parameters.AddWithValue("@pRateConv", Convert.ToString(dg_PDetails.Rows[i].Cells[10].Value));
                            cmd.Parameters.AddWithValue("@pAmount", Convert.ToString(dg_PDetails.Rows[i].Cells[11].Value));
                            cmd.Parameters.AddWithValue("@pPO", txt_PONo.Text);
                            cmd.ExecuteNonQuery();
                            
                        }
                    }
                    conPro.Close();
                }
                dg_PDetails.Rows.Clear();
                txt_POSC.Text = String.Empty;
                txt_POMS.Text = String.Empty;
                txt_TotalAmount.Text = String.Empty;
                rt_PONarration.Text = String.Empty;
                dt_PONo.Value = DateTime.Today;

            }
        }

        private void btn_POEdit_Click(object sender, EventArgs e)
        {
            btn_InsertNewPO.Enabled = false;
            btn_Save.Enabled = true;
            btn_OKPO.Enabled = false;

            //fetch Selected Data
            txt_POMS.Text = dg_POReport.CurrentRow.Cells[4].Value.ToString();
            txt_POSC.Text = dg_POReport.CurrentRow.Cells[3].Value.ToString();
            txt_PONo.Text = dg_POReport.CurrentRow.Cells[1].Value.ToString();
            dt_PONo.Text = dg_POReport.CurrentRow.Cells[2].Value.ToString();
            rt_PONarration.Text = dg_POReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmount.Text = dg_POReport.CurrentRow.Cells[5].Value.ToString();
            cbo_PurchaseCurrency.Text = dg_POReport.CurrentRow.Cells[7].Value.ToString();

            using(SqlConnection conP = new SqlConnection(conPurchase))
            {
                conP.Open();
                using(SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product_PODB WHERE PO_NO=@pPONO";
                    cmd.Parameters.AddWithValue("@pPONO", txt_PONo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Product_PODB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for(int i = 0; i <dt.Rows.Count;i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_PDetails.Rows.Add(dr);
                        dg_PDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                        dg_PDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                        dg_PDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                        dg_PDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                        dg_PDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                        dg_PDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                        dg_PDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                        dg_PDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                        dg_PDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                        dg_PDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["Rate_Conv"]);
                        dg_PDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                        dg_PDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["product_primary"]);
                        dg_PDetails.Rows[i].ReadOnly = false;
                    }
                }
                conP.Close();
            }

            //Enabling fields
            txt_POMS.Enabled = true;
            txt_POSC.Enabled = true;
            dt_PONo.Enabled = true;
            rt_PONarration.Enabled = true;
            txt_TotalAmount.Enabled = true;

        }

        private void dg_PDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (dg_PDetails.CurrentCell.ColumnIndex == 1)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    
                    ColorAdd cA = new ColorAdd();
                    cA.ShowDialog();
                    this.dg_PDetails.CurrentRow.Cells[1].Value = cA.cCode;
                    this.dg_PDetails.CurrentRow.Cells[2].Value = cA.cColor;
                    
                }
            }
            if(dg_PDetails.CurrentCell.ColumnIndex == 3)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                    
                    SearchSize ss = new SearchSize();
                    ss.ShowDialog();
                    this.dg_PDetails.CurrentRow.Cells[3].Value = ss.sCode;
                    this.dg_PDetails.CurrentRow.Cells[4].Value = ss.sSize;
                }
            }
            if (dg_PDetails.CurrentCell.ColumnIndex == 5)
            {
                if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)
                {
                   
                    SearchQuality searchQuality = new SearchQuality();
                    searchQuality.ShowDialog();
                    this.dg_PDetails.CurrentRow.Cells[5].Value = searchQuality.qCode;
                    this.dg_PDetails.CurrentRow.Cells[6].Value = searchQuality.qQuality;
                }
            }
        }

        private void cbo_PurchaseCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_PurchaseCurrency.Text == "₹ Purchase")
            {
                var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                format.CurrencySymbol = "₹ ";
                dg_PDetails.Columns["AmountProduct"].DefaultCellStyle.FormatProvider = format;
                dg_PDetails.Columns["AmountProduct"].DefaultCellStyle.Format = "c";
                dg_PDetails.Columns["RateProduct"].DefaultCellStyle.FormatProvider = format;
                dg_PDetails.Columns["RateProduct"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_PDetails.Rows.Count; i++)
                {
                    dg_PDetails.Rows[i].Cells[10].ReadOnly = false;
                    dg_PDetails.Rows[i].Cells[10].Style.BackColor = Color.White;

                }
            }
            else if (cbo_PurchaseCurrency.Text == "$ Purchase")
            {
                var formats = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
                formats.CurrencySymbol = "$ ";
                dg_PDetails.Columns["AmountProduct"].DefaultCellStyle.FormatProvider = formats;
                dg_PDetails.Columns["AmountProduct"].DefaultCellStyle.Format = "c";
                dg_PDetails.Columns["RateProduct"].DefaultCellStyle.FormatProvider = formats;
                dg_PDetails.Columns["RateProduct"].DefaultCellStyle.Format = "c";
                for (int i = 0; i < dg_PDetails.Rows.Count; i++)
                {
                    dg_PDetails.Rows[i].Cells[10].ReadOnly = true;
                    dg_PDetails.Rows[i].Cells[10].Style.BackColor = Color.Gray;

                }
            }
        }

        private void btn_DeletePO_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want to Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        conP.Open();
                        cmd.CommandText = "DELETE PurchaseOrderDB WHERE PO_No=@pID";
                        cmd.Parameters.AddWithValue("@pID", dg_POReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        refreshGrid_POReport();
                        conP.Close();
                    }
                }
                using (SqlConnection conPro = new SqlConnection(conPurchase))
                {
                    using (SqlCommand cmd = conPro.CreateCommand())
                    {
                        conPro.Open();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "DELETE Product_PODB WHERE PO_NO=@pPOID";
                        cmd.Parameters.AddWithValue("@pPOID", dg_POReport.CurrentRow.Cells[1].Value.ToString());
                        cmd.ExecuteNonQuery();
                        conPro.Close();
                    }
                }
            }
        }

        private void dg_POReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Disabling buttons
            btn_Save.Enabled = false;
            btn_InsertNewPO.Enabled = false;
            btn_OKPO.Enabled = true;
            //Data Fetching
            txt_POMS.Text = dg_POReport.CurrentRow.Cells[4].Value.ToString();
            txt_POSC.Text = dg_POReport.CurrentRow.Cells[3].Value.ToString();
            txt_PONo.Text = dg_POReport.CurrentRow.Cells[1].Value.ToString();
            dt_PONo.Text = dg_POReport.CurrentRow.Cells[2].Value.ToString();
            rt_PONarration.Text = dg_POReport.CurrentRow.Cells[6].Value.ToString();
            txt_TotalAmount.Text = dg_POReport.CurrentRow.Cells[5].Value.ToString();
            cbo_PurchaseCurrency.Text = dg_POReport.CurrentRow.Cells[7].Value.ToString();

            using (SqlConnection conP = new SqlConnection(conPurchase))
            {
                conP.Open();
                using (SqlCommand cmd = conP.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product_PODB WHERE PO_NO=@pPONO";
                    cmd.Parameters.AddWithValue("@pPONO", txt_PONo.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Product_PODB");
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dg_PDetails.Rows.Add(dr);
                        dg_PDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                        dg_PDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                        dg_PDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                        dg_PDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                        dg_PDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                        dg_PDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                        dg_PDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                        dg_PDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                        dg_PDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                        dg_PDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["Rate_Conv"]);
                        dg_PDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                        dg_PDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["product_primary"]);
                        dg_PDetails.Rows[i].ReadOnly = true;
                    }
                }
                conP.Close();
            }
            //Disabling fields
            txt_POMS.Enabled = false;
            txt_POSC.Enabled = false;
            dt_PONo.Enabled = false;
            rt_PONarration.Enabled = false;
            txt_TotalAmount.Enabled = false;

            //btnControl
            this.ActiveControl = btn_POEdit;
        }

        private void btn_POEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.E)
            {
                btn_InsertNewPO.Enabled = false;
                btn_Save.Enabled = true;
                btn_OKPO.Enabled = false;

                //fetch Selected Data
                txt_POMS.Text = dg_POReport.CurrentRow.Cells[4].Value.ToString();
                txt_POSC.Text = dg_POReport.CurrentRow.Cells[3].Value.ToString();
                txt_PONo.Text = dg_POReport.CurrentRow.Cells[1].Value.ToString();
                dt_PONo.Text = dg_POReport.CurrentRow.Cells[2].Value.ToString();
                rt_PONarration.Text = dg_POReport.CurrentRow.Cells[6].Value.ToString();
                txt_TotalAmount.Text = dg_POReport.CurrentRow.Cells[5].Value.ToString();
                cbo_PurchaseCurrency.Text = dg_POReport.CurrentRow.Cells[7].Value.ToString();

                using (SqlConnection conP = new SqlConnection(conPurchase))
                {
                    conP.Open();
                    using (SqlCommand cmd = conP.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Product_PODB WHERE PO_NO=@pPONO";
                        cmd.Parameters.AddWithValue("@pPONO", txt_PONo.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "Product_PODB");
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataRow dr = dt.NewRow();
                            dg_PDetails.Rows.Add(dr);
                            dg_PDetails.Rows[i].Cells[1].Value = Convert.ToString(dt.Rows[i]["ColorCode"]);
                            dg_PDetails.Rows[i].Cells[2].Value = Convert.ToString(dt.Rows[i]["Color"]);
                            dg_PDetails.Rows[i].Cells[3].Value = Convert.ToString(dt.Rows[i]["SizeCode"]);
                            dg_PDetails.Rows[i].Cells[4].Value = Convert.ToString(dt.Rows[i]["Size"]);
                            dg_PDetails.Rows[i].Cells[5].Value = Convert.ToString(dt.Rows[i]["QualityCode"]);
                            dg_PDetails.Rows[i].Cells[6].Value = Convert.ToString(dt.Rows[i]["Quality"]);
                            dg_PDetails.Rows[i].Cells[7].Value = Convert.ToString(dt.Rows[i]["Lot"]);
                            dg_PDetails.Rows[i].Cells[8].Value = Convert.ToString(dt.Rows[i]["Quantity"]);
                            dg_PDetails.Rows[i].Cells[9].Value = Convert.ToString(dt.Rows[i]["Rate"]);
                            dg_PDetails.Rows[i].Cells[10].Value = Convert.ToString(dt.Rows[i]["Rate_Conv"]);
                            dg_PDetails.Rows[i].Cells[11].Value = Convert.ToString(dt.Rows[i]["Amount"]);
                            dg_PDetails.Rows[i].Cells[12].Value = Convert.ToString(dt.Rows[i]["product_primary"]);
                            dg_PDetails.Rows[i].ReadOnly = false;
                        }
                    }
                    conP.Close();
                }
                //Enabling fields
                txt_POMS.Enabled = true;
                txt_POSC.Enabled = true;
                dt_PONo.Enabled = true;
                rt_PONarration.Enabled = true;
                txt_TotalAmount.Enabled = true;
            }
        }

        private void btn_AddNewPO_Click(object sender, EventArgs e)
        {
            
            //clearing fields
            txt_POMS.Text = String.Empty;
            txt_POSC.Text = String.Empty;
            txt_TotalAmount.Text = String.Empty;
            rt_PONarration.Text = String.Empty;
            dt_PONo.Text = String.Empty;
            cbo_PurchaseCurrency.Text = String.Empty;
            dg_PDetails.Rows.Clear();

            //Buttons Disabling
            btn_InsertNewPO.Enabled = true;
            btn_Save.Enabled = false;
            btn_OKPO.Enabled = false;
        }
    }
}
