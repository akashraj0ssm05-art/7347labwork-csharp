using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter the number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        int first = 0, second = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");

            int next = first + second;
            first = second;
            second = next;
        }
    }
}
