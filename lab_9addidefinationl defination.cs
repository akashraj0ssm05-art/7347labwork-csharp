using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total units consumed: ");
        int units = int.Parse(Console.ReadLine());

        double billAmount = 0;

  
        if (units <= 100)
        {
            billAmount = units * 1.5;
        }
        else if (units <= 200)
        {
            billAmount = (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            billAmount = (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }

    
        billAmount += 50;

        if (billAmount > 500)
        {
            billAmount += billAmount * 0.18;
            Console.WriteLine("GST Applied (18%)");
        }

        Console.WriteLine("Total Electricity Bill: ₹ " + billAmount);

        Console.ReadLine();
    }
}