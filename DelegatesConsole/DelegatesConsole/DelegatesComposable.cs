using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsole
{
    public delegate void MyDelegateComposable(int arg1, int arg2);

    class DelegatesComposable
    {
        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number from func1 is: " + result);
        }
        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number from func2 is: " + result);
        }


        public void Execute()
        {
            MyDelegateComposable f1 = func1;
            MyDelegateComposable f2 = func2;
            // Create a composed delegate from f1 and f2
            MyDelegateComposable f1f2 = f1 + f2;

            int a = 10;
            int b = 20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(a, b);
            Console.WriteLine("Calling the second delegate");
            f2(a, b);
            // Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");
            f1f2(a, b);

            // subtract off one of the delegates
            Console.WriteLine("\nCalling the unchained delegates");
            f1f2 -= f1;
            f1f2(b, b);
        }
    }
}
