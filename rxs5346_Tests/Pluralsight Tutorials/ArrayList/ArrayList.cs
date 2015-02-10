using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayList
{
    class ArrayList
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add("World");
            list.Add("Hello");

            Console.WriteLine("Count {0}",list.Count);
            Console.WriteLine("Capacity {0}",list.Capacity);
            //can set capacuty when list is created also 

            list.Sort();
            PrintCollections(list);
            Console.WriteLine("list[0] = {0}",list[0]);
            Console.WriteLine("list[1] = {0}", list[1]);

            Console.WriteLine("Contains Hello {0}",list.Contains("Hello")); //must walk through each item in the array to do a comparison

            list.BinarySearch("Hello"); //list must be sorted first, much faster than contains search 
        }
        private static void PrintCollections(IEnumerable collection)
        {
            foreach (object obj in collection)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
