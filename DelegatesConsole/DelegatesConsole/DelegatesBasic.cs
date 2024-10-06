using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsole
{
    // declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public string instanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }


    class DelegatesBasic
    {
        // TODO: Create functions to serve as delegate implementations
        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }
        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }

        public void Execute()
        {
            MyDelegate f = func1;
            Console.WriteLine("func1 - The number is: " + f(10, 20));
            f = func2;
            Console.WriteLine("func2 - The number is: " + f(10, 20));

            MyClass mc = new MyClass();
            f = mc.instanceMethod1;
            Console.WriteLine("MyClass. instanceMethod1 - The number is: " + f(10, 20));
        }
    }
}
