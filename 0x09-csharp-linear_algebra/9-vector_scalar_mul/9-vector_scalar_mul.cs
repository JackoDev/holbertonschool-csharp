using System;

/// <summary> Operations with matrix </summary>
class VectorMath
{
    /// <summary> Method for multiply a vector and a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] notPossible = {-1};
        if (vector.Length < 2 || vector.Length > 3)
        {
            return notPossible;
        }
        for (int x = 0; x < vector.Length; x++)
        {
            vector[x] = scalar * vector[x];
        }
        return vector;
    }
}
