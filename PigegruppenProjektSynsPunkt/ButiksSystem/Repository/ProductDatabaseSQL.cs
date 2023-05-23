using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Repository
{
    internal class ProductDatabaseSQL
    {
        //Vi giver systemet den connection string den skal bruge for at oprette forbindelse til databasen
        private static SqlConnection connection = new SqlConnection("Insert connection string HERE!"); //"Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9";

        //C
        public static void CreateProduct(int ProductID, string ProductName, double Price, int CategoryID, int Quantity)
        {

            string query = $"INSERT INTO Product (ProductID,ProductName,Price,CategoryID,Quantity) " +
                $"VALUES ({ProductID.ToString()}, '{ProductName}', {Price.ToString().Replace(',', '.')}, {CategoryID.ToString()}, {Quantity.ToString()})";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }


        //R
        public static List<string> ReadProduct()
        {
            List<string> result = new List<string>();
            string query = "SELECT * FROM Product";
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
        public static void UpdateProduct(int ProductID, string ProductName, double Price, int CategoryID, int Quantity)
        {
            //Update sætningen herunder er muligvis ikke korrekt
            string query = $"UPDATE Product SET ProductName = '{ProductName}', Price = '{Price}', CategoryID = '{CategoryID}', Quantity = '{Quantity}' WHERE ProductID = '{ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();

        }

        //D

        public static void DeleteProduct(int ProductID)
        {

            string query = $"DELETE FROM Product WHERE ProductID = '{ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }

    }
}
