using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        
        int[] array1 = new int[size];

        for (int i = 0; i < size - 1; i++)
        {
            if ( i + 1 == size)
                Console.WriteLine(size - 1);
            else
                Console.Write($"{i} ");
        }
        return array1;
    }
}
