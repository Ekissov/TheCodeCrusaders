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
    }
}
