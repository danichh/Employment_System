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
    public partial class InfoForm : Form
    {
        int employeNumber; 
        public InfoForm(int employeNumber)
        {
            InitializeComponent();
            this.employeNumber = employeNumber;
            LoadForm(new EmployeInfoForm(employeNumber));
            backBtn.Visible = false;
        }

        public void LoadForm(Object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            backBtn.Visible = true;
            backBtn.BringToFront();
            updateInfoBtn.Visible = false;
            this.mainPanel.Controls.Clear();
            LoadForm(new EditInfoForm(employeNumber));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            EditInfoForm ed = new EditInfoForm(employeNumber);
            Employe update = ed.updateInfo(employeNumber);


            SqliteDataAccess.UpdateEmployee(update);
            

            this.mainPanel.Controls.Clear();
            LoadForm(new EmployeInfoForm(employeNumber));

        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            backBtn.Visible = false;
            updateInfoBtn.Visible = true;
            this.mainPanel.Controls.Clear();
            LoadForm(new EmployeInfoForm(employeNumber));
        }
    }
}
