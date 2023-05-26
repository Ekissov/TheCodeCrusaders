using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ButiksSystem.Services
{
    internal class ProductServices
    {
        public static void CreateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            ProductDatabaseSQL.CreateProduct(product);
        }


        public void UpdateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.UpdateProduct(product);
        }

        public void DeleteProduct(Models.Product product)
        {
            //Insert businesslogic
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.DeleteProduct(product);
        }

        public List<Product> GetAllProducts()
        {

            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.GetAllProducts();

            return productDatabaseSQL.GetAllProducts();
        }

        public void PrintDataGridViewToFile(DataGridView dataGridView)
        {

            string filePath = ("printallproducts.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write column headers to the file
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    writer.Write(column.HeaderText + "\t");
                }
                writer.WriteLine();

                // Write rows to the file
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        writer.Write(cell.Value.ToString() + "\t");
                    }
                    writer.WriteLine();
                }
            }

            MessageBox.Show("DataGridView printed to file successfully!");
        }

        //File.WriteAllLines(@"C:\Pigegruppen - Synspunkt\NyPigegruppen - synspunkts\TheCodeCrusaders\PigegruppenProjektSynsPunkt\printallproducts.txt", writeLines);

        //File.WriteAllLines(@"C:\Pigegruppen - Synspunkt\NyPigegruppen - synspunkts\TheCodeCrusaders\PigegruppenProjektSynsPunkt\printallproducts.txt", writeLines);
        //File.WriteAllLines(@"C:\Datamatiker\1 semester projekt Codecrusaders\TheCodeCrusaders\PigegruppenProjektSynsPunkt\printallproducts.txt", writeLines);
       


    }
}