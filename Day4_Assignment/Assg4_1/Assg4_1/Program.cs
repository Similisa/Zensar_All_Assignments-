using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*1.Write a program to find the Sum and the Average points scored by the teams in the IPL. 
 * Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) 
 * that takes no.of matches as input and accepts that many scores from the user.
 * The function should then display the Average and Sum of the scores*/


namespace Assg4_1
{   
  
    class Cricket
    {
        public int sum;
        public float avg;

        public int no_of_matches;
        public void Pointscalculaton()
        {
            int[] score = new int[500];

            Console.WriteLine("Enter No. of Matches: ");
            no_of_matches = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= no_of_matches; i++)
            {
                Console.WriteLine("Enter Match {0} Score: ",i+1);
            
                score[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <= no_of_matches; i++)
            {
                sum = sum + score[i];
            }

            avg = sum /no_of_matches;
            Console.WriteLine("Sum of the scores are: "+sum);
            Console.WriteLine("Average of the scores are: " + avg);
                
        }         
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        Cricket cricket = new Cricket();

            cricket.Pointscalculaton();
            Console.Read();
        }
    }
}
