using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

namespace Dynamic_Methods
{
    class DynamicMethods
    {
        static void Main(string[] args)
        {
            MethodInfo methodInfo = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) });
            DynamicMethod method = new DynamicMethod("HelloWorld", typeof(void), new Type[] { });

            ILGenerator il = method.GetILGenerator();
            il.Emit(OpCodes.Ldstr, "Hello World");
            il.Emit(OpCodes.Call, methodInfo);
            il.Emit(OpCodes.Ret);

            Action action = (Action)method.CreateDelegate(typeof(Action));
            action();

        }
    }
}
