using System;

namespace Assignment1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 30m * 20.3823m;
            Console.WriteLine($"Сумма { Math.Round(sum, 3)}", MidpointRounding.AwayFromZero);
        }
    }
}
