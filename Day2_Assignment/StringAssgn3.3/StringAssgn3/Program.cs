using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program in C# to accept two words from user and find out if they are same. 
		To withdraw an amount after checking the balance
        To display name and balance.*/

namespace StringAssgn3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2;

            Console.Write("Enter first word:");
            str1 = Console.ReadLine();

            Console.Write("Enter second word:");
            str2 = Console.ReadLine();

            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();

        
            Array.Sort(char1);
            Array.Sort(char2);
 
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);
            
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes the words are same", str1, str2);
            }
            else
            {
                Console.WriteLine("No the words are not same", str1, str2);
            }

            Console.ReadLine();
        }
    }
}
    
