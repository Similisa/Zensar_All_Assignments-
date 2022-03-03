using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Create a class called Accounts which has data members like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal

-write a function that updates the balance depending upon the transaction type

	-If transaction type is deposit call the credit(int amount) function and update balance
	-If transaction type is withdraw call debit(int amt)function and update balance
-Pass the other information like Acount no,name,acc type through constructor
-call the show data method to display the values.*/

namespace Assgn1
{

    class Accounts
    {
       public long Account_No;
       public String Customer_Name, Account_Type, Transaction_Type;
       public int Amount;
       public float Balance;

        public Accounts(long accountNo, string customerName, string accountType, string transactionType, int amount, float balance)
        {
            Account_No = accountNo;
            Customer_Name = customerName;
            Account_Type = accountType;
            Transaction_Type = transactionType;
            Amount = amount;
            Balance = balance;
        }

          public void show()
         {          

            Console.WriteLine(" your Name: " + Customer_Name);
            Console.WriteLine(" your Account Number: " + Account_No);
            Console.WriteLine(" your Account Type: " + Account_Type);          
            Console.WriteLine(" your Amount: " + Amount);
        }          

        public void credit(int deposit_amt)
        {

            Balance = Balance + deposit_amt;
            Console.WriteLine("your Account Balance is: " + Balance);
        }
    
        public void debit(int withdraw_amt)
        {
            Balance = Balance - withdraw_amt;
            Console.WriteLine("your Account Balance is: " + Balance);
        }

        
    }        
    class Program
    {      
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want to Deposit or Withdraw: ");
            String Transaction_type = Console.ReadLine();
            Accounts accounts = new Accounts(678910, "Simi","saving", Transaction_type, 6000, 5000);

           
           accounts.show();
           

            if (Transaction_type == "Deposit")
            {
                Console.WriteLine("Enter the amount you want to deposit: ");
                int deposit_amt = Convert.ToInt32(Console.ReadLine());
                accounts.credit(deposit_amt);
            }
            else
            {
                Console.WriteLine("Enter the amount you want to withdraw: ");
                int withdrwa_amt = Convert.ToInt32(Console.ReadLine());
               accounts.debit(withdrwa_amt);
            }
            Console.ReadLine();
            
        } 
    }
}
