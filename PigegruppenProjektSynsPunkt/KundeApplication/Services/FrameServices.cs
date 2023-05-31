using KundeApplication.Models;
using KundeApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KundeApplication.Services
{
    public class FrameServices
    {
        public List<Frame> AllFrames { get; set; }
        public List<Frame> ReadAllFrames()
        {
            CustomerAppSQL customerAppSQL = new CustomerAppSQL();
            List<Frame> allFrames = customerAppSQL.ReadAllFrames();

            AllFrames = allFrames;
            return allFrames;
        }

        public List<Frame> GetFramesPrice(int priceMaxSelected) 
        {
            List<Frame> framesWithinprice = AllFrames.Where(x => x.ProductPrice <= priceMaxSelected).ToList();
            framesWithinprice = AllFrames;
            return framesWithinprice;
        }

        public List<Frame> GetFramesColour(string colour) 
        {
            List<Frame> framesSpecificColour = AllFrames.Where(x => x.FrameColour == colour).ToList();
            framesSpecificColour = AllFrames;
            return framesSpecificColour;
        }

        public List<Frame> GetFramesFacon(string facon)
        {
            List<Frame> framesSpecificFacon = AllFrames.Where(x => x.FrameFacon == facon).ToList();
            framesSpecificFacon = AllFrames;
            return framesSpecificFacon;
        }
        
        public List<Frame> GetFramesPattern(string pattern) 
        { 
            List<Frame> framesSpecificPattern = AllFrames.Where(x => x.FramePattern == pattern).ToList();
            framesSpecificPattern = AllFrames;
            return framesSpecificPattern;
        }

        public List<Frame> GetFramesNosePad(string nosepad) 
        {
            List<Frame> framesNosePad = AllFrames.Where(x => x.NosePads == nosepad).ToList();
            framesNosePad = AllFrames;
            return framesNosePad;
        }

        public List<Frame> GetFramesThickness(string thickness)
        {
            List<Frame> framesThickness = AllFrames.Where(x => x.FrameThickness == thickness).ToList();
            framesThickness = AllFrames;
            return framesThickness;
        }
    }
}
