/*
    📌 تکالیف
    سوال 5: محاسبه هزینه مصرف برق یک خانواده بر اساس مقدار مصرف
*/

using System;

namespace Takalif.Soal5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, h;
            Console.Write("لطفاً میزان مصرف برق (کیلووات) را وارد کنید: ");
            k = int.Parse(Console.ReadLine());

            if (k <= 5)
            {
                h = 0;
            }
            else if (k <= 20)
            {
                h = (k - 5) * 1000;
            }
            else
            {
                h = 15000 + ((k - 20) * 5000);
            }

            Console.WriteLine("هزینه مصرف برق: " + h + " تومان");
            Console.ReadLine();
        }
    }
}
