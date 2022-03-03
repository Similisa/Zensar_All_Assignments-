using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter 3 Numbers:");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Num1 is largest:"+num1);
            }
                          
            else if(num2>=num3 && num2 >= num1)
            {
                Console.WriteLine("Num2 is largest:"+num2);
            }

            else
            {
                Console.WriteLine("num3 is Largest" + num3);
            }
            Console.ReadLine();

        }
    }
}
