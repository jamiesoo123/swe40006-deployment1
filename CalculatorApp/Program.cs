using System;
using CalculatorOperations;
using InputValidation;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                if (!Validator.IsValidChoice(choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    Console.WriteLine();
                    continue;
                }

                if (choice == "5")
                {
                    Console.WriteLine("Calculator closed.");
                    break;
                }

                double number1;

                while (true)
                {
                    Console.Write("Enter first number: ");
                    string input = Console.ReadLine();

                    if (Validator.IsValidNumber(input, out number1))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                double number2;

                while (true)
                {
                    Console.Write("Enter second number: ");
                    string input = Console.ReadLine();

                    if (Validator.IsValidNumber(input, out number2))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                double result;

                switch (choice)
                {
                    case "1":
                        result = Calculator.Add(number1, number2);
                        break;

                    case "2":
                        result = Calculator.Subtract(number1, number2);
                        break;

                    case "3":
                        result = Calculator.Multiply(number1, number2);
                        break;

                    case "4":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            Console.WriteLine();
                            continue;
                        }

                        result = Calculator.Divide(number1, number2);
                        break;

                    default:
                        continue;
                }

                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}