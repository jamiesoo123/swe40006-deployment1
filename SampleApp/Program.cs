using System;

namespace SampleApp
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

                if (choice == "5")
                {
                    Console.WriteLine("Calculator closed.");
                    break;
                }

                if (choice != "1" &&
                    choice != "2" &&
                    choice != "3" &&
                    choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.\n");
                    continue;
                }

                double number1;
                while (true)
                {
                    Console.Write("Enter first number: ");

                    if (double.TryParse(Console.ReadLine(), out number1))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                double number2;
                while (true)
                {
                    Console.Write("Enter second number: ");

                    if (double.TryParse(Console.ReadLine(), out number2))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                double result = 0;
                bool validCalculation = true;

                switch (choice)
                {
                    case "1":
                        result = number1 + number2;
                        break;

                    case "2":
                        result = number1 - number2;
                        break;

                    case "3":
                        result = number1 * number2;
                        break;

                    case "4":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            validCalculation = false;
                        }
                        else
                        {
                            result = number1 / number2;
                        }
                        break;
                }

                if (validCalculation)
                {
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}