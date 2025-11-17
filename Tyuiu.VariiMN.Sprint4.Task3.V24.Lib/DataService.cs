using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VariiMN.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 1];

            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[i, 1] < min)
                    min = array[i, 1];
            }

            return min;
        }
    }
}
