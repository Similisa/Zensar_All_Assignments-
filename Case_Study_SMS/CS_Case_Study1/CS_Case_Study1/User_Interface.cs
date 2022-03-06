using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CS_Case_Study1
{

      abstract class UserInterface
      {
          public abstract void showFirstScreen();
          public abstract void showStudentScreen();
          public abstract void showAdminScreen();
          public abstract void showAllStudentsScreen();
          public abstract void showStudentRegistrationScreen();
          public abstract void introduceNewCourseScreen();
          public abstract void showAllCoursesScreen();

      }
        class Institute_Details : UserInterface
        {

          private string ans;
          public override void showFirstScreen()
          {
              do
              {
                  Console.WriteLine("Welcome to SMS(Student Management System)");
                  Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. All Registered Students");
                  Console.WriteLine();
                  Console.WriteLine("Enter your choice ( 1 or 2 or 3 ) : ");
                  int op = Convert.ToInt32(Console.ReadLine());

                  switch (op)
                  {
                      case 1:
                          showStudentScreen();
                          break;
                      case 2:
                          showAdminScreen();
                          break;
                      case 3:
                          showAllStudentsScreen();
                          break;
                      default:
                          Console.WriteLine("Please Enter valid Option :");
                          break;
                  }
                  Console.WriteLine("Do you want to continue in Main Screen : Yes or No ");
                  ans = Console.ReadLine();
              } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
          }

          public override void showStudentScreen()
          {
              do
              {
                  AppEngine ae = new AppEngine();
                  Console.WriteLine("Select: \n 1.Check Student Details \n 2.Update Your Details\n 3.Search Available Courses\n 4.Enroll Courses in List");
                  int op = Convert.ToInt32(Console.ReadLine());
                  switch (op)
                  {
                      case 1:
                          // Checks whether new registrartion or already existing user
                          ae.Student_Screen();
                          Console.WriteLine();
                          Console.WriteLine("Action Completed you may Exit...!");
                          break;
                     
                      case 2:
                          //updating Student details
                          ae.UpdateStudentData();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 3:
                          //Showcase all available courses
                          Console.WriteLine("************************List of Available Courses*****************************");
                          ae.Available_Courses();
                         Console.WriteLine();
                         Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 4:
                          //Student enrolling to particular course
                          ae.UpdateCourseData();
                        Console.WriteLine();
                        Console.WriteLine("Course successfully Enrolled.....!!");
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      default:
                          Console.WriteLine("Please Enter valid Option....!");
                          break;

                  }
                  Console.WriteLine("Do you want to continue in Student Screen : Yes or No ");
                  ans = Console.ReadLine();
              } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));

          }
          public override void showAdminScreen()
          {
              do
              {
                  AppEngine aE = new AppEngine();
                  Console.WriteLine("Select: \n 1:Registeration (new user) \n 2.Introduce New Course\n 3.Courses Available\n 4.Update Course Details\n 5.Retrieve Particular Course in List\n 6.Deleting Existing Student\n 7.Delete Course\n 8.Update Student Details\n 9.Retrive the particular course Details");
                  int op = Convert.ToInt32(Console.ReadLine());
                  switch (op)
                  {

                    case 1://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2:
                          //If any new course want to add for Organization
                          this.introduceNewCourseScreen();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 3:
                          //list of existing courses
                          Console.WriteLine("*********************All Available Courses in Institute**********************");
                          this.showAllCoursesScreen();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 4:
                          //updates in Course structure
                          aE.UpdateCourseData();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 5:
                          //getting particular course details
                          aE.enrolling_courses();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 6:
                          //deletes particular student
                          aE.DeleteStudentData();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 7:
                          //deletes existing course only that are not enrolled by any students
                          aE.DeleteCourseData();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 8:
                          //modify existing student details
                          aE.UpdateStudentData();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                      case 9:
                          aE.Retrieve_Particular_Course();
                        Console.WriteLine();
                        Console.WriteLine("Action Completed you may Exit....!");
                          break;
                    
                    default:
                          Console.WriteLine("Please Enter valid Option....!");
                          break;
                  }
                  Console.WriteLine("Do you want to continue in Admin Screen : Yes or No ");
                  ans = Console.ReadLine();
              } while ((ans == "yes") || (ans == "Yes") || (ans == "y") || (ans == "Y"));
          }

          public override void showAllStudentsScreen()
          {
              AppEngine Ae = new AppEngine();
              Ae.Show_all_registered_Students();
          }
          public override void showStudentRegistrationScreen()
          {
              AppEngine A = new AppEngine();
              A.New_StudentRegistration();

          }
          public override void introduceNewCourseScreen()
          {
              AppEngine AE = new AppEngine();
              AE.Introducing_NewCourse();
          }
          public override void showAllCoursesScreen()
          {
              AppEngine ape = new AppEngine();
              ape.Available_Courses();
          }

        }
}

