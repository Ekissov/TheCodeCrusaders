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
    public partial class EditCustomerSearchForm : Form
    {
        public Models.Customer Customer { get; set; }
        public string CustomerInput { get; set; }
        public List<Customer> AllCustomers { get; set; }
        public int CustomerID { get; set; }
        public EditCustomerSearchForm()

        {
            InitializeComponent();
            dgv_showCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Method to show all customers in datagridview when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCustomerSearchForm_Load(object sender, EventArgs e)
        {
            this.customerTableTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet.CustomerTable); //Connecting datagridview to database
            CustomerController customerController = new CustomerController();  //connecting to controller

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
            CustomerInput = txt_searchCustomerIDOrName.Text;

        }
        /// <summary>
        /// buttonclick event that show the result in the database that matches the userinput. this i shown in the datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btn_OKShowCustomer_Click(object sender, EventArgs e)
        {
            CustomerController customerController = new CustomerController();
            dgv_showCustomerInfo.DataSource = customerController.CustomerBySearch(CustomerInput);

        }

        /// <summary>
        /// Buttonclick event that takes the marked customer in the datagridview and shows all info in the textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_showCustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerController customerController = new CustomerController();
            Customer selectedCustomer = customerController.GetSelectedCustomer(CustomerID);


            txt_changeCustomerFirstName.Text = selectedCustomer.FirstName;
            txt_changeCustomerLastName.Text = selectedCustomer.LastName;
            txt_changeCustomerPhoneNumber.Text = selectedCustomer.PhoneNumber;
            txt_changeCustomerEmail.Text = selectedCustomer.Email;
            txt_changeCustomerPostalCode.Text = selectedCustomer.PostalCode.ToString();
            txt_changeCustomerCity.Text = selectedCustomer.City.ToString();
            txt_changeCustomerAddress.Text = selectedCustomer.Address.ToString();
            txt_showCustomerIDFromSearch.Text = selectedCustomer.CustomerID.ToString();

        }

        /// <summary>
        /// buttonclick event that shows a messagebox, asking the user, if they wants to delete the customer and if so, runs the deletemethod, if not closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deleteCustomerInDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil slette kunden?", "Bekræftelse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Controllers.CustomerController customerController = new Controllers.CustomerController();
                DeleteCustomer();
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }
        /// <summary>
        ///  buttonclick event that shows a messagebox, asking the user, if their changes are correct and if so, runs the updatemethod, if not closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveEditedCustomerToDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil gemme ændringerne?", "Bekræftelse", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Controllers.CustomerController customerController = new Controllers.CustomerController();
                UpdateCustomer();
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }
        /// <summary>
        /// Method that updates a customer. this is connected all the way to our repository where the CRUD logic lies and there it updates the customer in the database. 
        /// </summary>
        private void UpdateCustomer()
        {

            Models.Customer customer = new Models.Customer(

                txt_changeCustomerFirstName.Text,
                txt_changeCustomerLastName.Text,
                txt_changeCustomerPhoneNumber.Text,
                txt_changeCustomerEmail.Text,
                int.Parse(txt_changeCustomerPostalCode.Text),
                txt_changeCustomerCity.Text,
                txt_changeCustomerAddress.Text,
                int.Parse(txt_showCustomerIDFromSearch.Text));

            CustomerController customerController = new CustomerController();
            customerController.UpdateCustomer(customer);

        }
        /// <summary>
        /// Method that deletes a customer. this is connected all the way to our repository where the CRUD logic lies and there it deletes the customer from the database. 
        /// </summary>
        private void DeleteCustomer()
        {
            int customerID = (int.Parse(txt_showCustomerIDFromSearch.Text));
            Customer customer = new Customer(
                txt_changeCustomerFirstName.Text,
                txt_changeCustomerLastName.Text,
                txt_changeCustomerPhoneNumber.Text,
                txt_changeCustomerEmail.Text,
                int.Parse(txt_changeCustomerPostalCode.Text),
                txt_changeCustomerCity.Text,
                txt_changeCustomerAddress.Text,
                int.Parse(txt_showCustomerIDFromSearch.Text));

            customer.CustomerID = customerID;

            CustomerController customerController = new CustomerController();
            customerController.DeleteCustomer(customer);
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

