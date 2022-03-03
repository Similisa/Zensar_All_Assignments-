using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to accept a word from the user and display the reverse of it. 
namespace StringAssgn2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";
            int Length = 0;

            Console.WriteLine("Enter a Word");           
            str = Console.ReadLine();
           
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }         
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();


        }
    }
}
