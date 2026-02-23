using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string original = input;
        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
        }

        if (original.Equals(reverse, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("String is Palindrome");
        }
        else
        {
            Console.WriteLine("String is Not Palindrome");
        }

        Console.ReadLine();
    }
}