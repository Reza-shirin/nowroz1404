using System;

namespace مضارب_5_بین_دو_عدد
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("لطفاً عدد اول را وارد کنید: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("لطفاً عدد دوم را وارد کنید: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("مضارب ۵ بین {0} و {1} عبارتند از:", a, b);
            for (int i = a + 1; i < b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
