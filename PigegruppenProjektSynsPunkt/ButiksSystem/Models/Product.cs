using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }

        public Product(string productName, decimal productPrice, int categoryID, int quantity)
        {

            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.CategoryID = categoryID;
            this.Quantity = quantity;
        }

        public Product(int productID, string productName, decimal productPrice, int categoryID, int quantity)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.CategoryID = categoryID;
            this.Quantity = quantity;
        }

        public override string ToString() 
        {

           return $"Produktnavn: " +
                $"{this.ProductName}\n" +
                $"  - Salgspris: {this.ProductPrice}\n" +
                $"  - VaregruppeNr: {this.CategoryID}\n" +
                $"  - Lagerbeholding: {this.Quantity}\n";
        
        }

    }
}
