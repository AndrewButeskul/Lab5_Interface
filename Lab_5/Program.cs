using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        delegate void Method();
        static void Main(string[] args)
        {
            Method pointer;

            Admistration admistration = new Admistration("Mike", "Ukraine", "Odessa", "Man", 25, 8, 22, "Manager");

            pointer = admistration.Print_Employee;
            pointer += admistration.Print_Engineer;
            pointer += admistration.Print_Staff;
            pointer += admistration.Print_Admistration;
            pointer();
            Console.ReadKey();
        }      

       
       
    }
}
