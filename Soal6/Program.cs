/*
    📌 تکالیف
    سوال 6: نمایش بالاترین جایگاه ارقام یک عدد
*/

using System;

namespace Takalif.Soal6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("لطفاً یک عدد وارد کنید: ");
            num = int.Parse(Console.ReadLine());

            if (num < 10)
                Console.WriteLine("بالاترین رقم: " + num);
            else if (num < 100)
                Console.WriteLine("بالاترین رقم: " + (num / 10));
            else if (num < 1000)
                Console.WriteLine("بالاترین رقم: " + (num / 100));
            else if (num < 10000)
                Console.WriteLine("بالاترین رقم: " + (num / 1000));
            else if (num < 100000)
                Console.WriteLine("بالاترین رقم: " + (num / 10000));
            else
                Console.WriteLine("خطا: عدد باید کمتر از 100000 باشد.");

            Console.ReadKey();
        }
    }
}
