using ButiksSystem.Controllers;
using ButiksSystem.Models;
using ButiksSystem.Services;
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
        //Properties that is needed to store information
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<CostumerOrder> ListOfCostumerOrders { get; set; }

        
        public SalesStatisticForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Shows all DummyData in datagridview, when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesStatistic_Load(object sender, EventArgs e)
        {
            dgv_showSalesStatisticsInDatagrid.DataSource = Database.DummyDataSales.CreateDummyDataSales();
           
        }

        /// <summary>
        /// Sends the given enddate to be stored in the property StartDate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dtp_salesStatisticsStartDate_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtp_salesStatisticsStartDate.Value.Date;
        }

        /// <summary>
        /// Sends the given enddate to be stored in the property EndDate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dtp_salesStatisticsEndDate_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtp_salesStatisticsEndDate.Value.Date;
        }

        /// <summary>
        /// Displays new list of Orders in datagridview that are within the two given dates. 
        /// Calls the controller and the method GetCostumerOrdersWithinGivenTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {         
            UIController uIController = new UIController();
            ListOfCostumerOrders = uIController.GetCostumerOrdersWithinGivenTime(StartDate, EndDate);
            dgv_showSalesStatisticsInDatagrid.DataSource = ListOfCostumerOrders;
        }

        /// <summary>
        /// Prints the datagridview list of sales out in a textfile. 
        /// Calls method from UIControlled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salesStatisticsPrintToTxtFile_Click(object sender, EventArgs e)
        {
            UIController uiController = new UIController();

           // uiController.CreateSalesFileDataGridview(dgv_showSalesStatisticsInDatagrid, StartDate, EndDate);
            uiController.CreateSalesFile(ListOfCostumerOrders, StartDate, EndDate);
           
            
            this.Close();
        }

        private void dgv_showSalesStatisticsInDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
