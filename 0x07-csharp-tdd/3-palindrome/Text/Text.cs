using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> A string class </summary>
    public class Str
    {
        /// <summary> Method for returns true if found a palindrome </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            var newString = new StringBuilder();
            foreach (char c in s)
            {
                if ((!char.IsPunctuation(c)) && c != ' ')
                {
                    newString.Append(c);
                }
            }
            string s2 = newString.ToString();
            s2 = s2.ToLower();
            char[] arr = s2.ToCharArray();
            Array.Reverse(arr);

            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] == arr[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}