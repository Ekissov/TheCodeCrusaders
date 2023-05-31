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
            // TODO: This line of code loads data into the 'saanneeha_dk_db_databaseDataSet.Frame' table. You can move, or remove it, as needed.
            this.frameTableAdapter.Fill(this.saanneeha_dk_db_databaseDataSet.Frame);

        }

        private void Dgv_Frames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrameServices frameServices = new FrameServices();
            List<Frame> allframes = frameServices.ReadAllFrames();



        }
    }
}
