﻿using ButiksSystem.Models;
using ButiksSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Controllers
{
    internal class UIController
    {
        //This class only has methods that calls the methods of SalesStatisticServices,
        //and sends the information to SalesStatisticForm in the UI

        public List<CustomerOrder> GetCustomerOrdersWithinGivenTime(DateTime StartDate, DateTime EndDate)
        {
            SalestatisticServices salestatisticServices = new SalestatisticServices();
            return salestatisticServices.GetCustomerOrdersWithinGivenTime(StartDate, EndDate);
        }

        public void CreateSalesFile(List<CustomerOrder> listOfCustomerOrders, DateTime startDate, DateTime endDate, DataGridView dataGridView)
        {
            SalestatisticServices salestatisticServices = new SalestatisticServices();
            salestatisticServices.CreateSalesFile(listOfCustomerOrders, startDate, endDate, dataGridView);
        }
       
    }
}
