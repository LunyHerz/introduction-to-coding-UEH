internal class Bai_5
{
    static void Main(string[] args)
    {
        Console.Write("Nhap diem mon lap trinh C#: ");
        double diem_lap_trinh = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap diem mon Toan roi rac: ");
        double diem_toan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap diem mon Tieng Anh: ");
        double diem_tieng_anh = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap trong so lap trinh C#: ");
        double trongSo_lap_trinh = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap trong so Toan roi rac: ");
        double trongSo_toan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhap trong so mon Tieng Anh: ");
        double trongSo_tieng_anh = Convert.ToDouble(Console.ReadLine());

        double diem_trung_binh = (diem_lap_trinh * trongSo_lap_trinh + diem_toan * trongSo_toan + diem_tieng_anh * trongSo_tieng_anh) / (trongSo_lap_trinh + trongSo_toan + trongSo_tieng_anh);

        char diem_chu;
        double GPA;
        string xep_loai;
        if (diem_trung_binh > 10)
        {
            Console.WriteLine("Nhap diem chua dung!");
            return;
        }
        else if (diem_trung_binh >= 8.5)
        {
            diem_chu = 'A';
            GPA = 4.0;
            xep_loai = "Xuat sac/ Gioi";
        }
        else if (diem_trung_binh >= 7)
        {
            diem_chu = 'B';
            GPA = 3.0;
            xep_loai = "Kha";
        }
        else if (diem_trung_binh >= 5.5)
        {
            diem_chu = 'C';
            GPA = 2.0;
            xep_loai = "Trung binh";
        }
        else if (diem_trung_binh >= 4)
        {
            diem_chu = 'D';
            GPA = 1.0;
            xep_loai = "Yeu";
        }
        else
        {
            diem_chu = 'F';
            GPA = 0.0;
            xep_loai = "Kem (Truot)";
        }

        if (diem_trung_binh <= 10)
        {
            Console.WriteLine($"Diem TB thang 10: {diem_trung_binh.ToString("F2")}");
            Console.WriteLine($"Diem chu quy doi: {diem_chu}");
            Console.WriteLine($"Diem GPA thang 4: {GPA:F1}");
            Console.WriteLine($"Xep loai hoc luc: {xep_loai}");
        }
    }
}