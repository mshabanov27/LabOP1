using System;

namespace ConsoleApp2
{
    class Lab1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть меншу основу: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введіть більшу основу: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введіть висоту: ");
            double h = double.Parse(Console.ReadLine());
            double S = (a + b)*h/2;
            double c = Math.Sqrt(((b - a)*(b - a) / 4) + h*h);
            double P = a + b + 2 * c;
            Console.WriteLine("Площа трапеції дорівнює " + S);
            Console.WriteLine("Периметр трапеції дорівнює " + P);
        }
    }
}
