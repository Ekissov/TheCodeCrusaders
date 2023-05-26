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


        private void ShowAllProductsForm_Load(object sender, EventArgs e)
        {

            ProductController productController = new ProductController();
            List<Product> products = productController.GetAllProducts();
            dgv_showProductInfo.DataSource = products;

        }

        private void btn_printAllProductsToTxtfile_Click(object sender, EventArgs e)
        {
            
            //     lindaFilePath = @"C:\Pigegruppen - Synspunkt\NyPigegruppen - synspunkts\TheCodeCrusaders\PigegruppenProjektSynsPunkt\printallproducts.txt";

            ProductServices productServices = new ProductServices();
            productServices.PrintDataGridViewToFile(dgv_showProductInfo);

        }

        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Vis alle Varer.pdf");
        }
    }
}
