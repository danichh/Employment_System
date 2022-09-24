using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AWPS
{
    public class Employe
    {
        public int EmployeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string AccountNumber{ get; set; }
        public string HourlySalary { get; set; }

        public string display
        {
            get{
                return $"{EmployeNumber}  {FirstName,35}, {LastName}";
            }
        }
    }
}
