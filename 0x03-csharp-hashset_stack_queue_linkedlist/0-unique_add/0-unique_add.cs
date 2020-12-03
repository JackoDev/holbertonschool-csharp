using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int suma = 0;
        List<int> newList = new HashSet<int>(myList).ToList();
        for (int i = 0; i < newList.Count; i++)
        {
            suma = suma + newList[i];
        }
        return suma;
    }
}
