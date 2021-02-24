using System;
using System.Collections;
    
/// <summary> Operations with matrix </summary>
class MatrixMath
{
    /// <summary> Method for calculate inverse of a 2D matrix </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 &&
            (matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]) != 0)
        {
            double[,] inverseMat = new double[,] {
                {matrix[1, 1], (-1)*matrix[0, 1]},
                {(-1)*matrix[1, 0], matrix[0, 0]}
            };
            double detInverMat = 1/(matrix[0, 0]*matrix[1, 1] - matrix[0, 1]*matrix[1, 0]);

            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    inverseMat[row, col] = Math.Round(detInverMat*inverseMat[row, col], 2);
                }
            }
            return inverseMat;
        }
        return new double[,] {{-1}};
    }
}