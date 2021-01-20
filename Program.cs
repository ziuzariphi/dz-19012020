using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 16.8, b = 12.4;

            double A = 1.4, B = -5.5, C = 0.6, AC, BC;
            AC = Math.Abs(A - C);
            BC = Math.Abs(B - C);

            double x1 = -6.2, y1 = 5.2, x2 = 2.1, y2 = 9.8;

            int x, y, xy = 41;

            x = xy / 10;
            y = xy % 10;

            double N = 10985;

            int K = 202;

            Console.WriteLine(Math.Sqrt(a * b));
            Console.WriteLine(AC + " " + BC + " " + (AC + BC));
            Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.WriteLine(y + "" + x);
            Console.WriteLine(N / 60);
            Console.WriteLine(K - 7 * (K / 7));
        }
    }
}
