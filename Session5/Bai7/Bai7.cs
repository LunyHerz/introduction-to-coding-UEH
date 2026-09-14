using System;

class Bai8
{
    static void Main(string[] args)
    {
        Console.Write("Enter the end value (start value is 0): ");
        int endnum = int.Parse(Console.ReadLine());
        Console.WriteLine("Perfect number(s) in range: ");
        for (int i = 1; i <= endnum; i++)
        {
            int sumofdivisors = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    sumofdivisors = sumofdivisors + j;
                }
            }
            if (sumofdivisors == i)
            {
                Console.Write($"{i}");
            }
        }
    }
}