using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            {
                string hexa = Convert.ToString(i, 16);
                Console.Write("{0} = 0x{1}\n", i, hexa);
            }
        }
    }