﻿using System;
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
    public partial class EditCostumerSearchForm : Form
    {
        public Models.Costumer costumer { get; set; }
        public EditCostumerSearchForm()
        {
            InitializeComponent();
        }

        private void EditCostumerSearchForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Method to update a current costumer in the database
        /// </summary>
        private void UpdateCostumer()
        {
            //Insert Logic
           // EditCostumerSearchForm.FirstName = txt_changeCustomerFirstName.Text;
        }
        private void btn_saveEditedCustomerToDatabase_Click(object sender, EventArgs e)
        {
            UpdateCostumer();

            MessageBox.Show("Er du sikker på at du vil gemme ændringerne?");
            //this.Close();
        }
    }
}
