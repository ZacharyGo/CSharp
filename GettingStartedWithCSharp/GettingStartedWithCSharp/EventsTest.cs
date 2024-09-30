using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GettingStartedWithCSharp.EventsTest;

namespace GettingStartedWithCSharp
{
    public class EventsTest

    //Delegate and Events Test
    {
        public delegate void StringDelegate(string text);                           //Delegates

        public EventsTest()
        {

            StringDelegate stringDelegate = ToUpperCase;                            //Delegates

            WriteOutput("this is a lowercase string", stringDelegate);              //Delegates 

            //events
            Strings myString = new Strings();
            myString.stringEvent += TextChanged;

            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit")) myString.Value = str;
            } while (!str.Equals("exit"));
        }

        void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());         //Delegates
        void ToLowerCase(string text) => Console.WriteLine(text.ToLower());         //Delegates
        void TextChanged(string text) => Console.WriteLine($"You entered: {text}");

        void WriteOutput(string text, StringDelegate stringDelegate)                //Delegates
        {
            Console.WriteLine($"Before: {text}");                                   //Delegates
            stringDelegate(text);                                                   //Delegates
        }
    }

    public class Strings
    {
        private string stringValue;
        public event StringDelegate stringEvent;

        public string Value
        {
            set
            {
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            }
        }
    }
} 
