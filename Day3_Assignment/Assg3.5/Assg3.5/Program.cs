using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 

Test Data:

Create a nested structure and store data in an array :                              
-------------------------------------------------------                          
Name of the employee : H.Rana
Input day of the birth : 05                                                      
Input month of the birth : 02                                                    
Input year for the birth : 58                                                    
                                                                                 
Name of the employee : S.Mathur
Input day of the birth : 04                                                      
Input month of the birth : 08                                                    
Input year for the birth : 59 */


namespace Assg3._5
{
    
    class Program
    {
        struct employee
        {
            public string EName;
            public dtObirth date;
        }
        struct dtObirth
        {
            public int Day, Month, Year;

        }
        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;
            int total = 2;
            employee[] emp = new employee[total];

            for(int i=0;i<total;i++)
            {
                Console.Write("Name of Employee: ");
                String name = Console.ReadLine();
                emp[i].EName = name;

                Console.Write("Input day of the Birth: ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].date.Day = dd;

                Console.Write("Input Month of the Birth: ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].date.Month = mm;

                Console.Write("Input Year of the Birth: ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].date.Year = yy;

                Console.Read();

            }
        }
    }
}
