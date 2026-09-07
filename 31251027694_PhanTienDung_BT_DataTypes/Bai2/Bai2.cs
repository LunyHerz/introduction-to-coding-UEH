using System;
using System.Collections.Generic;
using System.Text;

namespace _31251027694_PhanTienDung_BT_DataTypes
{
    internal class Bai_2
    {
        static void Main(string[] args)
        {
            Console.Write("Chieu cao (m): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Can nang (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double BMI = weight / (Math.Pow(height, 2));
            string health = null;
            if (BMI < 18.5)
            {
                health = "Gay";
            }
            else if (BMI < 23.0)
            {
                health = "Binh thuong";
            }
            else if (BMI < 25.0)
            {
                health = "Thua can";
            }
            else
            {
                health = "Beo phi";
            }
            double minweight = 18.5 * Math.Pow(height, 2);
            double maxweight = 22.9 * Math.Pow(height, 2);
            Console.WriteLine($"Chi so BMI cua ban: {Math.Round(BMI, 2)}");
            Console.WriteLine($"Phan loai suc khoe: {health}");
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {Math.Round(minweight, 2)} kg to {Math.Round(maxweight, 2)} kg");
        }
    }
}
