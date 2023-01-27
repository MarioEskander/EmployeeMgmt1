using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

// this is System commits 

namespace EmployeeMgmt1
{

    public partial class Departments : Form
    {

        Functions Con;
        public Departments()
        {

            InitializeComponent();
            Con = new Functions();
            ShowDepartments();

        }

        // this is a Department commit 
        private void ShowDepartments()
        {

            string Query = "Select * from DepartmentTb1";
            DepList.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {

                if(DepNameTb.Text == " ")
                {

                    MessageBox.Show("MISSING DATA!!!");

                }else
                {

                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values('{0}')";
                    Query = string.Format(Query,DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("DEPARTMENT ADDED!!!");
                    DepNameTb.Text = "";
                    
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);

            }
        }
        int Key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if(DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("MISSING DATA!!!");

                }
                else
                {

                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTb1 set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!!!");
                    DepNameTb.Text = "";

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTb1 where DepId = {0}";
                    Query = string.Format(Query,Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            
            this.Hide();
        }

        private void SalaryLb1_Click(object sender, EventArgs e)
        {
            
            Salaries Obj = new Salaries();
            Obj.Show();

            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            Login Obj = new Login();
            Obj.Show();
            
            this.Hide();
        }
    }
}
