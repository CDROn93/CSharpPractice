using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading settings");
            MySettings settings = MySettings.Load();

            Console.WriteLine("MyNumber = {0}",settings.MyNumber);
            Console.WriteLine("MyString = {0}", settings.MyString);

            
            Console.WriteLine("Updating settings and saving file");
            settings.MyNumber++;
            settings.MyString = DateTime.Now.ToString();
            settings.Save();
            Console.WriteLine("Done");

        }
    }
}
