using System;

namespace Lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть значення x: ");
            double x = double.Parse(Console.ReadLine());
            if (x > -1 && x < 1)
            {
                int i = 0;
                int n = i;
                double R0 = 2 * x;
                double RPrev = 2 * Math.Pow(x, 3) / 3;
                double Rn = Math.Pow(x, 2) * (n - 0.5) * RPrev / (n + 0.5);
                double S = R0 + RPrev;
                do
                {
                    i += i;
                    n = i;
                    RPrev = (Math.Pow(x, 2) * (n - 1.5)) * RPrev / (n - 0.5);
                    Rn = Math.Pow(x, 2) * (n - 0.5) * Rn / (n + 0.5);
                    S = S + Rn;
                } while (Math.Abs(Rn - RPrev) >= Math.Pow(10, -4));
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("Введений аргумент не входить в область визначення.");
            }
        }
    }
}

