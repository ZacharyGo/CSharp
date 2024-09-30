using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    internal class ActionTest
    {
        public ActionTest()
        {
            Action<double> square = Square;
            square(4);
            Action<double> cube = Cube;
            cube(2);
            Action two = Two;
            two(); 

            Action show = Show;
            show();
            
        }

        void Square(double number) => Console.WriteLine(Math.Pow(number, 2));
        void Cube(double number) => Console.WriteLine(Math.Pow(number, 3));

        void Two() => Console.WriteLine(2);

        static void Show() => Console.WriteLine("Hello There");
    }
}
