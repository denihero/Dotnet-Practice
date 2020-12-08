using System;

namespace Assignment2._6
{
    class Program
    {
        static void Main(string[] args)
        {
			int pow_1 = 0;
			Console.WriteLine("Введите число");
			double num = Convert.ToDouble(Console.ReadLine());

			do
			{
				Console.WriteLine("Введите степень в которую хотите преобразовать ");
				double pow = Convert.ToDouble(Console.ReadLine());
				if (pow > 10)
				{
					Console.WriteLine("Вводите числа с 1 до 10 !");
					pow_1 = 11;
				}
				else if (pow < 10)
				{
					double answ = Math.Pow(num, pow);
					Console.WriteLine($"Ваше число {answ}");
					break;
				}
			} while (pow_1 > 10);


		}
	}
}
