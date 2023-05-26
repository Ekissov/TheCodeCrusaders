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
        /// 
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

        public void PrintDataGridViewToFile(DataGridView dataGridView, string filePath)
        {
            ProductServices productServices = new ProductServices();
            productServices.PrintDataGridViewToFile(dataGridView, filePath);
        }

    }
}
