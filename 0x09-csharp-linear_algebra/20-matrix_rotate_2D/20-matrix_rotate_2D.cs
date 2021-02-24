using System;

/// <summary> Operations with matrix </summary>
class MatrixMath
{
    /// <summary> Method for multiply two matrix </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] notPossible = {{-1}};
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return notPossible;
        }
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] newMatrix = new double[rows1, cols2];
        for (int x = 0; x < rows1; x++)
        {
            for (int y = 0; y < cols2; y++)
            {
                double n = 0; 
                for (int z = 0; z < cols1; z++)
                {
                    n = n + matrix1[x, z] * matrix2[z, y];
                }
                newMatrix[x, y] = n;
            }
        }
        return newMatrix;
    }

    /// <summary> Method for rotate a matrix </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double angleCos = Math.Cos(angle);
        double angleSin = Math.Sin(angle);
        double[,] cosSin = {
            {angleCos, -angleSin}, 
            {angleSin, angleCos}
            };
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] notPossible = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return notPossible;
        }
        newMatrix = Multiply(cosSin, matrix);
        return newMatrix;
    }
}