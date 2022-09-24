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
    public partial class AddEmployesForm : Form
    {
        public AddEmployesForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Employe employe = new Employe();
            List<Employe> employes = SqliteDataAccess.LoadEmployee();


            employe.EmployeNumber = random.Next(0,999999);
            foreach (Employe em in employes)
            {
                if (em.EmployeNumber == employe.EmployeNumber)
                    {
                      employe.EmployeNumber++;
                    }
            }

            employe.FirstName = firstNameTextBox.Text;
            employe.LastName = lastNameTextBox.Text;
            employe.PhoneNumber = phoneNumberTextBox.Text;
            employe.Address = addressTextBox.Text;
            employe.AccountNumber = accountNumberTextBox.Text;
            employe.HourlySalary = hourlySalaryTextBox.Text;

            SqliteDataAccess.SaveEmployee(employe);
            

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
            accountNumberTextBox.Text = "";
            hourlySalaryTextBox.Text = "";
        }

        private void hourlySalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
