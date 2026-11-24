using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task2.V10.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Спринт #5 | Вариант 10 | Таск 2 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Таск #2                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv      *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int cols = 3;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Введите элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine() ?? string.Empty);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат (положительные -> 1, остальные -> 0):");
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                Console.Write("| ");
                for (int j = 0; j < parts.Length; j++)
                {
                    Console.Write($"{parts[j],5}");
                    Console.Write(" ");
                }
                Console.WriteLine(" |");
            }

            Console.WriteLine();
            Console.WriteLine($"Файл сохранён: {path}");
            Console.ReadKey();
        }
    }
}