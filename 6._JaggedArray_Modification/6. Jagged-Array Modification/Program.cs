using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] col = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                jaggedArray[row] = col;
            }

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (!command.Contains("END"))
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row >= jaggedArray.Length || col >= jaggedArray[row].Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command.Contains("Add"))
                    {
                        jaggedArray[row][col] += value; 
                    }
                    else if (command.Contains("Subtract"))
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split(' ').ToArray();

            }

            for (int row = 0; row < matrixRows; row++)
            {
                Console.WriteLine(String.Join(' ',jaggedArray[row])); 
            }
        }
    }
}
