using System;

internal class Bai_7
{
    static void Main(string[] args)
    {
        Console.Write("Nhap quang duong (km): ");
        double quangDuong = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap muc tieu hao (L/100km): ");
        double mucTieuHao = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap gia xang (VNĐ/Lit): ");
        decimal giaXang = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Nhap so nguoi di: ");
        int soNguoi = Convert.ToInt32(Console.ReadLine());

        double tongNhienLieu = (quangDuong / 100) * mucTieuHao;

        decimal tongChiPhi = (decimal)tongNhienLieu * giaXang;

        decimal chiPhiMoiNguoi = tongChiPhi / soNguoi;

        chiPhiMoiNguoi = Math.Ceiling(chiPhiMoiNguoi / 1000) * 1000;

        Console.WriteLine();
        Console.WriteLine($"Tong nhien lieu tieu thu: {tongNhienLieu:F2} Lit");
        Console.WriteLine($"Tong chi phi xang dau: {tongChiPhi:N0} VNĐ");
        Console.WriteLine($"Chi phi moi nguoi: {chiPhiMoiNguoi:N0} VNĐ");
    }
}