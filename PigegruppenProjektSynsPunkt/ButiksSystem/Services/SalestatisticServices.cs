using ButiksSystem.Database;
using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace ButiksSystem.Services
{
    public class SalestatisticServices
    {

        public List<Models.CostumerOrder> GetCostumerOrdersWithinGivenTime(DateTime startdate, DateTime endDate)
        {
            var listOfCostumerOrders = DummyDataSales.CreateDummyDataSales();

            var ordersWithinTimePeriod =listOfCostumerOrders.Where(x => x. OrderDate >= startdate && x.OrderDate <= endDate).ToList();

            return ordersWithinTimePeriod;
        }

        public void CreateSalesFile(List<CostumerOrder> listOfCostumerOrders, DateTime startDate, DateTime endDate)
        {
            List<CostumerOrder> costumerOrders = listOfCostumerOrders;

            string FilePath = @"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\Salgsstatistik.txt";

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine("SALGSSTATISTIK 2023" + "              Fra dato: " + startDate + "      Til Dato: " + endDate);
                string salesfileHeadigns = "Kundenummer      Kundenavn        Dato                          Køb";
                writer.WriteLine(salesfileHeadigns);

                foreach (var item in listOfCostumerOrders)
                {
                    writer.WriteLine(item.ToString());
                }
                decimal sumOfPrices = listOfCostumerOrders.Sum(x => x.TotalPrice);
                writer.WriteLine("                                              I alt kr.         " + sumOfPrices);
            }

        }
    }
}
