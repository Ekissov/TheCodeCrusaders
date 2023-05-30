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
        /// Recieves costumer object from Services and creates a new costumer in the database.
        /// </summary>
        /// <param name="costumer"></param>
        public void CreateCustomer(Models.Costumer costumer)
        {

            string query = $"INSERT INTO CustomerTable (FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email) " +
                $"VALUES ('{costumer.FirstName}'" +
                $",'{costumer.LastName}'," +
                $"'{costumer.PhoneNumber}'," +
                $"'{costumer.PostalCode}'," +
                $"'{costumer.City}'," +
                $"'{costumer.Address}'," +
                $"'{costumer.Email}')";

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
        public List<Costumer> GetAllCustomers()
        {
            List<Costumer> customerList = new List<Costumer>();
            string query = "SELECT FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email, CustomerID FROM CustomerTable";
            
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();  

            while (reader.Read())
            {
                int customerID = (int)reader["CustomerID"];

                Costumer costumer = new Costumer(
                 reader["FirstName"].ToString(),
                 reader["LastName"].ToString(),
                 reader["PhoneNumber"].ToString(),
                 reader["email"].ToString(),
                 (int)reader["PostalCode"],
                 reader["city"].ToString(),
                 reader["CustomerAddress"].ToString(),
                 customerID);

                customerList.Add(costumer);
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
        public Costumer GetSelectedCustomer(int customerID)
        {
            string query = $"SELECT FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email, CustomerID FROM CustomerTable WHERE CustomerID = {customerID}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();  

            Costumer selectedCustomer = null;
            while (reader.Read())
            {
                selectedCustomer = new Costumer(
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
        /// CRUD Method (U) this updates a Customer in the database. It recieves info from Service.CostumerService
        /// </summary>
        /// <param name="costumer"></param>
        public void UpdateCustomer(Models.Costumer costumer)
        {
            string query = $"UPDATE CustomerTable SET " +
                $"FirstName = '{costumer.FirstName}', " +
                $"LastName = '{costumer.LastName}', " +
                $"PhoneNumber = '{costumer.PhoneNumber}', " +
                $"Email = '{costumer.Email}', " +
                $"PostalCode = '{costumer.PostalCode}', " +
                $"City = '{costumer.City}', " +
                $"CustomerAddress = '{costumer.Address}' " +
                $"WHERE CustomerID = '{costumer.CostumerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery(); 

            connection.Close();

        }

        //D
        /// <summary>
        /// CRUD Method (D) this deletes a customer from the database. It recieves info from Service.CostumerService
        /// </summary>
        /// <param name="costumer"></param>
        public void DeleteCustomer(Models.Costumer costumer)
        {

            string query = $"DELETE FROM CustomerTable WHERE CustomerID = '{costumer.CostumerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery(); 

            connection.Close();
        }
    }
}
