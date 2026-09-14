using System;

class Bai1
{
    static void Main(string[] args)
    {
        Console.Write("Nhap canh a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap canh b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap canh c: ");
        double c = double.Parse(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Khong phai la tam giac.");
        }
        else if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Khong phai la tam giac.");
        }
        else if (a == b && b == c)
        {
            Console.WriteLine("Equilateral triangle");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Isosceles triangle");
        }
        else
        {
            Console.WriteLine("Scalene triangle");
        }
    }
}