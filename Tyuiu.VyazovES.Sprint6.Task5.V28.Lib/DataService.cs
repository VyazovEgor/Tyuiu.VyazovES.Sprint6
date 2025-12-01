using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] result = new double[0]; // Инициализируем пустой массив
            int index = 0;

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                // Сначала считаем, сколько у нас будет чисел
                int count = 0;
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string normalizedLine = line.Replace(',', '.');
                        if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                        {
                            count++;
                        }
                    }
                }

                // Создаем массив нужного размера
                result = new double[count];

                // Заполняем массив числами
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Заменяем запятые на точки для корректного парсинга
                    string normalizedLine = line.Replace(',', '.');

                    if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        // Округляем до трёх знаков после запятой
                        result[index] = Math.Round(number, 3);
                        index++;
                    }
                }
            }
            catch (Exception)
            {
                // В случае ошибки возвращаем пустой массив
                result = new double[0];
            }

            return result;
        }
    }
}

