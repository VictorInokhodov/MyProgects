using System;
using Arrays;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar1 = new int[] { 1, 2, 3, 4 };
            var ar = new DynamicArray<int>();

            ar.Add(10);

            ar.AddRange(ar1);

            ar.Remove(2);

            ar.Insert(2, 22);

            Console.WriteLine(ar[2]);

            Console.ReadKey();
        }
    }
}
