using System;
namespace findMaxValue
{
    class program
    {
        static void Main(string[] args)
        {
            var A = 10;
            var B = 50;
            var C = 30;

            if (A > B && A > C)
            {
                Console.WriteLine("Lerge Value: "+A);
            }

            else if (B > A && B > C)
            {
                Console.WriteLine("Lerge Value: "+B);
            }

            else if (C > A && C > B)
            {
                Console.WriteLine("Lerge Value: "+C);
            }

            else
                Console.WriteLine("Numbers are equal");

        }
    }
}

