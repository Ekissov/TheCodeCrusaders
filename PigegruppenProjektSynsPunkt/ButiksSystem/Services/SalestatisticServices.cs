using ButiksSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Services
{
    public class SalestatisticServices
    {

        public static List<Models.CostumerOrder> GetCostumerOrdersWithinGivenTime(DateTime startdate, DateTime endDate)
        {
            var listOfCostumerOrders = DummyDataSales.CreateDummyDataSales();

            var ordersWithinTimePeriod =listOfCostumerOrders.Where(x => x. OrderDate >= startdate && x.OrderDate <= endDate).ToList();

            return ordersWithinTimePeriod;
        }
    }
}
