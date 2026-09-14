using System;

class Bai5
{
    static void Main(string[] args)
    {
        Console.Write("Nhap gia tri X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhap gia tri Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is at the Origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y axis.");
        }
        else
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X axis.");
        }
    }
}