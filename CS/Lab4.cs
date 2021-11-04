using System;

namespace Lab4
{
    class Lab4
    {
        static void Main(string[] args)
        {
            float xn = 1 / 103;
            for (int i = 2; i < 52; i++)
            {
                xn = 1 / ((105 - 2 * i) + xn);
                Console.WriteLine(xn);
            }
        }
    }
}
