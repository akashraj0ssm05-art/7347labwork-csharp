using System;

class Rectangle
{
    int length;
    int width;

    // Default Constructor
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    // Parameterized Constructor
    public Rectangle(int l, int w)
    {
        length = l;
        width = w;
    }

    // Method to calculate area
    public int Area()
    {
        return length * width;
    }

    // Method to display values
    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + Area());
    }
}

class Program
{
    static void Main()
    {
        // Object using default constructor
        Rectangle r1 = new Rectangle();
        Console.WriteLine("Rectangle 1:");
        r1.Display();

        // Object using parameterized constructor
        Rectangle r2 = new Rectangle(10, 5);
        Console.WriteLine("\nRectangle 2:");
        r2.Display();
    }
}