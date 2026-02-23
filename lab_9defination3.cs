using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;
        int remainder;

        while (number > 0)
        {
            remainder = number % 10;
            sum += remainder * remainder * remainder;
            number = number / 10;
        }

        if (originalNumber == sum)
        {
            Console.WriteLine("Number is Armstrong");
        }
        else
        {
            Console.WriteLine("Number is Not Armstrong");
        }

        Console.ReadLine();
    }
}