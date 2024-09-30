using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRecord
{
    class Record1
    {
        static CustomFullName samuel = new("Samuel", "Dackson");
        CustomFullName samuelL = new(samuel) { FirstName = "Samuel L." };
        var (firstName, _) = samuelL;
        FullName samuell = new("Samuel", "Dackson");
        FullName samuelLl = samuell with { FirstName = "Samuel L." };
        var(firstNamel, _) = samuelLl;
        Record FullName(string FirstName, string LastName);
    }

    class CustomFullName : IEquatable<CustomFullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public CustomFullName(string firstName, string lastName) =>
        (FirstName, LastName) = (firstName, lastName);
        public CustomFullName(CustomFullName other) : this(other.FirstName, other.LastName) { }
    }
}