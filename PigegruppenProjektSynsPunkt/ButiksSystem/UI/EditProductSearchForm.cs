using ButiksSystem.Controllers;
using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        /// <summary>
        /// shows all products in the datagridview when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductSearchForm_Load(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> products = productController.GetAllProducts();
            dgv_showProductInfo.DataSource = products;

            // ProductController productController = new ProductController();
            // dgv_showProductInfo.DataSource = productController.GetAllProducts();
        }
        /// <summary>
        /// method that saves the userinput in the textbox in a varaiable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_searchProductIDOrName_TextChanged(object sender, EventArgs e)
        {
            ProductIDInput = txt_searchProductIDOrName.Text;
        }
        /// <summary>
        /// clickevent that filter the datagridview info, so it only shows the info that matches the input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OKShowProducts_Click(object sender, EventArgs e)
        {
            dgv_showProductInfo.DataSource = ProductIDInput;
        }

        private void dgv_showProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// method that takes the chosen product in the datagridview and shows all data in the textboxes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_showProductInfo_Click(object sender, EventArgs e)
        {

            /*txt_showProductIDFromSearch.Text = Product.ProductID.ToString();
            txt_editProductName.Text = Product.ProductName;
            txt_editProductPricePerItem.Text = Product.ProductPrice.ToString();
            txt_editProductGroupID.Text = Product.CategoryID.ToString();
            txt_editQuantityInStorage.Text = Product.Quantity.ToString(); */
        }
        /// <summary>
        /// clickevent that shows a messagebox, if yes is chosen it runs the deletemethod and closes the window, if cancel is chosen, it goes back to the EditProductSearchForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deleteProductInDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil Slette varen?", "Bekræftelse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Controllers.ProductController productController = new Controllers.ProductController();
                DeleteProduct(Product);
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
               
            }
        }
        private void btn_saveEditedProductToDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil gemme ændringerne?", "Bekræftelse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Controllers.ProductController productController = new Controllers.ProductController();
                UpdateProduct(Product);
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }
        private void UpdateProduct(Product product)
        {
            ProductController productController = new ProductController();
            productController.UpdateProduct(product);

            Product.ProductID = int.Parse(txt_showProductIDFromSearch.Text);
            Product.ProductName = txt_editProductName.Text;
            Product.ProductPrice = int.Parse(txt_editProductPricePerItem.Text);
            Product.CategoryID = int.Parse(txt_editProductGroupID.Text);
            Product.Quantity = int.Parse(txt_editQuantityInStorage.Text);
        }

        private void DeleteProduct(Product product)
        {
            ProductController productController = new ProductController();
            productController.DeleteProduct(product);

            Product.ProductID = int.Parse(txt_showProductIDFromSearch.Text);
        }

        public void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Redigér Vare.pdf");

        }
    }
}
