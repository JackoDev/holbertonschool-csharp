using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> A string class </summary>
    public class Str
    {
        /// <summary> Returns the first unique character </summary>
        public static int UniqueChar(string s)
        {
            string str1 = "";
            string str2 = "";

            if (s == "" || s == null)
                return -1;

            int rep = 0;
            for (int i = 0; i < s.Length; i++)
            {
                str1 = s.Substring(i, 1);
                int indexMin = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    str2 = s.Substring(j, 1);
                    if ((str1 == str2) && (i != j))
                        continue;
                    else if ((str1 != str2) && (i != j))
                    {
                        indexMin++;
                        if (indexMin == s.Length - 1 && rep < indexMin)
                        {
                            rep = indexMin;
                            return(i);
                        }
                    }
                }
            }
            return -1; 
        }
    }
}