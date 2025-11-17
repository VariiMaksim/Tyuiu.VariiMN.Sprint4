using System.Net.Http.Headers;
using Tyuiu.VariiMN.Sprint4.Task5.V26.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич  | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4.                           *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                   *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            int[,] mas2 = new int[5, 5];
            Console.WriteLine("Массив 5x5 (случайные числа от -4 до 4):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas2[i, j] = rnd.Next(-4, 5); 
                    Console.Write(mas2[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }

            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] modifiedArray = ds.Calculate(mas2);

            Console.WriteLine("Массив после замены положительных элементов на 1:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(modifiedArray[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}