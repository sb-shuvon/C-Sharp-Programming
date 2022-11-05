using System;
namespace Quadratic
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c = 4;
            double d,x, x1, x2;

            d = Math.Sqrt(b * b - 4 * a * c);

            if (d > 0)
            {
                x1 = (-b + d) / 2 * a;
                x2 = (-b - d) / 2 * a;

                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
            else if(d==0)
                {
                x = (-b / 2 * a);

                   Console.WriteLine("X = " + x);
                   Console.WriteLine("X = " + x);
            }
            else
            {
                Console.WriteLine("Root are imeainary");
            }
        }
    }
}