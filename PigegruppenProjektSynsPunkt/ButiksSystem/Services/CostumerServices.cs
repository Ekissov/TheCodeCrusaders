using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Services
{
    public class CostumerServices
    {
        public static void CreateCostumer(Models.Costumer costumer)
        {
            CostumerDatabaseSQL costumerDatabaseSQL = new CostumerDatabaseSQL();
            CostumerDatabaseSQL.CreateCustomer(costumer);

        }

        public static void UpdateCostumer(Models.Costumer costumer) 
        {
            CostumerDatabaseSQL costumerDatabaseSQL = new CostumerDatabaseSQL();
            CostumerDatabaseSQL.UpdateCustomer(costumer.CostumerID, costumer.FirstName, costumer.LastName, costumer.PhoneNumber, costumer.Email, costumer.PostalCode, costumer.City, costumer.Adress);
        }

        public static void DeleteCostumer() 
        {
            //Insert businesslogic
        }

    }
}
