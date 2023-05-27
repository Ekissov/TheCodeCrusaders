using ButiksSystem.Controllers;
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
using System.Diagnostics;

namespace ButiksSystem.UI
{
    public partial class EditCostumerSearchForm : Form
    {
        public Models.Costumer Costumer { get; set; }
        public string CostumerInput { get; set; }
        public List<Costumer> AllCostumers { get; set; }
        public int CustomerID { get; set; }
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
        private void txt_searchCustomerIDOrName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_searchCustomerIDOrName_TextChanged(object sender, EventArgs e)
        {
            CostumerInput = txt_searchCustomerIDOrName.Text;

        }


        private void btn_OKShowCostumer_Click(object sender, EventArgs e)
        {
            CostumerController costumerController = new CostumerController();
            AllCostumers = costumerController.ReadCustomer(CostumerInput);
            dgv_showCustomerInfo.DataSource = AllCostumers;
        }
        //private void dgv_showCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        
        private void btn_showCustomerInfo_Click(object sender, EventArgs e)
        {
            CostumerController costumerController = new CostumerController();

            Costumer selectedCustomer = costumerController.GetSelectedCustomer(CustomerID);


            txt_changeCustomerFirstName.Text = selectedCustomer.FirstName; 
            txt_changeCustomerLastName.Text = selectedCustomer.LastName;
            txt_changeCustomerPhoneNumber.Text = selectedCustomer.PhoneNumber;
            txt_changeCustomerEmail.Text = selectedCustomer.Email;
            txt_changeCustomerPostalCode.Text = selectedCustomer.PostalCode.ToString();
            txt_changeCustomerCity.Text = selectedCustomer.City.ToString();
            txt_changeCustomerAddress.Text = selectedCustomer.Address.ToString();
            txt_showCustomerIDFromSearch.Text = selectedCustomer.CostumerID.ToString();

            /*Costumer costumer = new Costumer(
            txt_changeCustomerFirstName.Text,
            txt_changeCustomerLastName.Text,
            txt_changeCustomerPhoneNumber.Text,
            txt_changeCustomerEmail.Text,
            int.Parse(txt_changeCustomerPostalCode.Text),
            txt_changeCustomerCity.Text,
            txt_changeCustomerAddress.Text,
            int.Parse(txt_showCustomerIDFromSearch.Text));*/
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

        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Redigér Kunde.pdf");
        }

        private void dgv_showCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Models.Costumer chosenCostumer = 
            

            DataGridViewRow selectedRow = null;

            if (dgv_showCustomerInfo.SelectedRows.Count > 0)
            {
                selectedRow = dgv_showCustomerInfo.SelectedRows[0];
            }

            int customerId = Convert.ToInt32(selectedRow.Cells["customerIDDataGridViewTextBoxColumn"].Value);
            CustomerID = customerId;
           
        }
    }

}

