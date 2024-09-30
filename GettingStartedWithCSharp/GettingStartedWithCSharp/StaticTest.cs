using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    public class StaticTest
    {
        public StaticTest()
        {
            StaticClass.StaticMethod();
            Console.WriteLine(StaticClass.staticString);
        }
    }

    public static class StaticClass
    {
        public static string staticString = "Static String";
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
