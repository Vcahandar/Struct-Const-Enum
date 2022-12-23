using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Costumer(int id,string name,string surname,int age,string position)
        {
            Id = id;
            Name=name;
            Surname=surname;
            Age= age;
            Position = position;

        }
    }
}
