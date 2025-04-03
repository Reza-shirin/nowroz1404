/*
    📌 تکالیف
    سوال 7: انجام عملیات ریاضی بر اساس ورودی کاربر
*/

using System;

namespace Takalif.Soal7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            int c;

            Console.Write("لطفاً عدد اول را وارد کنید: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("لطفاً عدد دوم را وارد کنید: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("لطفاً عملیات مورد نظر را انتخاب کنید:");
            Console.WriteLine("1- ضرب (Multiplication)");
            Console.WriteLine("2- تقسیم (Division)");
            Console.WriteLine("3- جمع (Addition)");
            Console.WriteLine("4- تفریق (Subtraction)");
            Console.Write("عدد عملیات: ");
            c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine("نتیجه = " + (a * b));
                    break;
                case 2:
                    if (b != 0)
                        Console.WriteLine("نتیجه = " + (a / b));
                    else
                        Console.WriteLine("خطا: تقسیم بر صفر امکان‌پذیر نیست.");
                    break;
                case 3:
                    Console.WriteLine("نتیجه = " + (a + b));
                    break;
                case 4:
                    Console.WriteLine("نتیجه = " + (a - b));
                    break;
                default:
                    Console.WriteLine("خطا: عملیات نامعتبر.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
