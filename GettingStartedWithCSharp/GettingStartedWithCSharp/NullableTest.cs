using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    internal class NullableTest
    {
        public NullableTest() 
        {
            Nullable<int> a = new Nullable<int>();
            int? b = null;
            int c = b ?? 0;

            Nullable<double> d = new Nullable<double>();
            double? e = null;
            double f = e ?? 0;

            Console.WriteLine($"Integer -> a: {a}m b: {b}m c:{c}");
            Console.WriteLine($"Double -> d: {d}m e: {e}m f:{f}");
        }
    }
}
