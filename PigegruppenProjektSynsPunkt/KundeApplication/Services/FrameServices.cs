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
        public List<Frame> FramesFacon { get; set; }
        public List<Frame> FramesPattern { get; set; }
        public List<Frame> FramesNosePad { get; set; }
        public List<Frame> FramesThickness { get; set; }
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
            List<Frame> framesSpecificColour = FramesWithinPrice.Where(x => x.FrameColour == colour).ToList();
            FramesWithColour = framesSpecificColour;
            return framesSpecificColour;
        }

        public List<Frame> GetFramesFacon(string facon)
        {
            List<Frame> framesSpecificFacon = FramesWithColour.Where(x => x.FrameFacon == facon).ToList();
            FramesFacon = framesSpecificFacon;
            return framesSpecificFacon;
        }
        
        public List<Frame> GetFramesPattern(string pattern) 
        { 
            List<Frame> framesSpecificPattern = FramesFacon.Where(x => x.FramePattern == pattern).ToList();
            FramesPattern = framesSpecificPattern;
            return framesSpecificPattern;
        }

        public List<Frame> GetFramesNosePad(string nosepad) 
        {
            List<Frame> framesNosePad = FramesPattern.Where(x => x.NosePads == nosepad).ToList();
            FramesNosePad = framesNosePad;
            return framesNosePad;
        }

        public List<Frame> GetFramesThickness(string thickness)
        {
            List<Frame> framesThickness = FramesNosePad.Where(x => x.FrameThickness == thickness).ToList();
            FramesThickness = framesThickness;
            return framesThickness;
        }
    }
}
