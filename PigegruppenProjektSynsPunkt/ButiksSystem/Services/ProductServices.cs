using ButiksSystem.Repository;
using ButiksSystem.UI;
using System;
using System.Collections.Generic;
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

        public static void UpdateProduct(Models.Product product)
        {
            //Insert businesslogic
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            ProductDatabaseSQL.UpdateProduct(product);
        }

        public static void DeleteProduct(Models.Product product)
        {
            //Insert businesslogic
            ProductDatabaseSQL productDatabaseSQL = new ProductDatabaseSQL();
            ProductDatabaseSQL.DeleteProduct(product);
        }
    }
}