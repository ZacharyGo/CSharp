using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Records1
    {
        CustomFullName samuel = new("Samuel", "Jackson");

        static FullName samuel1 = new("Samuel", "Jackson");
        FullName samuelL1 = samuel1 with { FirstName = "Samuel L." };


        record FullName(string FirstName, string LastName);
        class CustomFullName
        {
            public string FirstName { get; init; } 
            public string LastName { get; init; }

            public CustomFullName(string firstName, string lastName) =>
                (FirstName, LastName) = (firstName, lastName);
        }
        
    }

    

    
}
