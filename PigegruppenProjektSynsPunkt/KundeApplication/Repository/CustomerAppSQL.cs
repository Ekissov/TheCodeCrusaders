using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeApplication.Repository
{
    internal class CustomerAppSQL
    {
        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9");

        public List<> ReadAllProducts()
        {
            List<> allProducts = new Product();

            string query =  $"SELECT ProductID, ProductName, Price, ProductColour FROM Product";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product(
                    (int)reader("ProductID"),
                    reader("ProductName").ToString(),
                    (int)reader("Price"),
                    reader("ProductColour"));

                allProducts.Add(product);
            }
            reader.Close();
            connection.Close();

            return allProducts;
        }
    }
}
