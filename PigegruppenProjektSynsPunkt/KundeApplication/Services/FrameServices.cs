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
        public List<Frame> FramesWithinPrice { get; set; }
        public List<Frame> FramesWithColour { get; set; }
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
            FramesWithinPrice = framesWithinprice;
            return framesWithinprice;
        }

        public List<Frame> GetFramesColour(string colour) 
        {
            FramesWithColour = FramesWithinPrice.Where(x => x.FrameColour == colour).ToList();
            return FramesWithinPrice.Where(x => x.FrameColour == colour).ToList();
        }

        public List<Frame> GetFramesFacon(string facon)
        {
            List<Frame> framesSpecificFacon = AllFrames.Where(x => x.FrameFacon == facon).ToList();
            AllFrames = framesSpecificFacon;
            return framesSpecificFacon;
        }
        
        public List<Frame> GetFramesPattern(string pattern) 
        { 
            List<Frame> framesSpecificPattern = AllFrames.Where(x => x.FramePattern == pattern).ToList();
            AllFrames = framesSpecificPattern;
            return framesSpecificPattern;
        }

        public List<Frame> GetFramesNosePad(string nosepad) 
        {
            List<Frame> framesNosePad = AllFrames.Where(x => x.NosePads == nosepad).ToList();
            AllFrames = framesNosePad;
            return framesNosePad;
        }

        public List<Frame> GetFramesThickness(string thickness)
        {
            List<Frame> framesThickness = AllFrames.Where(x => x.FrameThickness == thickness).ToList();
            AllFrames = framesThickness;
            return framesThickness;
        }
    }
}
