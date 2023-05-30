using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class CustomerOrder
    {
        private int OrderID { get; set; }
        private int EmployeeID { get; set; }
        private string OrderLineID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        private DateTime DeliveryDate { get; set; }
        

        public CustomerOrder(int customerID, string customerName, int orderID, int employeeID, string orderLineID, DateTime deliveryDate, DateTime orderDate, decimal totalPrice)
        {
            OrderID = orderID;
            EmployeeID = employeeID;
            OrderLineID = orderLineID;
            OrderDate = orderDate.Date;
            TotalPrice = totalPrice;
            DeliveryDate = deliveryDate.Date;
            CustomerID = customerID;
            CustomerName = customerName;
        }

        public CustomerOrder( string customerName, int costumerID, DateTime orderDate, decimal totalPrice)
        {
            TotalPrice = totalPrice;
            OrderDate = orderDate.Date;
            CustomerID = costumerID;
            CustomerName = customerName;
        }

        public override string ToString()
        {
            return $"{CustomerID}                {CustomerName}      {OrderDate}           {TotalPrice}";
        }
    }
}
