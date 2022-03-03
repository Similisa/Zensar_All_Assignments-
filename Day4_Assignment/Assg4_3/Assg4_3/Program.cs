using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.Create a simple Stationery application to add items and display added items using Generic collections*/

namespace Assg4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
           
            list.Add("Pencil Sharpener");
            list.Add("Notepads.");
            list.Add("Eraser.");
            list.Add("Stapler.");
            list.Add("Pencil.");
            list.Add("Whitener");
          
            foreach(String str in list)
            {
                Console.WriteLine(str);
            }
            Console.Read();
        }
    }
}
