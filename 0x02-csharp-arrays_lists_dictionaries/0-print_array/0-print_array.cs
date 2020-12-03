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

        for (int i = 0; i < size; i++)
        {
            array1[i] = i;
            if ( i < size - 1)
                Console.Write($"{i} ");
            else
                Console.WriteLine(size - 1);
        }
        return array1;
    }
}
