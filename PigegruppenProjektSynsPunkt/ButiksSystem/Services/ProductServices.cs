using ButiksSystem.Models;
using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButiksSystem.Services
{
    internal class ProductServices
    {
        public static void CreateProduct(Models.Product product)
        {
            //Insert businesslogic

            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            ProductDatabaseSQL.CreateProduct(product);
        }

        
        public void UpdateProduct(Models.Product product)
        {
            //Insert businesslogic
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.UpdateProduct(product);
        }

        public void DeleteProduct(Models.Product product)
        {
            //Insert businesslogic
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            productDatabaseSQL.DeleteProduct(product);
        }

        public static void PrintAllProducts() 
        {
            List<Product> products = ProductDatabaseSQL.GetAllProducts();
            List<string> writeLines = products.Select(x => x.ToString()).ToList();
            File.WriteAllLines(@"C:\Pigegruppen - Synspunkt\NyPigegruppen - synspunkts\TheCodeCrusaders\PigegruppenProjektSynsPunkt\printallproducts.txt", writeLines);

        }


    }
}