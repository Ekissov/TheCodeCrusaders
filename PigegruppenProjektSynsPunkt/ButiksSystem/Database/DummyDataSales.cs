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

           CostumerOrder sale2 = new CostumerOrder(2, 15, "12", orderDate, 4534, deliveryDate, 4, costumer.FirstName + " " + costumer.LastName);
            
            orderDate = new DateTime(2023, 02, 10);
            deliveryDate = new DateTime(2023, 02, 20);

            CostumerOrder sale3 = new CostumerOrder(3, 8, "17", orderDate, 4000, deliveryDate, 2, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 10);
            deliveryDate = new DateTime(2023, 01, 19);

            CostumerOrder sale4 = new CostumerOrder(4, 11, "4", orderDate, 8000, deliveryDate, 3, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 03);
            deliveryDate = new DateTime(2023, 01, 13);

            CostumerOrder sale5 = new CostumerOrder(5, 5, "9", orderDate, 2500, deliveryDate, 7, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);

            CostumerOrder sale6 = new CostumerOrder(6, 15,"6", orderDate, 4500, deliveryDate, 6, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 03, 15);
            deliveryDate = new DateTime(2023, 03, 21);

            CostumerOrder sale7 = new CostumerOrder(7, 11, "3", orderDate, 8500, deliveryDate, 10, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 02, 13);
            deliveryDate = new DateTime(2023, 02, 21);

            CostumerOrder sale8 = new CostumerOrder(8, 5, "5", orderDate, 5400, deliveryDate, 12, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 04, 10);
            deliveryDate = new DateTime(2023, 04, 19);

            CostumerOrder sale9 = new CostumerOrder(9, 8, "8", orderDate, 3990, deliveryDate, 13, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 03, 02);
            deliveryDate = new DateTime(2023, 03, 10);

            CostumerOrder sale10 = new CostumerOrder(10, 15, "13", orderDate, 6050, deliveryDate, 22, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 04, 25);
            deliveryDate = new DateTime(2023, 05, 03);

            CostumerOrder sale11 = new CostumerOrder(11, 12, "9", orderDate, 6370, deliveryDate, 21, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 03, 01);
            deliveryDate = new DateTime(2023, 03, 11);

            CostumerOrder sale12 = new CostumerOrder(12, 8, "7", orderDate, 5000, deliveryDate, 41, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 16);
            deliveryDate = new DateTime(2023, 01, 24);

            CostumerOrder sale13 = new CostumerOrder(13, 8, "6", orderDate, 6400, deliveryDate, 15, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 01, 31);
            deliveryDate = new DateTime(2023, 02, 08);

            CostumerOrder sale14 = new CostumerOrder(14, 15, "9", orderDate, 10500, deliveryDate, 24, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 02, 20);
            deliveryDate = new DateTime(2023, 02, 28);

            CostumerOrder sale15 = new CostumerOrder(15, 8, "11", orderDate, 9450, deliveryDate, 20, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 03, 24);
            deliveryDate = new DateTime(2023, 04, 02);

            CostumerOrder sale16 = new CostumerOrder(16, 11, "10", orderDate, 7540, deliveryDate, 9, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 02, 25);
            deliveryDate = new DateTime(2023, 03, 07);

            CostumerOrder sale17 = new CostumerOrder(17, 12, "7", orderDate, 2500, deliveryDate, 5, costumer.FirstName + " " + costumer.LastName);

            orderDate = new DateTime(2023, 03, 18);
            deliveryDate = new DateTime(2023, 03, 27);

            CostumerOrder sale18 = new CostumerOrder(18, 5, "9", orderDate, 5020, deliveryDate, 8, costumer.FirstName + " " + costumer.LastName);

            listOfSales.Add(sale1);
            listOfSales.Add(sale2);
            listOfSales.Add(sale3);
            listOfSales.Add(sale4);
            listOfSales.Add(sale5);
            listOfSales.Add(sale6);
            listOfSales.Add(sale7);
            listOfSales.Add(sale8);
            listOfSales.Add(sale9);
            listOfSales.Add(sale10);
            listOfSales.Add(sale11);
            listOfSales.Add(sale12);
            listOfSales.Add(sale13);
            listOfSales.Add(sale14);
            listOfSales.Add(sale15);
            listOfSales.Add(sale16);
            listOfSales.Add(sale17);
            listOfSales.Add(sale18);

            return listOfSales;
        }
    }
}
