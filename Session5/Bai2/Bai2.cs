using System;

class Bai2
{
    static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        double number3 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 4: ");
        double number4 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 5: ");
        double number5 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 6: ");
        double number6 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 7: ");
        double number7 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 8: ");
        double number8 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 9: ");
        double number9 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 10: ");
        double number10 = double.Parse(Console.ReadLine());

        double sum = number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10;
        double avr = sum / 10;
        Console.WriteLine($"Average of 10 numbers {avr}");
        Console.WriteLine($"Sum of 10 numbers {sum}");

    }
}