using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }

        public Product (int productID, string productName, decimal productPrice, int quantity, int categoryID)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
            CategoryID = categoryID;
        }
    }
}
