namespace Stock_and_POS
{
    using System.Data.OleDb;
    using System.Linq;

    public partial class frmEnterProduct : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2002s\Documents\Database\dbStockPOS.accdb";

        public frmEnterProduct()
        {
            InitializeComponent();
        }

        private void frmEnterProduct_Load(object sender, EventArgs e)
        {

        }

        private bool validBarcode(string barcode)
        {
            string cleanBarcode = barcode.Trim();

            if (string.IsNullOrEmpty(cleanBarcode))
            {
                return false;
            }

            return cleanBarcode.All(char.IsDigit);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarcode.Text) ||
                string.IsNullOrEmpty(txtCostPrice.Text) ||
                string.IsNullOrEmpty(txtSellingPrice.Text))
            {
                MessageBox.Show("Barcode, Cost Price, and Selling Price cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!validBarcode(txtBarcode.Text))
            {
                MessageBox.Show("The Barcode must contain only numerical digits (0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcode.Focus();
                return;
            }

            string barcode = txtBarcode.Text.Trim();
            string brand = txtBrand.Text;
            string weightVolume = txtSize.Text;
            string weightVolumeUnit = cmbSize.Text;
            string description = txtDescription.Text;
            decimal sellingPrice = decimal.Parse(txtSellingPrice.Text);
            decimal costPrice = decimal.Parse(txtCostPrice.Text);
            decimal leadTime = decimal.Parse(txtLeadTime.Text);

            string checkDuplicateQuery = "SELECT COUNT(Barcode) FROM tblProduct WHERE Barcode = @barcodeToCheck";

            string insertProductQuery = "INSERT INTO tblProduct (Barcode, Brand, Description, WeightVolume, WeightVolumeUnit, SellingPrice, CostPrice, LeadTimeDays) " +
                                        "VALUES (@barcode, @brand, @description, @weightVolume, @weightVolumeUnit, @sellingPrice, @costPrice, @leadTime)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // CHECK FOR EXISTING BARCODE

                using (OleDbCommand checkCommand = new OleDbCommand(checkDuplicateQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@barcodeToCheck", barcode);

                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show($"The barcode '{barcode}' already exists in the database. Product insertion aborted.",
                                        "Duplicate Barcode",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (OleDbCommand command = new OleDbCommand(insertProductQuery, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@barcode", barcode);
                        command.Parameters.AddWithValue("@brand", brand);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@WeightVolume", weightVolume);
                        command.Parameters.AddWithValue("@WeightVolumeUnit", weightVolumeUnit);
                        command.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                        command.Parameters.AddWithValue("@costPrice", costPrice);
                        command.Parameters.AddWithValue("@leadTime", leadTime);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear fields
                            clearProductFields();
                        }
                        else
                        {
                            MessageBox.Show("Product was not saved. No rows affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void clearProductFields()
        {
            txtBarcode.Text = "";
            txtBrand.Text = "";
            txtSize.Text = "";
            txtDescription.Text = "";
            txtSellingPrice.Text = "";
            txtCostPrice.Text = "";
            txtLeadTime.Text = "";
            cmbSize.SelectedIndex = -1;
            txtBarcode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearProductFields();
        }

        private void btnSearchBarcode_Click(object sender, EventArgs e)
        {
            string barcode = txtBarcodeSearch.Text;

            if (!validBarcode(barcode))
            {
                MessageBox.Show("The Barcode must contain only numerical digits (0-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcodeSearch.Focus();
                return;
            }

            string barcodeSearchQuery = "SELECT * FROM tblProduct WHERE Barcode = @barcode";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
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
                            }
                            else
                            {
                                MessageBox.Show($"No product found with barcode: {barcode}", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clearProductFields();
                                txtBarcode.Text = barcode;
                                txtBarcodeSearch.Focus();
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

        private void OnlyNumericValues(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (e.KeyChar == ',')
            {

                if (((TextBox)sender).Text.Contains(','))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PriceTextBoxLeave(object sender, EventArgs e)
        {
            TextBox priceBox = (TextBox)sender;
            decimal priceValue;

            if (!decimal.TryParse(priceBox.Text, out priceValue))
            {
                MessageBox.Show("Please enter a valid price (e.g., 12,50).", "Invalid Input");
                priceBox.Focus();
                priceBox.SelectAll();
            }
            else
            {
                priceBox.Text = priceValue.ToString("N2");
            }
        }

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumericValues(sender, e);
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumericValues(sender, e);
        }

        private void txtSellingPrice_Leave(object sender, EventArgs e)
        {
            PriceTextBoxLeave(sender, e);
        }

        private void txtCostPrice_Leave(object sender, EventArgs e)
        {
            PriceTextBoxLeave(sender, e);
        }
    }
}


