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
            lblError.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product current = new()
            {
                Id = CurrentProduct?.Id ?? 0,
                ProductName = txtProductName.Text.Trim(),
                CategoryID = cbCategory.SelectedValue == null ? null : (int)cbCategory.SelectedValue,
                QuantityPerUnit = txtQtyPerUnit.Text.Trim(),
                UnitPrice = string.IsNullOrWhiteSpace(txtUnitPrice.Text.Trim()) ? 0 : decimal.Parse(txtUnitPrice.Text.Trim()),
                UnitsInStock = string.IsNullOrWhiteSpace(txtStockUnit.Text.Trim()) ? 0 : int.Parse(txtStockUnit.Text.Trim()),
            };

            if (string.IsNullOrWhiteSpace(current.ProductName))
            {
                lblError.Text = "Product name is required";
                return;
            }

            lblError.Text = "";

            var isUpdate = CurrentProduct != null && CurrentProduct.Id > 0;
            if (isUpdate)
            {
                productService.UpdateProduct(current);
            }
            else
            {
                productService.AddProduct(current);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();

            if (CurrentProduct != null)
            {
                BindProductData(CurrentProduct);
                button1.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Product current = new()
            {
                Id = 0,// CurrentProduct?.Id ?? 0,
                ProductName = txtProductName.Text.Trim(),
                CategoryID = cbCategory.SelectedValue == null ? null : (int)cbCategory.SelectedValue,
                QuantityPerUnit = txtQtyPerUnit.Text.Trim(),
                UnitPrice = string.IsNullOrWhiteSpace(txtUnitPrice.Text.Trim()) ? 0 : decimal.Parse(txtUnitPrice.Text.Trim()),
                UnitsInStock = string.IsNullOrWhiteSpace(txtStockUnit.Text.Trim()) ? 0 : int.Parse(txtStockUnit.Text.Trim()),
            };

            if (string.IsNullOrWhiteSpace(current.ProductName))
            {
                lblError.Text = "Product name is required";
                return;
            }

            lblError.Text = "";

            productService.AddProduct(current);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
