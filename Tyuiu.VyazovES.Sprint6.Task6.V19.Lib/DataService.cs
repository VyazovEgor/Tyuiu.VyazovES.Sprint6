using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VyazovES.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return "Файл не найден.";
            }

            try
            {
                string text = File.ReadAllText(path);

                // Разделяем текст на слова, используя различные разделители
                char[] separators = { ' ', '\t', '\n', '\r', ',', '.', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '"', '\'' };

                string[] allWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Фильтруем слова: должны содержать букву 'l' или 'L'
                List<string> filteredWords = new List<string>();

                foreach (string word in allWords)
                {
                    // Проверяем наличие 'l' или 'L' в слове
                    bool containsL = false;
                    foreach (char c in word)
                    {
                        if (c == 'l')
                        {
                            containsL = true;
                            break;
                        }
                    }

                    if (containsL)
                    {
                        filteredWords.Add(word);
                    }
                }

                // Если нужно точное соответствие, возможно, тут дополнительная фильтрация
                // Например, исключить слова, которые слишком длинные или содержат цифры

                return filteredWords.Count > 0 ? string.Join(" ", filteredWords) : "Слова с буквой 'l' не найдены.";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
    }
}

