using System;

internal class Bai_12
{
    static void Main(string[] args)
    {
        Console.Write("Nhap van ban can ma hoa: ");
        string vanBan = Console.ReadLine();

        Console.Write("Nhap khoa dich chuyen k (1-25): ");
        int k = Convert.ToInt32(Console.ReadLine());

        string vanBanMaHoa = "";

        foreach (char c in vanBan)
        {
            char kyTuMoi;

            if (c >= 'A' && c <= 'Z')
            {
                kyTuMoi = (char)('A' + (c - 'A' + k) % 26);
            }
            else if (c >= 'a' && c <= 'z')
            {
                kyTuMoi = (char)('a' + (c - 'a' + k) % 26);
            }
            else
            {
                kyTuMoi = c;
            }

            vanBanMaHoa += kyTuMoi;
        }

        string vanBanGiaiMa = "";

        foreach (char c in vanBanMaHoa)
        {
            char kyTuMoi;

            if (c >= 'A' && c <= 'Z')
            {
                kyTuMoi = (char)('A' + (c - 'A' - k + 26) % 26);
            }
            else if (c >= 'a' && c <= 'z')
            {
                kyTuMoi = (char)('a' + (c - 'a' - k + 26) % 26);
            }
            else
            {
                kyTuMoi = c;
            }

            vanBanGiaiMa += kyTuMoi;
        }

        Console.WriteLine();
        Console.WriteLine($"Van ban Ma hoa: {vanBanMaHoa}");
        Console.WriteLine($"Van ban Giai ma: {vanBanGiaiMa}");
    }
}