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
    public partial class EmployeViewForm : Form
    {
        static List<Employe>  employees = new List<Employe>();
        public EmployeViewForm()
        {
            InitializeComponent();
            LoadEmployeeList();
            WireUPPeopleList();
        }

        public static void LoadEmployeeList()
        {
            employees = SqliteDataAccess.LoadEmployee();
        }

        private void WireUPPeopleList()
        {
            employeesViewListBox.DataSource = null;
            employeesViewListBox.DataSource = employees;
            employeesViewListBox.DisplayMember = "display";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.deleteEmplopee(this.getId());
            LoadEmployeeList();
            WireUPPeopleList();
        }

        private void moreDetailBtn_Click(object sender, EventArgs e)
        {
            this.getId();
            Form f = new InfoForm(this.getId());
            f.Show();
        }

        private int getId()
        {
            String item = employeesViewListBox.Text;
            string[] word = item.Split(' ');
            return Int32.Parse(word[0]);
        }
    }
}
