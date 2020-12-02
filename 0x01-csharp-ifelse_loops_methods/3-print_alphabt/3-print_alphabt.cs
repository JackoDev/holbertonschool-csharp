using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 26; i++) 
                { 
                    if ((i + 97) == 101 || (i + 97) == 113)
                        continue;
                    else
                        Console.Write(Convert.ToChar(i + 97));
                } 
        }
    }
}
