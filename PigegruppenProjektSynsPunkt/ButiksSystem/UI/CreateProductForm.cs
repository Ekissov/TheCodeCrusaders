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
    public partial class CreateProductForm : Form
    {
        public Models.Product Product { get; set; }
        public CreateProductForm()
        {
            InitializeComponent();
        }

        public void btn_createProduct_Click(object sender, EventArgs e)
        {
            Product = new Product(txt_createProductName.Text, 
                                 decimal.Parse(txt_CreateSalesPricePerItem.Text), 
                                 int.Parse(txt_createQuantityInStorage.Text), 
                                 int.Parse(txt_createProductGroupID.Text));

            /*Product.ProductID = int.Parse(txt_createProductID.Text);
            Product.ProductName = txt_createProductName.Text;
            Product.ProductPrice = decimal.Parse(txt_CreateSalesPricePerItem.Text);
            Product.Quantity = int.Parse(txt_createQuantityInStorage.Text);*/

            
            this.Close();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
