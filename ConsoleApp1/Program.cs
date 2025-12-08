using ConsoleApp1;
using lab222;


class Program
{
    static void Main()
    {
        //Lab34();
        //Lab5();
        Lab6();
        Console.ReadKey();
    }

    static int MakeNum(int max, int min, bool isZeroBad = true)
    {
        int num;
        do
        {
            num = TryCatch.TryConverToNum(Console.ReadLine(), max, min, isZeroBad);
            if (num == 0 && isZeroBad)
            {
                continue;
            }
            break;
        } while (true);
        return num;
    }
    static double MakeDoubleNum(int max, int min, bool isZeroBad = true)
    {
        double num;
        do
        {
            num = TryCatch.TryConvertToDouble(Console.ReadLine(), max, min, isZeroBad);
            if (num == 0 && isZeroBad)
            {
                continue;
            }
            break;
        } while (true);
        return num;
    }

    static void Lab34()
    {
        string sentense = "В настоящий момент на нем пишутся самые различные приложения: от небольших десктопных программок до крупных веб-порталов и веб-сервисов, обслуживающих ежедневно миллионы пользователей.";
        string word = "Взаимообусловлены";
        string coconut = "Кокосы";
        StringTasks stringTasks = new StringTasks();

        Console.WriteLine(StringTasks.Task1("Авиаконструктор"));
        Console.WriteLine(StringTasks.Task2(coconut));
        Console.WriteLine(StringTasks.Task3(coconut));
        Console.WriteLine($"Задача 4 - Часть слова образованная идущими подряд буквами начиная с m-й и кончая n-й \n Слово: {word} \n");
        Console.Write($"Введите m от 1 до {word.Length}: ");
        int m = MakeNum(word.Length, 1);
        Console.Write($"Введите n от {m} до {word.Length}: ");
        int n = MakeNum(word.Length, m);
        Console.WriteLine(StringTasks.Task4(word, m, n));
        Console.WriteLine(StringTasks.Task5("Стол"));
        Console.WriteLine(StringTasks.Task6(coconut));
        Console.WriteLine(StringTasks.Task7(sentense));
        Console.WriteLine(StringTasks.Task8(sentense));
        Console.WriteLine(StringTasks.Task9(sentense));
        Console.WriteLine(StringTasks.Task10(sentense));
        Console.WriteLine($"Задача 11 - замена s1 на s2 в предложении\n{sentense}");
        do
        {
            Console.Write("Введите подстроку s1 для замены: ");
            string s1 = TryCatch.TryConverToStr(Console.ReadLine());
            Console.Write("Введите подстроку s2: ");
            string s2 = TryCatch.TryConverToStr(Console.ReadLine());
            if (s1 == "0" || s2 == "0" || s1 == s2)
            {
                Console.WriteLine("Вы ввели 2 одинаковые строки или некорректные данные");
                continue;
            }
            Console.WriteLine(StringTasks.Task11(sentense, s1, s2));
            break;
        } while (true);
        Console.WriteLine(StringTasks.Task12("Программирование"));
        Console.WriteLine(StringTasks.Task13(word));
        Console.WriteLine($"Задача 14 - Замена f на s в слове {word}");
        Console.Write($"Введите F (от 1 до {word.Length}): ");
        int f = MakeNum(word.Length, 1);
        Console.Write($"Введите S (от 1 до {word.Length}): ");
        int s = MakeNum(word.Length, 1);
        Console.WriteLine(StringTasks.Task14(word, f, s));
        Console.WriteLine("Все задачи выполнены))))");
        Console.ReadKey();
    }

    static void Lab5()
    {
        // task 1
        Console.WriteLine("Задача 1");
        Console.Write("Введите число от 1 до 7: ");
        int a = MakeNum(7, 1);
        Console.WriteLine(SwitchCaseLab.Task1(a));

        // task 2
        Console.WriteLine("Задача 2");
        Console.Write("Введите число от 1 до 12: ");
        a = MakeNum(12, 1);
        Console.WriteLine(SwitchCaseLab.Task2(a));

        // task 3
        Console.WriteLine("Задача 3");
        Console.Write("Введите число от 1 до 12: ");
        a = MakeNum(12, 1);
        Console.WriteLine(SwitchCaseLab.Task3(a));

        // task 4
        Console.WriteLine("Задача 4");
        Console.Write("Введите число от 1 до 12: ");
        int month = MakeNum(12, 1);
        Console.Write("Введите тип года (1 - обычный, 2 - високосный): ");
        int yearType = MakeNum(2, 1);
        int daysInMonth = SwitchCaseLab.Task4(month, yearType);
        Console.WriteLine($"Дней в {month} месяце: {daysInMonth}");

        // task 5
        Console.WriteLine("Задача 5");
        Console.Write("Введите число от 1 до 365: ");
        int dayOfYear = MakeNum(365, 1);
        Console.Write("Введите d-й день недели для 1 января (1-понедельник, ..., 7-воскресенье): ");
        int firstDay = MakeNum(7, 1);
        Console.WriteLine($"{dayOfYear} день это {SwitchCaseLab.Task5(dayOfYear, firstDay)}");

        // task 6
        Console.WriteLine("Задача 6");
        Console.Write("Введите порядковый номер месяца от 1 до 12: ");
        month = MakeNum(12, 1);
        daysInMonth = SwitchCaseLab.Task4(month, 1);
        Console.Write($"Введите число от 1 до {daysInMonth}: ");
        int day = MakeNum(daysInMonth, 1);
        Console.WriteLine($"{day} день {month} месяца это {SwitchCaseLab.Task6(month, day, daysInMonth)}");

        // task 7
        Console.WriteLine("Задача 7");
        Console.Write("Введите год: ");
        int year = MakeNum(4000, 1);
        int yearTypeTask7 = 1;
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            yearTypeTask7 = 2;
        }
        Console.Write("Введите номер месяца от 1 до 12: ");
        int monthTask7 = MakeNum(12, 1);
        int daysInMonthTask7 = SwitchCaseLab.Task4(monthTask7, yearTypeTask7);
        Console.Write($"Введите число от 1 до {daysInMonthTask7}: ");
        int dayTask7 = MakeNum(daysInMonthTask7, 1);
        Console.WriteLine(SwitchCaseLab.Task7(dayTask7, monthTask7, daysInMonthTask7, year));

