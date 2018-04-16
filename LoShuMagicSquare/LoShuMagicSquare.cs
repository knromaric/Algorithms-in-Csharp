using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoShuMagicSquare
{
    class LoShuMagicSquare
    {
        private static int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine(counter);
                SwitchCells();

            } while (!IsMagicSquare());

            DisplayBoard(numbers);
            Console.WriteLine($"Number of attempt: {counter}");
        }

        private static void DisplayBoard(int[,] numbers)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsMagicSquare()
        {
            var tempSum = numbers[0, 0] + numbers[0, 1] + numbers[0, 2];

            // check that the sum of elements on each ROW is equal to tempsum
            for(var i=1; i<3; i++)
            {
                if (numbers[i, 0] + numbers[i, 1] + numbers[i, 2] != tempSum)
                    return false;
            }

            // check that the sum of elements on each COLUMN is equal to tempsum
            for (int i = 0; i < 3; i++)
            {
                if (numbers[0, i] + numbers[1, i] + numbers[2, i] != tempSum)
                    return false;
            }

            //check that the sum of elements on each DIAGONAL is equal to tempsum

            return numbers[0, 0] + numbers[1, 1] + numbers[2, 2] != tempSum &&
                numbers[2, 0] + numbers[1, 1] + numbers[0, 2] != tempSum;
        }

        private static void SwitchCells()
        {
            int[] indexFirstpos = new int[2];
            int[] indexSecondPos = new int[2];

            indexFirstpos[0] = rand.Next(0, 3);
            indexFirstpos[1] = rand.Next(0, 3);
            indexSecondPos[0] = rand.Next(0, 3);
            indexSecondPos[1] = rand.Next(0, 3);

            int temp = numbers[indexFirstpos[0], indexFirstpos[1]];
            numbers[indexFirstpos[0], indexFirstpos[1]] = numbers[indexSecondPos[0], indexSecondPos[1]];
            numbers[indexSecondPos[0], indexSecondPos[1]] = temp;
        }
    }
}
