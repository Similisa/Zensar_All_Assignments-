using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Mgnt_Sys
{

    public class Student
    {
        private int id;
        public int StudId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string Name;
        public string StudName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string DOB;


        //public string name,Date;         

        public Student(int i, string n, string dob)
        {
            id = i;
            Name = n;
            DOB = dob;

        }
    }
    public class Course
    {
        private int ID;
        public int CourseID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        private string Name;
        public string CourseName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public float Course_Duration;
        public float fees;

        public Course(int id, string Course_Name, float duration, float CourseFees)
        {
            ID = id;
            Name = Course_Name;
            Course_Duration = duration;
            fees = CourseFees;
        }

    }
   
    class Info
    {

        public void display(Student student)
        {
            //Code here to display the details of given student

            Console.WriteLine($"  Student Name:  {student.StudName} \n  Student ID :  {student.StudId } \n  DateOfBirth: { student.DOB}");

            Console.WriteLine();
        }

        public void display(Course course)
        {
            Console.WriteLine($"  Course ID:  {course.CourseID} \n  Course Name :  {course.CourseName } \n  Duration: { course.Course_Duration}  days \n  Fees: {course.fees}");

            Console.WriteLine();
        }
    }
}
