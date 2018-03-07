using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Med
{
    public class ControlFunctions
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Med.Properties.Settings.LastMedDBConnectionString"].ConnectionString;
        //public static SqlConnection connection = new SqlConnection(@"Data Source = ISKUSNIK; Initial Catalog = LastMedDB; Integrated Security = True");
        public static SqlConnection connection = new SqlConnection(connectionString);


        public static bool LoginPasswordCheck(string login, string password)
        {
            
            return false;
        }
        public static void RegistrationCall()
        {

        }
    }
}
