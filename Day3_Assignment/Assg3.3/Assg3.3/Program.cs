using Assg3._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method.
Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.Test The functionalities.*/

namespace Assg3._3
{

    interface IStudent
    {
        int StudentId { get; set; }
        string StudentName { get; set; }

        void showDetails();


    }
    class Dayscholar : IStudent
    {
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public void showDetails()
        {
            Console.WriteLine("Enter student Name: ");
            StudentName = Console.ReadLine();

            Console.WriteLine("Enter student ID: ");
            StudentId = Convert.ToInt32(Console.ReadLine());
        }

    }

    class Resident : IStudent
    {
        string Student_Name { get; set; }
        public int Student_Id { get; set; }

        public string StudentName
        {
            get { return Student_Name; }
            set { Student_Name = value; }
        }
        public int StudentId
        {
            get { return Student_Id; }
            set { Student_Id = value; }
        }
        public void showDetails()
        {
            Console.WriteLine("Enter student Name: ");
            StudentName = Console.ReadLine();

            Console.WriteLine("Enter student ID: ");
            StudentId = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            IStudent ds = new Dayscholar();
            ds.showDetails();
            
            IStudent r = new Resident();
            r.showDetails();            

            Console.WriteLine($"Student Name: {ds.StudentName} with student Id: {ds.StudentId} is dayscholar");
            Console.WriteLine($"Student Name: {r.StudentName} with student Id: {r.StudentId} is Resident student");

            Console.Read();
        }
    }
}

