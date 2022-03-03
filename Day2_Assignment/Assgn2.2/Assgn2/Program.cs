using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*2. Create a class called student which has data members like rollno, name, class, SEM, branch,int[] marks = new int marks[5] (marks of 5 subjects )
-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35 but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Pass the details of student like rollno, name, class, SEM, branch in constructor
-Write a Display Data method to display all values.
*/
namespace Assgn2
{
    class Student
    {
        int roll_no,Class,sem,sum;
        string name, branch;
        int[]marks=new int[5];
        float avg;

        public Student(int Roll_No, int std, int Sem, string Name, string Branch)
        {
            roll_no = Roll_No;
            Class = std;
            sem = Sem;
            name = Name;
            branch = Branch;

        }

        public void display_result()
        {
            
            for(int i = 0; i < marks.Length; i++)
            {
                sum = sum + marks[i];
            }
                avg = sum / marks.Length;
               Console.WriteLine("Average of marks is: " + avg);
        }    

       private  void Marks()
        {
            Console.WriteLine("Enter the marks");
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i]=Convert.ToInt32(Console.ReadLine());
               // Console.WriteLine(marks[i]);

            }
            
        }
        public void displayallvalue()
        {
            Marks();
            Console.WriteLine(name+" "+roll_no+" "+Class+" "+branch+" "+sem+" ");
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            
        }

        public void get_result()
        {
            
            for(int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Failed1");
                    return;
                }
                else if(marks[i]>35 && avg < 50)
                {

                    Console.WriteLine("Failed2");
                    return;
                }
                else if (avg > 50)
                {
                    Console.WriteLine("Passed");
                    return;
                }
            }
            
        }
                
        
    }
    class Program
    {
      
        static void Main(string[] args)
        {
           
            Student student = new Student(22,2,5,"simi","CS");
            student.displayallvalue();
            student.display_result();
            student.get_result();        
            Console.ReadKey();

        }
    }
}
