using ButiksSystem.Database;
using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButiksSystem.Services
{
    public class SalestatisticServices
    {

        public List<Models.CostumerOrder> GetCostumerOrdersWithinGivenTime(DateTime startdate, DateTime endDate)
        {
            var listOfCostumerOrders = DummyDataSales.CreateDummyDataSales();

            var ordersWithinTimePeriod =listOfCostumerOrders.Where(x => x. OrderDate >= startdate && x.OrderDate <= endDate).ToList();

            return ordersWithinTimePeriod;
        }

        public void CreateSalesFile(List<CostumerOrder> listOfCostumerOrders, DateTime startDate, DateTime endDate)
        {
            List<CostumerOrder> costumerOrders = listOfCostumerOrders;

            string FilePath = @"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\Salgsstatistik.txt";

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.WriteLine("SALGSSTATISTIK 2023" + "              Fra dato: " + startDate + "      Til Dato: " + endDate);
                string salesfileHeadigns = "Kundenummer      Kundenavn        Dato                          Køb";
                writer.WriteLine(salesfileHeadigns);


                foreach (var item in listOfCostumerOrders)
                {
                    writer.WriteLine(string.Format("{0}     {1}     {2}          {3}", item.CostumerID, item.CostumerName, item.OrderDate, item.TotalPrice.ToString())); 
                }

                decimal sumOfPrices = listOfCostumerOrders.Sum(x => x.TotalPrice);
                writer.WriteLine("                                              I alt kr.         " + sumOfPrices);
            }

        }


        public void CreateSalesFileDataGridview(DataGridView dataGridView)
        {
            {
                //This line of code creates a text file for the data export.
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\Salgsstatistik.txt");
                try
                {
                    string sLine = "";

                    //This for loop loops through each row in the table
                    for (int r = 0; r <= dataGridView.Rows.Count - 1; r++)
                    {
                        //This for loop loops through each column, and the row number
                        //is passed from the for loop above.
                        for (int c = 0; c <= dataGridView.Columns.Count - 1; c++)
                        {
                            sLine = sLine + dataGridView.Rows[r].Cells[c].Value;
                            if (c != dataGridView.Columns.Count - 1)
                            {
                                //A comma is added as a text delimiter in order
                                //to separate each field in the text file.
                                //You can choose another character as a delimiter.
                                sLine = sLine + "         ";
                            }
                        }
                        //The exported text is written to the text file, one line at a time.
                        file.WriteLine(sLine);
                        sLine = "";
                    }

                    file.Close();
                    System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }
    }
}
