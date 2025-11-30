using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int start, int end)
        {
            int size = end - start + 1;
            double[] result = new double[size];
            int index = 0;

            for (int x = start; x <= end; x++)
            {
                // Вычисляем значение функции для текущего x
                double res = CalculateFunction(x);
                res = Math.Round(res, 2);
                result[index] = res;
                index++;
            }

            return result;
        }

        private double CalculateFunction(double x)
        {
            try
            {
                // F(x) = 5 - 3x + (1 + sin(x)) / (2x - 0.5)
                double numerator = 1 + Math.Sin(x);
                double denominator = 2 * x - 0.5;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 1e-10)
                {
                    return 0;
                }

                return 5 - 3 * x + numerator / denominator;
            }
            catch
            {
                return 0;
            }
        }
    }
}

