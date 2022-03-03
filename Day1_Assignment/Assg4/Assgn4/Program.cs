using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn4
{
    class Program
    {
        static void Student()
        {

            Console.WriteLine("Enter Student Name: ");
            String Name = Console.ReadLine();

            Console.WriteLine($"Enter C# Marks of {Name} : ");
            int CMarks = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter HTML Marks of {Name} : ");
            int HTML_Marks = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter SQL Marks of {Name}: ");
            int SQL_Marks = int.Parse(Console.ReadLine());

            float avg = (CMarks + HTML_Marks + SQL_Marks) / 3;
            Console.WriteLine($"Average of {Name} is : {avg}");

            if (avg < 50)
            {
                Console.WriteLine("FAIL");
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Student();
            }
        }
    }
}
