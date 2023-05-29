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
            var deliveryDate = new DateTime(2023, 05, 24);
            Costumer costumer = new Costumer("Eigil    ", "Olsen     ", "+45 12 34 56 78", "Boulevarden 25", 7100, "Vejle", "Hej22@gmail.com", 2);
            CostumerOrder sale1 = new CostumerOrder(costumer.FirstName + " " + costumer.LastName, 10, orderDate, 4534);
            
            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Costumer costumer1 = new Costumer("Albert   ", "Hansen    ", "22448475", "Vestergade 359", 8000, "Århus", "AHansen@gmail.com",3);
            CostumerOrder sale2 = new CostumerOrder(costumer1.FirstName + " " + costumer1.LastName, 11, orderDate, 4534);

            orderDate = new DateTime(2023, 02, 10);
            deliveryDate = new DateTime(2023, 02, 20);
            Costumer costumer2 = new Costumer("Emma     ", "Roberts   ", "+4559483264", "Søndrealle 3", 8700, "Horsens", "EmRob@mail.dk",4);
            CostumerOrder sale3 = new CostumerOrder(costumer2.FirstName + " " + costumer2.LastName, 12, orderDate, 4000);

            orderDate = new DateTime(2023, 01, 10);
            deliveryDate = new DateTime(2023, 01, 19);
            Costumer costumer3 = new Costumer("Maja     ", "Sørensen  ", "49389503", "Parkvej 34", 8660, "Skanderborg", "MajaS@hotmail.com", 5);
            CostumerOrder sale4 = new CostumerOrder(costumer3.FirstName + " " + costumer3.LastName, 13, orderDate, 8000);

            orderDate = new DateTime(2023, 01, 03);
            deliveryDate = new DateTime(2023, 01, 13);
            Costumer costumer4 = new Costumer("Jacob    ", "Lassen    ", "39367429", "Skolegade 1", 7100, "Vejle", "LassenJ@live.dk", 6);
            CostumerOrder sale5 = new CostumerOrder(costumer4.FirstName + " " + costumer4.LastName, 14, orderDate, 2500);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Costumer costumer5 = new Costumer("René     ", "Jørgensen ", "44862061", "Pallesvej 1", 6064, "Jordrup", "ReneGensen@hotmail.com",7);
            CostumerOrder sale6 = new CostumerOrder(costumer5.FirstName + " " + costumer5.LastName, 15, orderDate, 4500);

            orderDate = new DateTime(2023, 03, 15);
            deliveryDate = new DateTime(2023, 03, 21);
            Costumer costumer6 = new Costumer("Peter    ", "Jensen    ", "43619480", "Villavej 35", 6094, "Hejls", "pjensen@gmail.com",8);
            CostumerOrder sale7 = new CostumerOrder(costumer6.FirstName + " " + costumer6.LastName, 16, orderDate, 8500);

            orderDate = new DateTime(2023, 02, 13);
            deliveryDate = new DateTime(2023, 02, 21);
            Costumer costumer7 = new Costumer("Hanne    ", "Kjær      ", "43659246", "Lysevej 35", 6092, "Sønder Stenderup", "HanneKJ@Live.dk", 9);
            CostumerOrder sale8 = new CostumerOrder(costumer7.FirstName + " " + costumer7.LastName, 17, orderDate, 5400);

            orderDate = new DateTime(2023, 04, 10);
            deliveryDate = new DateTime(2023, 04, 19);
            Costumer costumer8 = new Costumer("Camilla  ", "Ottesen   ", "+4526814082", "Rosevej 23", 6051, "Almind", "Cottesen@mail.dk", 10);
            CostumerOrder sale9 = new CostumerOrder(costumer8.FirstName + " " + costumer8.LastName, 18, orderDate, 3990);

            orderDate = new DateTime(2023, 03, 02);
            deliveryDate = new DateTime(2023, 03, 10);
            Costumer costumer9 = new Costumer("Thomas   ", "Nielsen   ", "+4572904831", "Dagnæsalle 43", 6623, "Vorbasse", "tni89@hotmail.com", 11);
            CostumerOrder sale10 = new CostumerOrder(costumer9.FirstName + " " + costumer9.LastName, 22, orderDate, 6050);

            orderDate = new DateTime(2023, 04, 25);
            deliveryDate = new DateTime(2023, 05, 03);
            Costumer costumer10 = new Costumer("Maria    ", "Petersen  ", "43882506", "Baggade 40", 6560, "Sommersted", "Maria224@hotmail.com", 12);
            CostumerOrder sale11 = new CostumerOrder(costumer10.FirstName + " " + costumer10.LastName, 21, orderDate, 6370);

            orderDate = new DateTime(2023, 03, 01);
            deliveryDate = new DateTime(2023, 03, 11);
            Costumer costumer11 = new Costumer("Daniel   ", "Dahl      ", "+4523954071", "Dyrealle", 6621, "Gesten", "Danicool@mail.dk", 13);
            CostumerOrder sale12 = new CostumerOrder(costumer11.FirstName + " " + costumer11.LastName, 23, orderDate, 5000);

            orderDate = new DateTime(2023, 01, 16);
            deliveryDate = new DateTime(2023, 01, 24);
            Costumer costumer12 = new Costumer("Leila    ", "Dyrmose   ", "+4524258301", "Grejsdahlsvejl 39", 7100, "Vejle", "DyrmosenL@gmail.com", 14);
            CostumerOrder sale13 = new CostumerOrder(costumer12.FirstName + " " + costumer12.LastName, 30, orderDate, 6400);

            orderDate = new DateTime(2023, 01, 31);
            deliveryDate = new DateTime(2023, 02, 08);
            Costumer costumer13 = new Costumer("Mikkel   ", "Laursen   ", "+4531923874", "P.C. Hansens Gade 85", 6580, "Vamdrup", "LaursenMik@gmail.com", 15);
            CostumerOrder sale14 = new CostumerOrder(costumer13.FirstName + " " + costumer13.LastName, 24, orderDate, 8500);

            orderDate = new DateTime(2023, 02, 20);
            deliveryDate = new DateTime(2023, 02, 28);
            Costumer costumer14 = new Costumer("Julie    ", "Kaspersen ", "+4584028475", "Spurvevej 2", 6640, "Lunderskov", "LegolasFrodo@gmail.com", 16);
            CostumerOrder sale15 = new CostumerOrder(costumer14.FirstName + " " + costumer14.LastName, 41, orderDate, 9450);

            orderDate = new DateTime(2023, 03, 24);
            deliveryDate = new DateTime(2023, 04, 02);
            Costumer costumer15 = new Costumer("Henrik   ", "Skov      ", "+4593827450", "Løvvej 32", 6670, "Holsted", "DMalfoy@live.dk", 17);
            CostumerOrder sale16 = new CostumerOrder(costumer15.FirstName + " " + costumer15.LastName, 69, orderDate, 7540);

            orderDate = new DateTime(2023, 02, 25);
            deliveryDate = new DateTime(2023, 03, 07);
            Costumer costumer16 = new Costumer("Mathilde ", "Johnson   ", "44291790", "Majsalle 40", 6683, "Føvling", "HGranger@gmail.com", 18);
            CostumerOrder sale17 = new CostumerOrder(costumer16.FirstName + " " + costumer16.LastName, 35, orderDate, 2500);

            orderDate = new DateTime(2023, 03, 18);
            deliveryDate = new DateTime(2023, 03, 27);
            Costumer costumer17 = new Costumer("Johs     ", "Møller    ", "+4524839450", "Kirkevej 16", 7100, "Vejle", "RWeasley@live.dk", 19);
            CostumerOrder sale18 = new CostumerOrder(costumer17.FirstName + " " + costumer17.LastName, 47, orderDate, 5020);

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
          
            return listOfSales.OrderByDescending(x => x.OrderDate).ToList();
        }
    }
}
