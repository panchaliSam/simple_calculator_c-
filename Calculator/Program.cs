using System;
using System.Runtime.InteropServices.JavaScript;

namespace SimpleCalcualtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");

            bool continueClaculating = true;

            while (continueClaculating)
            {
                Console.Write("Enter the first number: ");
                double num1 = GetValidNumber();
                
                Console.Write("Enter the second number: ");
                double num2 = GetValidNumber();
                
                Console.WriteLine("Choose an operation (+,-,*,/):");
                string operation = Console.ReadLine();
                
                double result  = PerformOperation(num1, num2, operation);

                if (!double.IsNaN(result))
                {
                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                }
                
                Console.WriteLine("Would you like to perform another calculation? (y/n)");
                continueClaculating = Console.ReadLine()?.ToLower() == "y";
            }
            
            Console.WriteLine("Thanks for using the calculator!");
        }

        static double GetValidNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        static double PerformOperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return double.NaN;
                    }
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return double.NaN;
            }
            {
                
            }
        }
    }
}

