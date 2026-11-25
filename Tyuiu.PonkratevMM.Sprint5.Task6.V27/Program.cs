using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task6.V27.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Спринт #5 | Вариант 27 | Таск 6 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Таск #6                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных. Найти количество трехзначных чисел*");
            Console.WriteLine("* в заданной строке. Результат вывести на консоль.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V27.txt");
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Данные:");
            Console.WriteLine(File.ReadAllText(path));

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество трёхзначных чисел в строке: {result}");

            Console.ReadKey();
        }
    }
}