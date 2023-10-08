using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterNine
{
    public partial class EmployeForm : Form
    {
        public EmployeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employeList = new List<Employee>();

            List<Employee> empList = new List<Employee> { new Employee("Ali", 4, "2", "Teacher"), new Employee("Aisho", 1, "2", "Accounting"), new Employee("Daahir", 3, "2", "Finance") };

            lblInfo.Text = "";
            foreach( Employee employee in empList ) 
            {
                lblInfo.Text += $"Name \t {employee.Name} \t Id \t {employee.IdNumber} \t Dep \t {employee.Department} \t Pos \t{employee.Position} \n\n";
            }

            //grand father
            User us = new User();

            //father
            Register reg = new Register();
            

            //child
            Order or = new Order();
           

        }
    }
}
