using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    public class PartialClass
    {
        public PartialClass()
        {
            HelloClass helloClass = new HelloClass();
            helloClass.HelloWorld();
            helloClass.HelloUniverse();

        }
    }

    public partial class HelloClass
    {
        string helloUniverse = "Hello Universe";
        public void HelloWorld() => Console.WriteLine(helloWorld);
    }

    public partial class HelloClass
    {
        string helloWorld = "Hello World";

        public void HelloUniverse() => Console.WriteLine(helloUniverse);
    }
}
