using POSNorthwind.Logic.Models;
using POSNorthwind.Logic.Services;

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
            var result = detailForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadProductList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProductList();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            LoadProductList();
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
            detailForm.Text = "Product: " + product.ProductName;
            detailForm.CurrentProduct = product;

            var result = detailForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadProductList();
            }
        }

        private void LoadProductList()
        {
            RenderProductListView(productService.GetProductList(txtSearch.Text.Trim()));
        }
    }
}
