using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int heigth = 5;
            int [,] newArray = new int[width, heigth];

            newArray[2, 2] = 1;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    if (j < heigth - 1)
                        Console.Write(newArray[i, j] + " ");
                    else
                        Console.WriteLine(newArray[i, j]);
                }
            }
        }
    }
}