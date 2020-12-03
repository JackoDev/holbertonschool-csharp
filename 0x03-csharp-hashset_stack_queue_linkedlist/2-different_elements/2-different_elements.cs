using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        for(int i = 0; i < list1.Count; i++)
        {
            if (list2.Contains(list1[i]) == false)
                newList.Add(list1[i]);
            else
                continue;
        }
        for(int j = 0; j < list2.Count; j++)
        {
            if (list1.Contains(list2[j]) == false)
                newList.Add(list2[j]);
            else
                continue;
        }
        newList.Sort();
        return newList;
    }
}