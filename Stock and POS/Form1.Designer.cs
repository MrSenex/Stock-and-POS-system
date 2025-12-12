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
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            btnSearchBarcode = new Button();
            btnClear = new Button();
            cmbWeightVolumeType = new ComboBox();
            lblLeadTime = new Label();
            txtLeadTime = new TextBox();
            lblCostPrice = new Label();
            lblSellingPrice = new Label();
            txtCostPrice = new TextBox();
            txtSellingPrice = new TextBox();
            lblDecsription = new Label();
            lblWeightVolume = new Label();
            txtDescription = new TextBox();
            txtWeightVolume = new TextBox();
            lblBrand = new Label();
            lblBarcode = new Label();
            txtBrand = new TextBox();
            txtBarcode = new TextBox();
            btnSwitchToStock = new Button();
            pnlProductEntry.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProductEntry
            // 
            pnlProductEntry.BackColor = SystemColors.ActiveBorder;
            pnlProductEntry.Controls.Add(btnUpdateProduct);
            pnlProductEntry.Controls.Add(btnAddProduct);
            pnlProductEntry.Controls.Add(btnSearchBarcode);
            pnlProductEntry.Controls.Add(btnClear);
            pnlProductEntry.Controls.Add(cmbWeightVolumeType);
            pnlProductEntry.Controls.Add(lblLeadTime);
            pnlProductEntry.Controls.Add(txtLeadTime);
            pnlProductEntry.Controls.Add(lblCostPrice);
            pnlProductEntry.Controls.Add(lblSellingPrice);
            pnlProductEntry.Controls.Add(txtCostPrice);
            pnlProductEntry.Controls.Add(txtSellingPrice);
            pnlProductEntry.Controls.Add(lblDecsription);
            pnlProductEntry.Controls.Add(lblWeightVolume);
            pnlProductEntry.Controls.Add(txtDescription);
            pnlProductEntry.Controls.Add(txtWeightVolume);
            pnlProductEntry.Controls.Add(lblBrand);
            pnlProductEntry.Controls.Add(lblBarcode);
            pnlProductEntry.Controls.Add(txtBrand);
            pnlProductEntry.Controls.Add(txtBarcode);
            pnlProductEntry.Location = new Point(12, 12);
            pnlProductEntry.Name = "pnlProductEntry";
            pnlProductEntry.Size = new Size(407, 520);
            pnlProductEntry.TabIndex = 15;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(277, 441);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(105, 43);
            btnUpdateProduct.TabIndex = 32;
            btnUpdateProduct.Text = "UPDATE PRODUCT";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(277, 383);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(105, 43);
            btnAddProduct.TabIndex = 31;
            btnAddProduct.Text = "ADD PRODUCT";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnSearchBarcode
            // 
            btnSearchBarcode.Location = new Point(277, 40);
            btnSearchBarcode.Name = "btnSearchBarcode";
            btnSearchBarcode.Size = new Size(105, 43);
            btnSearchBarcode.TabIndex = 31;
            btnSearchBarcode.Text = "SEARCH";
            btnSearchBarcode.UseVisualStyleBackColor = true;
            btnSearchBarcode.Click += btnSearchBarcode_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(277, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 43);
            btnClear.TabIndex = 30;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbWeightVolumeType
            // 
            cmbWeightVolumeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeightVolumeType.FormattingEnabled = true;
            cmbWeightVolumeType.Items.AddRange(new object[] { "grams", "kilograms", "millilitre", "liter" });
            cmbWeightVolumeType.Location = new Point(107, 185);
            cmbWeightVolumeType.Name = "cmbWeightVolumeType";
            cmbWeightVolumeType.Size = new Size(89, 23);
            cmbWeightVolumeType.TabIndex = 29;
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
            // txtWeightVolume
            // 
            txtWeightVolume.Location = new Point(16, 185);
            txtWeightVolume.Name = "txtWeightVolume";
            txtWeightVolume.Size = new Size(85, 23);
            txtWeightVolume.TabIndex = 19;
            txtWeightVolume.KeyPress += txtSize_KeyPress;
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
            txtBarcode.Text = "6009604170021";
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // btnSwitchToStock
            // 
            btnSwitchToStock.Location = new Point(804, 549);
            btnSwitchToStock.Name = "btnSwitchToStock";
            btnSwitchToStock.Size = new Size(219, 51);
            btnSwitchToStock.TabIndex = 17;
            btnSwitchToStock.Text = "Update Stock";
            btnSwitchToStock.UseVisualStyleBackColor = true;
            btnSwitchToStock.Click += btnSwitchToStock_Click;
            // 
            // frmEnterProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 612);
            Controls.Add(btnSwitchToStock);
            Controls.Add(pnlProductEntry);
            Name = "frmEnterProduct";
            Text = "Enter Products";
            Load += frmEnterProduct_Load;
            pnlProductEntry.ResumeLayout(false);
            pnlProductEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProductEntry;
        private ComboBox cmbWeightVolumeType;
        private Label lblLeadTime;
        private TextBox txtLeadTime;
        private Label lblCostPrice;
        private Label lblSellingPrice;
        private TextBox txtCostPrice;
        private TextBox txtSellingPrice;
        private Label lblDecsription;
        private Label lblWeightVolume;
        private TextBox txtDescription;
        private TextBox txtWeightVolume;
        private Label lblBrand;
        private Label lblBarcode;
        private TextBox txtBrand;
        private TextBox txtBarcode;
        private Button btnAddProduct;
        private Button btnClear;
        private Button btnSearchBarcode;
        private Button btnSwitchToStock;
        private Button btnUpdateProduct;
    }
}
