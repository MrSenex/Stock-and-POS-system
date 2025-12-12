namespace Stock_and_POS
{
    partial class frmSale
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
            lblCurrentSale = new Label();
            panel1 = new Panel();
            lblTotalSale = new Label();
            lstTotalSale = new ListBox();
            panel2 = new Panel();
            lstNewSale = new ListBox();
            panel3 = new Panel();
            txtBarcodeSearch = new TextBox();
            btnAddToSale = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblCurrentSale
            // 
            lblCurrentSale.AutoSize = true;
            lblCurrentSale.Location = new Point(26, 9);
            lblCurrentSale.Name = "lblCurrentSale";
            lblCurrentSale.Size = new Size(89, 20);
            lblCurrentSale.TabIndex = 1;
            lblCurrentSale.Text = "Current Sale";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(lblTotalSale);
            panel1.Controls.Add(lstTotalSale);
            panel1.Location = new Point(36, 510);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 101);
            panel1.TabIndex = 2;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.Font = new Font("Segoe UI", 30F);
            lblTotalSale.Location = new Point(12, 14);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(144, 67);
            lblTotalSale.TabIndex = 1;
            lblTotalSale.Text = "Total:";
            // 
            // lstTotalSale
            // 
            lstTotalSale.Font = new Font("Segoe UI", 20F);
            lstTotalSale.FormattingEnabled = true;
            lstTotalSale.ItemHeight = 45;
            lstTotalSale.Location = new Point(181, 32);
            lstTotalSale.Name = "lstTotalSale";
            lstTotalSale.Size = new Size(196, 49);
            lstTotalSale.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(lstNewSale);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(26, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 632);
            panel2.TabIndex = 4;
            // 
            // lstNewSale
            // 
            lstNewSale.FormattingEnabled = true;
            lstNewSale.Location = new Point(36, 18);
            lstNewSale.Name = "lstNewSale";
            lstNewSale.Size = new Size(391, 464);
            lstNewSale.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(btnAddToSale);
            panel3.Controls.Add(txtBarcodeSearch);
            panel3.Location = new Point(505, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 632);
            panel3.TabIndex = 5;
            // 
            // txtBarcodeSearch
            // 
            txtBarcodeSearch.Location = new Point(37, 19);
            txtBarcodeSearch.Name = "txtBarcodeSearch";
            txtBarcodeSearch.Size = new Size(156, 27);
            txtBarcodeSearch.TabIndex = 0;
            // 
            // btnAddToSale
            // 
            btnAddToSale.Location = new Point(240, 19);
            btnAddToSale.Name = "btnAddToSale";
            btnAddToSale.Size = new Size(145, 29);
            btnAddToSale.TabIndex = 1;
            btnAddToSale.Text = "ADD TO SALE";
            btnAddToSale.UseVisualStyleBackColor = true;
            btnAddToSale.Click += this.btnAddToSale_Click;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 705);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblCurrentSale);
            Name = "frmSale";
            Text = "Sale";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCurrentSale;
        private Panel panel1;
        private Panel panel2;
        private Label lblTotalSale;
        private ListBox lstTotalSale;
        private Panel panel3;
        private TextBox txtBarcodeSearch;
        private ListBox lstNewSale;
        private Button btnAddToSale;
    }
}