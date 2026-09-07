using System.Globalization;

namespace _31251027694_PhanTienDung_BT_DataTypes
{
    internal class Bai_4
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay sinh (dd/mm/yyyy): ");
            string input = Console.ReadLine();
            DateTime birthDate;
            bool isValid = DateTime.TryParseExact(
                input,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDate
                );
            if (!isValid)
            {
                Console.WriteLine("Ngay sinh khong dung dinh dang!");
                return;
            }
            DateTime today = DateTime.Now.Date;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age))
            {
            }
            TimeSpan livedTime = today - birthDate;
            int totalDays = (int)livedTime.TotalDays;
            DateTime nextBirthday =
                new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            TimeSpan remainingTime = nextBirthday - today;
            int remainingDays = (int)remainingTime.TotalDays;
            Console.WriteLine("Tuoi hien tai: " + age + " tuoi");
            Console.WriteLine("Ban da song: " + totalDays + " ngay");
            Console.WriteLine("Sinh nhat tiep theo con: " + remainingDays + " ngay nua");
        }
    }
}