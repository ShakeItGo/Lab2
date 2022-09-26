using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Info information = new Info();
            information.Index = 02099;
            information.Country = "Ukraine";
            information.City = "Kyiv";
            information.Street = "Perova st.";
            information.House = 123;
            information.Apartment = 22;

            Console.WriteLine($"Index: {information.Index} , Country: {information.Country} , City: {information.City} , Street: {information.Street} , House: {information.House} , Apartment: {information.Apartment}.");
        }
    }
}
