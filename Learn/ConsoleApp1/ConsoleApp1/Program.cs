using System.Text;

CustomMononym aristotle = new("Aristotle");
CustomFullName samuel = new("Samuel", "Jackson");
CustomFullName samuelL = new(samuel) { FirstName = "Samuel L." };
var (firstName, _) = samuelL;
Mononym aristotlel = new("Aristotle");
FullName samuell = new("Samuel", "Dackson") { MiddleNames = "Leroy"};
FullName samuelLl = samuell with { MiddleNames = "Leroy" };

var (firstNamel, _) = samuelLl;

abstract record Name;

record Mononym(string FirstName) : Name
{
    public string FirstName { get; set; } = FirstName;
    protected override bool PrintMembers(StringBuilder builder)
    {
        if (base.PrintMembers(builder)) builder.Append(' ');
        builder.Append(FirstName);
        return true;
    }
}

record FullName(string FirstName, string LastName) : Name
{
    public string MiddleNames { get; set; } = string.Empty;
}

class CustomMononym
{
    public string FirstName { get; init; }
    public CustomMononym(string firstName) => FirstName = firstName;

}

    class CustomFullName : IEquatable<CustomFullName>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public CustomFullName(string firstName, string lastName) =>
            (FirstName, LastName) = (firstName, lastName);

        public CustomFullName(CustomFullName other) : this(other.FirstName, other.LastName) { }

        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (FirstName, LastName);

        public override bool Equals(object? other) => Equals(other as CustomFullName);


        public bool Equals(CustomFullName? other) =>
            other is not null &&
            other.FirstName == FirstName &&
            other.LastName == LastName;
        public override int GetHashCode() => HashCode.Combine(FirstName, LastName);

        public static bool operator ==(CustomFullName? left, CustomFullName? right) =>
            left is null ? right is null : left.Equals(right);
        public static bool operator !=(CustomFullName? left, CustomFullName? right) =>
            !(left == right);

        public override string ToString() =>
            $"{typeof(CustomFullName).Name} {{ {nameof(FirstName)} = {FirstName}, {nameof(LastName)} = {LastName} }}";
    }
}

