using Tyuiu.PonkratevMM.Sprint5.Task0.V27.Lib;
using System;

namespace Tyuiu.PonkratevMM.Sprint5.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Вариант 27 | Таск 0 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Таск #0                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}