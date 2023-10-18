namespace POSNorthwind
{
    partial class ProductListForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            lvProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(679, 31);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(697, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(815, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(1281, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lvProducts
            // 
            lvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(12, 79);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(1410, 726);
            lvProducts.TabIndex = 4;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product name";
            columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Qty. Per Unit";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unit Price";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Category";
            columnHeader4.Width = 300;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 817);
            Controls.Add(lvProducts);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "ProductListForm";
            Text = "POS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnAdd;
        private ListView lvProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}