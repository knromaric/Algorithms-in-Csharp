using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------For Loop solution ------------ ");
            FizzBuzzLoop(); 
            Console.WriteLine();

            Console.WriteLine("--------------Recursive solution ------------ ");
            FizzBuzzRecursive(100);
        }

        private static void FizzBuzzLoop()
        {
            int number = 100;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");

                Console.WriteLine(i);

            }
        }

        private static void FizzBuzzRecursive(int n)
        {
            string text = "";
            if (n < 1)
                return;

            if (n % 3 == 0 && n % 5 == 0)
                text = "FizzBuzz";
            else if (n % 3 == 0)
                text = "Fizz";
            else if (n % 5 == 0)
                text = "Buzz";
            else
                text = n.ToString();
                
            Console.WriteLine(text);
            FizzBuzzRecursive(n - 1);

        }
    }
}
