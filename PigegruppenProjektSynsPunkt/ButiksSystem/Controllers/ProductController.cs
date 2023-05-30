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
        public void CreateProduct(string productName, decimal price, int categoryId, int quantity)
        {
            Product product = new Product(productName, price, categoryId, quantity);
            ProductServices productServices = new ProductServices();
            productServices.CreateProduct(product);
        }

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

        public List<Product> ProductListBySearch(string input)
        {
            ProductServices productServices = new ProductServices();
            return productServices.ProductListBySearch(input);
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

        public Product GetSelectedProduct(int productID)
        {
            ProductServices productServices = new ProductServices();
            Product selectedProduct = productServices.GetSelectedProduct(productID);
            return selectedProduct;
        }
    }
}
