using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string nameKey = "0";
        if (myList.Count <= 0)
        {
            return "None";
        }

        foreach (KeyValuePair<string, int> pair in myList)
        {
            int maxVal = myList.Values.Max();
            if (pair.Value == maxVal)
            {
                nameKey = pair.Key;
            }
        }
        return nameKey;
    }
}
