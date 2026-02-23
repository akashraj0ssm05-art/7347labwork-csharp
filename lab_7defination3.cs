using System;

class Program
{
    static void Main()
    {
        int number;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("The number is Prime.");
        }
        else
        {
            Console.WriteLine("The number is Not Prime.");
        }
    }
}
