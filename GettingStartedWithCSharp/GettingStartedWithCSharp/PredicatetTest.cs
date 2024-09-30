using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedWithCSharp
{
    class PredicatetTest
    {
        public PredicatetTest() 
        {
            Predicate<int> isEven = IsEven;
            Console.WriteLine(isEven(6));

            Predicate<string> isLowerCase = IsLowerCase;
            Console.WriteLine(isLowerCase("this is lower case string"));

            Predicate<int> isEven2 = delegate(int number) { return number % 2 == 0; }; 
            Console.WriteLine(isEven2(6));

            Predicate<string> isLowerCase2 = s=> s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase2("this is NOT lower case string"));


        }

        public bool IsEven(int number) => number % 2 == 0;
        public bool IsLowerCase(string text) => text.Equals(text.ToLower());
    }

    

}
