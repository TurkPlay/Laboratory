using System;

namespace lab222
{
    public class StringTasks
    {
        public static string Task1(string word)
        {
            string result1 = word[8].ToString() + word[10] + word[14] + word[6] + word[2] + word[4];
            string result2 = word[14].ToString() + word[10] + word[4] + word[3];
            return $"Задача 1 \n Было: {word} \n Стало :{result1}, {result2} \n";

        }

        public static string Task2(string word)
        {

            string result = word[1].ToString() + word[3];
            return $"Задача 2 \n Было: {word} \n Стало :{result} \n";

        }

        public static string Task3(string word)
        {
            string firstHalf = word.Substring(0, word.Length / 2);
            return $"Задача 3 \n Слово: {word} \n Первая половина: {firstHalf} \n";
        }

        public static string Task4(string word, int m, int n)
        {
            string result = word.Substring(m - 1, n - m + 1);
            return $" Результат: {result} \n";
        }

        public static string Task5(string word)
        {


            string result = word.Replace('о', 'у');
            return $"Задача 5 \n Было: {word} \n Стало: {result} \n ";
        }

        public static string Task6(string word)
        {


            string result = word.Remove(0, word.Length / 2) + word.Remove(word.Length / 2);
            return $"Задача 6 \n Было: {word} \n Стало: {result} \n";
        }

        public static string Task7(string sentense)
        {
            string result = sentense.Replace('е', 'и');
            return $"Задача 7 - Замена 'е' на 'и' \n Результат: {result}\n";
        }

        public static string Task8(string text)
        {
            string result = text.Replace(' ', '_');
            return $"Задача 8 - Замена пробелов на подчеркивания \n Результат: {result}\n";
        }

        public static string Task9(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 1; i < chars.Length; i += 2)
            {
                chars[i] = 'ы';
            }
            string result = new string(chars);
            return $"Задача 9 - Замена каждого второго символа на 'ы' \n Результат: {result}\n";
        }

        public static string Task10(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 2; i < chars.Length; i += 3)
            {
                chars[i] = 'а';
            }
            string result = new string(chars);
            return $"Задача 10 - Замена каждого третьего символа на 'а' \n Результат: {result}\n";
        }

        public static string Task11(string text, string s1, string s2 )
        {

            string result = text.Replace(s1, s2);
            return $"Задача 11 - Замена 's1' на 's2' \n Результат: {result}\n";
        }

        public static string Task12(string word)
        {
            if (word.Length >= 5)
            {
                char[] chars = word.ToCharArray();
                char temp = chars[1];
                chars[1] = chars[4];
                chars[4] = temp;
                string result = new string(chars);
                return $"Задача 12 - Обмен 2-го и 5-го символов \n Результат: {result}\n";
            }
            else
            {
                return $"Задача 12 - Обмен 2-го и 5-го символов \n Результат: Слово слишком короткое!\n";
            }
        }

        public static string Task13(string word)
        {
            char[] letters = word.ToCharArray();
            char temp = letters[2];
            letters[2] = letters[letters.Length - 1];
            letters[letters.Length - 1] = temp;
            string result = new string(letters);
            return $"Задача 13 - Обмен 3-го и последнего символов \n Результат: {result}\n";
        }

        public static string Task14(string word, int m, int n)
        {
            char[] chars = word.ToCharArray();
            (chars[m-1], chars[n-1]) = (chars[n-1], chars[m-1]);
            string result = new string(chars);
            return $"Задача 14 - Обмен символов на позициях {m} и {n} \n Результат: {result}\n";
        }
    }
}
