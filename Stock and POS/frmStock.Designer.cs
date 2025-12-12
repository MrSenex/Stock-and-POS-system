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
            panel1.Location = new Point(14, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 693);
            panel1.TabIndex = 17;
            // 
            // chkRemoveStock
            // 
            chkRemoveStock.AutoSize = true;
            chkRemoveStock.Location = new Point(341, 575);
            chkRemoveStock.Margin = new Padding(3, 4, 3, 4);
            chkRemoveStock.Name = "chkRemoveStock";
            chkRemoveStock.Size = new Size(149, 24);
            chkRemoveStock.TabIndex = 37;
            chkRemoveStock.Text = "SUBTRACT STOCK";
            chkRemoveStock.UseVisualStyleBackColor = true;
            // 
            // lblQuantityToAdd
            // 
            lblQuantityToAdd.AutoSize = true;
            lblQuantityToAdd.Location = new Point(23, 609);
            lblQuantityToAdd.Name = "lblQuantityToAdd";
            lblQuantityToAdd.Size = new Size(65, 20);
            lblQuantityToAdd.TabIndex = 36;
            lblQuantityToAdd.Text = "Quantity";
            // 
            // txtQuantityToAdd
            // 
            txtQuantityToAdd.Location = new Point(23, 633);
            txtQuantityToAdd.Margin = new Padding(3, 4, 3, 4);
            txtQuantityToAdd.Name = "txtQuantityToAdd";
            txtQuantityToAdd.Size = new Size(203, 27);
            txtQuantityToAdd.TabIndex = 35;
            txtQuantityToAdd.KeyPress += textBox1_KeyPress;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Enabled = false;
            btnUpdateStock.Location = new Point(349, 607);
            btnUpdateStock.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(120, 57);
            btnUpdateStock.TabIndex = 34;
            btnUpdateStock.Text = "UPDATE STOCK";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnAddStock_Click;
            // 
            // lblSearchResults
            // 
            lblSearchResults.AutoSize = true;
            lblSearchResults.Location = new Point(23, 135);
            lblSearchResults.Name = "lblSearchResults";
            lblSearchResults.Size = new Size(103, 20);
            lblSearchResults.TabIndex = 33;
            lblSearchResults.Text = "Search Results";
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.Location = new Point(23, 159);
            lstSearchResults.Margin = new Padding(3, 4, 3, 4);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new Size(445, 244);
            lstSearchResults.TabIndex = 32;
            // 
            // btnSearchBarcode
            // 
            btnSearchBarcode.Location = new Point(349, 68);
            btnSearchBarcode.Margin = new Padding(3, 4, 3, 4);
            btnSearchBarcode.Name = "btnSearchBarcode";
            btnSearchBarcode.Size = new Size(120, 57);
            btnSearchBarcode.TabIndex = 31;
            btnSearchBarcode.Text = "SEARCH";
            btnSearchBarcode.UseVisualStyleBackColor = true;
            btnSearchBarcode.Click += btnSearchBarcode_Click;
            // 
            // lblBarcodeSearch
            // 
            lblBarcodeSearch.AutoSize = true;
            lblBarcodeSearch.Location = new Point(23, 44);
            lblBarcodeSearch.Name = "lblBarcodeSearch";
            lblBarcodeSearch.Size = new Size(64, 20);
            lblBarcodeSearch.TabIndex = 19;
            lblBarcodeSearch.Text = "Barcode";
            // 
            // txtBarcodeSearch
            // 
            txtBarcodeSearch.Location = new Point(23, 68);
            txtBarcodeSearch.Margin = new Padding(3, 4, 3, 4);
            txtBarcodeSearch.Name = "txtBarcodeSearch";
            txtBarcodeSearch.Size = new Size(203, 27);
            txtBarcodeSearch.TabIndex = 18;
            txtBarcodeSearch.KeyPress += txtBarcodeSearch_KeyPress;
            // 
            // btnSwitchToProducts
            // 
            btnSwitchToProducts.Location = new Point(987, 745);
            btnSwitchToProducts.Margin = new Padding(3, 4, 3, 4);
            btnSwitchToProducts.Name = "btnSwitchToProducts";
            btnSwitchToProducts.Size = new Size(250, 68);
            btnSwitchToProducts.TabIndex = 18;
            btnSwitchToProducts.Text = "Update Products";
            btnSwitchToProducts.UseVisualStyleBackColor = true;
            btnSwitchToProducts.Click += btnSwitchToProducts_Click;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 829);
            Controls.Add(btnSwitchToProducts);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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