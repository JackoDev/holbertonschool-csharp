﻿  
using System;
using System.Collections;
    
/// <summary> Operations with matrix </summary>
class MatrixMath
{
    /// <summary> Method for transpose a matrix </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return new double[,] {};

        double[,] transposeMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                transposeMatrix[col, row] = Math.Round(matrix[row, col], 2);
            }
        }
        return transposeMatrix;
    }
}
