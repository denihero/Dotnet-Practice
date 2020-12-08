using System;

namespace Assignment2._7
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите длинну фигуры");
			int l = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите ширину фигуры");
			int w = int.Parse(Console.ReadLine());

			for (int i = 1; i <= l; i++)
			{
				for (int j = 1; j <= w; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
    }
}
