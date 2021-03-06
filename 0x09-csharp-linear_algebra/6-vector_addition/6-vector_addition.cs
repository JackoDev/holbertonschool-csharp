﻿  
using System;

/// <summary> Operations with matrices </summary>
class VectorMath
{
    /// <summary> Method for adds two vectors </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] notPossible = {-1};
        if (vector1.Length != vector2.Length)
        {
            return notPossible;
        }
        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length > 3 || vector2.Length > 3)
        {
            return notPossible;
        }
        double[] newVec = new double[vector1.Length];
        for (int x = 0; x < vector1.Length; x++)
        {
            newVec[x] = vector1[x] + vector2[x];
        }
        return newVec;
    }
}
