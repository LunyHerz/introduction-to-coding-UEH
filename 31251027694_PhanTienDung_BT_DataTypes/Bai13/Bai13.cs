using System;

enum VehicleType
{
    Motorbike,
    Car,
    Truck
}

internal class Bai_13
{
    static void Main(string[] args)
    {
        Console.Write("Nhap loai xe (Motorbike/Car/Truck): ");
        VehicleType loaiXe = Enum.Parse<VehicleType>(Console.ReadLine());

        Console.Write("Nhap gio vao (yyyy-MM-dd HH:mm): ");
        DateTime checkIn = DateTime.ParseExact(
            Console.ReadLine(),
            "yyyy-MM-dd HH:mm",
            null);

        Console.Write("Nhap gio ra (yyyy-MM-dd HH:mm): ");
        DateTime checkOut = DateTime.ParseExact(
            Console.ReadLine(),
            "yyyy-MM-dd HH:mm",
            null);

        TimeSpan thoiGianDo = checkOut - checkIn;
        double totalHours = thoiGianDo.TotalHours;

        int soGioTinhPhi = (int)Math.Ceiling(totalHours);

        decimal phi2GioDau;
        decimal phiMoiGio;

        if (loaiXe == VehicleType.Motorbike)
        {
            phi2GioDau = 5000m;
            phiMoiGio = 2000m;
        }
        else if (loaiXe == VehicleType.Car)
        {
            phi2GioDau = 20000m;
            phiMoiGio = 10000m;
        }
        else
        {
            phi2GioDau = 50000m;
            phiMoiGio = 25000m;
        }

        decimal phiPhatSinh = 0;

        if (soGioTinhPhi > 2)
        {
            phiPhatSinh = (soGioTinhPhi - 2) * phiMoiGio;
        }

        decimal tongPhi = phi2GioDau + phiPhatSinh;

        bool quaDem = checkIn.Date != checkOut.Date;

        decimal phiQuaDem = 0;

        if (quaDem)
        {
            phiQuaDem = 30000m;
            tongPhi += phiQuaDem;
        }

        Console.WriteLine();
        Console.WriteLine($"Tong thoi gian do: {totalHours:F2} gio -> Tinh phi: {soGioTinhPhi} gio");
        Console.WriteLine($"Phi 2 gio dau: {phi2GioDau:N0} VND");

        if (soGioTinhPhi > 2)
        {
            Console.WriteLine(
                $"Phi {soGioTinhPhi - 2} gio tiep theo: {phiPhatSinh:N0} VND ({phiMoiGio:N0} x {soGioTinhPhi - 2})");
        }

        if (quaDem)
        {
            Console.WriteLine($"Phu phi qua dem: {phiQuaDem:N0} VND");
        }

        Console.WriteLine($"TONG PHI DO XE: {tongPhi:N0} VND");
    }
}