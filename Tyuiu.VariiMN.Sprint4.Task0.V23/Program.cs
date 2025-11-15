using Tyuiu.VariiMN.Sprint4.Task0.V23.Lib;

namespace Tyuiu.VariiMN.Sprint4.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Варий М.Н. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич | ИСПб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов,                    *");
            Console.WriteLine("* заполненный статически значениями в диапазоне от 0 до 9:                *");
            Console.WriteLine("* {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                                          *");
            Console.WriteLine("* Подсчитать произведение нечётных элементов массива.                     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsarray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Массив: ");
            for (int i = 0; i < numsarray.Length - 1; i++)
            {
                Console.WriteLine(numsarray[i]);
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumOdd = ds.GetMultOddArrEl(numsarray);

            Console.WriteLine("Сумма нечётных элементов = " + sumOdd);

            Console.ReadKey();
        }
    }
}