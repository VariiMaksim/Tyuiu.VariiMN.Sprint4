using Tyuiu.VariiMN.Sprint4.Task4.V10.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task4.V10
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич  | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 1 до 7.              *");
            Console.WriteLine("* Заменить нечётные элементы массива на 0.                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];
            Console.WriteLine("Введите 25 целых чисел в диапазоне от 1 до 7:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    string input = Console.ReadLine();
                    int value = int.Parse(input);

                    if (value < 2 || value > 8)
                    {
                        Console.WriteLine("!Вне dungeon");
                        j--; 
                        continue;
                    }

                    array[i, j] = value;
                }
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < 4) Console.Write(", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] modifiedArray = ds.Calculate(array);

            Console.WriteLine("Массив после замены нечётных на 0:");
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