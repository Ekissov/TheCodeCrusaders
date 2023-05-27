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
        /// Method that links the CreateProduct method between service and UI
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
        /// Method that links the GetAllProducts method between service and UI 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {

            ProductServices productServices = new ProductServices();
            productServices.GetAllProducts();

            return productServices.GetAllProducts();

        }
        //Spørg Linda :P
        public List<Product> ReadAllProductsToList()
        {
            var result = new List<Product>();
            return result;
        }
        /// <summary>
        /// Method that links the UpdateProduct method between service and UI
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Product product)
        {
            ProductServices productServices = new ProductServices();
            productServices.UpdateProduct(product);
        }
        /// <summary>
        /// Method that links the DeleteProduct method between service and UI
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Product product)
        {
            ProductServices productServices = new ProductServices();
            productServices.DeleteProduct(product);
        }
        /// <summary>
        /// Method that links the PrintDataGridViewToFile method between service and UI
        /// </summary>
        /// <param name="dataGridView"></param>
        public void PrintDataGridViewToFile(DataGridView dataGridView)
        {
            ProductServices productServices = new ProductServices();
            productServices.PrintDataGridViewToFile(dataGridView);
        }

    }
}
