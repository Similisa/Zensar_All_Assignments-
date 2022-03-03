using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a program in C# to accept a word from the user and display the length of it.
namespace StringAssgn1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.WriteLine("Enter a word: ");
            String word = Console.ReadLine();

            foreach(char chr in word)
            {
                length = length + 1;
            }
            Console.WriteLine("Length of the word is: " + length);
            Console.ReadLine();
        }
    }
}
