using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Admistration : Staff
    {
        private string position;
        public string Position { get => position; set => position = value; }
        public Admistration(string name, int work_experiance, int amount_employe, string position)
            : base(name, work_experiance, amount_employe)
        {
            Position = position;
        }
        public Admistration()
        {
        }
    }

}
