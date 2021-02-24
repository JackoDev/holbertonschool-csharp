  
using System;

/// <summary> Operation with matrix </summary>
class VectorMath
{
    /// <summary> Method for calculate the cross product of two 3D vectors </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1 is double[] && vector1 is double[] &&
            vector1.Length == 3 && vector1.Length == vector2.Length)
        {
            double[] crossProduct = new double[]
            {
                vector1[1]*vector2[2] - vector1[2]*vector2[1],
                vector1[2]*vector2[0] - vector1[0]*vector2[2],
                vector1[0]*vector2[1] - vector1[1]*vector2[0]
            };
            return crossProduct;
        }
        return new double[] {-1};
    }
}
