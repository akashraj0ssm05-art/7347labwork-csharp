using System;

class Program
{
    static void Main()
    {
        double bill;
        string category;
        double discount = 0;
        double finalBill;

        Console.Write("Enter Bill Amount: ");
        bill = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Customer Category (senior / regular / industrial): ");
        category = Console.ReadLine().ToLower();

        if (category == "senior")
        {
            discount = bill * 0.20;   
        }
        else if (category == "regular")
        {
            discount = bill * 0.10;   
        }
        else if (category == "industrial")
        {
            discount = bill * 0.05;   
        }
        else
        {
            Console.WriteLine("Invalid category");
        }

        finalBill = bill - discount;

        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Bill Amount: " + finalBill);
    }
}