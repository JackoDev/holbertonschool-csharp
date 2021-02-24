using System;

/// <summary> Operations with matrix </summary>
class VectorMath
{
    /// <summary> Method for find the lenght of a vector </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double res = 0;
        double vecLen = new double();
        foreach (double x in vector)
        {
            double sqrt = Math.Pow(x, 2);
            res = res + sqrt;
        }
        vecLen = Math.Sqrt(res);
        return Math.Round(vecLen, 2); 
    }
}