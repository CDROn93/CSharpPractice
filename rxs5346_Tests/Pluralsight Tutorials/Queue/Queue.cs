using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            System.Collections.Queue queue = new System.Collections.Queue();
            queue.Enqueue("Fine");
            queue.Enqueue("Does");
            queue.Enqueue("Boy");
            queue.Enqueue("Good");
            queue.Enqueue("Every");

            Console.WriteLine("Peek returns {0}", queue.Peek());
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }
    }
}
