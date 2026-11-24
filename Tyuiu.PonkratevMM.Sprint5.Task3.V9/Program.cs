using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task3.V9.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Вариант 9 | Таск 3 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с бинарными файлами                                        *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Таск #3                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: y = x^3 / (x^2 - 1). Вычислить его значение при x = 3,   *");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на    *");
            Console.WriteLine("* консоль. Округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            double result;
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = br.ReadDouble();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"y = {result:F3}");

            Console.WriteLine();
            Console.WriteLine($"Файл сохранён: {path}");
            Console.ReadKey();
        }
    }
}