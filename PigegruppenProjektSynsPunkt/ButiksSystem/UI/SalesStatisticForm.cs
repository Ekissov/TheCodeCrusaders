using ButiksSystem.Controllers;
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
    public partial class SalesStatisticForm : Form
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SalesStatisticForm()
        {
            InitializeComponent();
        }

        public void dtp_salesStatisticsStartDate_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtp_salesStatisticsStartDate.Value;
        }
        public void dtp_salesStatisticsEndDate_ValueChanged(object sender, EventArgs e)
        {
           EndDate = dtp_salesStatisticsEndDate.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {         
            UIController uIController = new UIController();
            dgv_showSalesStatisticsInDatagrid.DataSource = uIController.GetCostumerOrdersWithinGivenTime(StartDate, EndDate);
        }

        private void SalesStatistic_Load(object sender, EventArgs e)
        {
            dgv_showSalesStatisticsInDatagrid.DataSource = Database.DummyDataSales.CreateDummyDataSales();
        }


    }
}
