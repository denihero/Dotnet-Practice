using System;

namespace Assignment1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите не целое число");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Math.Round(number));
        }
    }
}
