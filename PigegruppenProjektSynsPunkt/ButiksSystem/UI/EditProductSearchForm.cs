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
        public EditProductSearchForm()
        {
            InitializeComponent();
        }

        private void UpdateProduct()
        {
            //Insert Logic
        }
        private void btn_saveEditedProductToDatabase_Click(object sender, EventArgs e)
        {
            UpdateProduct();

            this.Close();
        }
    }
}
