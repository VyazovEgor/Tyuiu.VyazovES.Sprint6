using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {

        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] result = new double[0]; // Инициализируем пустой массив
            int index = 0;

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                // Список для хранения отфильтрованных чисел
                List<double> filteredNumbers = new List<double>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Заменяем запятые на точки для корректного парсинга
                    string normalizedLine = line.Replace(',', '.');

                    if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        // Добавляем только если число меньше 10
                        if (number < 10)
                        {
                            // Округляем до трёх знаков после запятой
                            filteredNumbers.Add(Math.Round(number, 3));
                        }
                    }
                }

                // Преобразуем список в массив
                result = filteredNumbers.ToArray();
                index = result.Length; // Обновляем индекс
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

