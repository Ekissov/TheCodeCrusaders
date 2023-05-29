using ButiksSystem.Database;
using ButiksSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using System.Diagnostics;

namespace ButiksSystem.Services
{
    public class SalestatisticServices
    {
        /// <summary>
        /// Creates a list of DummyData within specific timeinterval, that contains costumerOrders.
        /// Sorts the list by orderdate.
        /// </summary>
        /// <param name="startdate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Models.CostumerOrder> GetCostumerOrdersWithinGivenTime(DateTime startdate, DateTime endDate)
        {
            var listOfCostumerOrders = DummyDataSales.CreateDummyDataSales();

            if (startdate == default && endDate == default)
            {
                return listOfCostumerOrders.Where(x => x.OrderDate == DateTime.Today).ToList();
            }
            else
            {
                var ordersWithinTimePeriod = listOfCostumerOrders.Where(x => x.OrderDate >= startdate && x.OrderDate <= endDate).ToList();
                return ordersWithinTimePeriod.OrderBy(x => x.OrderDate).ToList();


            }

        }

        /// <summary>
        /// Takes all costumerorders within a given time, start- endDate, into a list.
        /// If not start or endDate is choosen it will print all costumer orders in the datagridview
        /// </summary>
        /// <param name="listOfCostumerOrders"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="dataGridView"></param>
        public void CreateSalesFile(List<CostumerOrder> listOfCostumerOrders, DateTime startDate, DateTime endDate, DataGridView dataGridView)
        {
            try
            {
                List<CostumerOrder> costumerOrders = listOfCostumerOrders;

                //string FilePath = @"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\Salgsstatistik.txt";
                string FilePath = ("Salgsstatistik.txt");

                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    writer.WriteLine("SALGSSTATISTIK 2023" + "              Fra dato: " + startDate + "      Til Dato: " + endDate);
                    string salesfileHeadigns = "\nKundenummer   Kundenavn                       Dato                           Køb\n"; ;
                    writer.WriteLine(salesfileHeadigns);

                    if (listOfCostumerOrders == null)
                    {
                        SalestatisticServices.CreateSalesFileDataGridview(dataGridView, startDate, endDate);

                        return;
                    }
                    foreach (var item in listOfCostumerOrders)
                    {
                        writer.WriteLine(string.Format("{0}            {1}            {2}            {3}",
                            item.CostumerID, item.CostumerName, item.OrderDate.Date, item.TotalPrice.ToString()));
                    }

                    decimal sumOfPrices = listOfCostumerOrders.Sum(x => x.TotalPrice);
                    writer.WriteLine("\n                                                           I alt kr.         " + sumOfPrices);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Der er sket en fejl, data kunne ikke overføres til fil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prints all costumerOrders visible in datagridview in a file.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public static void CreateSalesFileDataGridview(DataGridView dataGridView, DateTime startDate, DateTime endDate)
        {
            {

                System.IO.StreamWriter file = new StreamWriter(@"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\AlleSalg.txt");

                try
                {
                    //The document starts up here, sets up main headings and information.
                    file.WriteLine("SALGSSTATISTIK 2023" + "              Fra dato: " + startDate.Date + "      Til Dato: " + endDate.Date);
                    file.WriteLine("Kundenummer   Kundenavn                       Dato                           Køb");

                    string sLine = "";

                    if (dataGridView.RowCount == 0 || dataGridView.ColumnCount == 0)
                    {
                        MessageBox.Show("Der er ikke nogle data i Datagridview, Intet overføres til fil", "Fejlmeddelses", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        for (int r = 0; r <= dataGridView.Rows.Count - 1; r++)
                        {
                            for (int c = 0; c <= dataGridView.Columns.Count - 1; c++)
                            {
                                sLine = sLine + dataGridView.Rows[r].Cells[c].Value;
                                if (c != dataGridView.Columns.Count - 1)
                                {
                                    sLine = sLine + "            ";
                                }
                            }
                            file.WriteLine(sLine);
                            sLine = "";
                        }
                        file.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Der er sket en fejl, data kunne ikke overføres til fil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }
    }
}
