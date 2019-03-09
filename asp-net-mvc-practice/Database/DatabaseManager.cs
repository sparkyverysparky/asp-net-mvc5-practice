using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcPractice.Database
{
    public class DatabaseManager
    {
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.ApplicationName = "MvcPractice";
            connectionStringBuilder.DataSource = "localhost";
            connectionStringBuilder.InitialCatalog = "MvcPractice";
            connectionStringBuilder.UserID = "MvcPractice";
            connectionStringBuilder.Password = "1324";
            connectionStringBuilder.ConnectTimeout = 60;
            return connectionStringBuilder.ConnectionString;
        }
    }
}