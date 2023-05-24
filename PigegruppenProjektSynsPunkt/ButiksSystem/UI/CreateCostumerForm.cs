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

namespace ButiksSystem.UI
{
    public partial class CreateCostumerForm : Form
    {
        public Models.Costumer Costumer { get; set; }

        public CreateCostumerForm()
        {
            InitializeComponent();
        }

        public void btn_createCustomer_Click(object sender, EventArgs e)
        {
            //controller.opretkunde
           // Costumer = new Models.Costumer(Costumer.FirstName, Costumer.LastName, Costumer.PhoneNumber, Costumer.Adress, Costumer.PostalCode, Costumer.City, Costumer.Email);

            Costumer.FirstName = txt_createCustomerFirstName.Text;
            Costumer.LastName = txt_createCustomerLastName.Text;
            Costumer.PhoneNumber = txt_createCutomerPhoneNumber.Text;
            Costumer.Email = txt_createCustomerEmail.Text;
            Costumer.Address = txt_createCustomerAddress.Text;
            Costumer.PostalCode = int.Parse(txt_createCustomerPostalCode.Text);
            Costumer.City = txt_createCustomerCity.Text;
            
            Costumer = new Models.Costumer(Costumer.FirstName, Costumer.LastName, Costumer.PhoneNumber, Costumer.Address, Costumer.PostalCode, Costumer.City, Costumer.Email);
            
            this.Close();
        }



    }
}
