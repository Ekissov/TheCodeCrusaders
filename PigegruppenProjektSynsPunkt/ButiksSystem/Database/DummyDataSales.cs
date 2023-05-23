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

        public static List<CostumerOrder> CreateDummyDataSales()
        {
           List<CostumerOrder> listOfSales = new List<CostumerOrder>();

            var orderDate = DateTime.Now.Date;
            var deliveryDate = new DateTime(2023, 05, 29);
            Costumer costumer = new Costumer("Eigil", "Olsen", "+45 12 34 56 78", "Boulevarden 25", 7100, "Vejle", "Hej22@gmail.com");
            CostumerOrder sale1 = new CostumerOrder(1, 12, "1", orderDate, 4534, deliveryDate, 1, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);

           // CostumerOrder sale2 = new CostumerOrder(2, 15, "12", orderDate, 4534, deliveryDate, 4);
            
            orderDate = new DateTime(2023, 02, 10);
            deliveryDate = new DateTime(2023, 02, 20);

           // CostumerOrder sale3 = new CostumerOrder(3, 8, "17", orderDate, 4000, deliveryDate, 2);

            orderDate = new DateTime(2023, 01, 10);
            deliveryDate = new DateTime(2023, 01, 19);

           // CostumerOrder sale4 = new CostumerOrder(4, 11, "4", orderDate, 8000, deliveryDate, 3);

            orderDate = new DateTime(2023, 03, 25);
            deliveryDate = new DateTime(2023, 04, 03);

          //  CostumerOrder sale5 = new CostumerOrder(2, 5, "9", orderDate, 2500, deliveryDate, 1);

            listOfSales.Add(sale1);
          /*  listOfSales.Add(sale2);
            listOfSales.Add(sale3);
            listOfSales.Add(sale4);
            listOfSales.Add(sale5);*/
            return listOfSales;
        }
    }
}
