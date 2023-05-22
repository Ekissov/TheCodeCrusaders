using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Database
{
    public class DummyDataSales
    {

        public static List<Sales> CreateDummyDataSales()
        {
           List<Sales> listOfSales = new List<Sales>();

            var orderDate = DateTime.Now.Date;
            var deliveryDate = new DateTime(2023, 05, 29);

            Sales sale1 = new Sales(1, 12, "1", orderDate, 4534, 4534, 1133.5M, deliveryDate, 1);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 18);

            Sales sale2 = new Sales(2, 15, "12", orderDate, 4534, 4534, 1133.5M, deliveryDate, 1);

            listOfSales.Add(sale1);
            listOfSales.Add(sale2);
            return listOfSales;
        }
    }
}
