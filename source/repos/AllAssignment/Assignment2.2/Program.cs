using System;

namespace Assignment2._2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("a * b \n------\na + b");

			Console.WriteLine("Введите A");
			decimal a = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Введите B");
			decimal b = Convert.ToDecimal(Console.ReadLine());


			decimal firstStep = a * b;
			decimal secondStep = a + b;

			decimal third = firstStep / secondStep;

			Console.WriteLine(third);
		}
    }
}
