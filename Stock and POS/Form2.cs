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
        private int _currentStockOnForm = 0;
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
                                lstSearchResults.Items.Clear();

                                decimal sellingPrice = reader["SellingPrice"] is DBNull ? 0 : Convert.ToDecimal(reader["SellingPrice"]);
                                decimal costPrice = reader["CostPrice"] is DBNull ? 0 : Convert.ToDecimal(reader["CostPrice"]);
                                int currentQuantity = reader["Quantity"] is DBNull ? 0 : Convert.ToInt32(reader["Quantity"]);
                                _currentStockOnForm = currentQuantity;

                                lstSearchResults.Items.Add("--- PRODUCT DETAILS ---");
                                lstSearchResults.Items.Add("Brand: " + reader["Brand"].ToString());
                                lstSearchResults.Items.Add("Description: " + reader["Description"].ToString());

                                string weightVolume = reader["WeightVolume"].ToString();
                                string weightUnit = reader["WeightVolumeUnit"].ToString();
                                lstSearchResults.Items.Add($"Weight/Volume: {weightVolume} {weightUnit}");

                                lstSearchResults.Items.Add($"Selling Price: {sellingPrice:C}");
                                lstSearchResults.Items.Add($"Cost Price: {costPrice:C}");

                                lstSearchResults.Items.Add($"Lead Time (Days): {reader["LeadTimeDays"].ToString()}");

                                lstSearchResults.Items.Add($"*** Current Stock: {currentQuantity} ***");

                                btnUpdateStock.Enabled = true;
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
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string updateStockQuery = "UPDATE tblStock SET Quantity = Quantity + @quantityChange WHERE Barcode = @barcode";
            string barcode = txtBarcodeSearch.Text;
            string quantityText = txtQuantityToAdd.Text;

            if (string.IsNullOrWhiteSpace(quantityText) || quantityText == "0")
            {
                MessageBox.Show("Please enter a quantity to add.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantityToAdd.Focus();
                return;
            }

            if (!int.TryParse(quantityText, out int newQuantity))
            {
                MessageBox.Show("Please enter a quantity to add/remove.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantityToAdd.Focus();
                return;
            }

            if (chkRemoveStock.Checked)
            {
                // Confirmation for stock removal
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to REMOVE stock?",
                    "Confirm Stock Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
                newQuantity = -newQuantity;
            }

            if (newQuantity + _currentStockOnForm < 0)
            {
                MessageBox.Show("Cannot remove more stock than is currently available.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityToAdd.Focus();
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(AppConfig.ConnectionString))
            {
                using (OleDbCommand command = new OleDbCommand(updateStockQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@quantity", newQuantity);
                        command.Parameters.AddWithValue("@barcode", barcode);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Stock updated successfully from {_currentStockOnForm} to {newQuantity + _currentStockOnForm}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearStockFields();
                        }
                        else
                        {
                            MessageBox.Show("Stock update was not saved. No rows affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void clearStockFields()
        {
            btnUpdateStock.Enabled = false;
            lstSearchResults.Items.Clear();
            txtQuantityToAdd.Text = "";
        }

        private void btnSwitchToProducts_Click(object sender, EventArgs e)
        {
            frmEnterProduct productForm = new frmEnterProduct();
            productForm.Show();
            this.Hide();
        }

        private void txtBarcodeSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchBarcode.PerformClick();
                e.Handled = true;
            }
        }
    }
}
