using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Services
{
    public class CustomerServices
    {
        /// <summary>
        /// Create a new customer in the database with the customer information input from customer Parameter. 
        /// </summary>
        /// <param name="customer"></param>
        public void CreateCustomer(Customer customer)
        {
            CustomerDatabaseSQL customerDatabaseSQL = new CustomerDatabaseSQL();
            customerDatabaseSQL.CreateCustomer(customer);
        }

        /// <summary>
        /// Method to update or change a customer and then save the new information in the database
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Models.Customer customer)
        {
            CustomerDatabaseSQL customerDatabaseSQL = new CustomerDatabaseSQL();
            customerDatabaseSQL.UpdateCustomer(customer);
        }

        /// <summary>
        /// Method to delete a customer. 
        /// </summary>
        /// <param name="customer"></param>
        public void DeleteCustomer(Models.Customer customer)
        {
            CustomerDatabaseSQL customerDatabaseSQL = new CustomerDatabaseSQL();
            customerDatabaseSQL.DeleteCustomer(customer);
        }
        /// <summary>
        /// Method that enables the user to search for a customer with both ID and name/parts of name - returns a list with the result.
        /// </summary>
        /// <param name="customerInput"></param>
        /// <returns></returns>
        public List<Customer> CustomerBySearch(string customerInput)
        {
            CustomerDatabaseSQL customerDatabaseSQL = new CustomerDatabaseSQL();
            List<Customer> allCustomers = customerDatabaseSQL.GetAllCustomers();

            int searchCustomerId;
            bool isNumeric = int.TryParse(customerInput, out searchCustomerId);

            var allCustomersSearch = allCustomers.Where(x =>
            x.FirstName.IndexOf(customerInput, StringComparison.OrdinalIgnoreCase) >= 0 ||
            x.LastName.IndexOf(customerInput, StringComparison.OrdinalIgnoreCase) >= 0 ||
            (isNumeric && x.CustomerID == searchCustomerId)).ToList();

            return allCustomersSearch;
        }
        /// <summary>
        /// call GetSelectedCustomer from our repository.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public Customer GetSelectedCustomer(int customerID)
        {
            CustomerDatabaseSQL customerDatabaseSQL = new CustomerDatabaseSQL();
            return customerDatabaseSQL.GetSelectedCustomer(customerID);
        }
    }
}
