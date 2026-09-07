using System;

internal class Bai_6
{
    static void Main(string[] args)
    {
        Console.Write("Nhap ho ten tho: ");
        string hoTenTho = Console.ReadLine();

        string[] cacTu = hoTenTho.Trim().Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        for (int i = 0; i < cacTu.Length; i++)
        {
            cacTu[i] = cacTu[i].ToLower();

            cacTu[i] = cacTu[i].Substring(0, 1).ToUpper()
                        + cacTu[i].Substring(1);
        }

        string hoTenChuan = string.Join(" ", cacTu);

        Console.WriteLine();
        Console.WriteLine("Ho ten chuan hoa: " + hoTenChuan);

        string ho = cacTu[0];
        string ten = cacTu[cacTu.Length - 1];

        string tenDem = "";

        if (cacTu.Length > 2)
        {
            string[] phanTenDem = new string[cacTu.Length - 2];

            for (int i = 1; i < cacTu.Length - 1; i++)
            {
                phanTenDem[i - 1] = cacTu[i];
            }

            tenDem = string.Join(" ", phanTenDem);
        }

        Console.WriteLine(
            $"Ho: {ho} | Ten dem: {tenDem} | Ten: {ten}"
        );

        string hoTenKhongDau = hoTenChuan;

        hoTenKhongDau = hoTenKhongDau
            .Replace("a", "a")
            .Replace("A", "A")
            .Replace("á", "a")
            .Replace("à", "a")
            .Replace("ả", "a")
            .Replace("ã", "a")
            .Replace("ạ", "a")
            .Replace("ă", "a")
            .Replace("ắ", "a")
            .Replace("ằ", "a")
            .Replace("ẳ", "a")
            .Replace("ẵ", "a")
            .Replace("ặ", "a")
            .Replace("â", "a")
            .Replace("ấ", "a")
            .Replace("ầ", "a")
            .Replace("ẩ", "a")
            .Replace("ẫ", "a")
            .Replace("ậ", "a")
            .Replace("đ", "d")
            .Replace("Đ", "D")
            .Replace("é", "e")
            .Replace("è", "e")
            .Replace("ẻ", "e")
            .Replace("ẽ", "e")
            .Replace("ẹ", "e")
            .Replace("ê", "e")
            .Replace("ế", "e")
            .Replace("ề", "e")
            .Replace("ể", "e")
            .Replace("ễ", "e")
            .Replace("ệ", "e")
            .Replace("í", "i")
            .Replace("ì", "i")
            .Replace("ỉ", "i")
            .Replace("ĩ", "i")
            .Replace("ị", "i")
            .Replace("ó", "o")
            .Replace("ò", "o")
            .Replace("ỏ", "o")
            .Replace("õ", "o")
            .Replace("ọ", "o")
            .Replace("ô", "o")
            .Replace("ố", "o")
            .Replace("ồ", "o")
            .Replace("ổ", "o")
            .Replace("ỗ", "o")
            .Replace("ộ", "o")
            .Replace("ơ", "o")
            .Replace("ớ", "o")
            .Replace("ờ", "o")
            .Replace("ở", "o")
            .Replace("ỡ", "o")
            .Replace("ợ", "o")
            .Replace("ú", "u")
            .Replace("ù", "u")
            .Replace("ủ", "u")
            .Replace("ũ", "u")
            .Replace("ụ", "u")
            .Replace("ư", "u")
            .Replace("ứ", "u")
            .Replace("ừ", "u")
            .Replace("ử", "u")
            .Replace("ữ", "u")
            .Replace("ự", "u")
            .Replace("ý", "y")
            .Replace("ỳ", "y")
            .Replace("ỷ", "y")
            .Replace("ỹ", "y")
            .Replace("ỵ", "y");

        string[] tenKhongDau = hoTenKhongDau.Split(' ');

        string tenUsername = tenKhongDau[tenKhongDau.Length - 1].ToLower();

        string hoVaTenDem = "";

        if (tenKhongDau.Length > 1)
        {
            string[] phanHoTenDem = new string[tenKhongDau.Length - 1];

            for (int i = 0; i < tenKhongDau.Length - 1; i++)
            {
                phanHoTenDem[i] = tenKhongDau[i].ToLower();
            }

            hoVaTenDem = string.Join("", phanHoTenDem);
        }

        string username = tenUsername + "." + hoVaTenDem;

        string email = username + "@company.edu.vn";

        Console.WriteLine("Username tao tu dong: " + username);
        Console.WriteLine("Email cap phat: " + email);
    }
}