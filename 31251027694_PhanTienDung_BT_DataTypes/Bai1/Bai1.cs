using System;
using System.Collections.Generic;
using System.Text;

namespace _31251027694_PhanTienDung_BT_DataTypes
{
    internal class Bai_1
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chi so dien cu (kWh): ");
            int csd_cu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chi so dien moi (kWh): ");
            int csd_moi = Convert.ToInt32(Console.ReadLine());
            while (csd_moi < csd_cu)
            {
                Console.WriteLine("So dien moi phai lon hon so dien cu!");
                Console.Write("Nhap chi so dien moi (kWh): ");
                csd_moi = Convert.ToInt32(Console.ReadLine());
            }
            int consumption = csd_moi - csd_cu;
            double bill = 0;
            if (consumption <= 50)
            {
                bill = consumption * 1806;
            }
            else if (consumption <= 100)
            {
                bill = (50 * 1806) + ((consumption - 50) * 1866);
            }
            else if (consumption <= 200)
            {
                bill = (50 * 1806) + (50 * 1866) + ((consumption - 100) * 2167);
            }
            else if (consumption <= 300)
            {
                bill = (50 * 1806) + (50 * 1866) + (100 * 2167) + ((consumption - 200) * 2729);
            }
            else
            {
                bill = (50 * 1806) + (50 * 1866) + (100 * 2167) + (100 * 2729) + ((consumption - 300) * 3050);
            }
            double VAT = bill * 0.08;
            Console.WriteLine($"So dien tieu thu: {consumption} kWh");
            Console.WriteLine($"Tien dien chua thue: {bill.ToString("#,##0")} VND");
            Console.WriteLine($"Thue VAT (8%): {VAT.ToString("#,##0")} VND");
            Console.WriteLine($"Tong thanh toan: {(bill + VAT).ToString("#,##0")} VND");
        }
    }
}