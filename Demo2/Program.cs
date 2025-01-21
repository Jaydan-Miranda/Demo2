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

            Console.WriteLine("Please enter an even or odd integer. ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            //is the end of the code
            Console.ReadLine();
        }
    }
}
