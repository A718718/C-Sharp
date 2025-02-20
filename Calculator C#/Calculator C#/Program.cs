using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Calculator!");
        Console.WriteLine("Available operations: + (add), - (subtract), * (multiply), / (divide)");

        while (true)
        {
            Console.Write("Enter the first number (or type 'exit' to quit): ");
            string input1 = Console.ReadLine();

            // Exit condition
            if (input1.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            double num1;
            if (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            double num2;
            if (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                continue;
            }

            double result = 0;
            bool isValidOperation = true;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        isValidOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation! Please use one of the following: +, -, *, /");
                    isValidOperation = false;
                    break;
            }

            if (isValidOperation)
            {
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            }
        }
    }
}