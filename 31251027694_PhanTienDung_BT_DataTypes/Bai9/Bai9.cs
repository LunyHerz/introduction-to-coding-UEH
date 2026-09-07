using System;

internal class Bai_9
{
    static void Main(string[] args)
    {
        Console.Write("Nhap luong Gross (VND): ");
        decimal luongGross = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Nhap so nguoi phu thuoc: ");
        int soNguoiPhuThuoc = Convert.ToInt32(Console.ReadLine());
        
        decimal BHXH = luongGross * 0.08m;
        decimal BHYT = luongGross * 0.015m;
        decimal BHTN = luongGross * 0.01m;

        decimal tongBaoHiem = BHXH + BHYT + BHTN;

        decimal giamTruBanThan = 11000000m;
        decimal giamTruNguoiPhuThuoc = soNguoiPhuThuoc * 4400000m;

        decimal thuNhapChiuThue = luongGross
                                - tongBaoHiem
                                - giamTruBanThan
                                - giamTruNguoiPhuThuoc;

        if (thuNhapChiuThue < 0)
        {
            thuNhapChiuThue = 0;
        }

        decimal thueTNCN = 0;

        if (thuNhapChiuThue <= 5000000m)
        {
            thueTNCN = thuNhapChiuThue * 0.05m;
        }
        else if (thuNhapChiuThue <= 10000000m)
        {
            thueTNCN = 5000000m * 0.05m
                     + (thuNhapChiuThue - 5000000m) * 0.10m;
        }
        else if (thuNhapChiuThue <= 18000000m)
        {
            thueTNCN = 5000000m * 0.05m
                     + 5000000m * 0.10m
                     + (thuNhapChiuThue - 10000000m) * 0.15m;
        }

        decimal luongNet = luongGross - tongBaoHiem - thueTNCN;

        Console.WriteLine();
        Console.WriteLine($"Giam tru Bao hiem (10.5%): {tongBaoHiem:N0} VND");
        Console.WriteLine($"Thu nhap chiu thue: {thuNhapChiuThue:N0} VND");
        Console.WriteLine($"Thue TNCN phai nop: {thueTNCN:N0} VND");
        Console.WriteLine($"LUONG NET THUC NHAN: {luongNet:N0} VND");
    }
}