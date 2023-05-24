﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Models
{
    public class CostumerOrder
    {
        private int OrderID { get; set; }
        private int EmployeeID { get; set; }
        private string OrderLineID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        private DateTime DeliveryDate { get; set; }
        public int CostumerID { get; set; }
        public string CostumerName { get; set; }

        public CostumerOrder(int costumerID, string costumerName, int orderID, int employeeID, string orderLineID, DateTime deliveryDate, DateTime orderDate, decimal totalPrice)
        {
            OrderID = orderID;
            EmployeeID = employeeID;
            OrderLineID = orderLineID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            DeliveryDate = deliveryDate;
            CostumerID = costumerID;
            CostumerName = costumerName;
        }

        public override string ToString()
        {
            return $"{CostumerID}                {CostumerName}      {OrderDate}           {TotalPrice}";
        }
    }
}
