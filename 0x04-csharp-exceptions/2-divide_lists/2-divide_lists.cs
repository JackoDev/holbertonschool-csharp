using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int i, total;
        List<int> newList = new List<int>();
        for (i = 0; i < listLength; i++)
        {
            try
            {
                total = list1[i]/list2[i];
                newList.Add(total);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                total = 0;
                newList.Add(total);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");  
            }
        }
        return newList;
    }
}
