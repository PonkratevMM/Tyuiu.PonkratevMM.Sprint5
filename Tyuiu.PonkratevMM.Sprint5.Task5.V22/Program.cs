using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task5.V22.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Спринт #5 | Вариант 22 | Таск 5 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Таск #5                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором значений. Найти минимальное целое число, которое     *");
            Console.WriteLine("* делится на 4. Результат вывести на консоль.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Данные:");
            Console.WriteLine(File.ReadAllText(path));

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальное целое число, кратное 4: {result:F3}");

            Console.ReadKey();
        }
    }
}