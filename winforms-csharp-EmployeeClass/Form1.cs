/*
Employee Class Write a class named Employee that has the following properties: 
• Name—The Name property holds the employee’s name.
• IdNumber—The IdNumber property holds the employee’s ID number.
• Department—The Department property holds the name of the department in which the employee works. 
• Position—The Position property holds the employee’s job title.
The class should have the following overloaded constructors: 
• A constructor that accepts the following values as arguments and assigns them to the appropriate properties: employee’s name, employee’s ID number, department, and position
• A constructor that accepts the following values as arguments and assigns them to the appropriate properties: employee’s name and ID number.The Department and Position properties should be assigned an empty string ("") 
• A parameterless constructor that assigns empty strings("") to the Name, Department, and Position properties, and 0 to the IdNumber property
In an application, create three Employee objects to hold the following data: 

Name           ID Number       Department        Position
Susan Meyers     47899        Accounting      Vice President
Mark Jones       39119          IT               Programmer
Joy Rogers       81774       Manufacturing        Engineer

The application should store this data in the three objects and display the data for each employee on the screen.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_csharp_EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>();
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee("Susan Mayer", 47899, "Accounting", "Vice President"
                ));
            employees.Add(new Employee("Mark Jones", 39199));
            employees.Add(new Employee());

            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            txtOutput.Clear();
            foreach(Employee e in employees)
            {
                txtOutput.Text += e.ToString();
                txtOutput.Text += Environment.NewLine;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employees[1].Department = "IT";
            employees[1].Position = "Programmer";

            employees[2].Name = "Joy Rogers";
            employees[2].Id = 81774;
            employees[2].Department = "Manufacturing";
            employees[2].Position = "Engineer";

            DisplayEmployees();
        }
    }
}
