using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create an Abstract class Student with Name, StudentId, Grade as members and also
 * an abstract method Boolean Ispassed(grade) 
 * which takes grade as an input and checks whether student passed the course or not.

Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method

For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false.
For the Grad class, if the grade is above 80.0, 
then isPassed returns true, otherwise returns false.*/


namespace Assgn3
{
    
    abstract class Student
    {
       public String Name;
       public int StudentID;
       public float Grade;

        abstract public Boolean IsPassed(float Grade);
    }

    class UnderGraduate : Student
    {
        public override Boolean IsPassed(float Grade)
        {
            Console.WriteLine("Enter student Name: ");
           Name= Console.ReadLine();

            Console.WriteLine("Enter student id: ");
            StudentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name of student is:{0}",Name);
            Console.WriteLine("Id of student is {0} ",StudentID);
            Console.WriteLine("Undergraduate Grade :{0} ",Grade);
            if (Grade > 70.0f)
            {
               
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }

    class Graduate:Student
    {
        public override Boolean IsPassed(float Grade)
        {
            Console.WriteLine("Enter student Name: ");
            Name=Console.ReadLine();

            Console.WriteLine("Enter student id: ");
            StudentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name of student is:"+ Name);
            Console.WriteLine("Id of student is {0} ", StudentID);
            Console.WriteLine("Graduate Grade :{0} ", Grade);
            if (Grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            UnderGraduate underGraduate = new UnderGraduate();
            Console.WriteLine(underGraduate.IsPassed(70.0f));
            Graduate graduate = new Graduate();
            Console.WriteLine(graduate.IsPassed(80.0f));

            Console.Read();
        }
    }
}
