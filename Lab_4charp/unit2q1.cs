using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        char op;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result = " + result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("Result = " + result);
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine("Result = " + result);
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }

        Console.ReadLine();
    }
}
