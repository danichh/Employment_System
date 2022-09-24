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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginInBtn_Click(object sender, EventArgs e)
        {
            if((userTextBox.Text == "admin")  && (pwdTextBox.Text == "1234"))
            {
                MainForm form = new MainForm();
                this.Hide();
                form.Show();
            } else
            {
                errorLabel.Text = "Incorrect User or PassWord";
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
