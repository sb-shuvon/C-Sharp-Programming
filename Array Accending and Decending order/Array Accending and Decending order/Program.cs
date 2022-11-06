using System;
namespace Array_Sorted 
{
    class program
    {
        static void Main(string[] args)
        {
            int i, j,temp;
            int[] array = new int[5];

            Console.WriteLine("Enter 5 Element: ");
            for (i = 0; i < 5; i++)
            {
                 array[i] =Convert.ToInt32(Console.ReadLine());
            }
            
            for (i = 0; i < 5; i++)
            {
                for (j =i+1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }

            Console.WriteLine("Ascending order : ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Desending order : ");
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}