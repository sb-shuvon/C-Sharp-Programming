using System;
namespace sum
{
    class program
    {
        static void Main(string[] args)
        {
            int i,sum=0;

            for (i = 1; i < 100; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("1 to 100 sum = " + sum);

        }
    }
}