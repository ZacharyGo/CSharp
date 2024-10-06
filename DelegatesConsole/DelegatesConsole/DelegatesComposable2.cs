using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsole
{
    // declare the delegate type
    public delegate void MyDelegatesComposable2(int arg1, ref int arg2);
    
    internal class DelegatesComposable2
    {
        void func1(int arg1, ref int arg2)
        {
            string result = (arg1 + arg2).ToString();
            arg2 += 20;
            Console.WriteLine("The number is: " + result);
        }
        void func2(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }
        public void Execute()
        {
            MyDelegatesComposable2 f1 = func1;
            MyDelegatesComposable2 f2 = func2;
            // Create a composed delegate from f1 and f2
            MyDelegatesComposable2 f1f2 = f1 + f2;

            int a = 10;
            int b = 20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(a, ref b);
            Console.WriteLine("Calling the second delegate");
            f2(a, ref b);
            // Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");
            f1f2(a, ref b);
        }
    }
}
