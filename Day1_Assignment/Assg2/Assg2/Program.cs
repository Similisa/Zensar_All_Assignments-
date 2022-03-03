using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.ReadLine();
        }
    }
}
