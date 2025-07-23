using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Team_Project_1.Features {
    internal class Simple_Math_Tool {
        // This class provides a simple math tool that can perform basic arithmetic operations.


        //Services
        private double basic_calculator(double a, double b, string operation) {
            switch (operation) {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    if (b != 0) {
                        return a / b;
                    }
                    else {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }

        private double square_root(double a) {
            if (a < 0) {
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            }
            return Math.Sqrt(a);
        }

        private int factorial(int n) {
            if (n < 0) {
                throw new ArgumentException("Cannot calculate the factorial of a negative number.");
            }
            if (n == 0 || n == 1) {
                return 1;
            }
            int result = 1;
            for (int i = 2; i <= n; i++) {
                result *= i;
            }
            return result;
        }



        // Main method to run the Simple Math Tool
        public static void Run() {
            Console.WriteLine("Welcome to the Simple Math Tool!");
            Simple_Math_Tool mathTool = new Simple_Math_Tool();
            while (true) {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Basic Calculator (add, subtract, multiply, divide)");
                Console.WriteLine("2. Square Root");
                Console.WriteLine("3. Factorial");
                Console.WriteLine("0. Main Menu");
                Console.Write("Enter your choice (0-3): ");
                string choice = Console.ReadLine();

            
                switch (choice) {
                    case "0":
                        Console.WriteLine("Returning to main menu...");
                        return; 
                    case "1":
                        Console.Write("Enter first number: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter operation (add, subtract, multiply, divide): ");
                        string operation = Console.ReadLine().ToLower();
                        try {
                            double result = mathTool.basic_calculator(a, b, operation);
                            Console.WriteLine($"Result: {result}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "2":
                        Console.Write("Enter number to find square root: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        try {
                            double sqrtResult = mathTool.square_root(num);
                            Console.WriteLine($"Square Root: {sqrtResult}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case "3":
                        Console.Write("Enter a non-negative integer for factorial: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        try {
                            int factResult = mathTool.factorial(n);
                            Console.WriteLine($"Factorial of {n} is {factResult}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                        break;




                }
            }
        }
            
    }
}// End of Simple_Math_Tool.cs
