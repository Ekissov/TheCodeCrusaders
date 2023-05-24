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

        private void EditCostumerSearchForm_Load(object sender, EventArgs e)
        {
            //dgv_showCustomerInfo.DataSource = READ ALL COSTUMERS
        }
        private void txt_searchCustomerIDOrName_TextChanged(object sender, EventArgs e)
        {
            var CostumerIDInput = txt_searchCustomerIDOrName.Text;
        }
        private void btn_OKShowCostumer_Click(object sender, EventArgs e)
        {
            dgv_showCustomerInfo.DataSource = CostumerIDInput;
        }
        private void dgv_showCustomerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_showCustomerInfo_Click(object sender, EventArgs e)
        {
            txt_showCustomerIDFromSearch.Text = Costumer.CostumerID.ToString();
            txt_changeCustomerFirstName.Text = Costumer.FirstName;
            txt_changeCustomerLastName.Text = Costumer.LastName;
            txt_changeCustomerPhoneNumber.Text = Costumer.PhoneNumber;
            txt_changeCustomerEmail.Text = Costumer.Email;
            txt_changeCustomerAddress.Text = Costumer.Address;
            txt_changeCustomerPostalCode.Text = Costumer.PostalCode.ToString();
            txt_changeCustomerCity.Text = Costumer.City;
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
            Costumer.PostalCode= int.Parse(txt_changeCustomerPostalCode.Text);
            Costumer.City = txt_changeCustomerCity.Text;

        }


    }
}
