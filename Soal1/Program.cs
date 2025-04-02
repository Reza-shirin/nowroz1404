/*
    📌 تکالیف
    سوال 2: محاسبه تعداد روزهایی که یک فرد تا نوروز 1404 زندگی کرده است
*/

using System;

namespace Takalif.Soal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, m, d, r, r1, r2;
            Console.WriteLine("لطفاً سال تولد خود را وارد کنید: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً ماه تولد خود را وارد کنید: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً روز تولد خود را وارد کنید: ");
            d = int.Parse(Console.ReadLine());

            r1 = (1404 - y - 1) * 365;
            if (m <= 6)
                r2 = 365 - ((m - 1) * 31 + d);
            else
                r2 = 365 - (186 + (m - 7) * 30 + d);
            r = r1 + r2;

            Console.WriteLine("شما '" + r + "' روز زندگی کرده‌اید.");
            y = r / 365;
            m = (r % 365) / 30;
            d = ((r % 365) % 30);
            Console.WriteLine(y + " سال و " + m + " ماه و " + d + " روز");
            Console.ReadKey();
        }
    }
}
