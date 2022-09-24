using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AWPS
{
    class SqliteDataAccess
    {
        public static List<Employe> LoadEmployee()
        {
            using (IDbConnection cnn = new SQLiteConnection(LeadConnectionString()))
            {
                var output = cnn.Query<Employe>("select * from Employee", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void deleteEmplopee(int EmployeNumber)
        {
            using (IDbConnection cnn = new SQLiteConnection(LeadConnectionString()))
            {
                cnn.Execute($"Delete From Employee where EmployeNumber = '{EmployeNumber}'");
            }
        }

        public static void SaveEmployee(Employe employe)
        {
            using (IDbConnection cnn = new SQLiteConnection(LeadConnectionString()))
            {
                cnn.Execute("Insert into Employee (EmployeNumber, FirstName, LastName, PhoneNumber, " +
                    "Address, AccountNumber, HourlySalary) values (@EmployeNumber, @FirstName, @LastName, " +
                    "@PhoneNumber, @Address, @AccountNumber, @HourlySalary)", employe);
            }
        }

        public static void UpdateEmployee(Employe employe)
        {
            using (IDbConnection cnn = new SQLiteConnection(LeadConnectionString()))
            {
                cnn.Execute("Update or Ignore Employee Set EmployeNumber = @EmployeNumber, FirstName = @FirstName, " +
                    "LastName = @LastName, PhoneNumber = @PhoneNumber, Address = @Address, AccountNumber = @AccountNumber, " +
                    "HourlySalary = @HourlySalary", employe);
            }
        }

        private static string LeadConnectionString(String id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}


