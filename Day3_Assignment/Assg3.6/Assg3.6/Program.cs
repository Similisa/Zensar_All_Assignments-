using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Write a program in C# Sharp to insert the information of two books. 

Test Data :

Insert the information of two books :                    
-----------------------------------------                
Information of book 1 :                                  
Input name of the book : BASIC
Input the author : S.TROELSTRA

Information of book 2 :                                  
Input name of the book : C+                              
Input the author : G.RTRTG

Expected Output:

1: Title = BASIC,  Author = S.TROELSTRA                  
                                                         
2: Title = C+,  Author = G.RTRTG */


namespace Assg3._6
{
    struct Book
    {
        public string Title;
        public string Author;
    }
    class Program
    {       
     
      public static void Main()
      {
                int NoOfBook = 1000;
                Book[] books = new Book[NoOfBook];
                int i, j, k = 1,n=1;

                Console.Write("\n\nInsert the information of two books :\n");
                Console.Write("-----------------------------------------\n");
                for (j = 0; j <= n; j++)
                {
                    Console.WriteLine("Information of book {0} :", k);

                    Console.Write("Input name of the book : ");
                    books[j].Title = Console.ReadLine();

                    Console.Write("Input the author : ");
                    books[j].Author = Console.ReadLine();
                    k++;
                    Console.WriteLine();
                }

                for (i = 0; i <= n; i++)
                {
                    Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].Title, books[i].Author);
                    Console.WriteLine();
                }
                    Console.Read();

      }
      


    }
}

