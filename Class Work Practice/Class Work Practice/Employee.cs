using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Work_Practice
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }


        public Employee(string name, string surname, int age, string address)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
        }


        public override string ToString()
        {
            return $"{Name} {Surname} {Age} {Address}";   
        }
    }
}
