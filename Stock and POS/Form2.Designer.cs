namespace Stock_and_POS
{
    partial class frmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            chkRemoveStock = new CheckBox();
            lblQuantityToAdd = new Label();
            txtQuantityToAdd = new TextBox();
            btnUpdateStock = new Button();
            lblSearchResults = new Label();
            lstSearchResults = new ListBox();
            btnSearchBarcode = new Button();
            lblBarcodeSearch = new Label();
            txtBarcodeSearch = new TextBox();
            btnSwitchToProducts = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(chkRemoveStock);
            panel1.Controls.Add(lblQuantityToAdd);
            panel1.Controls.Add(txtQuantityToAdd);
            panel1.Controls.Add(btnUpdateStock);
            panel1.Controls.Add(lblSearchResults);
            panel1.Controls.Add(lstSearchResults);
            panel1.Controls.Add(btnSearchBarcode);
            panel1.Controls.Add(lblBarcodeSearch);
            panel1.Controls.Add(txtBarcodeSearch);
            panel1.Location = new Point(12, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 520);
            panel1.TabIndex = 17;
            // 
            // chkRemoveStock
            // 
            chkRemoveStock.AutoSize = true;
            chkRemoveStock.Location = new Point(305, 430);
            chkRemoveStock.Name = "chkRemoveStock";
            chkRemoveStock.Size = new Size(122, 19);
            chkRemoveStock.TabIndex = 37;
            chkRemoveStock.Text = "SUBTRACT STOCK";
            chkRemoveStock.UseVisualStyleBackColor = true;
            // 
            // lblQuantityToAdd
            // 
            lblQuantityToAdd.AutoSize = true;
            lblQuantityToAdd.Location = new Point(20, 457);
            lblQuantityToAdd.Name = "lblQuantityToAdd";
            lblQuantityToAdd.Size = new Size(53, 15);
            lblQuantityToAdd.TabIndex = 36;
            lblQuantityToAdd.Text = "Quantity";
            // 
            // txtQuantityToAdd
            // 
            txtQuantityToAdd.Location = new Point(20, 475);
            txtQuantityToAdd.Name = "txtQuantityToAdd";
            txtQuantityToAdd.Size = new Size(178, 23);
            txtQuantityToAdd.TabIndex = 35;
            txtQuantityToAdd.KeyPress += textBox1_KeyPress;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Enabled = false;
            btnUpdateStock.Location = new Point(305, 455);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(105, 43);
            btnUpdateStock.TabIndex = 34;
            btnUpdateStock.Text = "UPDATE STOCK";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnAddStock_Click;
            // 
            // lblSearchResults
            // 
            lblSearchResults.AutoSize = true;
            lblSearchResults.Location = new Point(20, 101);
            lblSearchResults.Name = "lblSearchResults";
            lblSearchResults.Size = new Size(82, 15);
            lblSearchResults.TabIndex = 33;
            lblSearchResults.Text = "Search Results";
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.ItemHeight = 15;
            lstSearchResults.Location = new Point(20, 119);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new Size(390, 184);
            lstSearchResults.TabIndex = 32;
            // 
            // btnSearchBarcode
            // 
            btnSearchBarcode.Location = new Point(305, 51);
            btnSearchBarcode.Name = "btnSearchBarcode";
            btnSearchBarcode.Size = new Size(105, 43);
            btnSearchBarcode.TabIndex = 31;
            btnSearchBarcode.Text = "SEARCH";
            btnSearchBarcode.UseVisualStyleBackColor = true;
            btnSearchBarcode.Click += btnSearchBarcode_Click;
            // 
            // lblBarcodeSearch
            // 
            lblBarcodeSearch.AutoSize = true;
            lblBarcodeSearch.Location = new Point(20, 33);
            lblBarcodeSearch.Name = "lblBarcodeSearch";
            lblBarcodeSearch.Size = new Size(50, 15);
            lblBarcodeSearch.TabIndex = 19;
            lblBarcodeSearch.Text = "Barcode";
            // 
            // txtBarcodeSearch
            // 
            txtBarcodeSearch.Location = new Point(20, 51);
            txtBarcodeSearch.Name = "txtBarcodeSearch";
            txtBarcodeSearch.Size = new Size(178, 23);
            txtBarcodeSearch.TabIndex = 18;
            // 
            // btnSwitchToProducts
            // 
            btnSwitchToProducts.Location = new Point(864, 559);
            btnSwitchToProducts.Name = "btnSwitchToProducts";
            btnSwitchToProducts.Size = new Size(219, 51);
            btnSwitchToProducts.TabIndex = 18;
            btnSwitchToProducts.Text = "Update Products";
            btnSwitchToProducts.UseVisualStyleBackColor = true;
            btnSwitchToProducts.Click += btnSwitchToProducts_Click;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 622);
            Controls.Add(btnSwitchToProducts);
            Controls.Add(panel1);
            Name = "frmStock";
            Text = "Enter Stock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSearchResults;
        private ListBox lstSearchResults;
        private Button btnSearchBarcode;
        private Label lblBarcodeSearch;
        private TextBox txtBarcodeSearch;
        private Label lblQuantityToAdd;
        private TextBox txtQuantityToAdd;
        private Button btnUpdateStock;
        private Button btnSwitchToProducts;
        private CheckBox chkRemoveStock;
    }
}