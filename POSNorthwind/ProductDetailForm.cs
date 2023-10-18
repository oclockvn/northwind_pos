using POSNorthwind.Logic.Models;
using POSNorthwind.Logic.Services;
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

        private CategoryService categoryService = new();
        private ProductService productService = new();

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
            Product current = new()
            {
                ProductName = txtProductName.Text.Trim(),
                CategoryID = (int)cbCategory.SelectedValue,
                QuantityPerUnit = txtQtyPerUnit.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                UnitsInStock = int.Parse(txtUnitPrice.Text),
            };

            productService.AddProduct(current);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();

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

            // show combobox
            cbCategory.SelectedValue = product.CategoryID;
        }

        private void LoadCategoryList()
        {
            var categories = categoryService.GetCategoryList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
        }
    }
}
