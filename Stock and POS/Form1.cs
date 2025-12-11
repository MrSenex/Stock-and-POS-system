namespace Stock_and_POS
{
    using System.Data.OleDb;
    using System.Linq;

    public partial class frmEnterProduct : Form
    {

        public frmEnterProduct()
        {
            InitializeComponent();
        }

        private void frmEnterProduct_Load(object sender, EventArgs e)
        {

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

            if (!InputValidation.validBarcode(txtBarcode.Text))
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
            int leadTime = int.Parse(txtLeadTime.Text);
            
            System.Globalization.CultureInfo currentCulture = System.Globalization.CultureInfo.CurrentCulture;
            if (!decimal.TryParse(txtSellingPrice.Text, System.Globalization.NumberStyles.Currency, currentCulture, out decimal sellingPrice) ||
                !decimal.TryParse(txtCostPrice.Text, System.Globalization.NumberStyles.Currency, currentCulture, out decimal costPrice))
            {
                MessageBox.Show("Invalid number format for price. Please check your price input.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            string checkDuplicateQuery = "SELECT COUNT(Barcode) FROM tblProduct WHERE Barcode = @checkBarcode";

            string insertProductQuery = "INSERT INTO tblProduct (Barcode, Brand, Description, WeightVolume, WeightVolumeUnit, SellingPrice, CostPrice, LeadTimeDays) " +
                                        "VALUES (@barcode, @brand, @description, @weightVolume, @weightVolumeUnit, @sellingPrice, @costPrice, @leadTime)";

            using (OleDbConnection connection = new OleDbConnection(AppConfig.ConnectionString))
            {
                connection.Open();

                // CHECK FOR EXISTING BARCODE

                using (OleDbCommand checkCommand = new OleDbCommand(checkDuplicateQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@checkBarcode", barcode);

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
                        command.Parameters.Add("@sellingPrice", OleDbType.Currency).Value = sellingPrice;
                        command.Parameters.Add("@costPrice", OleDbType.Currency).Value = costPrice;


                        command.Parameters.AddWithValue("@leadTime", leadTime);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            }
                            else
                            {
                                MessageBox.Show($"No product found with barcode: {barcode}", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clearProductFields();
                                txtBarcodeSearch.Text = barcode;
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

        private void txtSellingPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.OnlyNumericValues(sender, e);
        }

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.OnlyNumericValues(sender, e);
        }

        private void txtSellingPrice_Leave(object sender, EventArgs e)
        {
            InputValidation.PriceTextBoxLeave(sender, e);
        }

        private void txtCostPrice_Leave(object sender, EventArgs e)
        {
            InputValidation.PriceTextBoxLeave(sender, e);
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation.OnlyNumericValues(sender, e);
        }
    }

    public static class AppConfig
    {
        public const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2002s\Documents\Database\dbStockPOS.accdb";
    }


    public static class InputValidation
    {
        public static bool validBarcode(string barcode)
        {
            string cleanBarcode = barcode.Trim();

            if (string.IsNullOrEmpty(cleanBarcode))
            {
                return false;
            }

            return cleanBarcode.All(char.IsDigit);
        }

        public static void PriceTextBoxLeave(object sender, EventArgs e)
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

        public static void OnlyNumericValues(object sender, KeyPressEventArgs e)
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
    }
}


