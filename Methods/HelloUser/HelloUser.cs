// 1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
// Write a program to test this method.

namespace HelloUser
{
    using System;
    using System.Linq;

    internal class HelloUser
    {
        private static void Main()
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            SaluteTheUser(name);
        }

        private static void SaluteTheUser(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}