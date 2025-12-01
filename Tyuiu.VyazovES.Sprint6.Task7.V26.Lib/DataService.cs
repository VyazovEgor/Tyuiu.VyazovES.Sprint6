using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        public int[,] GetMatrix(string path)
        {
            try
            {

                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                // Определяем размеры матрицы
                int rows = lines.Length;
                if (rows == 0) return new int[0, 0];

                // Разбиваем первую строку для определения количества столбцов
                string[] firstLineValues = lines[0].Split(',');
                int cols = firstLineValues.Length;

                // Создаем двумерный массив
                int[,] matrix = new int[rows, cols];

                // Заполняем массив данными из файла
                for (int i = 0; i < rows; i++)
                {
                    // Разбиваем строку на значения
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < cols; j++)
                    {
                        // Парсим значение в целое число
                        if (int.TryParse(values[j].Trim(), out int value))
                        {
                            matrix[i, j] = value;

                            // Изменяем значения во втором столбце (индекс 1)
                            // Положительные значения больше 5 меняем на 222
                            if (j == 1 && value > 5 && value > 0)
                            {
                                matrix[i, j] = 222;
                            }
                        }
                        else
                        {
                            // Если не удалось распарсить, оставляем 0
                            matrix[i, j] = 0;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception)
            {
                return new int[0, 0];
            }
        }
    }
}

