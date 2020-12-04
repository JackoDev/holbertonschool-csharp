using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int size = aStack.Count;

        Console.WriteLine("Number of items: " + size);

        if (size <= 0)
            System.Console.WriteLine("Stack is empty");
        else
        {
            string topItem = aStack.Peek();
            System.Console.WriteLine("Top item: " + topItem);
        }

        if (aStack.Contains(search))
            Console.WriteLine($"Stack contains {search}: True");
        else
            Console.WriteLine($"Stack contains {search}: False");


        if (aStack.Contains(search))
        {
            while(aStack.Contains(search))
            {
                aStack.Pop();
            }
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}
