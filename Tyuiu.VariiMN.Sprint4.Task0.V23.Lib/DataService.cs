using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.VariiMN.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
        {
            int sum = 1;
            for(int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum *= array[i];
                }
            }
            return sum;
        }
    }
}
