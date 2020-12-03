using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
        }

        List<int> numbers = new List<int> ();
        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
        }
        for (int j = 0; j < numbers.Count; j++)
        {
            if (j < numbers.Count - 1)
                Console.Write(numbers[j] + " ");
            else
                Console.WriteLine(numbers[j]);
        }
        return numbers;
    }
}
