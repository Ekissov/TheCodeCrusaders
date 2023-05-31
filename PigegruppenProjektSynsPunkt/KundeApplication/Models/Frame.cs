using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeApplication.Models
{
    public class Frame
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string FrameColour { get; set; }
        public string FrameFacon { get; set; }
        public string FrameThickness { get; set; }
        public string NosePads { get; set; }
        public string FramePattern { get; set; }
        public int ProductPrice { get; set; }
        

        public Frame(int productID, string productName, string frameColour, string frameFacon, string frameThickness, string nosePads, string framePattern, int productPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.FrameColour = frameColour;
            this.FrameFacon = frameFacon;
            this.FrameThickness = frameThickness;
            this.NosePads = nosePads;
            this.FramePattern = framePattern;
            this.ProductPrice = productPrice;
        }
    }
}
