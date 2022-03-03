using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Exception Handling
 
1. Create a console application to book train tickets.Create a Passanger
    class with (Name, Age) and write a function called TicketBooking(no_of_tickets) 
    that takes no.of tickets to be booked.If the no of tickets is > 5 per booking, raise an user defined exception,
    and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". Add a Test class to call
    TicketBooking method by accepting all required details.*/


namespace Assg3._1
{

    class BookingTrainTicketException : ApplicationException
    {
        public BookingTrainTicketException(string msg) : base(msg)
        {

        }
    }
    class Passenger
    {
        string name;
        int Age;
        int no_of_Tickets;

        public void TicketBooking()
        {
            Console.WriteLine("Enter number of tickets: ");
            no_of_Tickets = Convert.ToInt32(Console.ReadLine());
            if(no_of_Tickets > 5)
            {
                throw (new BookingTrainTicketException("Cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully: ");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            try
            {
                passenger.TicketBooking();
            }
            catch(BookingTrainTicketException Be)
            {
                Console.WriteLine(Be.Message);
            }
            Console.Read();
        }
    }
}
