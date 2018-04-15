using System;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static bool[] allNumber;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 'n' : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var arrSize = n + 1;
            CreateArray(arrSize);
            Console.WriteLine();
            Console.WriteLine($"Displaying primes numbers between 0 and {n} :");
            Sieve(arrSize);
        }

        static void Sieve(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (allNumber[i])
                {
                    for(int c = i; i * c < n; c++)
                    {
                        allNumber[i * c] = false;  
                    }
                }
            }
            var counter = 0;
            for (int i = 2; i < n; i++)
            {
                if (allNumber[i])
                {
                    Console.Write(i + " ");
                    counter++;
                }
                if(counter == 10)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            Console.WriteLine();
        }
        static void CreateArray(int n)
        {
            allNumber = new bool[n];
            for (int i = 0; i < n; i++)
            {
                allNumber[i] = true;
            }
        }
    }
}
