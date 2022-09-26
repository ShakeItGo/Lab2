using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee inform = new Employee();
            inform.Name = "John";
            inform.Surname = "Dorian";
            inform.Ocupation = "Junior dev.";
            inform.Experience = 10;
            inform.Taxes = 0.5;
            inform.Amount = 300;

            inform.Info();
        }
    }
}
