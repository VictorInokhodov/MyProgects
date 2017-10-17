using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UserExample
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine($"Name: {user1.Name}\n" +
                $"Sername: {user1.SerName}\n" +
                $"Date of birth: {user1.DateOfBirth.Date}\n" +
                $"Ages: {user1.Age}");
        }
    }
}
