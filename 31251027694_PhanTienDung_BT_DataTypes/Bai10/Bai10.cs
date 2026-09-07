using System;

enum StockStatus
{
    OutOfStock,
    LowStock,
    InStock,
    Discontinued
}

internal class Bai_10
{
    static void Main(string[] args)
    {
        string maSanPham = "KB-09";
        string tenSanPham = "Ban phim Co Akko";

        int? quantity = null;
        int minThreshold = 10;

        DateTime? restockDate = null;

        int qty = quantity ?? 0;

        StockStatus trangThaiKho;

        if (quantity == null || quantity == 0)
        {
            trangThaiKho = StockStatus.OutOfStock;
        }
        else if (quantity < minThreshold)
        {
            trangThaiKho = StockStatus.LowStock;
        }
        else
        {
            trangThaiKho = StockStatus.InStock;
        }

        string ngayNhapHang = restockDate?.ToString("dd/MM/yyyy")
                              ?? "Chua co lich nhap hang";

        Console.WriteLine($"Ma san pham: {maSanPham}");
        Console.WriteLine($"Ten san pham: {tenSanPham}");
        Console.WriteLine($"So luong hien thi: {qty}");

        if (quantity == null)
        {
            Console.WriteLine("Canh bao: Du lieu trong");
        }

        Console.WriteLine($"Trang thai kho: {trangThaiKho}");

        if (trangThaiKho == StockStatus.OutOfStock)
        {
            Console.WriteLine("Trang thai: Het hang");
        }
        else if (trangThaiKho == StockStatus.LowStock)
        {
            Console.WriteLine("Trang thai: Sap het hang");
        }
        else if (trangThaiKho == StockStatus.InStock)
        {
            Console.WriteLine("Trang thai: Con hang");
        }

        Console.WriteLine($"Du kien nhap hang: {ngayNhapHang}");
    }
}