using System;

namespace BasicCSharp.Common
{
    internal class Name
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public static implicit operator Name(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            string[] parts = name.Split(
                new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                string message = string.Format(
                    "Cannot recognize \"{0}\" as a name.",
                    name);
                throw new FormatException(message);
            }

            string firstName = parts[0];
            string lastName = parts[1];

            return new Name(firstName, lastName);
        }

        public static implicit operator string(Name name)
        {
            return name == null ? null : name.ToString();
        }
    }
}