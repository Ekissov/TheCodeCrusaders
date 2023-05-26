﻿using ButiksSystem.Controllers;
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
    public partial class EditCostumerSearchForm : Form
    {
        public Models.Costumer Costumer { get; set; }
        public string CostumerIDInput { get; set; }
        public EditCostumerSearchForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Method to show all costumers in datagridview when the form is loaded. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCostumerSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saanneeha_dk_db_databaseDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet.CustomerTable);
            CostumerController costumerController = new CostumerController();  //connecting to controller
           
        }
        private void txt_searchCustomerIDOrName_TextChanged(object sender, EventArgs e)
        {
            CostumerIDInput = txt_searchCustomerIDOrName.Text;

        }
        private void btn_OKShowCostumer_Click(object sender, EventArgs e)
        {
            CostumerController costumerController = new CostumerController();
            dgv_showCustomerInfo.DataSource = costumerController.ReadCustomer(CostumerIDInput);
        }
        private void dgv_showCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btn_showCustomerInfo_Click(object sender, EventArgs e)
        {
            Costumer costumer = new Costumer(
            txt_changeCustomerFirstName.Text,
            txt_changeCustomerLastName.Text,
            txt_changeCustomerPhoneNumber.Text,
            txt_changeCustomerEmail.Text,
            int.Parse(txt_changeCustomerPostalCode.Text),
            txt_changeCustomerCity.Text,
            txt_changeCustomerAddress.Text);
        }
        private void btn_deleteCustomerInDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil slette kunden?", "Bekræftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Controllers.CostumerController costumerController = new Controllers.CostumerController();
                DeleteCostumer();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btn_saveEditedCustomerToDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil gemme ændringerne?", "Bekræftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Controllers.CostumerController costumerController = new Controllers.CostumerController();
                UpdateCostumer();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void UpdateCostumer()
        {
            //Insert Logic
            Costumer.CostumerID = int.Parse(txt_showCustomerIDFromSearch.Text);
            Costumer.FirstName = txt_changeCustomerFirstName.Text;
            Costumer.LastName = txt_changeCustomerLastName.Text;
            Costumer.PhoneNumber = txt_changeCustomerPhoneNumber.Text;
            Costumer.Email = txt_changeCustomerEmail.Text;
            Costumer.Address = txt_changeCustomerAddress.Text;
            Costumer.PostalCode = int.Parse(txt_changeCustomerPostalCode.Text);
            Costumer.City = txt_changeCustomerCity.Text;

        }

        private void DeleteCostumer()
        {
            Costumer.CostumerID = (int.Parse(txt_showCustomerIDFromSearch.Text));
        }
    }

}

