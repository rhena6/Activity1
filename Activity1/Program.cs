using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator in C# Functions");

        // Get user input
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose an operation: Add / Subtract / Multiply / Divide");
        string operation = Console.ReadLine();

        switch (operation.ToLower())
        {
            case "add":
                Console.WriteLine($"Result: {Add(num1, num2)}");
                break;
            case "subtract":
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
                break;
            case "multiply":
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
                break;
            case "divide":
                if (num2 != 0)
                    Console.WriteLine($"Result: {Divide(num1, num2)}");
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }

    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static double Divide(int a, int b) => (double)a / b;
}
