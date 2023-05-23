using ButiksSystem.Models;
using ButiksSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Controllers
{
    public class ProductController
    {
        public static void CreateProduct(string productName, decimal price, int categoryId, int quantity)
        {
            Product product = new Product(productName, price, categoryId, quantity);
            ProductServices.CreateProduct(product);
        }



    }


}
