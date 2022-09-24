using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWPS
{
    public partial class EmployeInfoForm : Form
    {
         int employeNumber; 
        public EmployeInfoForm(int employeNumber)
        {
            InitializeComponent();
            this.employeNumber = employeNumber;
            this.loadInfo();
        }

        public void loadInfo()
        {
            Employe rightEmploye = RightEmploye(employeNumber); 

            infoFirstNameLabel.Text = rightEmploye.FirstName;
            infoLastNameLabel.Text = rightEmploye.LastName;
            infoPhoneNumberLabel.Text = rightEmploye.PhoneNumber;
            infoAddressLabel.Text = rightEmploye.Address;
            infoAccountNumberLabel.Text = rightEmploye.AccountNumber;
            infoHourlySalaryLabel.Text = rightEmploye.HourlySalary;
        }

        public static Employe RightEmploye(int EmployeNumber)
        {
            List<Employe> employes = SqliteDataAccess.LoadEmployee();
            foreach (Employe employe in employes)
            {
                if (employe.EmployeNumber == EmployeNumber)
                {
                    return employe;
                }
            }
            return new Employe();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
