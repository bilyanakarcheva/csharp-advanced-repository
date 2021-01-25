using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int currSumOfSubMatrix = 0;
            int maxSum = int.MinValue;
            int currRow = 0;
            int currCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currSumOfSubMatrix = matrix[row, col]
                        + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currSumOfSubMatrix > maxSum)
                    {
                        maxSum = currSumOfSubMatrix;
                        currRow = row;
                        currCol = col;
                    }
                }

                currSumOfSubMatrix = 0;
            }

            Console.WriteLine($"{matrix[currRow, currCol]} {matrix[currRow, currCol + 1]} ");
            Console.WriteLine($"{matrix[currRow + 1, currCol]} {matrix[currRow + 1, currCol + 1]} ");
            Console.WriteLine(maxSum);
        }
    }
}
