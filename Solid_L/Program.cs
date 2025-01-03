﻿namespace Solid_L;

public class Program
{
    public static int Area(Rectangle rc)
    {
        return rc.Width * rc.Height;
    }

    // use override to fix the issue
    public static void Main()
    {
        var rc = new Rectangle(2, 3);
        Console.WriteLine($"{rc} has area {Area(rc)}");

        //Square sq = new Square(); // Works as expected

        // To work as expected, the Square class
        // should override the Width and Height properties
        Rectangle sq = new Square();
        sq.Width = 4;
        Console.WriteLine($"{sq} has area {Area(sq)}");
    }
}