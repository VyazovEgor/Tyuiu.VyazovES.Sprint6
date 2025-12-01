using System.Data;
using System.Globalization;
using System.Reflection.Metadata;
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

                // Убираем пустые строки
                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                if (lines.Length == 0)
                {
                    return new int[0, 0];
                }

                // Определяем количество строк и столбцов
                int rows = lines.Length;

                // Используем правильный разделитель - точку с запятой
                string[] firstLineValues = lines[0].Split(';');
                int cols = firstLineValues.Length;

                // Создаем матрицу
                int[,] matrix = new int[rows, cols];

                // Заполняем матрицу
                for (int i = 0; i < rows; i++)
                {
                    string[] values = lines[i].Split(';');

                    for (int j = 0; j < cols; j++)
                    {
                        if (j < values.Length && int.TryParse(values[j].Trim(), out int value))
                        {
                            // Изменяем значения во втором столбце (индекс 1)
                            // Положительные значения больше 5 меняем на 222
                            if (j == 1 && value > 5 && value > 0)
                            {
                                matrix[i, j] = 222;
                            }
                            else
                            {
                                matrix[i, j] = value;
                            }
                        }
                        else
                        {
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

