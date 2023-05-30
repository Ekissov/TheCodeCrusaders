using ButiksSystem.Controllers;
using ButiksSystem.Models;
using ButiksSystem.Services;
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
    public partial class ShowAllProductsForm : Form
    {

        public ShowAllProductsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that shows all the products in the database, when the form loads. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAllProductsForm_Load(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> products = productController.GetAllProducts();
            dgv_showProductInfo.DataSource = products;
        }
        /// <summary>
        /// buttonclick event that creates a txt file with all products and their info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_printAllProductsToTxtfile_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            productController.PrintDataGridViewToFile(dgv_showProductInfo);

            this.Close();
        }
        /// <summary>
        /// buttonclick event that opens up a PDF file that explains the current window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Vis alle Varer.pdf");
        }
    }
}
