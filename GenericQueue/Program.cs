using System;
using System.Collections.Generic;
public class QueueGen
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("deleting elements");
        queue.Dequeue();
        foreach (var item in queue)
        {
            Console.WriteLine(item);

        }
    }
}
