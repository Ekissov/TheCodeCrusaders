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
        /// <summary>
        /// Metode til at oprette et produkt - den modtager det nye produkt fra models og sender det videre til repository
        /// </summary>
        /// <param name="product"></param>
        public static void CreateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            ProductDatabaseSQL.CreateProduct(product);
        }

        /// <summary>
        /// Metode til at opdatere et produkt - dem modtager opdateringen om et produkt fra models og sender det videre til repository
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.UpdateProduct(product);
        }
        /// <summary>
        /// Metode til at slette et produkt. den modtager opdatereingen om et produkt fra models og sender det videre til repository
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.DeleteProduct(product);
        }
        /// <summary>
        /// Metode der danner en liste af alle produkter - den tager info fra repository. 
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {

            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.GetAllProducts();

            return productDatabaseSQL.GetAllProducts();
        }

        /// <summary>
        /// Metode til at printe indholdet i et datagridview til en txt fil.
        /// </summary>
        /// <param name="dataGridView"></param>
        public void PrintDataGridViewToFile(DataGridView dataGridView)
        {

            string filePath = ("printallproducts.txt"); //Txt filen kommer til at ligge direkte i denne sti, så det er ens for alle der har hele mappen: ButiksSystem\bin\Debug\printallproducts.txt" 
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
    }
}