using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement
{
    public class FlightCenterConfig
    {
        //public const string ADMIN_NAME = "admin";
        //public const string ADMIN_PASSWORD = "9999";

        public static string strConn = @"Data Source=.;Initial Catalog=AirlineManagementDB;Integrated Security=True";
        public static int OneDayInterval = 24 * 60 * 60 * 1000; //24 hours in milliseconds
        
    }
}
