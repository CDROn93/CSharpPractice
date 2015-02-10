using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedList
{
    class SortedList
    {
        static void Main(string[] args)
        {
            //very similar as hashtable
            //sorted list has two arrays behind it, keys and values,  keys is sorted so that values is to
            System.Collections.SortedList table = new System.Collections.SortedList();
            table["Ryan"] = 22;
            table["Mike"] = 25;
            table["Josh"] = 15;

            Console.WriteLine("Ryan is found at index {0}", table.IndexOfKey("Ryan"));
            Console.WriteLine("Mike is found at index {0}", table.IndexOfKey("Mike"));
            Console.WriteLine("Josh is found at index {0}", table.IndexOfKey("Josh"));

            Console.WriteLine("Ryan is {0} years old", table["Ryan"]);
            Console.WriteLine("ContainsKey foo? {0}", table.ContainsKey("foo"));
            Console.WriteLine("ContainsKey Ryan? {0}", table.ContainsKey("Ryan"));

        }
    }
}
