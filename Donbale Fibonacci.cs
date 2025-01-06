using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pleas enter a number");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);

            Console.WriteLine("Your number in fibonacci is: " + result);
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
