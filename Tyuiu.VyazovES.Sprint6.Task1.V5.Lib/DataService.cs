using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int start, int end)
        {
            int size = end - start + 1;
            double[] result = new double[size];
            int index = 0;
            for (int x = start; x <= end; x++)
            {
                // Вычисляем значение функции для текущего x
                double res = Math.Sin(x) + (Math.Cos(2 * x) / 2) - (1.5 * x);
                res = Math.Round(res, 2);
                result[index] = res;
                index++;
            }

            return result;
        }
    }
}

