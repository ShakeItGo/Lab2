using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.Login = "Chopper";

            user.Name = "Donald";

            user.Surname = "Duck";

            user.Age = 48;

            Console.WriteLine("User information: Login - {0}, Name - {1}, Surname - {2}, Age - {3}, time - {4}", user.Login, user.Name, user.Surname, user.Age, DateTime.Now);
            Console.ReadLine();
        }
    }