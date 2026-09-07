using System;

internal class Bai_11
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so tien gui (VND): ");
        decimal tienGui = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Nhap lai suat nam (%/nam): ");
        double laiSuat = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap ky han gui (thang): ");
        int kyHan = Convert.ToInt32(Console.ReadLine());

        decimal tienLaiDon = tienGui
                            * (decimal)(laiSuat / 100)
                            * (decimal)(kyHan / 12.0);

        double tienGuiDouble = (double)tienGui;
        double laiSuatThang = (laiSuat / 100) / 12;

        double tongTienLaiKepDouble = tienGuiDouble
                                    * Math.Pow(1 + laiSuatThang, kyHan);

        decimal tongTienLaiKep = (decimal)tongTienLaiKepDouble;

        decimal chenhLech = tongTienLaiKep - tienGui - tienLaiDon;

        Console.WriteLine();
        Console.WriteLine($"Tong tien lai (Lai don): {tienLaiDon:N0} VND");
        Console.WriteLine($"Tong tien lai (Lai kep): {tongTienLaiKep - tienGui:N0} VND");

        if (chenhLech > 0)
        {
            Console.WriteLine($"Loi nhuan chenh lech: {chenhLech:N0} VND (Lai kep toi uu hon)");
        }
        else if (chenhLech < 0)
        {
            Console.WriteLine($"Loi nhuan chenh lech: {-chenhLech:N0} VND (Lai don toi uu hon)");
        }
        else
        {
            Console.WriteLine("Loi nhuan chenh lech: 0 VND (Hai phuong thuc bang nhau)");
        }
    }
}