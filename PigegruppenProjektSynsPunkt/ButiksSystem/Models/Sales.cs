using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class Sales
    {
        private int OrderID { get; set; }
        private int EmployeeID { get; set; }
        public string OrderLineID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CostumerID { get; set; }

        public Sales(int orderID, int employeeID, string orderLineID, DateTime orderDate, decimal totalPrice, DateTime deliveryDate, int costumerID)
        {
            OrderID = orderID;
            EmployeeID = employeeID;
            OrderLineID = orderLineID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            DeliveryDate = deliveryDate;
            CostumerID = costumerID;
        }

    }
}
