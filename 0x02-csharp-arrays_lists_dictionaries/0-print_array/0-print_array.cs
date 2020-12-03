using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
            Console.WriteLine();
        
        int[] array1 = new int[size];
        for (int i = 0; i < size - 1; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine(size - 1);
        return array1;
    }
}
