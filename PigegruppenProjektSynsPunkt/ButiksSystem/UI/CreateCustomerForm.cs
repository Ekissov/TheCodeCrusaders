﻿using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;

namespace ButiksSystem.UI
{
    public partial class CreateCustomerForm : Form
    {

        public CreateCustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked, it saves the information in a Customer object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createCustomer_Click_1(object sender, EventArgs e)
        {

            Customer customer = new Models.Customer(
            txt_createCustomerFirstName.Text,
            txt_createCustomerLastName.Text,
            txt_createCutomerPhoneNumber.Text,
            txt_createCustomerEmail.Text,
            int.Parse(txt_createCustomerPostalCode.Text),
            txt_createCustomerCity.Text,
            txt_createCustomerAddress.Text);

            Controllers.CustomerController customerController = new Controllers.CustomerController();
            customerController.CreateCustomer(customer);

            this.Close();
        }
        /// <summary>
        /// Clickevent that opens up a PDF file, that explains the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {

            Process.Start("Hjælpeside til Opret Kunde.pdf");
        }


    }
}
