using ButiksSystem.Models;
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
    public partial class CreateCostumerForm : Form
    {

        public CreateCostumerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked, it saves the information in a Costumer object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
               Costumer costumer = new Models.Costumer(
               txt_createCustomerFirstName.Text,
               txt_createCustomerLastName.Text,
               txt_createCutomerPhoneNumber.Text,
               txt_createCustomerEmail.Text,
               int.Parse(txt_createCustomerPostalCode.Text),
               txt_createCustomerCity.Text,
               txt_createCustomerAddress.Text,
               int.Parse(txt_createCustomerID.Text));

               Controllers.CostumerController costumerController = new Controllers.CostumerController();
               costumerController.CreateCostumer(costumer);

                this.Close();
            }
            catch 
            {
                MessageBox.Show("Postnummeret er ikke skrevet korrekt, det kan kun bestå af tal, prøv igen", "Fejlmeddelelse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            
            Process.Start("Hjælpeside til Opret Kunde.pdf");
        }

        private void CreateCostumerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
