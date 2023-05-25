using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Services
{
    public class CostumerServices
    {
        /// <summary>
        /// Create a new costumer in the database with the costumer information input from Costumer Parameter.
        /// </summary>
        /// <param name="costumer"></param>
        public void CreateCostumer(Costumer costumer)
        {
                //Costumer costumer1 = new Costumer(costumer.FirstName, costumer.LastName, costumer.PhoneNumber, costumer.Email, costumer.PostalCode, costumer.City, costumer.Address);
                CustomerDatabaseSQL costumerDatabaseSQL = new CustomerDatabaseSQL();
                costumerDatabaseSQL.CreateCustomer(costumer);

        }
        /// <summary>
        /// Method to update or change a costumer and then save the new information in the database
        /// </summary>
        /// <param name="costumer"></param>
        public void UpdateCostumer(Models.Costumer costumer)
        {
            CustomerDatabaseSQL costumerDatabaseSQL = new CustomerDatabaseSQL();
            costumerDatabaseSQL.UpdateCustomer(costumer);
        }

        /// <summary>
        /// Method to delete a costumer. 
        /// </summary>
        /// <param name="costumer"></param>
        public void DeleteCostumer(Models.Costumer costumer)
        {
            //Insert businesslogic
            CustomerDatabaseSQL costumerDatabaseSQL = new CustomerDatabaseSQL();
            costumerDatabaseSQL.DeleteCustomer(costumer);
        }

    }
}
