using System;

namespace TowerOfHanoi
{
    class TowerOfHanoi
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            var disc = 0;
            Console.Write("Enter the number of disc : ");
            disc = Convert.ToInt32(Console.ReadLine());
            Tower(disc, 1, 2, 3);
            Console.WriteLine("Number of steps is : " + counter);
        }

        private static void Tower(int n, int sourcePeg, int destinationPeg, int sparePeg)
        {
            if(n == 1)
            {
                Console.WriteLine(sourcePeg + "->" + destinationPeg);
                counter++; 
            }
            else
            {
                Tower(n - 1, sourcePeg, sparePeg, destinationPeg);
                Console.WriteLine(sourcePeg + "->" + destinationPeg);
                counter++;
                Tower(n - 1, sparePeg, destinationPeg, sourcePeg);
                
            }
        }
        
    }
}
