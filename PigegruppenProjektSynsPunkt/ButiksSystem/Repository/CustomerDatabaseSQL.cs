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
        //Vi giver systemet den connection string den skal bruge for at oprette forbindelse til databasen
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
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }


        //R
        public List<Costumer> ReadCustomer()
        {
            List<Costumer> customerList = new List<Costumer>();
            string query = "SELECT * FROM CustomerTable";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); //Åbner readeren 

            while (reader.Read())
            {
                Costumer costumer = new Costumer(
                 reader["FirstName"].ToString(),
                 reader["LastName"].ToString(),
                 reader["PhoneNumber"].ToString(),
                 reader["email"].ToString(),
                 (int)reader["PostalCode"],
                 reader["city"].ToString(),
                 reader["CustomerAddress"].ToString(),
                 (int)reader["CustomerID"]);

                customerList.Add(costumer);
            }
            if (customerList == null)
            {
                throw new Exception("Der er ingen kunder i listen");
            }
            reader.Close(); // lukker aflæseren og forbindelsen 
            connection.Close();
            return customerList; // retunerer resultatet som en liste
        }

        //R
        public Costumer GetSelectedCustomer(int customerID)
        {
            string query = $"SELECT FirstName, LastName, PhoneNumber, PostalCode, City, CustomerAddress, Email, CustomerID FROM CustomerTable WHERE CustomerID = {customerID}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); //Åbner readeren 

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

         
            reader.Close(); // lukker aflæseren og forbindelsen 
            connection.Close();
            return selectedCustomer;
        }   
            

            //U
        public void UpdateCustomer(Models.Costumer costumer)
        {
            //Update sætningen herunder er muligvis ikke korrekt
            string query = $"UPDATE Customer SET FirstName = '{costumer.FirstName}', LastName = '{costumer.LastName}', PhoneNumber = '{costumer.PhoneNumber}', Email = '{costumer.Email}', PostalCode = '{costumer.PostalCode}', City = '{costumer.City}', Address = '{costumer.Address}' WHERE CustomerID = '{costumer.CostumerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();

        }

        //D

        public void DeleteCustomer(Models.Costumer costumer)
        {

            string query = $"DELETE FROM Costumer WHERE CostumerID = '{costumer.CostumerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }
    }
}
