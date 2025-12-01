using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(path))
            {
                return "Файл не найден.";
            }

            try
            {
                // Читаем весь текст из файла
                string text = File.ReadAllText(path);

                // Разбиваем текст на слова, используя различные разделители
                char[] separators = new char[]
                {
            ' ', '\t', '\n', '\r',
            ',', '.', '!', '?', ';', ':',
            '(', ')', '[', ']', '{', '}',
            '"', '\'', '-', '—', '–', '…'
                };

                // Разделяем текст на слова
                string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Создаем список для хранения слов с буквой 'l'
                List<string> wordsWithL = new List<string>();

                // Проверяем каждое слово
                foreach (string word in words)
                {
                    // Убираем возможные знаки препинания вокруг слова
                    string cleanWord = word.Trim();

                    // Проверяем, содержит ли слово букву 'l' (регистронезависимо)
                    if (cleanWord.IndexOf('l', StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        wordsWithL.Add(cleanWord);
                    }
                }

                // Если нашли слова с 'l', объединяем их в строку
                if (wordsWithL.Count > 0)
                {
                    // Объединяем слова через пробел
                    return string.Join(" ", wordsWithL);
                }
                else
                {
                    return "Слова с буквой 'l' не найдены.";
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок чтения файла
                return $"Ошибка при чтении файла: {ex.Message}";
            }
        }
    }
}

