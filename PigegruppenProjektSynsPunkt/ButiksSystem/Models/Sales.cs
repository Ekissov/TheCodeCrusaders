using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Sales
    {
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public string OrderLineID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CostumerID { get; set; }

        public Sales(int orderID, int employeeID, string orderLineID, DateTime orderDate, decimal totalPrice, decimal discountPrice, decimal taxAmount, DateTime deliveryDate, int costumerID)
        {
            OrderID = orderID;
            EmployeeID = employeeID;
            OrderLineID = orderLineID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            DiscountPrice = discountPrice;
            TaxAmount = taxAmount;
            DeliveryDate = deliveryDate;
            CostumerID = costumerID;
        }

    }
}
