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

        int[] array1 = new int[size];

        if (size == 0)
        {
            Console.WriteLine();
            return array1;
        }

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
