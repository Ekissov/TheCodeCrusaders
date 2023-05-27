﻿using ButiksSystem.Models;
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
        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9"); //"Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9";

        //C
        /// <summary>
        /// CRUD Method (C) this creates a product in the database. it recieves info from Service.Product
        /// </summary>
        /// <param name="product"></param>
        public void CreateProduct(Models.Product product)
        {

            string query = $"INSERT INTO Product (ProductName, Price, CategoryID, Quantity) " +
                $"VALUES ('{product.ProductName}', {product.ProductPrice.ToString().Replace(',', '.')}, {product.CategoryID.ToString()}, {product.Quantity.ToString()})";

          
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

            connection.Close();
        }


        //R
        /// <summary>
        /// CRUD Method (R) this reads a product in the database. Then it returns the info in a list. 
        /// </summary>
        /// <returns></returns>
        public List<string> ReadProduct()
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
                    row += reader[i] + " - "; // Aflæser data og laver det om til string
                }
                result.Add(row); //tilføjer data til listen
            }

            reader.Close(); // lukker aflæseren og forbindelsen 
            connection.Close();
            return result; // retunerer resultatet som en liste

        }

        //U
        /// <summary>
        /// CRUD Method (U) this updates a product in the database. It recieves info from Service.Product
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Models.Product product)
        {
            //Update sætningen herunder er muligvis ikke korrekt
            string query = $"UPDATE Product SET ProductName = '{product.ProductName}', Price = '{product.ProductPrice}', CategoryID = '{product.CategoryID}', Quantity = '{product.Quantity}' WHERE ProductID = '{product.ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end besked med at databasen er opdateret

            connection.Close();

        }

        //D
        /// <summary>
        /// CRUD Method (D) this deletes a product in the database. It recieves info from Service.Product
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Models.Product product)
        {

            string query = $"DELETE FROM Product WHERE ProductID = '{product.ProductID}'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int count = command.ExecuteNonQuery(); //NonQuery betyder at vi ikke retunerer noget andet end i besked med at databasen er opdateret

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
            SqlDataReader reader = command.ExecuteReader(); //Åbner readeren 

            while (reader.Read())
            {
                int productID = reader.GetInt32(0);
                string productName = reader.GetString(1);
                decimal productPrice = reader.GetDecimal(2);
                int categoryID = reader.GetInt32(3);
                int quantity = reader.GetInt32(4);
                Product row = new Product(productID, productName, productPrice, categoryID, quantity);

                result.Add(row); //tilføjer data til listen
            }

            reader.Close(); // lukker aflæseren og forbindelsen 
            connection.Close();
            return result; // retunerer resultatet som en liste

        }

    }
}
