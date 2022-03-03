using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg5
{
    class Program
    {
        static void Main(string[] args)
        {
            int TempInForenheit,TempInCelsius;
            Console.WriteLine("Enter the temperature in Forenheit:");
            TempInForenheit = Convert.ToInt32(Console.ReadLine());

            TempInCelsius = (TempInForenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in celsius is: " + TempInCelsius);
            Console.ReadLine();
        }
    }
}
