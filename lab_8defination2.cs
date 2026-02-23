using System;

class Program
{
    static void Main()
    {
        int number, sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum = " + sum);
    }
}
