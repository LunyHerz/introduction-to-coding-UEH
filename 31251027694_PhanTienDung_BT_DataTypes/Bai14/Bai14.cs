using System;

internal class Bai_14
{
    static void Main(string[] args)
    {
        string chuoiSo;
        int giaTriInt;

        while (true)
        {
            Console.Write("Nhap chuoi so: ");
            chuoiSo = Console.ReadLine();

            if (int.TryParse(chuoiSo, out giaTriInt))
            {
                break;
            }

            Console.WriteLine("Loi: Chuoi vua nhap khong phai la so nguyen!");
            Console.WriteLine("Vui long nhap lai.");
        }

        Console.WriteLine($"Kiem tra Parse: Thanh cong! Gia tri int = {giaTriInt}");

        if (giaTriInt >= byte.MinValue && giaTriInt <= byte.MaxValue)
        {
            Console.WriteLine("Phu hop kieu byte: CO (Vua van trong dai 0-255)");
        }
        else
        {
            Console.WriteLine("Phu hop kieu byte: KHONG");
        }

        if (giaTriInt >= short.MinValue && giaTriInt <= short.MaxValue)
        {
            Console.WriteLine("Phu hop kieu short: CO (Vua van trong dai -32768 den 32767)");
        }
        else
        {
            Console.WriteLine("Phu hop kieu short: KHONG");
        }

        int soTam = Math.Abs(giaTriInt);
        int tongChuSo = 0;

        while (soTam > 0)
        {
            tongChuSo += soTam % 10;
            soTam /= 10;
        }

        Console.Write("Tong cac chu so: ");

        string soHienThi = Math.Abs(giaTriInt).ToString();

        for (int i = 0; i < soHienThi.Length; i++)
        {
            Console.Write(soHienThi[i]);

            if (i < soHienThi.Length - 1)
            {
                Console.Write(" + ");
            }
        }

        Console.WriteLine($" = {tongChuSo}");

        try
        {
            checked
            {
                int ketQua = giaTriInt;

                for (int i = 1; i <= 10; i++)
                {
                    ketQua *= giaTriInt;
                }

                Console.WriteLine("Kiem tra Tran so: An toan trong pham vi int32.");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Kiem tra Tran so: Da xay ra OverflowException!");
        }
    }
}