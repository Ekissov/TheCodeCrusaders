using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.UI
{
    public partial class ICreateBookingForm : Form
    {
        public ICreateBookingForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateCustomerForm createCostumerForm = new CreateCustomerForm();
            createCostumerForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ISeeAllBookingsForm seeAllBookingsForm = new ISeeAllBookingsForm();
            seeAllBookingsForm.ShowDialog();
        }
    }
}
