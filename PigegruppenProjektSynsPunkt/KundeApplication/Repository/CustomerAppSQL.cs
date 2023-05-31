using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundeApplication.Repository
{
    public class CustomerAppSQL
    {
        private static SqlConnection connection = new SqlConnection("Data Source=mssql5.unoeuro.com; Initial Catalog =  saanneeha_dk_db_database; User ID = saanneeha_dk; Password = yx5chmEw6HtDg2efarF9");

        public List<Models.Frame> ReadAllFrames()
        {
            List<Models.Frame> allFrames = new List<Models.Frame>();

            string query =  $"SELECT ProductID, ProductName, FrameColour, FrameFacon, FrameThickness, Nosepads, FramePattern, ProductPrice FROM Frame";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Models.Frame product = new Models.Frame(
                    (int)reader["ProductID"],
                    reader["ProductName"].ToString(),                   
                    reader["FrameColour"].ToString(),
                    reader["FrameFacon"].ToString(),
                    reader["FrameThickness"].ToString(),
                    reader["NosePads"].ToString(),
                    reader["FramePattern"].ToString(),
                    (decimal)reader["ProductPrice"]);

                allFrames.Add(product);
            }
            reader.Close();
            connection.Close();

            return allFrames;
        }


    }
}
