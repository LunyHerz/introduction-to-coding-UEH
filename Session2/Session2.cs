using System;

class Session2
{
    static void Main(string[] args)
    {
        /* 1. Add / Sum Two Numbers */
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"{num1} + {num2} = {sum}" );

        /* 2. Swap Values of Two Variables */
        Console.WriteLine("Before swapping:");
        Console.WriteLine($"First number = {num1}" );
        Console.WriteLine($"Second number = {num2}");
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After swapping:");
        Console.WriteLine($"First number = {num1}");
        Console.WriteLine($"Second number = {num2}");

        /* 3. Multiply two Floating Point Numbers */
        Console.Write("Enter the first floating-point number: ");
        double double1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second floating-point number: ");
        double double2 = Convert.ToDouble(Console.ReadLine());
        double multiply = double1 * double2;
        Console.WriteLine($"Product: {multiply}");

        /* 4. convert feet to meter */
        Console.Write("Enter length in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double meters = feet * 0.3048;
        Console.WriteLine($"Length in meters: {Math.Round(meters,2)}");

        /* 5. convert Celsius to Fahrenheit and vice versa */
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose an option: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {Math.Round(fahrenheit,2)}");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {Math.Round(celsius,2)}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        /* 6. find the Size of data types */
        Console.WriteLine("Size of byte: " + sizeof(byte) + " byte");
        Console.WriteLine("Size of short: " + sizeof(short) + " bytes");
        Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
        Console.WriteLine("Size of long: " + sizeof(long) + " bytes");
        Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
        Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
        Console.WriteLine("Size of decimal: " + sizeof(decimal) + " bytes");
        Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
        Console.WriteLine("Size of bool: " + sizeof(bool) + " byte");

        /* 7. Print ASCII Value (tip: read character, print number of this char) */
        Console.Write("Enter a character: ");
        char character = Convert.ToChar(Console.ReadLine());
        int asciiValue = (int)character;
        Console.WriteLine($"ASCII value: {asciiValue}");

        /* 8. Calculate Area of Circle */
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double areaC = Math.PI * Math.Pow(radius,2);
        Console.WriteLine($"Area of the circle: {Math.Round(areaC,3)}");

        /* 9. Calculate Area of Square */
        Console.Write("Enter the side of the square: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double areaS = Math.Pow(side,2);
        Console.WriteLine($"Area of the square: {areaS}");

        /* 10. convert days to years, weeks and days */
        Console.Write("Enter number of days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());
        int years = totalDays / 365;
        int remainingDays = totalDays % 365;
        int weeks = remainingDays / 7;
        int days = remainingDays % 7;

        Console.Write($"Years: {years}");
        Console.Write($"\tWeeks: {weeks}");
        Console.Write($"\tDays: {days}");
    }
}