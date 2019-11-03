using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms_csharp_EmployeeClass
{
    class Employee
    {
        public Employee(string name, int id, string department, string position)
        {
            Name = name;
            Id = id;
            Department = department;
            Position = position;
        }

        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
            Department = "";
            Position = "";
        }

        public Employee()
        {
            Name = "";
            Id = 0;
            Department = "";
            Position = "";
        }

        public override string ToString()
        {
            return string.Format("Name: {0}" + Environment.NewLine +
                                 "Id: {1}" + Environment.NewLine +
                                 "Dept: {2}" + Environment.NewLine +
                                 "Position: {3}" + Environment.NewLine,
                                 Name, Id, Department, Position);
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

    }
}
