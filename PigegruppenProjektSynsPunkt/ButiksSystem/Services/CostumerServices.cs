﻿using ButiksSystem.Models;
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
        /// <summary>
        /// Method to create a new costumer and save the information in the database.
        /// </summary>
        /// <param name="costumer"></param>
        public void CreateCostumer(Costumer costumer) 
        { 
            //Costumer costumer1 = new Costumer(costumer.FirstName, costumer.LastName, costumer.PhoneNumber, costumer.Email, costumer.PostalCode, costumer.City, costumer.Address);
            CostumerDatabaseSQL costumerDatabaseSQL = new CostumerDatabaseSQL();
            costumerDatabaseSQL.CreateCustomer(costumer);
        }
        /// <summary>
        /// Method to update or change a costumer and then save the new information in the database
        /// </summary>
        /// <param name="costumer"></param>
        public void UpdateCostumer(Models.Costumer costumer)
        {
            CostumerDatabaseSQL costumerDatabaseSQL = new CostumerDatabaseSQL();
            costumerDatabaseSQL.UpdateCustomer(costumer);
        }

        /// <summary>
        /// Method to delete a costumer. 
        /// </summary>
        /// <param name="costumer"></param>
        public void DeleteCostumer(Models.Costumer costumer)
        {
            //Insert businesslogic
            CostumerDatabaseSQL costumerDatabaseSQL = new CostumerDatabaseSQL();
            costumerDatabaseSQL.DeleteCustomer(costumer);
        }

    }
}
