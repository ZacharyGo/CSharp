using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    class GenericsTest
    {
        public GenericsTest() { 
            Test<string> firstTest = new Test<string>();
            firstTest.Value = "This is a string";
            firstTest.Details();
            Test<int> secondTest = new Test<int>();
            secondTest.Value = 5;
            secondTest.Details();
        }
    }
    public class Test<T>
    {
        public T Value { get; set; }
        public void Details() => Console.WriteLine($"Parameter Type : {typeof(T)},  Value : {Value}");
    }
}
