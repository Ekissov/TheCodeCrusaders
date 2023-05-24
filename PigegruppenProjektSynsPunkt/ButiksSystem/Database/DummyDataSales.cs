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
            CostumerOrder sale1 = new CostumerOrder(01, costumer.FirstName + " " + costumer.LastName, 1, 12, "1", deliveryDate, orderDate, 4534);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Costumer costumer1 = new Costumer("Albert", "Hansen", "22448475", "Vestergade 359", 8000, "Århus", "AHansen@gmail.com");
            CostumerOrder sale2 = new CostumerOrder(04, costumer1.FirstName + " " + costumer1.LastName, 2, 15, "12", deliveryDate, orderDate, 4534);

            orderDate = new DateTime(2023, 02, 10);
            deliveryDate = new DateTime(2023, 02, 20);
            Costumer costumer2 = new Costumer("Emma", "Roberts", "+4559483264", "Søndrealle 3", 8700, "Horsens", "EmRob@mail.dk");
            CostumerOrder sale3 = new CostumerOrder(02, costumer2.FirstName + " " + costumer2.LastName, 3, 8, "17", deliveryDate, orderDate, 4000);

            orderDate = new DateTime(2023, 01, 10);
            deliveryDate = new DateTime(2023, 01, 19);
            Costumer costumer3 = new Costumer("Maja", "Sørensen", "49389503", "Parkvej 34", 8660, "Skanderborg", "MajaS@hotmail.com");
            CostumerOrder sale4 = new CostumerOrder(03, costumer3.FirstName + " " + costumer3.LastName, 4, 11, "4", deliveryDate, orderDate, 8000);

            orderDate = new DateTime(2023, 01, 03);
            deliveryDate = new DateTime(2023, 01, 13);
            Costumer costumer4 = new Costumer("Jacob", "Lassen", "39367429", "Skolegade 1", 7100, "Vejle", "LassenJ@live.dk");
            CostumerOrder sale5 = new CostumerOrder(07, costumer4.FirstName + " " + costumer4.LastName, 5, 5, "9", deliveryDate, orderDate, 2500);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Costumer costumer5 = new Costumer("René", "Jørgensen", "44862061", "Pallesvej 1", 6064, "Jordrup", "ReneGensen@hotmail.com");
            CostumerOrder sale6 = new CostumerOrder(06, costumer5.FirstName + " " + costumer5.LastName, 6, 15, "6", deliveryDate, orderDate, 4500);

            orderDate = new DateTime(2023, 03, 15);
            deliveryDate = new DateTime(2023, 03, 21);
            Costumer costumer6 = new Costumer("Peter", "Jensen", "43619480", "Villavej 35", 6094, "Hejls", "pjensen@gmail.com");
            CostumerOrder sale7 = new CostumerOrder(10, costumer6.FirstName + " " + costumer6.LastName, 7, 11, "3", deliveryDate, orderDate, 8500);

            orderDate = new DateTime(2023, 02, 13);
            deliveryDate = new DateTime(2023, 02, 21);
            Costumer costumer7 = new Costumer("Hanne", "Kjær", "43659246", "Lysevej 35", 6092, "Sønder Stenderup", "HanneKJ@Live.dk");
            CostumerOrder sale8 = new CostumerOrder(12, costumer7.FirstName + " " + costumer7.LastName, 8, 5, "5", deliveryDate, orderDate, 5400);

            orderDate = new DateTime(2023, 04, 10);
            deliveryDate = new DateTime(2023, 04, 19);
            Costumer costumer8 = new Costumer("Camilla", "Ottesen", "+4526814082", "Rosevej 23", 6051, "Almind", "Cottesen@mail.dk");
            CostumerOrder sale9 = new CostumerOrder(13, costumer8.FirstName + " " + costumer8.LastName, 9, 8, "8", deliveryDate, orderDate, 3990);

            orderDate = new DateTime(2023, 03, 02);
            deliveryDate = new DateTime(2023, 03, 10);
            Costumer costumer9 = new Costumer("Thomas", "Nielsen", "+4572904831", "Dagnæsalle 43", 6623, "Vorbasse", "tni89@hotmail.com");
            CostumerOrder sale10 = new CostumerOrder(22, costumer9.FirstName + " " + costumer9.LastName, 10, 15, "13", deliveryDate, orderDate, 6050);

            orderDate = new DateTime(2023, 04, 25);
            deliveryDate = new DateTime(2023, 05, 03);
            Costumer costumer10 = new Costumer("Maria", "Petersen", "43882506", "Baggade 40", 6560, "Sommersted", "Maria224@hotmail.com");
            CostumerOrder sale11 = new CostumerOrder(21, costumer10.FirstName + " " + costumer10.LastName, 11, 12, "9", deliveryDate, orderDate, 6370);

            orderDate = new DateTime(2023, 03, 01);
            deliveryDate = new DateTime(2023, 03, 11);
            Costumer costumer11 = new Costumer("Daniel", "Dahl", "+4523954071", "Dyrealle", 6621, "Gesten", "Danicool@mail.dk");
            CostumerOrder sale12 = new CostumerOrder(41, costumer11.FirstName + " " + costumer11.LastName, 12, 8, "7", deliveryDate, orderDate, 5000);

            orderDate = new DateTime(2023, 01, 16);
            deliveryDate = new DateTime(2023, 01, 24);
            Costumer costumer12 = new Costumer("Leila", "Dyrmose", "+4524258301", "Grejsdahlsvejl 39", 7100, "Vejle", "DyrmosenL@gmail.com");
            CostumerOrder sale13 = new CostumerOrder(15, costumer12.FirstName + " " + costumer12.LastName, 13, 8, "6", deliveryDate, orderDate, 6400);

            orderDate = new DateTime(2023, 01, 31);
            deliveryDate = new DateTime(2023, 02, 08);
            Costumer costumer13 = new Costumer("Mikkel", "Laursen", "+4531923874", "P.C. Hansens Gade 85", 6580, "Vamdrup", "LaursenMik@gmail.com");
            CostumerOrder sale14 = new CostumerOrder(24, costumer13.FirstName + " " + costumer13.LastName, 14, 15, "9", deliveryDate, orderDate, 10500);

            orderDate = new DateTime(2023, 02, 20);
            deliveryDate = new DateTime(2023, 02, 28);
            Costumer costumer14 = new Costumer("Julie", "Kaspersen", "+4584028475", "Spurvevej 2", 6640, "Lunderskov", "LegolasFrodo@gmail.com");
            CostumerOrder sale15 = new CostumerOrder(20, costumer14.FirstName + " " + costumer14.LastName, 15, 8, "11", deliveryDate, orderDate, 9450);

            orderDate = new DateTime(2023, 03, 24);
            deliveryDate = new DateTime(2023, 04, 02);
            Costumer costumer15 = new Costumer("Henrik", "Skov", "+4593827450", "Løvvej 32", 6670, "Holsted", "DMalfoy@live.dk");
            CostumerOrder sale16 = new CostumerOrder(09, costumer15.FirstName + " " + costumer15.LastName, 16, 11, "10", deliveryDate, orderDate, 7540);

            orderDate = new DateTime(2023, 02, 25);
            deliveryDate = new DateTime(2023, 03, 07);
            Costumer costumer16 = new Costumer("Mathilde", "Johnson", "44291790", "Majsalle 40", 6683, "Føvling", "HGranger@gmail.com");
            CostumerOrder sale17 = new CostumerOrder(05, costumer16.FirstName + " " + costumer16.LastName, 17, 12, "7", deliveryDate, orderDate, 2500);

            orderDate = new DateTime(2023, 03, 18);
            deliveryDate = new DateTime(2023, 03, 27);
            Costumer costumer17 = new Costumer("Johs", "Møller", "+4524839450", "Kirkevej 16", 7100, "Vejle", "RWeasley@live.dk");
            CostumerOrder sale18 = new CostumerOrder(08, costumer17.FirstName + " " + costumer17.LastName, 18, 5, "9", deliveryDate, orderDate, 5020);

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
