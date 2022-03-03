using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Create a class library CalculateConcession()  that takes age as an input and calculates concession for travel as below:
If age<=5 then “Little Champs- Free Ticket” should be displayed
If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500 / -) and Display “ Senior Citizen” + Calculated Fare
Else “Print Ticket Booked” + Fare. 
Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age. 
Accept Name, Age from the user and call the CalculateConcession() function*/


namespace ClassLibrary1
{
    public class Class1
    {

        const int totalfare = 500;
       
        public void CalculateConsession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free TIcket ");
            }
            else if (age > 60)
            {
                int calulatedFare = totalfare - 30;
                Console.WriteLine("Senior Citizen: " + calulatedFare);
            }
            else
            {
                Console.WriteLine("TIcket Booked Successfully" + totalfare);
            }
        }
    }
}