using System;
using System.Collections.Generic;
using System.Linq;

namespace BeginnerTeamProject1.Features {
    internal class SimpleMathTool {
        // This class provides a simple math tool that can perform basic arithmetic operations.

        private double BasicCalculator(double firstNumber, double secondNumber, string operation) {
            switch (operation.ToLower()) {
                case "add":
                    return firstNumber + secondNumber;
                case "subtract":
                    return firstNumber - secondNumber;
                case "multiply":
                    return firstNumber * secondNumber;
                case "divide":
                    if (secondNumber == 0) {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return firstNumber / secondNumber;
                default:
                    throw new InvalidOperationException("Invalid operation specified.");
            }
        }

        private double CalculateSquareRoot(double number) {
            if (number < 0) {
                throw new ArgumentException("Cannot calculate square root of negative number.");
            }
            return Math.Sqrt(number);
        }

        private int CalculateFactorial(int number) {
            if (number < 0) {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (number == 0 || number == 1) {
                return 1;
            }

            int result = 1;
            for (int i = 2; i <= number; i++) {
                result *= i;
            }
            return result;
        }

        public static void Run() {
            Console.WriteLine("Welcome to the Simple Math Tool!");
            var mathTool = new SimpleMathTool();

            while (true) {
                DisplayMenu();
                var choice = Console.ReadLine();

                switch (choice) {
                    case "0":
                        Console.WriteLine("Returning to main menu...");
                        return;
                    case "1":
                        HandleBasicCalculator(mathTool);
                        break;
                    case "2":
                        HandleSquareRoot(mathTool);
                        break;
                    case "3":
                        HandleFactorial(mathTool);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 0-3.");
                        break;
                }
            }
        }

        private static void DisplayMenu() {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Basic Calculator (add, subtract, multiply, divide)");
            Console.WriteLine("2. Square Root");
            Console.WriteLine("3. Factorial");
            Console.WriteLine("0. Main Menu");
            Console.Write("Enter your choice (0-3): ");
        }

        private static void HandleBasicCalculator(SimpleMathTool mathTool) {
            try {
                Console.Write("Enter first number: ");
                var firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                var secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation (add, subtract, multiply, divide): ");
                var operation = Console.ReadLine();

                var result = mathTool.BasicCalculator(firstNumber, secondNumber, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void HandleSquareRoot(SimpleMathTool mathTool) {
            try {
                Console.Write("Enter number to find square root: ");
                var number = Convert.ToDouble(Console.ReadLine());
                var result = mathTool.CalculateSquareRoot(number);
                Console.WriteLine($"Square Root: {result}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void HandleFactorial(SimpleMathTool mathTool) {
            try {
                Console.Write("Enter a non-negative integer for factorial: ");
                var number = Convert.ToInt32(Console.ReadLine());
                var result = mathTool.CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is {result}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}