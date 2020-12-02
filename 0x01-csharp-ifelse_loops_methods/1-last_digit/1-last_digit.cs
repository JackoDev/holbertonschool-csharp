using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int module = number % 10;

        if (module > 5)
            Console.WriteLine($"The last digit of {number} is {module} and is greater than 5");
        else if (module == 0)
            Console.WriteLine($"The last digit of {number} is {module} and is 0");
        else if ((module < 6) && !(module == 0))
            Console.WriteLine($"The last digit of {number} is {module} and is less than 6 and not 0");
    }
}