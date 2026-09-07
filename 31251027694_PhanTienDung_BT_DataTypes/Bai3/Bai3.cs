using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _31251027694_PhanTienDung_BT_DataTypes
{
    public enum CurrencyType
    {
        USD,
        EUR,
        JPY,
        GBP,
    }
    public static class BankConfig
    {
        public static readonly Dictionary<CurrencyType, decimal> ExchangeRates = new Dictionary<CurrencyType, decimal>
        {
            { CurrencyType.USD, 25400.0m },
            { CurrencyType.EUR, 27200.0m },
            { CurrencyType.JPY, 165.0m },
            { CurrencyType.GBP, 32100.0m }
        };
        public static decimal ConvertVndToForeign(decimal vndAmount, CurrencyType targetCurrency)
        {
            if (ExchangeRates.TryGetValue(targetCurrency, out decimal rate))
            {
                if (rate == 0) throw new DivideByZeroException("Ty gia khong the bang 0.");
                return vndAmount / rate;
            }
            throw new ArgumentException("Khong tim thay ti gia");
        }
    }
    internal class Bai_3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so tien VND: ");
            decimal VND = Convert.ToDecimal(Console.ReadLine());
            decimal Tax = 0.005M * VND;
            Console.Write("Chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP: ");
            byte choice = Convert.ToByte(Console.ReadLine());
            CurrencyType targetCurrency = (CurrencyType)(choice - 1);
            Console.WriteLine($"Phi dich vu (0.5%): {Tax.ToString("N0")} VND");
            Console.WriteLine($"So tien VND tinh doi: {(VND - Tax).ToString("N0")} VND");
            try
            {
                decimal foreignAmount = BankConfig.ConvertVndToForeign(VND - Tax, targetCurrency);
                foreignAmount = Math.Round(foreignAmount, 2);
                Console.WriteLine($"So tien ngoai te nhan duoc: {foreignAmount:N2} {targetCurrency}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nLoi: {ex.Message}. Vui long kiem tra lai lua chon ngoai te.");
            }
        }
    }
}