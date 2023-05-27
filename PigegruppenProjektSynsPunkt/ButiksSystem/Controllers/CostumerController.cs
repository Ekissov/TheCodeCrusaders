using ButiksSystem.Models;
using ButiksSystem.Services;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Controllers
{
    public class CostumerController
    {
        public void UpdateCostumer(Costumer costumer)
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
        public void DeleteCostumer(Costumer costumer)
        {
            Services.CostumerServices costumerServices = new Services.CostumerServices();
            costumerServices.DeleteCostumer(costumer);
        }

        public List<Costumer> ReadCustomer(string customerInput)
        {
            CostumerServices costumerServices = new CostumerServices();
            List<Costumer> allCustomers = costumerServices.ReadCustomer();

            var allcustomersToDgv = allCustomers.Where(
                x => x.FirstName == customerInput || 
                x.LastName == customerInput).ToList();
           
            return allcustomersToDgv;
        }

        public Costumer GetSelectedCustomer(int customerID)
        {
            CostumerServices costumerServices = new CostumerServices();
            Costumer selectedCustomer = costumerServices.GetSelectedCustomer(customerID);
          
            return selectedCustomer;
        }

    }
}
