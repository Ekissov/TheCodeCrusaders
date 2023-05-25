﻿using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Controllers
{
    public class CostumerController
    {
        public void UpdateCostumer(Models.Costumer costumer)
        {
            Services.CostumerServices costumerServices = new Services.CostumerServices();
            costumerServices.UpdateCostumer(costumer);
        }

        public List<Costumer> ReadAllCostumers()
        {
            var result = new List<Costumer>();
            return result;
        }

        /// <summary>
        /// Recieves a costumer object from CreateCostumerUI
        /// Instantiate new Services.CostumerService and calls CreateCostumer
        /// </summary>
        /// <param name="costumer"></param>
        public void CreateCostumer(Costumer costumer)
        {         
            Services.CostumerServices costumerServices = new Services.CostumerServices();
            costumerServices.CreateCostumer(costumer);
        }

    }
}