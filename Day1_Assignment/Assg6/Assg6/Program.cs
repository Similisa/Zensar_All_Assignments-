using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Average of an array elements : {a.Average()}");
            Console.WriteLine($"Minimum of an array is {a.Min()} and maximum of an array is {a.Max()}");
        }
    }
}
