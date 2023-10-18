using POSNorthwind.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSNorthwind
{
    public partial class ProductDetailForm : Form
    {
        public Product CurrentProduct { get; set; }

        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            if (CurrentProduct != null)
            {
                BindProductData(CurrentProduct);
            }
        }

        private void BindProductData(Product product)
        {
            txtProductName.Text = product.ProductName;
            txtQtyPerUnit.Text = product.QuantityPerUnit;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtStockUnit.Text = product.UnitsInStock.ToString();

            // todo: show combobox
        }
    }
}
