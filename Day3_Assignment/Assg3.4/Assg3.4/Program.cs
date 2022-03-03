using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*4. Write a program in C# Sharp to declare a structure called Books with a property,
    a method to display the value of Book_id, and a private field called Book_id (int)*/

namespace Assg3._4
{
    struct Books
    {
        private int Book_id;

        public int id
        {
            get { return Book_id; }
            set { Book_id = value; }
        }

        public void Display()
        {
            Console.WriteLine("Value of book id is: {0} ", Book_id);
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Books books = new Books();
            books.id = 111;
            books.Display();
            Console.Read();
        }
       
    }
}
