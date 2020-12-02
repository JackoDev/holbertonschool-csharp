using System;


class Number
{
    public static int PrintLastDigit(int number)
    {
        int response = number % 10;
        if (response < 0)
            response = response * -1;
        Console.Write(response);
        return response;
    }
}
