using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance
    as its members.Create a method calculate_EMI() for the LoanAmount, with the rate of interest as 13% for
    a total of 3 years and store it in the EMI_Amount. The rest of the information to be passed through constructors.
    Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount.
    If yes then throw a custom exception.Display " Not Sufficient Balance to repay Loan" in the finally. 
    Give explanatory comments.*/

namespace Assg3._2
{
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {

        }
    }
    class LoanProcess
    {
       public long Loan_No,loan_Amount,Account_Balance;
       public string Customer_Name;
       public double EMI_Amount;
       public float p, r, t;

        public LoanProcess(float R,float T,long LoanNo)
        {

             p = loan_Amount;
             r = R;
             t = T;
             Loan_No = LoanNo;
        }
        public void calculate_EMI()
        {

            Console.WriteLine("Enter Customer Name: ");
            Customer_Name = Console.ReadLine();

            Console.WriteLine("Enter Loan Amount: ");
            loan_Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer Name : " + Customer_Name);
            Console.WriteLine("Loan Amount : " + loan_Amount);

            Console.WriteLine("Loan Number: "+ Loan_No);

            p = loan_Amount;
                r = r / (12 * 100); 
                t = t * 12; 
                EMI_Amount = (p * r * (float)Math.Pow(1 + r, t))
                              / (float)(Math.Pow(1 + r, t) - 1);

            Console.WriteLine("EMI Amount is :"+EMI_Amount);          

        }
        public void CheckBalance()
        {
            Console.WriteLine("Enter Account Balance: ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());

            if (EMI_Amount < Account_Balance)
            {
                throw(new LoanException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("Loan Paid successfully");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            LoanProcess loanProcess = new LoanProcess(13,3,5476890);

            try
            {
                loanProcess.calculate_EMI();
                loanProcess.CheckBalance();
            }

            catch(LoanException le)
            {
                Console.WriteLine(le.Message);
            }
                Console.Read();          
        }
                 
    }
                 
}
