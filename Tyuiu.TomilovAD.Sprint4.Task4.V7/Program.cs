using Tyuiu.TomilovAD.Sprint4.Task4.V7.Lib;
namespace Tyuiu.TomilovAD.Sprint.Task.V
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] numsarray = new int[5,5];

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Введите " + i + " элемент массива строки" +j);
                    numsarray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(ds.Calculate(numsarray));
            Console.ReadKey();
        }
    }
}