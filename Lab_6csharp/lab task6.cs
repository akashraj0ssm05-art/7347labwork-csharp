using System;

class Program
{
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        int attempts = 3;

        while (attempts > 0)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login Successful!");
                break;
            }
            else
            {
                attempts--;
                Console.WriteLine("Invalid credentials. Attempts left: " + attempts);
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("Account Locked! Too many failed attempts.");
        }
    }
}
