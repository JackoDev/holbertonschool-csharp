using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] matrix1 = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };
        for (int i = 0; i < matrix1.Length; i++)
        {
            for (int j = 0; j < matrix1[i].Length; j++)
                Console.Write("{0}{1}", matrix1[i][j], j == (matrix1[i].Length -1) ? "" : " ");
            Console.WriteLine();
        }
        }
    }
}
