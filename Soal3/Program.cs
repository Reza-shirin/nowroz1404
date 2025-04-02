/*
    📌 تکالیف
    سوال 3: بررسی اینکه آیا سه عدد یک تصاعد حسابی تشکیل می‌دهند یا نه
*/

using System;

namespace Takalif.Soal3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, e1, e2;
            Console.Write("لطفاً عدد اول را وارد کنید: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("لطفاً عدد دوم را وارد کنید: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("لطفاً عدد سوم را وارد کنید: ");
            num3 = int.Parse(Console.ReadLine());

            e1 = num1 - num2;
            e2 = num2 - num3;

            if (e1 == e2)
                Console.WriteLine("این سه عدد یک تصاعد حسابی تشکیل می‌دهند!");
            else
                Console.WriteLine("این سه عدد یک تصاعد حسابی تشکیل نمی‌دهند!");
                
            Console.ReadKey();
        }
    }
}
