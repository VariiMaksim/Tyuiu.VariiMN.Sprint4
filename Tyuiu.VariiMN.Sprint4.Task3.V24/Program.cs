using Tyuiu.VariiMN.Sprint4.Task3.V24.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8.                          *");
            Console.WriteLine("* Найдите минимальный элемент во втором столбце массива.                  *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int[,] mas2 = new int[5, 5] { { 3, 6, 1, 7, 3 },
                                          { 2, 3, 7, 1, 1 },
                                          { 1, 2, 5, 5, 1 },
                                          { 7, 6, 7, 6, 2 },
                                          { 7, 6, 4, 5, 8 } };
            Console.WriteLine("Массив 5x5: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mas2[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);


            Console.WriteLine("Min во втором столбце: " + res);
            Console.ReadKey();
        }
    }
}