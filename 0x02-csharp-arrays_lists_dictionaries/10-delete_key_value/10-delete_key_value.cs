using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (!myDict.ContainsKey(key)){
            myDict.Add(key, value);
        }
        else {
            myDict[key] = value;
        }
        return myDict;
    }
}
