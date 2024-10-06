using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsole
{
    public delegate string MyDelegateAnonymous(int arg1, int arg2);

    class DelegatesAnonymous
    {
        public void Execute()
        {
            // Implement an anonymous delegate
            MyDelegateAnonymous f = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };
            Console.WriteLine("The number is: " + f(10, 20));
        }

    }
}
