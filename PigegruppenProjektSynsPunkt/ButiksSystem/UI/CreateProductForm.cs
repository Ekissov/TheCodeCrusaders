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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;
using ButiksSystem.Services;

namespace ButiksSystem.UI
{
    public partial class CreateProductForm : Form
    {
        public Models.Product Product { get; set; }
        public CreateProductForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// clickevent that saves all the userinputs, saves them in varibles and sends them to ProductController method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_createProduct_Click(object sender, EventArgs e)
        {
            string productName = txt_createProductName.Text;
            decimal salesPricePerItem = decimal.Parse(txt_CreateSalesPricePerItem.Text);
            int categoryID = int.Parse(txt_createProductGroupID.Text);
            int quantityInStorage = int.Parse(txt_createQuantityInStorage.Text);
            
            ProductController productController = new ProductController();
            productController.CreateProduct(productName, salesPricePerItem, categoryID, quantityInStorage);

            /*Product.ProductID = int.Parse(txt_createProductID.Text);
            Product.ProductName = txt_createProductName.Text;
            Product.ProductPrice = decimal.Parse(txt_CreateSalesPricePerItem.Text);
            Product.Quantity = int.Parse(txt_createQuantityInStorage.Text);*/

            
            this.Close();
        }
        /// <summary>
        /// clickevent that opens a PDF that explains the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Opret Vare.pdf");
        }
    }
}
