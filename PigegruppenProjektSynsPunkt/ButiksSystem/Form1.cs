﻿using ButiksSystem.UI;
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
            EditCostumerSearch editCostumerSearch = new EditCostumerSearch();
            editCostumerSearch.ShowDialog();
        }

        private void opretVareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }

        private void vareinformationerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProductSearch editProductSearch = new EditProductSearch();
            editProductSearch.ShowDialog();
        }
    }
}
