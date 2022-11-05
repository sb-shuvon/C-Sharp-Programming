using System;
namespace sum_series
{
    class program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Enter n : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 5; i <= n; i = i + 5)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum = " +sum);

        }
    }
}