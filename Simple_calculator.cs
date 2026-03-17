
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double a, b;
        string exp;

        Console.WriteLine("Enter first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Expression (+, -, *, /): ");
        exp = Console.ReadLine();

        switch(exp)
        {
            case "+":
                Console.WriteLine("Result: " + (a + b));
                break;

            case "-":
                Console.WriteLine("Result: " + (a - b));
                break;

            case "*":
                Console.WriteLine("Result: " + (a * b));
                break;

            case "/":
                if (b != 0)
                    Console.WriteLine("Result: " + (a / b));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}

