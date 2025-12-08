namespace ConsoleApp1
{
    internal class SwitchCaseLab
    {
        static public string Task1(int a)
        {
            switch (a)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 0:
                case 7: return "Воскресенье";
                default:
                    return "";
            }
        }
        public static string Task2(int a)
        {

            switch (a)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default:
                    return "";
            }
        }
        public static string Task3(int a)
        {
            switch (a)
            {
                case 1:
                case 2: return "Зима";
                case 3:
                case 4:
                case 5: return "Весна";
                case 6:
                case 7:
                case 8: return "Лето";
                case 9:
                case 10:
                case 11: return "Осень";
                case 12: return "Зима";
                default:
                    return "";
            }
        }
        public static int Task4(int month, int yearType)
        {
            if (month == 2 && yearType == 2)
            {
                return 29;
            }

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: return 31;
                case 4:
                case 6:
                case 9:
                case 11: return 30;
                case 2: return 28;
                default:
                    return 0;
            }
        }
        public static string Task5(int a, int b)
        {
            int c = (a + (b - 1)) % 7;
            return Task1(c);

        }
        public static string Task6(int month, int day, int maxDay)
        {
            if (day == maxDay)
            {
                return $"Дата предыдущего {day - 1} день {month} месяца\nДата следующего первое число {month + 1} месяца ";
            }
            if (day == 1)
            {
                return $"Дата предыдущего {Task4(month - 1, 1)} день {month - 1} месяца\nДата следующего {day + 1} день {month} месяца ";
            }
            return $"Дата предыдущего {day - 1} день {month} месяца\nДата следующего {day + 1} день {month} месяца ";
        }

        // task 7
        public static string Task7(int day, int month, int daysInMonth, int year)
        {
            if (day == daysInMonth)
            {
                if (month == 12)
                {
                    return $"Предыдущий день: {day - 1} {Task2(month)} {year}, Следующий день: 1 Января {year + 1}";
                }
                return $"Предыдущий день: {day - 1} {Task2(month)} {year}, Следующий день: 1 {Task2(month + 1)} {year}";
            }
            if (day == 1)
            {
                if (month == 1)
                {
                    int predDays = Task4(12, 1);
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    {
                        predDays = 29;
                    }
                    else
                    {
                        predDays = 28;
                    }
                    return $"Предыдущий день: {predDays} {Task2(12)} {year - 1}, Следующий день: {day + 1} {Task2(month)} {year}";
                }
                int predMonthDays = Task4(month - 1, 1);
                if (month - 1 == 2 && year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    predMonthDays = 29;
                }
                return $"Предыдущий день: {predMonthDays} {Task2(month - 1)} {year}, Следующий день: {day + 1} {Task2(month)} {year}";
            }
            return $"Предыдущий день: {day - 1} {Task2(month)} {year}, Следующий день: {day + 1} {Task2(month)} {year}";
        }

        // task 8
        public static string Task8(int operacia)
        {
            switch (operacia)
            {
                case 1: return "Сложение";
                case 2: return "Вычитание";
                case 3: return "Умножение";
                default: return "Операция неопределена";
            }
        }

        // task 9
        public static string Task9(int operacia, int chislo1, int chislo2)
        {
            switch (operacia)
            {
                case 1: return $"{chislo1} + {chislo2} = {chislo1 + chislo2}";
                case 2: return $"{chislo1} - {chislo2} = {chislo1 - chislo2}";
                case 3: return $"{chislo1} * {chislo2} = {chislo1 * chislo2}";
                default: return "Операция неопределена";
            }
        }

        // task 10
        public static string Task10(int god)
        {
            int startGod = 1984;

            int pozicia = (god - startGod) % 60;
            if (pozicia < 0)
            {
                pozicia += 60;
            }

            switch (pozicia)
            {
                case 0: return "Крыса, Зеленый";
                case 1: return "Корова, Зеленый";
                case 2: return "Тигр, Красный";
                case 3: return "Заяц, Красный";
                case 4: return "Дракон, Желтый";
                case 5: return "Змея, Желтый";
                case 6: return "Лошадь, Белый";
                case 7: return "Овца, Белый";
                case 8: return "Обезьяна, Черный";
                case 9: return "Петух, Черный";
                case 10: return "Собака, Зеленый";
                case 11: return "Свинья, Зеленый";
                case 12: return "Крыса, Красный";
                case 13: return "Корова, Красный";
                case 14: return "Тигр, Желтый";
                case 15: return "Заяц, Желтый";
                case 16: return "Дракон, Белый";
                case 17: return "Змея, Белый";
                case 18: return "Лошадь, Черный";
                case 19: return "Овца, Черный";
                case 20: return "Обезьяна, Зеленый";
                case 21: return "Петух, Зеленый";
                case 22: return "Собака, Красный";
                case 23: return "Свинья, Красный";
                case 24: return "Крыса, Желтый";
                case 25: return "Корова, Желтый";
                case 26: return "Тигр, Белый";
                case 27: return "Заяц, Белый";
                case 28: return "Дракон, Черный";
                case 29: return "Змея, Черный";
                case 30: return "Лошадь, Зеленый";
                case 31: return "Овца, Зеленый";
                case 32: return "Обезьяна, Красный";
                case 33: return "Петух, Красный";
                case 34: return "Собака, Желтый";
                case 35: return "Свинья, Желтый";
                case 36: return "Крыса, Белый";
                case 37: return "Корова, Белый";
                case 38: return "Тигр, Черный";
                case 39: return "Заяц, Черный";
                case 40: return "Дракон, Зеленый";
                case 41: return "Змея, Зеленый";
                case 42: return "Лошадь, Красный";
                case 43: return "Овца, Красный";
                case 44: return "Обезьяна, Желтый";
                case 45: return "Петух, Желтый";
                case 46: return "Собака, Белый";
                case 47: return "Свинья, Белый";
                case 48: return "Крыса, Черный";
                case 49: return "Корова, Черный";
                case 50: return "Тигр, Зеленый";
                case 51: return "Заяц, Зеленый";
                case 52: return "Дракон, Красный";
                case 53: return "Змея, Красный";
                case 54: return "Лошадь, Желтый";
                case 55: return "Овца, Желтый";
                case 56: return "Обезьяна, Белый";
                case 57: return "Петух, Белый";
                case 58: return "Собака, Черный";
                case 59: return "Свинья, Черный";
                default: return "Неизвестно";
            }
        }
    }
}