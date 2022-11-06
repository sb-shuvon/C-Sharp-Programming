using System;
namespace Switch
{
    class program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any letter : ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel\n");
                    break;

                default:
                    Console.WriteLine("Consonent\n");
                    break;
            }



        }
    }
}