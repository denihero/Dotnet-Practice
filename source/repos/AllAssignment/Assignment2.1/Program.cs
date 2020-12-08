using System;

namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите число");
			int a = Convert.ToInt32(Console.ReadLine());

			int num = a % 2;

			if (num == 0)
			{
				Console.WriteLine($"Четное {num}");
			}
			else if (num != 0)
			{
				Console.WriteLine($"Нечетное {num}");
			}
		}
    }
}
