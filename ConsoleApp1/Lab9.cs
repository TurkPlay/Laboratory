using System;
using System.Text;

class Program
{
    // Метод для первой задачи
    static string FindSpecialNumbers()
    {
        StringBuilder result = new StringBuilder();
        
        for (int num = 100; num <= 999; num++)
        {
            if ((num * num) % 1000 == num)
            {
                result.AppendLine($"{num}² = {num * num}");
            }
        }
        
        return result.ToString();
    }
    
    // Метод для второй задачи
    static string FindDivisibleBySevenNumbers()
    {
        StringBuilder result = new StringBuilder();
        
        for (int num = 105; num <= 994; num += 7)
        {
            int sum = 0;
            int temp = num;
            
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            
            if (sum % 7 == 0)
            {
                result.AppendLine($"Число: {num}, сумма цифр: {sum}");
            }
        }
        
        return result.ToString();
    }
    
    static void Main()
    {
        // Первая задача
        Console.WriteLine("Задача 1:");
        string task1Result = FindSpecialNumbers();
        Console.WriteLine(task1Result);
        
        // Вторая задача
        Console.WriteLine("Задача 2:");
        string task2Result = FindDivisibleBySevenNumbers();
        Console.WriteLine(task2Result);
    }


static string CheckProduct(int[] numbers)
    {
        if (numbers.Length != 8)
        {
            return "Ошибка: должно быть ровно 8 чисел!";
        }
        
        int product = 1;
        for (int i = 0; i < 8; i++)
        {
            product *= numbers[i];
        }
        
        if (product < 10000)
        {
            return $"Произведение {product} МЕНЬШЕ 10000";
        }
        else
        {
            return $"Произведение {product} БОЛЬШЕ ИЛИ РАВНО 10000";
        }
    }
static string CheckNumbers(int n, int[] numbers)
    {
        int count = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < 20) count++;
        }
        
        return count == 5 ? "Верно" : "Неверно";
    }
static string GetAverageOfMultiples(int m, int n, int[] numbers)
    {
        int sum = 0;
        int count = 0;
        
        for (int i = 0; i < m; i++)
        {
            if (numbers[i] % n == 0)
            {
                sum += numbers[i];
                count++;
            }
        }
        
        if (count == 0)
            return $"Нет чисел, кратных {n}";
        
        double average = (double)sum / count;
        return $"Среднее чисел, кратных {n}: {average:F2} (из {count} чисел)";
    }
}