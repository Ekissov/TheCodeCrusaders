using KundeApplication.Models;
using KundeApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KundeApplication
{
    public partial class HomePageForm : Form
    {
      
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            this.frameTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet.Frame);
        }

        private void NextBt_1_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();
            int maxPrice;

            switch (true)
            {
                case true when RB_MaxPrice1500.Checked:
                    maxPrice = 1500;
                    break;
                case true when RB_MaxPrice3000.Checked:
                    maxPrice = 3000;
                    break;
                case true when RB_MaxPrice5000.Checked:
                    maxPrice = 5000;
                    break;
                case true when RB_MaxPrice8000.Checked:
                    maxPrice = 8000;
                    break;
                default:
                    maxPrice = 20000;
                    break;
            }
            
          
            Dgv_Frames.DataSource = frameServices.GetFramesPrice(maxPrice);
        }

        private void NextBt_2_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            
            
            string choosenColour;

            switch (true)
            {
                case true when RB_ColourBlack.Checked:
                    choosenColour = "Sort";
                    break;
                case true when RB_ColourTransparent.Checked:
                    choosenColour = "Gennemsigtig";
                    break;
                case true when RB_ColourRed.Checked:
                    choosenColour = "Rød";
                    break;
                case true when RB_ColourBrown.Checked:
                    choosenColour = "Brun";
                    break;
                default:
                    choosenColour = "";
                    break;
            }

            Dgv_Frames.DataSource = frameServices.GetFramesColour(choosenColour);
        }

        private void NextBt_3_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();
            string facon;

            switch (true)
            {
                case true when RB_FaconRound.Checked:
                    facon = "Rund";
                    break;
                case true when RB_FaconSquare.Checked:
                    facon = "Firkantet";
                    break;
                default:
                    facon = "";
                    break;
            }

            Dgv_Frames.DataSource = frameServices.GetFramesFacon(facon);
        }

        private void NextBt_4_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();
            string pattern;

            switch (true)
            {
                case true when RB_PatternYES.Checked:
                    pattern = "Mønster";
                    break;
                case true when RB_PatternNO.Checked:
                    pattern = "Intet Mønster";
                    break;
                default:
                    pattern = "";
                    break;
            }

            Dgv_Frames.DataSource = frameServices.GetFramesPattern(pattern);
        }

        private void NextBt_5_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();
            string nosePad;

            switch (true)
            {
                case true when RB_NosePadsYES.Checked:
                    nosePad = "Med Næsepuder";
                    break;
                case true when RB_NosePadsNO.Checked: 
                    nosePad = "Uden Næsepuder";
                    break;
                default:
                    nosePad = "";
                    break;

            }

            Dgv_Frames.DataSource = frameServices.GetFramesNosePad(nosePad);
        }

        private void NextBt_6_Click(object sender, EventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();
            string thickness;
            switch (true)
            {
                case true when RB_ThicknessTHICK.Checked:
                    thickness = "Tyk";
                    break;
                case true when RB_ThicknessTHIN.Checked:
                    thickness = "Tyndt";
                    break;
                default:
                    thickness = "";
                    break;
            }

            Dgv_Frames.DataSource = frameServices.GetFramesThickness(thickness);
        }
    }
}
