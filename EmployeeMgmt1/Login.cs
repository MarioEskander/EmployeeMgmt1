using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// this is a new commit 
namespace EmployeeMgmt1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // this is a old code with old design...
        private void ResetLb1_Click(object sender, EventArgs e)
        {
            UNameTb.Text= "";
            PasswordTb.Text = "";
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if(UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Employees Obj = new Employees();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
        // this is the end of it...

        // this is a new code with new Design
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ResetLb1_Click_1(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Employees Obj = new Employees();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
            // this is the end of the code of the new design
        }
    }
}