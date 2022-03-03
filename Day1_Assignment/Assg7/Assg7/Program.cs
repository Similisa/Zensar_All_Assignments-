using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many marks you want:");
            int n = int.Parse(Console.ReadLine());
            int[] studMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                studMarks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total of marks is : {studMarks.Sum()}");
            Console.WriteLine($"Average of marks is :  {studMarks.Average()}");
            Console.WriteLine($"Minimum marks : {studMarks.Min()}");
            Console.WriteLine($"Maximum marks : {studMarks.Max()}");
            Array.Sort(studMarks);
            Console.WriteLine("Marks in asending order : ");
            for (int i = 0; i < studMarks.Length; i++)
            {
                Console.WriteLine(studMarks[i]);
            }
            Array.Reverse(studMarks);
            Console.WriteLine("Marks in desending order : ");
            for (int i = 0; i < studMarks.Length; i++)
            {
                Console.WriteLine(studMarks[i]);
            }
        }
    }
}
