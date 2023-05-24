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

        public void CreateCostumer(Models.Costumer costumer/*string firstName, string lastName, string phoneNumber, string address, int postalCode, string city, string email*/)
        {
            //Models.Costumer costumer = new Models.Costumer(firstName, lastName, phoneNumber, address, postalCode, city, email);
            Services.CostumerServices costumerServices = new Services.CostumerServices();
            costumerServices.CreateCostumer(costumer);
        }

    }
}
