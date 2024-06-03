using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Angajatul va fi caracterizat de:
//Nume
//Id :Guid
//Salary : double
//Department
//ToString – returneaza intr-o maniera prietenoasa toate informatiile despre angajat


namespace Lab14Tema14
{
    public class Employee
    {
        public string name { get; }
        public Guid Id { get; }
        public List<Departments> Departement { get; }
        public List<Salary> Salary { get; }
        public Employee(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Departement = new List<Departments>();
            Salary = new List<Salary>();
        }
        public string ToString()
        {
            return $"Player Id: {Id}, Name={Name}, Departement: {string.Join(" ", Departements)}, Salary: {string.Join(" ", Salary)}";
    }
}
