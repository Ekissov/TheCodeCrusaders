using KundeApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeApplication
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_AllGlasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Controller controller = new Controller();
            List<Product> allProducts = controller.//ReadAllProducts

            Dgv_AllGlasses.Datasource = allProducts; //Dette er kun midlertidigt, tænker at det skal op og være direkte på databasen.
        }
    }
}
