using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyFirstProgram!");
            Console.WriteLine("This is my first C# program.");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}! Nice to meet you.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}