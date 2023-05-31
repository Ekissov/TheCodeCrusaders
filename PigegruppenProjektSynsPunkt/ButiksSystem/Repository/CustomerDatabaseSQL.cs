using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Repository
{
    internal class CustomerDatabaseSQL
    {

        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9");

        //C
        /// <summary>
        /// Recieves customer object from Services and creates a new costumer in the database. CustomerTable
        /// </summary>
        /// <param name="costumer"></param>
        public void CreateCustomer(Models.Customer customer)
        {

            string query = $"INSERT INTO Customer (FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email) " +
                $"VALUES ('{customer.FirstName}'" +
                $",'{customer.LastName}'," +
                $"'{customer.PhoneNumber}'," +
                $"'{customer.PostalCode}'," +
                $"'{customer.City}'," +
                $"'{customer.Address}'," +
                $"'{customer.Email}')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); 

            connection.Close();
        }

        //R
        /// <summary>
        /// CRUD Method (R) Reads all Customers in the database and puts them in a list.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            string query = "SELECT FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email, CustomerID FROM Customer";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();  

            while (reader.Read())
            {
                int customerID = (int)reader["CustomerID"];

                Customer customer = new Customer(
                 reader["FirstName"].ToString(),
                 reader["LastName"].ToString(),
                 reader["PhoneNumber"].ToString(),
                 reader["email"].ToString(),
                 (int)reader["PostalCode"],
                 reader["city"].ToString(),
                 reader["CustomerAddress"].ToString(),
                 customerID);

                customerList.Add(customer);
            }
            
            reader.Close(); 
            connection.Close();
            return customerList; 
        }

        //R
        /// <summary>
        /// CRUD Method (R)  reads and selects a specific customer from the database. Then it returns the customer information in a modelcustomer to store the info.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public Customer GetSelectedCustomer(int customerID)
        {
            string query = $"SELECT FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email, CustomerID FROM Customer WHERE CustomerID = {customerID}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();  

            Customer selectedCustomer = null;
            while (reader.Read())
            {
                selectedCustomer = new Customer(
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["PhoneNumber"].ToString(),
                    reader["email"].ToString(),
                    (int)reader["PostalCode"],
                    reader["city"].ToString(),
                    reader["CustomerAddress"].ToString(),
                    (int)reader["CustomerID"]);
            }
         
            reader.Close();  
            connection.Close();
            return selectedCustomer;
        }


        //U
        /// <summary>
        /// CRUD Method (U) this updates a Customer in the database. It recieves info from Service.CUstomerService
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Models.Customer customer)
        {
            string query = $"UPDATE Customer SET " +
                $"FirstName = '{customer.FirstName}', " +
                $"LastName = '{customer.LastName}', " +
                $"PhoneNumber = '{customer.PhoneNumber}', " +
                $"Email = '{customer.Email}', " +
                $"PostalCode = '{customer.PostalCode}', " +
                $"City = '{customer.City}', " +
                $"CustomerAddress = '{customer.Address}' " +
                $"WHERE CustomerID = '{customer.CustomerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery(); 

            connection.Close();

        }

        //D
        /// <summary>
        /// CRUD Method (D) this deletes a customer from the database. It recieves info from Service.CustomerService
        /// </summary>
        /// <param name="customer"></param>
        public void DeleteCustomer(Models.Customer customer)
        {

            string query = $"DELETE FROM Customer WHERE CustomerID = '{customer.CustomerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery(); 

            connection.Close();
        }
    }
}
