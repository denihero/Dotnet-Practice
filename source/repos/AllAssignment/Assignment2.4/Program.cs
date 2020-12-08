using System;

namespace Assignment2._4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите первое число");
			decimal a = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Введите второе число");
			decimal b = decimal.Parse(Console.ReadLine());

			Console.WriteLine("Что хотите сделать ?");
			Console.WriteLine(" 1) +\n 2) - \n 3) * \n 4) / \n 5) %");

			int choose = int.Parse(Console.ReadLine());
			if (choose == 1)
			{
				a += b;
				Console.WriteLine(a);
			}
			else if (choose == 2)
			{
				a -= b;
				Console.WriteLine(a);
			}
			else if (choose == 3)
			{
				a *= b;
				Console.WriteLine(a);
			}
			else if (choose == 4)
			{
				a /= b;
				Console.WriteLine(a);
			}
			else if (choose == 5)
			{
				a %= b;
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine("Вы должны ввести цифры от 1 до 5");
			}

		}
	}
}
