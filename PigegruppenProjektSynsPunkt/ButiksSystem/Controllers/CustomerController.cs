using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.Services;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Controllers
{
    public class CustomerController
    {
        public void UpdateCustomer(Customer customer)
        {
            Services.CustomerServices customerServices = new Services.CustomerServices();
            customerServices.UpdateCustomer(customer);
        }

        public List<Customer> ReadAllCustomers()
        {
            var result = new List<Customer>();
            return result;
        }

        /// <summary>
        /// Recieves a customer object from CreateCustomerUI
        /// Instantiate new Services.CustomerService and calls CreateCustomer 
        /// </summary>
        /// <param name="customer"></param>
        public void CreateCustomer(Customer customer)
        {
            Services.CustomerServices customerServices = new Services.CustomerServices();
            customerServices.CreateCustomer(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            Services.CustomerServices customerServices = new Services.CustomerServices();
            customerServices.DeleteCustomer(customer);
        }

      
        public List<Customer> CustomerBySearch(string input)
        {
            CustomerServices customerServices = new CustomerServices();
            return customerServices.CustomerBySearch(input);
        }
        public Customer GetSelectedCustomer(int customerID)
        {
            CustomerServices customerServices = new CustomerServices();
            return customerServices.GetSelectedCustomer(customerID);
        }

    }
}
