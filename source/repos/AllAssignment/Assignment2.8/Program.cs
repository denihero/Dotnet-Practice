using System;

namespace Assignment2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введит высоту");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int x = i; x <= n; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
