using System;


namespace RollOfDice
{
    class RollOfDice
    {
        static void Main(string[] args)
        {
            var die1 = new Die();
            var die2 = new Die();

            int[] stats = new int[13];
            int[,] rolls = new int[7, 7];
            Console.WriteLine("Pleae enter how many times you want to roll the dice : ");
            var n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                var die1Value = die1.DieRoll();
                var die2Value = die2.DieRoll();
                rolls[die1Value, die2Value] += 1; 
                var sum = die1Value + die2Value;
                stats[sum] += 1; 
            }

            //display sums 
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine($"Sum of {i} occured {stats[i]} times");
            }

            //matrix display
            Console.WriteLine();
            Console.WriteLine("\t1\t2\t3\t4\t5\t6");
            Console.WriteLine(" -------------------------------------------------------- ");
            for (int row = 1; row < 7; row++)
            {
                Console.Write(row);
                for (int column = 1; column < 7; column++)
                {
                    Console.Write("\t" + rolls[row, column]);
                }
                Console.WriteLine();
            }

        }
    }
}
