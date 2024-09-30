namespace ConsoleRecord
{
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);
    public record Person2(string FirstName, string LastName)
    {
        public required string[] PhoneNumbers { get; init; }
    }


    public static class Program
    {
        public static void Main()
        {
            var phoneNumbers = new string[2];
            phoneNumbers[0] = "555-1234";
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            
            phoneNumbers[0] = "261-5111";
            Person person2 = new("Nancy", "Davolio", phoneNumbers);

            Console.WriteLine(person1 == person2); // output: True
            Console.WriteLine(ReferenceEquals(person1, person2));// output: False
            
            person1.PhoneNumbers[0] = "555-1234";
            person2.PhoneNumbers[0] = "261-5111";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
            person2 = person1;
            Console.WriteLine(ReferenceEquals(person1, person2)); // output: True

            Console.WriteLine("------------------");
            Person2 person21 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person21);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            Person2 person22 = person21 with { FirstName = "John" };
            Console.WriteLine(person22);
            // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person21 == person22); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }

    }
}
