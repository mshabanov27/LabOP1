using System;

namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть число k: ");
            int k = int.Parse(Console.ReadLine());
            int num;
            if (k % 2 == 1)
            {
                num = k / 20 + 1;
                Console.WriteLine("Цифра дорівнює: " + num);
            }
            else if (k % 2 == 0)
            {
                num = ((k / 2) - 1) % 10;
                Console.WriteLine("Цифра дорівнює: " + num);
            }
        }
    }
}
