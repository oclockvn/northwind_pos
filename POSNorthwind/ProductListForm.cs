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
    public partial class ProductListForm : Form
    {
        private ProductService productService = new();

        public ProductListForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDetailForm detailForm = new();
            detailForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var products = productService.GetProductList();
            // Render list view
            RenderProductListView(products);
        }

        private void RenderProductListView(List<Product> products)
        {
            // clear old items
            lvProducts.Items.Clear();
            foreach (var p in products)
            {
                ListViewItem item = new(p.ProductName);
                item.SubItems.Add(p.QuantityPerUnit);
                item.SubItems.Add(p.UnitPrice.ToString());
                item.SubItems.Add(p.CategoryName);
                item.SubItems.Add(p.UnitsInStock.ToString());
                item.Tag = p;

                lvProducts.Items.Add(item);
            }
        }

        private void lvProducts_DoubleClick(object sender, EventArgs e)
        {
            var lvi = lvProducts.SelectedItems[0];
            var product = (Product)lvi.Tag;

            ProductDetailForm detailForm = new();
            detailForm.CurrentProduct = product;

            detailForm.ShowDialog();
        }
    }
}
