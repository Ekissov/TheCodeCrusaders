using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Repository
{
    internal class CostumerDatabaseSQL
    {
        //Vi giver systemet den connection string den skal bruge for at oprette forbindelse til databasen
        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9");

        //C
        public static void CreateCustomer(Models.Costumer costumer)
        {

            string query = $"INSERT INTO Customer (CustomerID,FirstName,LastName,PhoneNumber,PostalCode,City,Address) " +
                $"VALUES ({costumer.CostumerID}, '{costumer.FirstName}','{costumer.LastName}','{costumer.PhoneNumber}','{costumer.Email}','{costumer.PostalCode}','{costumer.City}','{costumer.Address}')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }


        //R
        public static List<string> ReadCustomer()
        {
            List<string> result = new List<string>();
            string query = "SELECT * FROM Customer";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); //Åbner readeren 

            while (reader.Read())
            {
                string row = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row += reader[i].ToString() + " - "; // Aflæser data og laver det om til string
                }
                result.Add(row); //tilføjer data til listen
            }

            reader.Close(); // lukker aflæseren og forbindelsen 
            connection.Close();
            return result; // retunerer resultatet som en liste

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
