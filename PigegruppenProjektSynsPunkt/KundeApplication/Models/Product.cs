using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeApplication.Models
{
    internal class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductColour { get; set; }
        public int ProductPrice { get; set; }

        public Product(int productID, string productName, string productColour, int productPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ProductColour = productColour;
            this.ProductPrice = productPrice;
        }
    }
}
