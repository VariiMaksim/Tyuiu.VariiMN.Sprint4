using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VariiMN.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length > 5);
            return mas.Length;
        }
    }
}
