using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную X для формулы Y = sin^2-x/2-|cos2X|");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите переменную Y для формулы k1 = (корень)8X^2-3/|2X^2Y|(/корень) - (X+Y)^2/2XY");
            double y = Convert.ToDouble(Console.ReadLine());

            double Z()
            {
                double S = Math.Sin(Math.Pow(x / 2, 2));
                double C = Math.Abs(Math.Cos(2 * x));
                double Y = S - C;
                return Y;
            }
            double k1()
            {
                double Q = Math.Sqrt((8 * Math.Pow(x, 2) - 3) / Math.Abs(2 * Math.Pow(x, 2) * y));
                double Qe = Math.Pow((x + y), 2) / (2 * x * y);
                double K1 = Q - Qe;
                return K1;
            }
            double R = Z();
            double R1 = k1();
            Console.WriteLine("y = {0}", R);
            Console.WriteLine("k1 = {0}", R1);
            Console.ReadKey();
        }
    }
}
