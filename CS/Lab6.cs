using System;

namespace Lab6
{
    class Lab6
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            while(a <= 0)
            {
                Console.Write("The number should be positive, try again: ");
                a = double.Parse(Console.ReadLine());
            }

            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            while (b <= 0)
            {
                Console.Write("The number should be positive, try again: ");
                b = double.Parse(Console.ReadLine());
            }

            Console.Write("Enter how accurate the result should be: ");
            double accuracy = double.Parse(Console.ReadLine());
            while (accuracy <= 0)
            {
                Console.Write("The number should be positive, try again: ");
                accuracy = double.Parse(Console.ReadLine());
            }

            double resultY = calcRoot(accuracy, calcRoot(accuracy, a * b)) + calcRoot(accuracy, a);
            Console.WriteLine(resultY);
        }

        static double calcRoot(double n, double x)
        {
            if (n == 0)
                return x;
            else
                return 0.2 * ((x / Math.Pow(calcRoot(n - 1, x), 4)) + (4 * calcRoot(n - 1, x)));
        }
    }
}
