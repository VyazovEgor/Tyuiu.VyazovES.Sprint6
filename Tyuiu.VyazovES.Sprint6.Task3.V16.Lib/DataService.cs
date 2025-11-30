using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] a)
        {
            for (int j = 0; j < 5; j++)
            {
                if (a[2, j] % 2 == 0)
                {
                    a[2, j] = 0;
                }
            }

            return a;
        }
    }
}

