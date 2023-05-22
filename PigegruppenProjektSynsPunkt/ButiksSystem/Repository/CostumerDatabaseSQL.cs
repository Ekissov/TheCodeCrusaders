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
        private static SqlConnection connection = new SqlConnection("Insert connection string HERE!");

        //C
        public static void CreateCustomer(int CustomerID, string FirstName, string LastName, string PhoneNumber, string Email, int PostalCode, string City, string Address)
        {

            string query = $"INSERT INTO Customer (CustomerID,FirstName,LastName,PhoneNumber,PostalCode,City,Address) " +
                $"VALUES ({CustomerID.ToString()}, '{FirstName}','{LastName}','{PhoneNumber}','{Email}','{PostalCode.ToString()}','{City}','{Address}')";

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
        public static void UpdateCustomer(int CustomerID, string FirstName, string LastName, string PhoneNumber, string Email, int PostalCode, string City, string Address)
        {
            //Update sætningen herunder er muligvis ikke korrekt
            string query = $"UPDATE Customer SET FirstName = '{FirstName}', LastName = '{LastName}', PhoneNumber = '{PhoneNumber}', Email = '{Email}', PostalCode = '{PostalCode}', City = '{City}', Address = '{Address}' WHERE CustomerID = '{CustomerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();

        }

        //D

        public static void DeleteCustomer(int CustomerID)
        {

            string query = $"DELETE FROM Product WHERE ProductID = '{CustomerID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }
    }
}
