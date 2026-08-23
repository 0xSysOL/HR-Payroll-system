using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Collections.Concurrent;
using System.Reflection;
using System.Xml.Linq;

namespace Data_Layer.Configuration
{
    public class clsSetting
    {
        internal static ConcurrentDictionary<string, PropertyInfo[]> cache = new ConcurrentDictionary<string, PropertyInfo[]>();



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
