using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int start, int end)
        {
            int size = end - start + 1;
            double[] result = new double[size];
            int index = 0;
            for (int x = start; x <= end; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                //if (Math.Abs(denominator) < 1e-10) {
                //    return 0;
                //}

                double numerator = 2 * x - 3;
                double fraction = numerator / denominator;
                double res = fraction + 5 * x - 6;
                res = Math.Round(res, 2);
                result[index] = res;
                index++;
            }

            return result;

        }
    }
}

