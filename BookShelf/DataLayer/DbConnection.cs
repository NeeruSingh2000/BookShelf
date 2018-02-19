using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataLayer
{
     
    public class DbConnection
    {
        private static string strConnectionString = System.Configuration.ConfigurationManager.AppSettings["dbConnectionString"];
        
        /// <summary>
        /// Returns instance of sqlconnection
        /// </summary>
        /// <returns></returns>
        public static  SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            return conn;
        }

       
       }
}
