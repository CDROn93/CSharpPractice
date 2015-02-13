using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace GenericsCollections
{
    class Program
    {
        static int ITERATIONS = 10000000;
        static void Main(string[] args)
        {
            Rabbit r1 = new Rabbit { Name = "Fluiffy" };
            Rabbit r2 = new Rabbit { Name = "Muffin" };

            //List<Rabbit> list = new List<Rabbit>();
            //list.Add(r1);

            Dictionary<string, Rabbit> rabbits = new Dictionary<string, Rabbit>();
            rabbits.Add(r1.Name, r1);
            rabbits.Add(r2.Name, r2);

            Rabbit result = rabbits["Fluiffy"]; //quick look up 

            //can also use HashSet<t>
                //List<t>
                //Queue<t>
                //Stack<t>
                //Dictionary<tKey,tValue>

            long arrayListTime = CalulcateSumOnArrayList();
            long listTime = CalulcateSumOnListOfInt();
            Console.WriteLine("Arraylist took {0}ms, List<int> took{1}ms",arrayListTime,listTime);

        }
        private static long CalulcateSumOnArrayList()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            ArrayList list = new ArrayList();
            for (int i = 0; i < ITERATIONS; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                int value = (int)list[i];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
        private static long CalulcateSumOnListOfInt()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> list = new List<int>();
            for (int i = 0; i < ITERATIONS; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                int value = (int)list[i];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
