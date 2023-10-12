using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            //Taking input from user
            Console.WriteLine("Enter the number to print Fibonacci Series");
            int neo = Convert.ToInt32(Console.ReadLine());

            //Declare three variable
            int firstTerm = 0;
            int secondTerm = 1;
            int nextTerm;

            Console.WriteLine("Fibonacci Series Sequence strat from: " + firstTerm + "" + secondTerm);

            for (int i = 2; i < neo; i++)
            {
                nextTerm = firstTerm + secondTerm;
                Console.WriteLine(nextTerm);
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
