using ButiksSystem.Models;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ButiksSystem
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void opretKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCustomerForm = new CreateCustomerForm();
            createCustomerForm.ShowDialog();
        }

        private void kundeinformationerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomerSearchForm editCustomerSearch = new EditCustomerSearchForm();
            editCustomerSearch.ShowDialog();
        }

        private void opretVareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }

        private void vareinformationerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProductSearchForm editProductSearch = new EditProductSearchForm();
            editProductSearch.ShowDialog();
        }

        private void ordrestatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesStatisticForm salesStatisticForm = new SalesStatisticForm();
            salesStatisticForm.ShowDialog();
        }

        private void opretBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICreateBookingForm createBookingForm = new ICreateBookingForm();
            createBookingForm.ShowDialog();
        }

        private void aflysBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICreateBookingForm createBookingForm1 = new ICreateBookingForm();
            createBookingForm1.ShowDialog();
        }

        private void seBookingerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISeeAllBookingsForm seeAllBookingsForm = new ISeeAllBookingsForm();
            seeAllBookingsForm.ShowDialog();
        }

        private void opretSalgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICreateSaleForm createSaleForm = new ICreateSaleForm();
            createSaleForm.ShowDialog();
        }

        private void opretBestillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICreateOrderForm createOrderForm = new ICreateOrderForm();
            createOrderForm.ShowDialog();
        }
        /// <summary>
        /// Clickevnet that closes the form when clicked - the idea is that it will return the user to the logon site. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageEmployeeLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void retunerVarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IReturnItemForm returnItemForm = new IReturnItemForm();
            returnItemForm.ShowDialog();
        }
        /// <summary>
        /// clickevent that opens a PDF that explain the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            
            Process.Start("PDF der forklarer forsiden winform.pdf");
        }

        private void alleVarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllProductsForm showAllProductsForm = new ShowAllProductsForm();
            showAllProductsForm.ShowDialog();
        }
    }
}
