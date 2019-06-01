using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Employee : IData, ILocation
    {
        private string name;
        private string country;
        private string city;
        private string sex;
        private int age;
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        public Employee(string name)
        {
            Name = name;
        }
        public Employee()
        {
        }
    }
}
