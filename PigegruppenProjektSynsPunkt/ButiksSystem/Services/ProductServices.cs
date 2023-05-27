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
    public class ProductServices
    {
        /// <summary>
        /// Method that links the CreateProduct method between service and UI
        /// </summary>
        /// <param name="product"></param>
        public void CreateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.CreateProduct(product);
        }

        /// <summary>
        /// Method that links the UpdateProduct method between service and UI
        /// </summary>
        /// <param name="product"></param>
        public void UpdateProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.UpdateProduct(product);
        }
        /// <summary>
        /// Method that links the DeleteProduct method between service and UI
        /// </summary>
        /// <param name="product"></param>
        public void DeleteProduct(Models.Product product)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.DeleteProduct(product);
        }
        /// <summary>
        /// Method that links the GetAllProducts method between service and UI and returns a list, up to the controller, based on the method in the repository
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {

            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.GetAllProducts();

            return productDatabaseSQL.GetAllProducts();
        }

        /// <summary>
        /// MEthod to print the contents in a datagridview to a txt file.
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

        public Product GetSelectedProduct(int productID)
        {
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            Product selectedProduct = productDatabaseSQL.GetSelectedProduct(productID);
            return selectedProduct;
        }
    }
}