/*
    📌 تکالیف
    سوال 1: محاسبه اختلاف سنی بر اساس سال، ماه و روز تولد
*/

using System;

namespace Takalif.Soal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y1, m1, d1, y2, m2, d2, r, r1, r2, r3;
            Console.WriteLine("لطفاً سال تولد نفر اول را وارد کنید: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً ماه تولد نفر اول را وارد کنید: ");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً روز تولد نفر اول را وارد کنید: ");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً سال تولد نفر دوم را وارد کنید: ");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً ماه تولد نفر دوم را وارد کنید: ");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("لطفاً روز تولد نفر دوم را وارد کنید: ");
            d2 = int.Parse(Console.ReadLine());

            if (m1 <= 6)
            {
                r1 = 365 - (m1 - 1) * 31 + d1;
            }
            else
            {
                r1 = 365 - (186 + ((m1 - 7) * 30) + d1);
            }
            if (m2 <= 6)
            {
                r2 = 365 - (m2 - 1) * 31 + d2;
            }
            else
            {
                r2 = 365 - (186 + ((m2 - 7) * 30) + d2);
            }
            r3 = (y2 - y1 - 1) * 365;
            r = r1 + r2 + r3;
            Console.WriteLine("اختلاف سنی به روز: " + r);
            Console.ReadKey();
        }
    }
}
