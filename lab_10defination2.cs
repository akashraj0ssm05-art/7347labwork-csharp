using System;

class Program
{
    static void Main()
    {
        int age;
        double income;
        int creditScore;

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Credit Score: ");
        creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 21)
        {
            if (income >= 25000)
            {
                if (creditScore >= 650)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Loan Rejected due to low Credit Score");
                }
            }
            else
            {
                Console.WriteLine("Loan Rejected due to low Income");
            }
        }
        else
        {
            Console.WriteLine("Loan Rejected due to Age below 21");
        }
    }
}