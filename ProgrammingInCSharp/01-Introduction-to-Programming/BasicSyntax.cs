using System;

namespace IntroductionToProgramming
{
    public class BasicSyntax
    {
        public static void RunExample()
        {
            // 1. Variables and Data Types
            // VariableExamples();

            // 2. Basic Arithmetic Operations
            // ArithmeticOperations();

            // 3. Console Input/Output Example
            // InputOutputExample();

            // 4. Simple Method Creation and Usage
            int sum = AddNumbers(5, 3);
            decimal sumDecimals = AddNumbers(5.00m, 3.00m);
            Console.WriteLine($"Method Example: Sum of 5 and 3 is {sum}");
            Console.WriteLine($"Personal Example: Sum of 5.00 and 3.00 is {sumDecimals}");

            // Console.WriteLine("\n-- Basic Syntax Examples Completed --");
        }

        // 1. Variables and Data Types Example
        private static void VariableExamples()
        {
            Console.WriteLine("\n-- Variables and Data Types --");

            // Declare variables of different data types
            int integer = 10;                  // Integer
            double floatingPoint = 20.5;       // Double (floating-point number)
            char singleCharacter = 'A';        // Character
            string text = "Hello, C#";         // String
            bool isProgrammingFun = true;      // Boolean (true/false)
            decimal loanAmmount = 100.00M;     // Decimal (monetary)

            // Print variable values
            Console.WriteLine($"Integer: {integer}");
            Console.WriteLine($"Double: {floatingPoint}");
            Console.WriteLine($"Character: {singleCharacter}");
            Console.WriteLine($"String: {text}");
            Console.WriteLine($"Boolean: {isProgrammingFun}");
            Console.WriteLine($"Decimal: {loanAmmount}");
        }

        // 2. Basic Arithmetic Operations Example
        private static void ArithmeticOperations()
        {
            Console.WriteLine("\n-- Arithmetic Operations --");

            int a = 10;
            int b = 3;

            double c = 10.5;
            double d = 5.5;

            // Perform arithmetic operations and print results
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");      // Integer division
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");       // Remainder of division
            
            Console.WriteLine($"Addition: {c} + {d} = {c + d}");
            Console.WriteLine($"Subtraction: {c} - {d} = {c - d}");
        }

        // 3. Console Input/Output Example
        private static void InputOutputExample()
        {
            Console.WriteLine("\n-- Console Input/Output Example --");

            // Read input from the user and print a greeting message
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello, {name}! You are {age} years old!");
        }

        // 4. Simple Method Example: Adding two numbers
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        private static decimal AddNumbers(decimal num3, decimal num4)
        {
            return num3 + num4;
        }
    }
}
