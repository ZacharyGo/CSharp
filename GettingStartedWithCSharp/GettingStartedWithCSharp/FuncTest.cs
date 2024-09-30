using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    internal class FuncTest
    {
        public FuncTest()
        {
            Func<double, double> square = Square;
            Console.WriteLine($"Square:{square(2)}");
            Func<double, double> cube = Cube;
            Console.WriteLine($"Cube:{cube(2)}");
            Func<double> two = Two;
            Console.WriteLine($"Two:{two()}");


            Func<double, double> square2 = delegate(double value) { return value * value; };
            Console.WriteLine($"square2:{square2(2)}");

            // Using Lambda
            Func<double, double> cube2 = (double value) => value * value * value;
            Console.WriteLine($"cube2:{cube2(2)}");



        }
        double Square(double number) => Math.Pow(number, 2);
        double Cube(double number) => Math.Pow(number, 3);

        double Two() => 2;

        static void Show() => Console.WriteLine("Hello There,  cannot use Show in Func since it doesn't have return value");

    }
}
