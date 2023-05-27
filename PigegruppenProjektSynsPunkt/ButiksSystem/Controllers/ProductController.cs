using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Controllers
{
    public class ProductController
    {
        /// <summary>
        /// Method to create a new product in the database. takes info from the the UI and sends to ProductService.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="price"></param>
        /// <param name="categoryId"></param>
        /// <param name="quantity"></param>
        public static void CreateProduct(string productName, decimal price, int categoryId, int quantity)
        {
            Product product = new Product(productName, price, categoryId, quantity);
            ProductServices.CreateProduct(product);
        }

        /*public static void PrintAllProducts()
        {
            ProductServices.PrintAllProducts();
        }*/
        /// <summary>
        /// Method that creates a list with all products in the database. 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {

            ProductServices productServices = new ProductServices();
            productServices.GetAllProducts();

            return productServices.GetAllProducts();

        }

        public List<Product> ReadAllProductsToList()
        {
            var result = new List<Product>();
            return result;
        }

        public void UpdateProduct(Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.UpdateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.DeleteProduct(product);
        }

        public void PrintDataGridViewToFile(DataGridView dataGridView)
        {
            ProductServices productServices = new ProductServices();
            productServices.PrintDataGridViewToFile(dataGridView);
        }

    }
}
