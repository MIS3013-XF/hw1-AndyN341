// HW1a Sales Total

// Your Name: Andy Nguyen
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FootBallTicket;
            double NumOfTick;
            double PriceOfTick;
            double SubTotal;
            double SalesTax;
            const double Tax = 0.085;
            double Total;

            string NumOfTickAsString;
            string PriceOfTickAsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            FootBallTicket = Console.ReadLine();

            Console.WriteLine("How many Football Ticket's do you want to buy?");
            NumOfTickAsString = Console.ReadLine();

            NumOfTick = Convert.ToDouble(NumOfTickAsString);

            Console.WriteLine("What is the price for each football Ticket?");
            PriceOfTickAsString = Console.ReadLine();

            PriceOfTick = Convert.ToDouble(PriceOfTickAsString);

            SubTotal = NumOfTick * PriceOfTick; 
            Console.WriteLine("Your subtotal for your bill is " + "$" + SubTotal.ToString("N2") + ".");

            SalesTax = SubTotal * Tax;
            Console.WriteLine("Your sales tax for your bill is " + "$" + SalesTax.ToString("N2") + ".");

            Total = SubTotal + SalesTax;
            Console.WriteLine("Your total for your bill is " + "$" + Total.ToString("N2") + ".");


        }
    }
}
