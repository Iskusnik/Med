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

        //static string connectionString = ConfigurationManager.ConnectionStrings["Med.Properties.Settings.LastMedDBConnectionString"].ConnectionString;
        //public static SqlConnection connection = new SqlConnection(connectionString);
        //static public LastMedDBDataSet db = new LastMedDBDataSet();
        //db.PersonSet_Operator.FindByBirthDateNameHashID()
        public static string connectionString = @"Data Source=ISKUSNIK;Initial Catalog=FinallyWorkingDB;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        

        public static bool LoginPasswordCheck(string login, string password)
        {
            using (connection)
            {
                using (MEDDBContainer db = new MEDDBContainer())
                {
                    connection.Open();
                    
                    db.PersonSet.Add(new Patient { FullName = "Фёдоров Фёдор Фёдорович" });
                    db.PersonSet.Add(new Patient { FullName = "Иванов Фёдор Фёдорович" });
                    db.SaveChanges();
                    return false;
                }
            }
        }
        public static void RegistrationCall(object obj)
        {
            string sqlExpression = "INSERT INTO PersonSet (FullName, Gender) VALUES ('Tom Tommy Tomphson', 'M')";
            using (connection)
            {
                using (MEDDBContainer db = new MEDDBContainer())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                   // int number = command.ExecuteNonQuery();

                    db.PersonSet.Add(new Patient { FullName = "Фёдоров Фёдор Фёдорович" });
                    db.PersonSet.Add(new Patient { FullName = "Иванов Фёдор Фёдорович" });
                    db.SaveChanges();
                }
            }
        }
    }
}
