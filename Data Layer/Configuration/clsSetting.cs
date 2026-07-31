using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data_Layer.Configuration
{
    public class clsSetting
    {

        public static string GetConnectionString()
        {
            XDocument document = XDocument.Load("Configuration/App.config");

            string ConnectionString = document.Descendants("Connection_strings").FirstOrDefault()?.Value;


            return ConnectionString;
            
        }

        public static SqlConnection GetSqlConnection()
        {

            return new SqlConnection(GetConnectionString());

        }

    }
}
