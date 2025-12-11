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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            string barcode = txtBarcodeSearch.Text;

            if (!InputValidation.validBarcode(barcode))
            {
                MessageBox.Show("The Barcode must contain only numerical digits (0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcodeSearch.Focus();
                return;
            }

            string barcodeSearchQuery = "SELECT * FROM tblProduct WHERE Barcode = @barcode";

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
                                lstSearchResults.Items.Clear();

                                decimal sellingPrice = reader["SellingPrice"] is DBNull ? 0 : Convert.ToDecimal(reader["SellingPrice"]);
                                decimal costPrice = reader["CostPrice"] is DBNull ? 0 : Convert.ToDecimal(reader["CostPrice"]);

                                lstSearchResults.Items.Add("--- PRODUCT DETAILS ---");
                                lstSearchResults.Items.Add("Brand: " + reader["Brand"].ToString());
                                lstSearchResults.Items.Add("Description: " + reader["Description"].ToString());

                                string weightVolume = reader["WeightVolume"].ToString();
                                string weightUnit = reader["WeightVolumeUnit"].ToString();
                                lstSearchResults.Items.Add($"Weight/Volume: {weightVolume} {weightUnit}");

                                lstSearchResults.Items.Add($"Selling Price: {sellingPrice:C}");
                                lstSearchResults.Items.Add($"Cost Price: {costPrice:C}");

                                lstSearchResults.Items.Add($"Lead Time (Days): {reader["LeadTimeDays"].ToString()}");

                                btnAddStock.Enabled = true;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.OnlyNumericValues(sender, e);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            btnAddStock.Enabled = false;
        }
    }
}
