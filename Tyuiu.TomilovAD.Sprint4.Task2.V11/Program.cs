using System.Security.Cryptography;
using Tyuiu.TomilovAD.Sprint4.Task2.V11.Lib;

namespace Tyuiu.TomilovAD.Sprint4.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] numsarray = new int[15];

            for (int i = 1; i <= 10; i++)
            {
                numsarray[i] = rnd.Next(3, 8);
            }

            Console.WriteLine(ds.Calculate(numsarray));
            Console.ReadKey();
        }
    }
}