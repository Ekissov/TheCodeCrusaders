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

        public static List<CustomerOrder> CreateDummyDataSales()
        {
            List<CustomerOrder> listOfSales = new List<CustomerOrder>();

            var orderDate = DateTime.Now.Date;
            var deliveryDate = new DateTime(2023, 05, 24);
            Customer customer = new Customer("Eigil    ", "Olsen     ", "+45 12 34 56 78", "Boulevarden 25", 7100, "Vejle", "Hej22@gmail.com", 2);
            CustomerOrder sale1 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 10, orderDate, 4534);
            
            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Customer customer1 = new Customer("Albert   ", "Hansen    ", "22448475", "Vestergade 359", 8000, "Århus", "AHansen@gmail.com",3);
            CustomerOrder sale2 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 11, orderDate, 4534);

            orderDate = new DateTime(2023, 02, 10);
            deliveryDate = new DateTime(2023, 02, 20);
            Customer customer2 = new Customer("Emma     ", "Roberts   ", "+4559483264", "Søndrealle 3", 8700, "Horsens", "EmRob@mail.dk",4);
            CustomerOrder sale3 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 12, orderDate, 4000);

            orderDate = new DateTime(2023, 01, 10);
            deliveryDate = new DateTime(2023, 01, 19);
            Customer customer3 = new Customer("Maja     ", "Sørensen  ", "49389503", "Parkvej 34", 8660, "Skanderborg", "MajaS@hotmail.com", 5);
            CustomerOrder sale4 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 13, orderDate, 8000);

            orderDate = new DateTime(2023, 01, 03);
            deliveryDate = new DateTime(2023, 01, 13);
            Customer customer4 = new Customer("Jacob    ", "Lassen    ", "39367429", "Skolegade 1", 7100, "Vejle", "LassenJ@live.dk", 6);
            CustomerOrder sale5 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 14, orderDate, 2500);

            orderDate = new DateTime(2023, 01, 25);
            deliveryDate = new DateTime(2023, 02, 03);
            Customer customer5 = new Customer("René     ", "Jørgensen ", "44862061", "Pallesvej 1", 6064, "Jordrup", "ReneGensen@hotmail.com",7);
            CustomerOrder sale6 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 15, orderDate, 4500);

            orderDate = new DateTime(2023, 03, 15);
            deliveryDate = new DateTime(2023, 03, 21);
            Customer customer6 = new Customer("Peter    ", "Jensen    ", "43619480", "Villavej 35", 6094, "Hejls", "pjensen@gmail.com",8);
            CustomerOrder sale7 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 16, orderDate, 8500);

            orderDate = new DateTime(2023, 02, 13);
            deliveryDate = new DateTime(2023, 02, 21);
            Customer customer7 = new Customer("Hanne    ", "Kjær      ", "43659246", "Lysevej 35", 6092, "Sønder Stenderup", "HanneKJ@Live.dk", 9);
            CustomerOrder sale8 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 17, orderDate, 5400);

            orderDate = new DateTime(2023, 04, 10);
            deliveryDate = new DateTime(2023, 04, 19);
            Customer customer8 = new Customer("Camilla  ", "Ottesen   ", "+4526814082", "Rosevej 23", 6051, "Almind", "Cottesen@mail.dk", 10);
            CustomerOrder sale9 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 18, orderDate, 3990);

            orderDate = new DateTime(2023, 03, 02);
            deliveryDate = new DateTime(2023, 03, 10);
            Customer customer9 = new Customer("Thomas   ", "Nielsen   ", "+4572904831", "Dagnæsalle 43", 6623, "Vorbasse", "tni89@hotmail.com", 11);
            CustomerOrder sale10 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 22, orderDate, 6050);

            orderDate = new DateTime(2023, 04, 25);
            deliveryDate = new DateTime(2023, 05, 03);
            Customer customer10 = new Customer("Maria    ", "Petersen  ", "43882506", "Baggade 40", 6560, "Sommersted", "Maria224@hotmail.com", 12);
            CustomerOrder sale11 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 21, orderDate, 6370);

            orderDate = new DateTime(2023, 03, 01);
            deliveryDate = new DateTime(2023, 03, 11);
            Customer customer11 = new Customer("Daniel   ", "Dahl      ", "+4523954071", "Dyrealle", 6621, "Gesten", "Danicool@mail.dk", 13);
            CustomerOrder sale12 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 23, orderDate, 5000);

            orderDate = new DateTime(2023, 01, 16);
            deliveryDate = new DateTime(2023, 01, 24);
            Customer customer12 = new Customer("Leila    ", "Dyrmose   ", "+4524258301", "Grejsdahlsvejl 39", 7100, "Vejle", "DyrmosenL@gmail.com", 14);
            CustomerOrder sale13 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 30, orderDate, 6400);

            orderDate = new DateTime(2023, 01, 31);
            deliveryDate = new DateTime(2023, 02, 08);
            Customer customer13 = new Customer("Mikkel   ", "Laursen   ", "+4531923874", "P.C. Hansens Gade 85", 6580, "Vamdrup", "LaursenMik@gmail.com", 15);
            CustomerOrder sale14 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 24, orderDate, 8500);

            orderDate = new DateTime(2023, 02, 20);
            deliveryDate = new DateTime(2023, 02, 28);
            Customer customer14 = new Customer("Julie    ", "Kaspersen ", "+4584028475", "Spurvevej 2", 6640, "Lunderskov", "LegolasFrodo@gmail.com", 16);
            CustomerOrder sale15 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 41, orderDate, 9450);

            orderDate = new DateTime(2023, 03, 24);
            deliveryDate = new DateTime(2023, 04, 02);
            Customer customer15 = new Customer("Henrik   ", "Skov      ", "+4593827450", "Løvvej 32", 6670, "Holsted", "DMalfoy@live.dk", 17);
            CustomerOrder sale16 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 69, orderDate, 7540);

            orderDate = new DateTime(2023, 02, 25);
            deliveryDate = new DateTime(2023, 03, 07);
            Customer customer16 = new Customer("Mathilde ", "Johnson   ", "44291790", "Majsalle 40", 6683, "Føvling", "HGranger@gmail.com", 18);
            CustomerOrder sale17 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 35, orderDate, 2500);

            orderDate = new DateTime(2023, 03, 18);
            deliveryDate = new DateTime(2023, 03, 27);
            Customer customer17 = new Customer("Johs     ", "Møller    ", "+4524839450", "Kirkevej 16", 7100, "Vejle", "RWeasley@live.dk", 19);
            CustomerOrder sale18 = new CustomerOrder(customer.FirstName + " " + customer.LastName, 47, orderDate, 5020);

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
