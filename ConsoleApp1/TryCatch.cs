using System;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp1
{
    internal class TryCatch
    {
        public static double TryConvertToDouble(string num, double max, double min, bool Zero) 
        {
            if (num == null)
            {
                Console.WriteLine(" Вы ввели пустую строку, попоробуйте еще раз");
                return 0;
            }
            try
            {
                double conNum = double.Parse(num);
                if (conNum > max || (conNum == 0 && Zero) || conNum < min)
                {
                    Console.WriteLine("Вне диапозона");
                    return 0;
                }
                return conNum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public static int TryConverToNum(string num, int max, int min, bool Zero)
        {
            if (num == null)
            {
                Console.WriteLine(" Вы ввели пустую строку, попоробуйте еще раз" );
                return 0;
            }
            
                try
                {
                   int conNum = int.Parse(num);
                if (conNum > max || (conNum == 0 && Zero) || conNum < min)
                {
                    Console.WriteLine("Вне диапозона");
                    return 0;
                }
                return conNum;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        
        public static string TryConverToStr(string s1)
        {
            try
            {
                if (string.IsNullOrEmpty(s1))
                {
                    return "Ошибка: Подстрока s1 не может быть пустой! Попробуйте снова.\n";
                }
                return s1;

            }
            catch (OutOfMemoryException)
            {
                return "Ошибка: Недостаточно памяти! Попробуйте снова.\n";
            }
            catch (ArgumentNullException)
            {
                return "Ошибка: Пустая ссылка! Попробуйте снова.\n";
            }
            catch (ArgumentException ex)
            {
                return $"Ошибка аргумента: {ex.Message} Попробуйте снова.\n";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message} Попробуйте снова.\n";
            }
        }
    }
}
