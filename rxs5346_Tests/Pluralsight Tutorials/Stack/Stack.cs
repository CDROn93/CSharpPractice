using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Stack
    {
        static void Main(string[] args)
        {
            System.Collections.Stack stack = new System.Collections.Stack();
            stack.Push("Fine");
            stack.Push("Does");
            stack.Push("Boy");
            stack.Push("Good");
            stack.Push("Every");

            Console.WriteLine("Peek returns {0}",stack.Peek());
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


        }
    }
}
