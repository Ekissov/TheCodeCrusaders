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
    public partial class ShowAllProductsForm : Form
    {
        public ShowAllProductsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ProductController.PrintAllProducts();

        }

        private void ShowAllProductsForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_showAllProducts_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            List<Product> products = productController.GetAllProducts();
            dgv_showProductInfo.DataSource = products;
        }
    }
}
