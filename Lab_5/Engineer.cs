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

        public Engineer(string name, int work_experiance)
            : base(name)
        {
            Work_experiance = work_experiance;
        }
        public Engineer()
        {
        }
    }
}
