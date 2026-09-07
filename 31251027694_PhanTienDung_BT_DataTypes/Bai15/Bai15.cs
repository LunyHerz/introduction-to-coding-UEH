using System;

enum CustomerType
{
    Child,
    Student,
    Adult,
    Senior
}

internal class Bai_15
{
    static void Main(string[] args)
    {
        decimal giaVeGoc = 100000m;

        Console.Write("Nhap loai khach hang (Child/Student/Adult/Senior): ");
        CustomerType loaiKhachHang = Enum.Parse<CustomerType>(Console.ReadLine());

        Console.Write("Co the sinh vien hop le khong (True/False): ");
        bool coTheSinhVien = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Nhap ngay xem (Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday): ");
        DayOfWeek ngayXem = Enum.Parse<DayOfWeek>(Console.ReadLine());

        decimal giamGia = 0;
        decimal phuThuCuoiTuan = 0;
        string lyDoGiamGia = "Khong co";

        if (loaiKhachHang == CustomerType.Child)
        {
            giamGia = giaVeGoc * 0.50m;
            lyDoGiamGia = "Giam gia Tre em (50%)";
        }
        else if (loaiKhachHang == CustomerType.Senior)
        {
            giamGia = giaVeGoc * 0.50m;
            lyDoGiamGia = "Giam gia Nguoi cao tuoi (50%)";
        }
        else if (loaiKhachHang == CustomerType.Student &&
                 coTheSinhVien &&
                 ngayXem >= DayOfWeek.Monday &&
                 ngayXem <= DayOfWeek.Thursday)
        {
            giamGia = giaVeGoc * 0.30m;
            lyDoGiamGia = "Giam gia SV (30%)";
        }
        else if (loaiKhachHang == CustomerType.Adult &&
                 ngayXem == DayOfWeek.Wednesday)
        {
            giamGia = giaVeGoc * 0.20m;
            lyDoGiamGia = "Khuyen mai Thu 4 Vui Ve (20%)";
        }

        if (ngayXem == DayOfWeek.Friday ||
            ngayXem == DayOfWeek.Saturday ||
            ngayXem == DayOfWeek.Sunday)
        {
            phuThuCuoiTuan = 20000m;
        }

        decimal giaVeThanhToan = giaVeGoc - giamGia + phuThuCuoiTuan;

        Console.WriteLine();
        Console.WriteLine($"Gia ve goc: {giaVeGoc:N0} VND");

        if (giamGia > 0)
        {
            Console.WriteLine($"{lyDoGiamGia}: -{giamGia:N0} VND");
        }
        else
        {
            Console.WriteLine("Khoan giam gia: 0 VND");
        }

        Console.WriteLine($"Phu thu cuoi tuan: {phuThuCuoiTuan:N0} VND");
        Console.WriteLine($"TONG TIEN VE: {giaVeThanhToan:N0} VND");
    }
}