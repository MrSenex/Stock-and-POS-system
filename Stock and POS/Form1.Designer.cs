namespace Stock_and_POS
{
    partial class frmEnterProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlProductEntry = new Panel();
            btnAddProduct = new Button();
            btnClear = new Button();
            cmbSize = new ComboBox();
            lblLeadTime = new Label();
            txtLeadTime = new TextBox();
            lblCostPrice = new Label();
            lblSellingPrice = new Label();
            txtCostPrice = new TextBox();
            txtSellingPrice = new TextBox();
            lblDecsription = new Label();
            lblWeightVolume = new Label();
            txtDescription = new TextBox();
            txtSize = new TextBox();
            lblBrand = new Label();
            lblBarcode = new Label();
            txtBrand = new TextBox();
            txtBarcode = new TextBox();
            panel1 = new Panel();
            lblSearchResults = new Label();
            lstSearchResults = new ListBox();
            btnSearchBarcode = new Button();
            lblBarcodeSearch = new Label();
            txtBarcodeSearch = new TextBox();
            pnlProductEntry.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProductEntry
            // 
            pnlProductEntry.BackColor = SystemColors.ActiveBorder;
            pnlProductEntry.Controls.Add(btnAddProduct);
            pnlProductEntry.Controls.Add(btnClear);
            pnlProductEntry.Controls.Add(cmbSize);
            pnlProductEntry.Controls.Add(lblLeadTime);
            pnlProductEntry.Controls.Add(txtLeadTime);
            pnlProductEntry.Controls.Add(lblCostPrice);
            pnlProductEntry.Controls.Add(lblSellingPrice);
            pnlProductEntry.Controls.Add(txtCostPrice);
            pnlProductEntry.Controls.Add(txtSellingPrice);
            pnlProductEntry.Controls.Add(lblDecsription);
            pnlProductEntry.Controls.Add(lblWeightVolume);
            pnlProductEntry.Controls.Add(txtDescription);
            pnlProductEntry.Controls.Add(txtSize);
            pnlProductEntry.Controls.Add(lblBrand);
            pnlProductEntry.Controls.Add(lblBarcode);
            pnlProductEntry.Controls.Add(txtBrand);
            pnlProductEntry.Controls.Add(txtBarcode);
            pnlProductEntry.Location = new Point(12, 12);
            pnlProductEntry.Name = "pnlProductEntry";
            pnlProductEntry.Size = new Size(407, 520);
            pnlProductEntry.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(281, 441);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(105, 43);
            btnAddProduct.TabIndex = 31;
            btnAddProduct.Text = "ADD PRODUCT";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(281, 383);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 43);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbSize
            // 
            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.FormattingEnabled = true;
            cmbSize.Items.AddRange(new object[] { "grams", "kilograms", "millilitre", "liter" });
            cmbSize.Location = new Point(107, 185);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(89, 23);
            cmbSize.TabIndex = 29;
            // 
            // lblLeadTime
            // 
            lblLeadTime.AutoSize = true;
            lblLeadTime.Location = new Point(16, 443);
            lblLeadTime.Name = "lblLeadTime";
            lblLeadTime.Size = new Size(62, 15);
            lblLeadTime.TabIndex = 28;
            lblLeadTime.Text = "Lead Time";
            // 
            // txtLeadTime
            // 
            txtLeadTime.Location = new Point(16, 461);
            txtLeadTime.Name = "txtLeadTime";
            txtLeadTime.Size = new Size(178, 23);
            txtLeadTime.TabIndex = 27;
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Location = new Point(16, 374);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(60, 15);
            lblCostPrice.TabIndex = 26;
            lblCostPrice.Text = "Cost Price";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Location = new Point(16, 306);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(71, 15);
            lblSellingPrice.TabIndex = 25;
            lblSellingPrice.Text = "Selling Price";
            // 
            // txtCostPrice
            // 
            txtCostPrice.Location = new Point(16, 392);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(178, 23);
            txtCostPrice.TabIndex = 24;
            txtCostPrice.KeyPress += txtCostPrice_KeyPress;
            txtCostPrice.Leave += txtCostPrice_Leave;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(16, 324);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(178, 23);
            txtSellingPrice.TabIndex = 23;
            txtSellingPrice.KeyPress += txtSellingPrice_KeyPress;
            txtSellingPrice.Leave += txtSellingPrice_Leave;
            // 
            // lblDecsription
            // 
            lblDecsription.AutoSize = true;
            lblDecsription.Location = new Point(16, 235);
            lblDecsription.Name = "lblDecsription";
            lblDecsription.Size = new Size(67, 15);
            lblDecsription.TabIndex = 22;
            lblDecsription.Text = "Description";
            // 
            // lblWeightVolume
            // 
            lblWeightVolume.AutoSize = true;
            lblWeightVolume.Location = new Point(16, 167);
            lblWeightVolume.Name = "lblWeightVolume";
            lblWeightVolume.Size = new Size(96, 15);
            lblWeightVolume.TabIndex = 21;
            lblWeightVolume.Text = "Weight / Volume";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 253);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(178, 23);
            txtDescription.TabIndex = 20;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(16, 185);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(85, 23);
            txtSize.TabIndex = 19;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(16, 101);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(38, 15);
            lblBrand.TabIndex = 18;
            lblBrand.Text = "Brand";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(16, 33);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(50, 15);
            lblBarcode.TabIndex = 17;
            lblBarcode.Text = "Barcode";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(16, 119);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(178, 23);
            txtBrand.TabIndex = 16;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(16, 51);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(178, 23);
            txtBarcode.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lblSearchResults);
            panel1.Controls.Add(lstSearchResults);
            panel1.Controls.Add(btnSearchBarcode);
            panel1.Controls.Add(lblBarcodeSearch);
            panel1.Controls.Add(txtBarcodeSearch);
            panel1.Location = new Point(458, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 520);
            panel1.TabIndex = 16;
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
            lstSearchResults.Size = new Size(263, 364);
            lstSearchResults.TabIndex = 32;
            // 
            // btnSearchBarcode
            // 
            btnSearchBarcode.Location = new Point(305, 443);
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
            // frmEnterProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 612);
            Controls.Add(panel1);
            Controls.Add(pnlProductEntry);
            Name = "frmEnterProduct";
            Text = "Enter Products";
            Load += frmEnterProduct_Load;
            pnlProductEntry.ResumeLayout(false);
            pnlProductEntry.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProductEntry;
        private ComboBox cmbSize;
        private Label lblLeadTime;
        private TextBox txtLeadTime;
        private Label lblCostPrice;
        private Label lblSellingPrice;
        private TextBox txtCostPrice;
        private TextBox txtSellingPrice;
        private Label lblDecsription;
        private Label lblWeightVolume;
        private TextBox txtDescription;
        private TextBox txtSize;
        private Label lblBrand;
        private Label lblBarcode;
        private TextBox txtBrand;
        private TextBox txtBarcode;
        private Button btnAddProduct;
        private Button btnClear;
        private Panel panel1;
        private Label lblBarcodeSearch;
        private TextBox txtBarcodeSearch;
        private Button btnSearchBarcode;
        private Label lblSearchResults;
        private ListBox lstSearchResults;
    }
}
