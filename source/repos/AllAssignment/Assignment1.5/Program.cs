using System;

namespace Assignment1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal plm = Convert.ToDecimal(Console.ReadLine());
            decimal sum = plm * 20.3823m;
            Console.WriteLine($"Сумма {Math.Round(sum, 3)}", MidpointRounding.AwayFromZero);
        }
    }
}
