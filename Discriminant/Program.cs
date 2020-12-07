using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод пользователя значении
            Console.WriteLine("Введите значение a");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c");
            int C = Convert.ToInt32(Console.ReadLine());

            //Формула дискриминанта
            double D = Math.Pow((B), 2) - 4.0 * (A) * (C);

            Console.WriteLine($"D равен {D}", D);

            if (D > 0)
            {
                //Формула вычисление если дисриминант больше нуля 
                double X1 = (-(B) + Math.Sqrt(Math.Pow((B), 2) - 4.0 * (A) * (C))) / (2.0 * (A));
                double X2 = (-(B) - Math.Sqrt(Math.Pow((B), 2) - 4.0 * (A) * (C))) / (2.0 * (A));

                Console.WriteLine($"X1 равен {X1} | X2 равен {X2}", X1, X2);
                Console.ReadLine();
            }
            else if (D == 0)
            {
                //Формула вычисление если дисриминант равен нулю 
                double X3 = (-(B)) / (2.0 * (A));

                Console.WriteLine($"Дискримнант равент 0 поэтому ответ один {X3}", X3);
                Console.ReadLine();

            }
            else
            {
                //Ответ если корень ниже нуля 
                Console.WriteLine("Корней нет");
                Console.ReadLine();
            }

        }
    }
}
