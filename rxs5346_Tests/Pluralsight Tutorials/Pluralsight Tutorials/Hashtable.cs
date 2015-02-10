using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Pluralsight_Tutorials
{
    class Hashtable
    {
        static void Main(string[] args)
        {
            System.Collections.Hashtable table = new System.Collections.Hashtable();
            table["Ryan"] = 22;
            table["Mike"] = 25;
            table["Josh"] = 15;

            Console.WriteLine("Ryan is {0} years old", table["Ryan"]);
            Console.WriteLine("ContainsKey foo? {0}", table.ContainsKey("foo"));
            Console.WriteLine("ContainsKey Ryan? {0}", table.ContainsKey("Ryan"));

            PrintCollections(table.Keys);
            PrintCollections(table.Values);
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
