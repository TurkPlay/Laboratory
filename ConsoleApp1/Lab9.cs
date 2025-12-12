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

}