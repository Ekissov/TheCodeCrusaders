using ButiksSystem.Models;
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
        // Connectionstring to connect to the databse
        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9"); 

        //C
        /// <summary>
        /// CRUD Method (C) this creates a product in the database. it recieves info from Service.Product
        /// </summary>
        /// <param name="product"></param>
        public void CreateProduct(Product product)
        {

            string query = $"INSERT INTO Product (ProductName, Price, CategoryID, Quantity) " +
                $"VALUES ('" +
                $"{product.ProductName}', " +
                $"{product.ProductPrice.ToString().Replace(',', '.')}, " +
                $"{product.CategoryID}, " +
                $"{product.Quantity})";


            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        //R
        /// <summary>
        /// CRUD Method (R)  reads and selects a specific product from the database. Then it returns the productinformation in a modelproduct to store the info.
        /// </summary>
        /// <returns></returns>
        public Product GetSelectedProduct(int productID)
        {

            string query = $"SELECT ProductID, ProductName, Price, CategoryID, Quantity FROM Product WHERE ProductID = {productID}";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Product selectedProduct = null;
            while (reader.Read())
            {
                selectedProduct = new Product(
                    (int)reader["ProductID"],
                    reader["ProductName"].ToString(),
                    (decimal)reader["Price"],
                    (int)reader["CategoryID"],
                    (int)reader["Quantity"]);
            }
            reader.Close();
            connection.Close();
            return selectedProduct;
        }

        //U
        /// <summary>
        /// CRUD Method (U) this updates a product in the database. It recieves info from Service.ProductService
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            string query = $"UPDATE Product SET " +
                $"ProductName = '{product.ProductName}', " +
                $"Price = '{product.ProductPrice}', " +
                $"CategoryID = '{product.CategoryID}', " +
                $"Quantity = '{product.Quantity}' " +
                $"WHERE ProductID = '{product.ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        //D
        /// <summary>
        /// CRUD Method (D) this deletes a product in the database. It recieves info from Service.ProductService
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Product product)
        {
            string query = $"DELETE FROM Product WHERE ProductID = '{product.ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// This method creates a list. This list contains all 5 attributes from the ProductClass. It then sorts them alphabetically.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            string query = "SELECT ProductID, ProductName, Price, CategoryID, Quantity FROM [Product] ORDER BY ProductName ASC";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int productID = reader.GetInt32(0);
                string productName = reader.GetString(1);
                decimal productPrice = reader.GetDecimal(2);
                int categoryID = reader.GetInt32(3);
                int quantity = reader.GetInt32(4);
                Product product = new Product(productID, productName, productPrice, categoryID, quantity);

                result.Add(product);
            }
            reader.Close();
            connection.Close();
            return result;

        }

    }
}
