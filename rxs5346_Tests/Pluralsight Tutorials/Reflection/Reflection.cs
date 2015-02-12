using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;


namespace Reflection
{
    public class Animal
    {
        [Required]
        public string Name { get; set; }
    }
    class Reflection
    {
        static void Main(string[] args)
        {
            var type = typeof(Reflection);
            var members = type.GetMembers(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var memberInfo in members)
            {
                Console.WriteLine(memberInfo.Name);
            }
            Console.WriteLine("BREAK");

            //this isnt working like the demo... should return required for name
            //Type type2 = typeof(Animal);
            PropertyInfo propertyInfo = type.GetProperty("Name");
            object[] attributes = propertyInfo.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }
    }
}
