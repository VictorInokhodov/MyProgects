using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Examples
    {
        public static void UserExamples()
        {
            User user2 = new User("Victor", "Inokhodov", new DateTime(2016, 12, 1), "Alexandrovich");
            Console.WriteLine($"Name: {user2.Name}\n" +
                    $"Sername: {user2.SerName}\n" +
                    $"Patronymic: {user2.Patronymic}\n" +
                    $"Date of birth: {user2.DateOfBirth.Date}\n" +
                    $"Ages: {user2.Age}\n");
        }

        public static void RoundExample()
        {
            Round round = new Round(1, 1, 10);
            Console.WriteLine($"Length: {round.Length(): 0.###}\n" +
                $"Area: {round.Area(): 0.###}\n");
        }

        public static void TriangleExample()
        {
            Triangle tr = new Triangle(2, 3, 4);
            Console.WriteLine($"Area {tr.Area(): 0.##}\n" +
                $"Perimeter: {tr.Perimeter()}\n");
        }

        public static void MyStringExample()
        {
            MyString ms = new MyString("hello");
            MyString ms2 = new MyString("hello");
            Console.WriteLine(ms == ms2);
            ms = ms - ms2;
            ms = ms + new MyString("hello");
            Console.WriteLine(ms.ToString());
        }

        public static void EmployeeExample()
        {
            Employee emp = new Employee("Victor", "Inokhodov", new DateTime(1998, 7, 22), 0, "Programmer", "Alexandrovich");

            Console.WriteLine($"\nName: {emp.Name}\n" +
                    $"Sername: {emp.SerName}\n" +
                    $"Patronymic: {emp.Patronymic}\n" +
                    $"Date of birth: {emp.DateOfBirth.Date}\n" +
                    $"Ages: {emp.Age}\n" +
                    $"Position: {emp.Position}\n" +
                    $"Stage: {emp.Stage}\n");
        }

        public static void RingExample()
        {
            Ring rng = new Ring(1, 1, 10, 7);
            Console.WriteLine($"Length: {rng.Length(): 0.###}\n" +
                $"Area: {rng.Area(): 0.###}\n");
        }
    }
}
