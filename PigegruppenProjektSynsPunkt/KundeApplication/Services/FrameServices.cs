using KundeApplication.Models;
using KundeApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeApplication.Services
{
    public class FrameServices
    {
        public List<Frame> ReadAllFrames()
        {
            CustomerAppSQL customerAppSQL = new CustomerAppSQL();
            List<Frame> allFrames = customerAppSQL.ReadAllFrames();
            return allFrames;
        }
    }
}
