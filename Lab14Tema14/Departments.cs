using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Tema14
{
    //Departamentele pot fi:
    //Development
    //Testing
    //HumanResources
    //Maintenance
    //Logistics
        public enum Department
        {
            Development,
            Testing,
            HumanResources,
            Maintenance,
            Logistics,
        }
    public class Departments
    {
        public Department Department { get; }
        public Departments (Department department)
        {
            Department = department;
        }

    }
}
