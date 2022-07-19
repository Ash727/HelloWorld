using System;
namespace Methods.ANewPath
{
    public class Path2
    {
        public Path2()
        {
        }

        public static (string, string) GetFullName()
        {
            string? firstName, lastName;
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            return (firstName, lastName);
        }
    }
}

