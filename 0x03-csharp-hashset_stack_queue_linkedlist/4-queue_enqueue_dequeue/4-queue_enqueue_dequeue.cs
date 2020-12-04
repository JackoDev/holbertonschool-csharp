using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int size = aQueue.Count;

        Console.WriteLine("Number of items: " + size);

        if (size <= 0)
            System.Console.WriteLine("Queue is empty");
        else
        {
            string topItem = aQueue.Peek();
            System.Console.WriteLine("First item: " + topItem);
        }

        aQueue.Enqueue(newItem);

        if (aQueue.Contains(search))
            Console.WriteLine($"Queue contains \"{search}\": True");
        else
            Console.WriteLine($"Queue contains \"{search}\": False");


        if (aQueue.Contains(search))
        {
            while(aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }

        return aQueue;
    }
}