using System;
namespace Triangle_Area
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 12;
            int b = 13;
            int c = 14;
            double s, area;

            if ((a + b > c) && (b + c > a) && (c + a > b))
            {
                s = (a + b + c) / 2;

                area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("Triangle Area = "+ area);

            }

            else
            {
                Console.WriteLine("Triangle is not possible");
            }
        }
    }
}
