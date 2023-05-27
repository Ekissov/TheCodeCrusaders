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
        public int ProductID { get; set; }
        public EditProductSearchForm()

        {
            InitializeComponent();
            dgv_showProductInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        /// shows all products in the datagridview when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductSearchForm_Load(object sender, EventArgs e)
        {
            
            this.productTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet1.Product);
            //ProductController productController = new ProductController();
            //List<Product> products = productController.GetAllProducts();
            // dgv_showProductInfo.DataSource = products;

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
            DataGridViewRow selectedRow = null;

            if (dgv_showProductInfo.SelectedRows.Count > 0)
            {
                selectedRow = dgv_showProductInfo.SelectedRows[0];
            }
            int productId = Convert.ToInt32(selectedRow.Cells["productIDDataGridViewTextBoxColumn"].Value);
            ProductID = productId;
        }
        /// <summary>
        /// method that takes the chosen product in the datagridview and shows all data in the textboxes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_showProductInfo_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            Product selectedProduct = productController.GetSelectedProduct(ProductID);
            
            
            txt_showProductIDFromSearch.Text = selectedProduct.ProductID.ToString();
            txt_editProductName.Text = selectedProduct.ProductName;
            txt_editProductPricePerItem.Text = selectedProduct.ProductPrice.ToString();
            txt_editProductGroupID.Text = selectedProduct.CategoryID.ToString();
            txt_editQuantityInStorage.Text = selectedProduct.Quantity.ToString(); 
        }
        /// <summary>
        /// clickevent that shows a messagebox, if OK is chosen it runs the deletemethod and closes the window, if cancel is chosen, it goes back to the EditProductSearchForm.
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
        /// <summary>
        /// clickevent that shows a messagebox, if OK is chosen it runs the UpdateMethod and closes the window, if cancel is chosen, it goes back to the EditProductSearchForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Method that updates the pruduct, it saves the new input in Product, and the method is connected all the way to our repository where the CRUD method updates our database.
        /// </summary>
        /// <param name="product"></param>
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

        /// <summary>
        /// Method that deletes the pruduct, it saves the new input in Product, and the method is connected all the way to our repository where the CRUD method deletes the product from our database.
        /// </summary>
        /// <param name="product"></param>
        private void DeleteProduct(Product product)
        {
            ProductController productController = new ProductController();
            productController.DeleteProduct(product);

            Product.ProductID = int.Parse(txt_showProductIDFromSearch.Text);
        }

        /// <summary>
        /// clickevent that opens a PDF file that explains the form - it is saved directly in the debugger folder that follows our program. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Redigér Vare.pdf");

        }
    }
}
