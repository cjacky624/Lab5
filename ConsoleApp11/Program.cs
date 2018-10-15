using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer between 1 to 10");


                long numberFactorial = long.Parse(Console.ReadLine());
                long result = numberFactorial;

                for (long i = 1; i < numberFactorial; i++)
                {
                    result = result * i;
                    Console.WriteLine("{0}*{1}", numberFactorial, i);

                    Console.WriteLine(result);


                }

                Console.WriteLine("Would you like to continue calculating fractorials? (Y/N)");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "N")
                {
                    break;
                }
            }
        }
    }
}
