using System;

internal class Bai_8
{
    static void Main(string[] args)
    {
        string otpHeThong = "839201";
        DateTime creationTime = DateTime.Now;

        Console.Write("Nhap ma OTP nhan duoc: ");
        string otpNhap = Console.ReadLine();

        Console.Write("Nhap so phut da troi qua: ");
        string phutInput = Console.ReadLine();

        Console.Write("Nhap so giay da troi qua: ");
        string giayInput = Console.ReadLine();

        bool phutHopLe = int.TryParse(phutInput, out int soPhut);
        bool giayHopLe = int.TryParse(giayInput, out int soGiay);

        bool otpHopLe = otpNhap.Length == 6;

        if (otpHopLe)
        {
            foreach (char kyTu in otpNhap)
            {
                if (!char.IsDigit(kyTu))
                {
                    otpHopLe = false;
                    break;
                }
            }
        }

        if (!otpHopLe)
        {
            Console.WriteLine("Trang thai xac thuc: LOI - Dinh dang OTP khong hop le.");
            return;
        }

        if (!phutHopLe || !giayHopLe)
        {
            Console.WriteLine("Trang thai xac thuc: LOI - Thoi gian khong hop le.");
            return;
        }

        DateTime verificationTime = creationTime.AddMinutes(soPhut).AddSeconds(soGiay);

        TimeSpan elapsedTime = verificationTime - creationTime;

        if (elapsedTime.TotalSeconds > 300)
        {
            Console.WriteLine("Trang thai xac thuc: LOI - Het han OTP.");
            return;
        }

        if (otpNhap != otpHeThong)
        {
            Console.WriteLine("Trang thai xac thuc: LOI - Ma OTP sai.");
            return;
        }

        Console.WriteLine(
            "Trang thai xac thuc: THANH CONG - Giao dich da duoc phe duyet."
        );
    }
}