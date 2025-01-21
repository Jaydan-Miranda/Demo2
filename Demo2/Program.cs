using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prints the prompt for user to enter a input
            Console.WriteLine("Please enter an integer. ");

            //creates the variable "number" and converts the user input to an integer
            int number = Convert.ToInt32(Console.ReadLine());

            //if the number is divisible by 2, it is even
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            //if the number is not divisible by 2, it is odd
            else
            {
                Console.WriteLine("The number is odd.");
            }

            //is the end of the code and allows user to view results
            Console.ReadLine();
        }
    }
}
