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

        public List<Models.Product> ReadAllProducts()
        {
            List<Models.Product> allProducts = new List<Models.Product>();

            string query =  $"SELECT ProductID, ProductName, FrameColour, FrameFacon, FrameThickness, Nosepads, FramePattern, ProductPrice FROM Product";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Models.Product product = new Models.Product(
                    (int)reader["ProductID"],
                    reader["ProductName"].ToString(),                   
                    reader["FrameColour"].ToString(),
                    reader["FrameFacon"].ToString(),
                    (int)reader["FrameThickness"],
                    reader["NosePads"].ToString(),
                    reader["FramePattern"].ToString(),
                    (int)reader["Price"]);

                allProducts.Add(product);
            }
            reader.Close();
            connection.Close();

            return allProducts;
        }


    }
}
