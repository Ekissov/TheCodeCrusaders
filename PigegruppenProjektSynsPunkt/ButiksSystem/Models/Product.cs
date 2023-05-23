using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Product
    {
        //public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }

        public Product (string productName, decimal productPrice, int quantity, int categoryID)
        {
           
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.CategoryID = categoryID;
            this.Quantity = quantity;
        }
    }
}
