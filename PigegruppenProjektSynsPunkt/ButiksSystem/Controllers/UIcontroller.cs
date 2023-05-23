﻿using ButiksSystem.Models;
using ButiksSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Controllers
{
    internal class UIController
    {

        /// <summary>
        /// This method calls Services for the SalesStatistic UI, 
        /// So that it can get all costumerOrders within a specific time period
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public List<CostumerOrder> GetCostumerOrdersWithinGivenTime(DateTime StartDate, DateTime EndDate)
        {
            SalestatisticServices salestatisticServices = new SalestatisticServices();
            return salestatisticServices.GetCostumerOrdersWithinGivenTime(StartDate, EndDate);
        }

        public void CreateSalesFile(List<CostumerOrder> listOfCostumerOrders)
        {
            SalestatisticServices salestatisticServices = new SalestatisticServices();
            salestatisticServices.CreateSalesFile(listOfCostumerOrders);
        }
    }
}
