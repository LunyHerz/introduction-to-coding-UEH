using System;

class Session3
{
    static void Main(string[] args)
    {
        /* Celsius to Fahrenheit/Kelvin */
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 18 / 10 + 32;
        double kelvin = celsius + 273;
        Console.WriteLine($"Temperature in Fahrenheit: {Math.Round(fahrenheit, 2)}");
        Console.WriteLine($"Temperature in Kelvin: {Math.Round(kelvin, 2)}");

        /* surface and volume of a sphere */
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Surface: {Math.Round(surface, 2)}");
        Console.WriteLine($"Volume: {Math.Round(volume,2)}"); ;

        /* adding, subtracting,multiplying and dividing two numbers entered by the user + the rest of the division on the last line */
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        int sub = num1 - num2;
        int multi = num1 * num2;
        int div = num1 / num2;
        int mod = num1 % num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {sub}");
        Console.WriteLine($"{num1} * {num2} = {multi}");
        Console.WriteLine($"{num1} / {num2} = {div}");
        Console.WriteLine($"{num1} mod {num2} = {mod}");
    }
}