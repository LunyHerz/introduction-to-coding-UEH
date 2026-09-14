using System;

class Bai6
{
    static void Main(string[] args)
    {
        Console.Write("Enter the index number: ");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine($"The nth harmonic progression is 1/{position}");
        double sum = 0;
        for (int i = 1; i <= position; i++)
        {
            sum = sum + (double)1/i;
        }
        Console.WriteLine($"The nth harmonic number is {Math.Round(sum,4)}");

    }
}