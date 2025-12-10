using System.Text;


namespace ConsoleApp1
{
    internal class AlgoritmLab
    {
        public static int[] GetNums()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++) { array[i] = rand.Next(1, 100); }
            return array;
        }
        private static string ArrayToString(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
                if (i < arr.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }
        public static string MaxNum()
        {
            int[] num = GetNums();
            bool isEnd = false;
            do
            {
                for (int i = 0; i < 9; i++)
                {
                    if (num[i] >= num[i + 1])
                    {
                        int exp1 = num[i];
                        int exp2 = num[i + 1];
                        num[i] = exp2;
                        num[i + 1] = exp1;
                    }
                }

                for (int i = 0, g = 0; i < 9; i++)
                {
                    if (num[i] <= num[i + 1]) { g++; }
                    if (g == 9)
                    {
                        isEnd = true;
                        StringBuilder result = new StringBuilder();
                        for (int j = 0; j < 10; j++)
                        {
                            result.Append(num[j]);
                            if (j < 10) result.Append("");
                        }
                        string sup = (string.Join(" ", num));
                        return "Сортировка по возрастанию (пузыриком): " + sup;
                    }
                }

            }
            while (isEnd == false);

            return "";
        }

        public static string MinNum()
        {
            int[] num = GetNums();
            bool isEnd = false;
            do
            {
                for (int i = 0; i < 9; i++)
                {
                    if (num[i] <= num[i + 1])
                    {
                        int exp1 = num[i];
                        int exp2 = num[i + 1];
                        num[i] = exp2;
                        num[i + 1] = exp1;
                    }
                }

                for (int i = 0, g = 0; i < 9; i++)
                {
                    if (num[i] >= num[i + 1]) { g++; }
                    if (g == 9)
                    {
                        isEnd = true;
                        StringBuilder result = new StringBuilder();
                        for (int j = 0; j < 10; j++)
                        {
                            result.Append(num[j]);
                            if (j < 9) result.Append(" ");
                        }
                        string sup = (string.Join(" ", num));
                        return "Сортировка по убыванию (пузыриком): " + sup;
                    }
                }
            }
            while (isEnd == false);
            return "";
        }

        public static string InsertMin()
        {
            int[] arr = GetNums();

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            return "Сортировка по убыванию (вставками): " + ArrayToString(arr);
        }
        public static string InsertMax()
        {
            int[] arr = GetNums();

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            return "Сортировка по возрастанию (вставками): " + ArrayToString(arr);
        }
        public static string SelectionMin()
        {
            int[] arr = GetNums();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            return "Сортировка по убыванию (выбором): " + ArrayToString(arr);
        }
        public static string SelectionMax()
        {
            int[] arr = GetNums();

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return "Сортировка по возрастанию (вставками): " + ArrayToString(arr);
        }
        public static string EuclidAl(int num1, int num2)
        {
            Random rand = new Random();

            int originalNum1 = num1;
            int originalNum2 = num2;

            while (true)
            {
                int bigger, smaller;
                if (num1 > num2)
                {
                    bigger = num1;
                    smaller = num2;
                }
                else
                {
                    bigger = num2;
                    smaller = num1;
                }

                int remainder = bigger % smaller;

                if (remainder == 0)
                {
                    return $"НОД({originalNum1}, {originalNum2}) = {smaller}";
                }
                else
                {
                    num1 = smaller;
                    num2 = remainder;
                }
            }
        }
        public static string FindeNeighbot()
        {
            float[] numbers = new float[10];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (float)(rand.Next(100, 1000) / 100.0); 
            }

            float targetNumber = (float)(rand.Next(100, 1000) / 100.0);

            float nearestNumber = numbers[0];
            float minDifference = Math.Abs(numbers[0] - targetNumber);
            int nearestIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                float difference = Math.Abs(numbers[i] - targetNumber);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    nearestNumber = numbers[i];
                    nearestIndex = i;
                }
            }

            string numbersString = string.Join("  ", numbers);
            return $"Массив чисел: {numbersString}\nИсходное число: {targetNumber:F2}\nБлижайшее число: {nearestNumber:F2}";
        }
    }
} 