using System;
using System.Collections.Generic;
using System.Linq;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int width = myMatrix.GetLength(0);
        int height = myMatrix.GetLength(1);
        int[,] newMatrix = new int[width, height];

        for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int square = myMatrix[i, j] * myMatrix[i, j];
                    newMatrix[i, j] = square;
                }
            }
        return newMatrix;
    }
}
