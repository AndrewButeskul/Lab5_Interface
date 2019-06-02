using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Staff : Engineer
    {
        private int amount_employe;
        public int Amount_employe { get => amount_employe; set => amount_employe = value; }

        public Staff(string name, string country, string city, string sex, int age, int work_experiance, int amount_employe)
            : base(name, country, city, sex, age, work_experiance)
        {
            Amount_employe = amount_employe;
        }
        public Staff()
        {
        }
        public void Print_Staff()
        {
            Console.WriteLine( "\nAmount employee: " + Amount_employe);
        }
    }
}
