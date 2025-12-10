namespace ConsoleApp1
{
    internal class IfelseLab
    {
        public static int Modul(int a)
        {
            if (a < 0) { return a * -1; } else { return a; }
        }
        public static string Bolshe(int a, int b)
        {
            if (a == b)
            {
                return $"Число {a} = {b}";
            }
            else if (a < b)
            {
                return $"{a} < {b}";
            }
            else
            {
                return $"{a} > {b}";
            }
        }
        public static string MoreThanFive(int a)
        {
            if (a > 5 && a < 10) { return $"Число {a} входит в диапазон"; }
            else { return $"Число {a} вне диапазона"; }
        }
        public static string Bank(double a)
        {
            if (a > 0 && a < 100)
            {
                a += a / 100 * 5;
                return $"Ваш депозит через месяц {a}";
            }
            else if (a > 100 && a < 200)
            {
                a += a / 100 * 7;
                return $"Ваш депозит через месяц {a}";
            }
            else
            {
                a += a / 100 * 10;
                return $"Ваш депозит через месяц {a}";
            }
        }
        public static string SumOf4Num(int num1, int num2, int num3, int num4)
        {
            int result = 0;
            if (num1 % 3 == 0) { result += num1; }
            if (num2 % 3 == 0) { result += num2; }
            if (num3 % 3 == 0) { result += num3; }
            if (num4 % 3 == 0) { result += num4; }
            return $"Сумма всех чисел которые делтся на 3 без остатка {result} ";
        }
        public static string FootballMatch(int res)
        {
            if (res == 0)
            {
                return $"Проиграли";
            }
            else if (res == 1)
            {
                return $"Ничья";
            }
            else if (res == 3)
            {
                return $"Выйграли";
            }
            else { return $"2 неизвестно"; }
        }
        public static string Ufc(double mass)
        {
            if (mass < 60)
            {
                return $"В легком весе";
            }
            else
            if (mass > 60 && mass < 64)
            {
                return $"В первомполулегком весе";
            }
            else
            if (mass > 64 && mass < 69)
            {
                return $"В полулгком весе";
            }
            else { return "Не попал в категории"; }
        }
        public static string Dis(double a, double b, double c)
        {
            double dis = b * b - 4 * a * c;
            if (dis < 0)
            {
                return $"Нет корней";
            }
            else
            if (dis == 0)
            {
                double x = b * -1 / 2 * a;
                return $"{x} единственный корень уравнения";
            }
            else
            if (dis > 0)
            {
                double x1 = (b * -1 + Math.Sqrt(dis)) / 2 * a;
                double x2 = (b * -1 - Math.Sqrt(dis)) / 2 * a;
                return $"{x1} и {x2} корни уравнения";
            }
            else { return $"Не получилось"; }
        }
        public static string BolsheMensheRavno(double a, double b, double c)
        {
            if (a == b || a == c || b == c)
            { return $"Вы ввели несколько одинаковые переменные"; }
            if (a < b && a < c)
            {
                if (b > c)
                {
                    return $"{b}>{c}>{a}";
                }
                else
                if (c > b)
                {
                    return $"{c}>{b}>{a}";
                }
                else { return ""; }
            }
            else
            if (b < a && b < c)
            {
                if (a > c)
                {
                    return $"{a}>{c}>{b}";
                } else
                if (c > a)
                {
                    return $"{c}>{a}>{b}";
                }
                else { return ""; }
            }
            else
            if (c < a && c < b)
            {
                if (a > b)
                {
                    return $"{a}>{b}>{c}";
                } else
                if (b > a)
                {
                    return $"{b}>{a}>{c}";
                }
                else { return ""; }
            } else { return $"Что то пошло не так"; }
        }
        public static string BolsheMenshe(double a, double b, double c, int d) 
        {
            switch (d) 
            {
                case 1:
                    if (a < b && a < c)
                    {
                        return $"{a} Наименьшее";
                    }
                    if (b < a && b < c)
                    {
                        return $"{b} Наименьшее";
                    }
                    return $"{c} Наименьшее";
                case 2:
                    if (a > b && a > c)
                    {
                        return $"{a} Наибольшее";
                    }
                    if (b > a && b > c)
                    {
                        return $"{b} Наибольшее";
                    }
                    return $"{c} Наибольшее";
                default: return $"Неизвестно";
            }
        }
        public static string TernarTask1(int a, int b) 
        {
           return $"Максимальное число - {((a>b)? a: b)}";
        }
        public static string TernarTask2(double rad = 0, int stor = 0) 
        {
           double radS = Math.PI * rad * rad;
           int storS = stor*stor;
           return $"{((radS>storS)?radS:storS)}";
        }
        public static string TernarTask3(int a, int b, int c) 
        {
           int maxOfTree = (a>b)?((a>c)?a:c):((b>c)?b:c);
           return $"Максимаьнон число {maxOfTree}";
        }
        public static string TernarTask4(int number)
        {
           string digits = number.ToString();
           bool allDifirent = digits.Distinct().Count() == 4;
           return allDifirent?"да":"нет"; 
           
        }
    }
}
