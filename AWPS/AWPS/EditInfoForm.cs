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
    public partial class EditInfoForm : Form
    {
        int employeNumber; 
        public EditInfoForm(int EmployeNumber) 
        {
            InitializeComponent();
            this.employeNumber = EmployeNumber;
            loadInfo();
            updateLabel.Visible = false;
        }

        public void loadInfo()
        {
            Employe employe = EmployeInfoForm.RightEmploye(employeNumber);

            firstNameTextBox.Text = employe.FirstName;
            lastNameTextBox.Text = employe.LastName;
            phoneNumberTextBox.Text = employe.PhoneNumber;
            addressTextBox.Text = employe.Address;
            accountNumberTextBox.Text = employe.AccountNumber;
            hourlySalaryTextBox.Text = employe.HourlySalary;
        }

        public Employe updateInfo(int employeNumber)
        {
            Employe hh = new Employe();
            hh.EmployeNumber = employeNumber;
            hh.FirstName = firstNameTextBox.Text;
            hh.LastName = lastNameTextBox.Text;
            hh.PhoneNumber = phoneNumberTextBox.Text;
            hh.Address = addressTextBox.Text;
            hh.AccountNumber = accountNumberTextBox.Text;
            hh.HourlySalary = hourlySalaryTextBox.Text;

            return hh;
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            Employe update = this.updateInfo(employeNumber);
            SqliteDataAccess.UpdateEmployee(update);
            updateLabel.Visible = true;
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
