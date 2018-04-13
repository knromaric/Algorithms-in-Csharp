using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Fibonacci loop solution --------------");
            Console.WriteLine();

            FibonacciLoop(15);

            Console.WriteLine();
            Console.WriteLine("------------------Fibonacci recursive solution --------------");
            for (int i = 0; i <= 15; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
            
        }

        private static int FibonacciRecursive(int numb)
        {
            if (numb <= 1)
                return 1;
            return FibonacciRecursive(numb-2) + FibonacciRecursive(numb - 1);
        }

        private static void FibonacciLoop(int n)
        {
            var number1 = 0;
            var number2 = 1;
            Console.Write(number1 + " ");
            Console.Write(number2 + " ");

            for (int i = 0; i <= 15; i++)
            {
                var next = number1 + number2;
                number1 = number2;
                number2 = next;
                Console.Write(next+ " ");
            }

        }
    }
}
