using System;

class Bai3
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so thu nhat: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu ba: ");
        double c = double.Parse(Console.ReadLine());

        double max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        Console.WriteLine($"So lon nhat la: {max}");
    }
}