        // task 8
        Console.WriteLine("Задача 8");
        Console.Write("Введите номер операции: 1-сложение, 2-вычитание, 3-умножение: ");
        int oper = MakeNum(3, 1);
        Console.WriteLine(SwitchCaseLab.Task8(oper));

        // task 9
        Console.WriteLine("Задача 9");
        Console.Write("Введите номер операции: 1-сложение, 2-вычитание, 3-умножение: ");
        int operation = MakeNum(3, 1);
        Console.Write("Введите первое число: ");
        int num1 = MakeNum(12000, -12000, false);
        Console.Write("Введите второе число: ");
        int num2 = MakeNum(12000, -12000, false);
        Console.WriteLine(SwitchCaseLab.Task9(operation, num1, num2));

        // task 10
        Console.WriteLine("Задача 10");
        Console.Write("Введите год: ");
        int num = MakeNum(10000, 1984);
        Console.WriteLine(SwitchCaseLab.Task10(num));
    }
    static void Lab6()
    {
        // task 1
        Console.WriteLine("Лабораторная работа N6\nЗадача 1\nВывести модуль числа");
        int mod = MakeNum(100, -100, false);
        Console.WriteLine($"Модуль числа |{mod}| = {IfelseLab.Modul(mod)}");
        // task 2
        Console.WriteLine("Задача 2\nВведите 2 числа для сравнения");
        int firsCahr = MakeNum(100, -100, false);
        int secondChar = MakeNum(100, -100, false);
        Console.WriteLine(IfelseLab.Bolshe(firsCahr, secondChar));
        // task 3
        Console.WriteLine("Задача 3\nВходит ли число в диапозон (5:10)");
        int five = MakeNum(100, -100, false);
        Console.WriteLine($"{IfelseLab.MoreThanFive(five)}");
        // task 4
        Console.WriteLine("Задача 4\nПроцент в банке\nВведите начальный депозит");
        double bank = MakeDoubleNum(10000, 1);
        Console.WriteLine($"{IfelseLab.Bank(bank)}");
        // task 5
        Console.WriteLine("Задача 5\nCумма кратным 3\nВведите числа");
        int num1 = MakeNum(10000, 1);
        int num2 = MakeNum(10000, 1);
        int num3 = MakeNum(10000, 1);
        int num4 = MakeNum(10000, 1);
        Console.WriteLine($"{IfelseLab.SumOf4Num(num1, num2, num3, num4)}");
        // task 6
        Console.WriteLine("Задача 6\nРезультат\nВведите кол-во очков за игру");
        int match = MakeNum(3, 1);
        Console.WriteLine($"{IfelseLab.FootballMatch(match)}");
        // task 7
        Console.WriteLine("Задача 7\nРезультат\nВведите вес");
        double weight = MakeDoubleNum(1000, 1);
        Console.WriteLine($"{IfelseLab.Ufc(weight)}");
        // task 8
        Console.WriteLine("Задача 8\nРезультат\nВведите a,b,c (a не равно 0)");
        double a = MakeDoubleNum(1000, 1);
        double b = MakeDoubleNum(1000, 1, false);
        double c = MakeDoubleNum(1000, 1, false);
        Console.WriteLine($"{IfelseLab.Dis(a, b, c)}");
        // task 9 
        Console.WriteLine("Задача 9\nРезультат\nВведите 3 числа");
        double char1 = MakeDoubleNum(1000, -1000, false);
        double char2 = MakeDoubleNum(1000, -1000, false);
        double char3 = MakeDoubleNum(1000, -1000, false);
        Console.WriteLine($"{IfelseLab.BolsheMensheRavno(char1, char2, char3)}");
        // task 10
        Console.WriteLine("Задача 10\nРезультат\nВведите 3 числа\nА 4 числом введите 1 если хотите найти наименьшее и 2 если наибольшее");
        double fer1 = MakeDoubleNum(1000, -1000, false);
        double fer2 = MakeDoubleNum(1000, -1000, false);
        double fer3 = MakeDoubleNum(1000, -1000, false);
        int punkt = MakeNum(2, 1);
        Console.WriteLine($"{IfelseLab.BolsheMenshe(fer1, fer2, fer3, punkt)}");
    }
}