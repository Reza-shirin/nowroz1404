/*
    📌 تکالیف
    سوال 4: مرتب کردن سه عدد به ترتیب صعودی
*/

using System;

namespace Takalif.Soal4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("لطفاً عدد اول را وارد کنید: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("لطفاً عدد دوم را وارد کنید: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("لطفاً عدد سوم را وارد کنید: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                d = a; a = b; b = d;
            }
            if (a > c)
            {
                d = a; a = c; c = d;
            }
            if (b > c)
            {
                d = b; b = c; c = d;
            }

            Console.WriteLine("اعداد مرتب‌شده: " + a + " - " + b + " - " + c);
            Console.ReadLine();
        }
    }
}
