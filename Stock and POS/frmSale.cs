using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_and_POS
{
    public partial class frmSale : Form
    {
        private int _currentStockOnForm = 0;
        private StringBuilder barcodeBuffer = new StringBuilder();
        private System.Windows.Forms.Timer scanTimer = new System.Windows.Forms.Timer();
        private const int BARCODE_TERMINATOR_KEY = 13; 

        public frmSale()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Sale_KeyPress);

            scanTimer.Interval = 50;
            scanTimer.Tick += ScanTimer_Tick;
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            ProcessScannedBarcode(txtBarcodeSearch.Text.Trim());
        }

        private void Sale_KeyPress(object sender, KeyPressEventArgs e)
        {
            scanTimer.Stop();

            if ((int)e.KeyChar == BARCODE_TERMINATOR_KEY)
            {
                e.Handled = true;
                string scannedBarcode = barcodeBuffer.ToString();

                ProcessScannedBarcode(scannedBarcode);

                barcodeBuffer.Clear();
            }
            else
            {
                barcodeBuffer.Append(e.KeyChar);
                scanTimer.Start();
            }
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            scanTimer.Stop();
            barcodeBuffer.Clear();
        }

        private void ProcessScannedBarcode(string barcode)
        {
            if (!InputValidation.validBarcode(barcode))
            {
                MessageBox.Show("The Barcode must contain only numerical digits (0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcodeSearch.Focus();
                return;
            }

            string barcodeSearchQuery = @"
                                            SELECT 
                                                P.*, 
                                                S.Quantity 
                                            FROM 
                                                tblProduct AS P
                                            LEFT JOIN 
                                                tblStock AS S ON P.Barcode = S.Barcode
                                            WHERE 
                                                P.Barcode = @barcode";

            using (OleDbConnection connection = new OleDbConnection(AppConfig.ConnectionString))
            {
                using (OleDbCommand checkCommand = new OleDbCommand(barcodeSearchQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@barcodeToCheck", barcode);

                    try
                    {
                        connection.Open();

                        using (OleDbDataReader reader = checkCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string saleItem = "";
                                decimal sellingPrice = reader["SellingPrice"] is DBNull ? 0 : Convert.ToDecimal(reader["SellingPrice"]);
                              
                                int currentQuantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]);
                                _currentStockOnForm = currentQuantity;

                                saleItem = (" " + reader["Brand"].ToString());
                                saleItem += (" " + reader["Description"].ToString()) + " ";

                                saleItem += reader["WeightVolume"].ToString() + " ";
                                saleItem += reader["WeightVolumeUnit"].ToString();

                                saleItem += " R" + sellingPrice.ToString();

                                lstNewSale.Items.Add(saleItem);   
                            }
                            else
                            {
                                MessageBox.Show($"No product found with barcode: {barcode}", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during product search: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection.State == System.Data.ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
