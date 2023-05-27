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
            this.customerTableTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet.CustomerTable); //Connecting datagridview to database
            CostumerController costumerController = new CostumerController();  //connecting to controller

        }
        /// <summary>
        /// adding value to the string variable. the value being the userinput. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// buttonclick event that show the result in the database that matches the úserinput. this i shown in the datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btn_OKShowCostumer_Click(object sender, EventArgs e)
        {
            CostumerController costumerController = new CostumerController();
            AllCostumers = costumerController.ReadCustomer(CostumerInput);
            dgv_showCustomerInfo.DataSource = AllCostumers;
        }

        /// <summary>
        /// Buttonclick event that takes the marked customer in the datagridview and shows all info in the textboxes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        }

        /// <summary>
        /// buttonclick event that shows a messagebox, asking the user, if they wants to delete the customer and if so, runs the deletemethod, if not closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///  buttonclick event that shows a messagebox, asking the user, if their changes are correct and if so, runs the updatemethod, if not closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Method that updates a customer. this is connected all the way to our repository where the CRUD logic lies and there it updates the customer in the database. 
        /// </summary>
        private void UpdateCostumer()
        {

            Models.Costumer costumer = new Models.Costumer(
                
                txt_changeCustomerFirstName.Text,
                txt_changeCustomerLastName.Text,
                txt_changeCustomerPhoneNumber.Text,
                txt_changeCustomerEmail.Text,
                int.Parse(txt_changeCustomerPostalCode.Text),
                txt_changeCustomerCity.Text,
                txt_changeCustomerAddress.Text,             
                int.Parse(txt_showCustomerIDFromSearch.Text));            
            
            CostumerController costumerController = new CostumerController();
            costumerController.UpdateCostumer(costumer);

        }
        /// <summary>
        /// Method that deletes a customer. this is connected all the way to our repository where the CRUD logic lies and there it deletes the customer from the database. 
        /// </summary>
        private void DeleteCostumer()
        {
            Costumer.CostumerID = (int.Parse(txt_showCustomerIDFromSearch.Text));
        }

        /// <summary>
        /// buttonclick event that opens up a PDF file that explains the current window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homePageHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Hjælpeside til Redigér Kunde.pdf");
        }

        /// <summary>
        /// Makes it possible to select a row in the datagridview saves the customer ID in the property CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_showCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dgv_showCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
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

