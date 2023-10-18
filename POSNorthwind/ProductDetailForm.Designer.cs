namespace POSNorthwind
{
    partial class ProductDetailForm
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
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtQtyPerUnit = new TextBox();
            label3 = new Label();
            txtStockUnit = new TextBox();
            label4 = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            cbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Product name";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProductName.Location = new Point(12, 37);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(660, 31);
            txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // txtQtyPerUnit
            // 
            txtQtyPerUnit.Location = new Point(12, 407);
            txtQtyPerUnit.Name = "txtQtyPerUnit";
            txtQtyPerUnit.Size = new Size(375, 31);
            txtQtyPerUnit.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 379);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 4;
            label3.Text = "Quantity per unit";
            // 
            // txtStockUnit
            // 
            txtStockUnit.Location = new Point(12, 317);
            txtStockUnit.Name = "txtStockUnit";
            txtStockUnit.Size = new Size(196, 31);
            txtStockUnit.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 289);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Stock unit";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(12, 217);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(196, 31);
            txtUnitPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 8;
            label5.Text = "Unit price";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(12, 125);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(375, 33);
            cbCategory.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(574, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(456, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 519);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbCategory);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            Controls.Add(txtStockUnit);
            Controls.Add(label4);
            Controls.Add(txtQtyPerUnit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Info";
            Load += ProductDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtQtyPerUnit;
        private Label label3;
        private TextBox txtStockUnit;
        private Label label4;
        private TextBox txtUnitPrice;
        private Label label5;
        private ComboBox cbCategory;
        private Button btnSave;
        private Button btnCancel;
    }
}