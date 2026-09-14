using System;

class Bai8
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int numberofdivisors = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                numberofdivisors++;
            }
        }
        if (numberofdivisors == 2)
        {
            Console.WriteLine($"{num} is a prime number");
        }
        else
        {
            Console.WriteLine($"{num} is a composite number");
        }
    }
}