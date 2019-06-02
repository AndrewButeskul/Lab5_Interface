using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Engineer : Employee
    {
        private int work_experiance;
        public int Work_experiance { get => work_experiance; set => work_experiance = value; }

        public Engineer(string name, string country, string city, string sex, int age, int work_experiance)
            : base(name, country, city, sex, age)
        {
            Work_experiance = work_experiance;
        }
        public Engineer()
        {
        }
        public void Print_Engineer()
        {
            Console.WriteLine("\nWork Experiance: " + Work_experiance);
        }

    }
}
