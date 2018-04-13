using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" please enter the nth value as integer: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Factorial(loop V1) of {number} is : {FactorialUsingLoopV1(number)} ");
            Console.WriteLine($"The Factorial(loop V2) of {number} is : {FactorialUsingLoopV2(number)} ");
            Console.WriteLine($"The Factorial(recursion) of {number} is : {FactorialUsingRecursion(number)} ");

        }

        private static int FactorialUsingLoopV1(int numb)
        {
            int factorial = 1;
            for (int i = numb; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int FactorialUsingLoopV2(int numb)
        {
            int factorial = numb;
            for (int i = 1; i < numb; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private static int FactorialUsingRecursion(int numb)
        {
            if (numb < 2)
                return 1;
            else
                return numb * FactorialUsingRecursion(numb - 1);
        }
    }
}
