using ButiksSystem.Controllers;
using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.UI
{
    public partial class EditProductSearchForm : Form
    {
        public Models.Product Product { get; set; }
        public string ProductIDInput { get; set; }
        public EditProductSearchForm()

        {
            InitializeComponent();
        }

        private void EditProductSearchForm_Load(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> products = productController.GetAllProducts();
            dgv_showProductInfo.DataSource = products; 

           // ProductController productController = new ProductController();
           // dgv_showProductInfo.DataSource = productController.GetAllProducts();
        }

        private void txt_searchProductIDOrName_TextChanged(object sender, EventArgs e)
        {
            ProductIDInput = txt_searchProductIDOrName.Text;
        }

        private void btn_OKShowProducts_Click(object sender, EventArgs e)
        {
            dgv_showProductInfo.DataSource = ProductIDInput;
        }

        private void dgv_showProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_showProductInfo_Click(object sender, EventArgs e)
        {

            /*txt_showProductIDFromSearch.Text = Product.ProductID.ToString();
            txt_editProductName.Text = Product.ProductName;
            txt_editProductPricePerItem.Text = Product.ProductPrice.ToString();
            txt_editProductGroupID.Text = Product.CategoryID.ToString();
            txt_editQuantityInStorage.Text = Product.Quantity.ToString(); */
        }

        private void btn_deleteProductInDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil Slette varen?", "Bekræftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Controllers.ProductController productController = new Controllers.ProductController();
                DeleteProduct();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        private void btn_saveEditedProductToDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil gemme ændringerne?", "Bekræftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Controllers.ProductController productController = new Controllers.ProductController();
                UpdateProduct();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
        private void UpdateProduct()
        {
            Product.ProductID = int.Parse(txt_showProductIDFromSearch.Text);
            Product.ProductName = txt_editProductName.Text;
            Product.ProductPrice = int.Parse(txt_editProductPricePerItem.Text);
            Product.CategoryID = int.Parse(txt_editProductGroupID.Text);
            Product.Quantity = int.Parse(txt_editQuantityInStorage.Text);
        }

        private void DeleteProduct()
        {
            Product.ProductID = int.Parse(txt_showProductIDFromSearch.Text);
        }


    }
}
