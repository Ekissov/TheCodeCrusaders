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

namespace ButiksSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void opretKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCostumerForm createCostumerForm = new CreateCostumerForm();
            createCostumerForm.ShowDialog();
        }

        private void kundeinformationerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCostumerSearchForm editCostumerSearch = new EditCostumerSearchForm();
            editCostumerSearch.ShowDialog();
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
            CreateBookingForm createBookingForm = new CreateBookingForm();
            createBookingForm.ShowDialog();
        }

        private void aflysBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBookingForm createBookingForm1 = new CreateBookingForm();
            createBookingForm1.ShowDialog();
        }

        private void seBookingerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBookingForm createBookingForm2 = new CreateBookingForm();
            createBookingForm2.ShowDialog();

        }
    }
}
