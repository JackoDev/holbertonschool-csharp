using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                j = i + 1;
                for (; j <= 9; j++)
                {
                    Console.Write(i);
                    Console.Write($"{j}, ");
                }
            }
            Console.WriteLine(89);
        }
    }
}
