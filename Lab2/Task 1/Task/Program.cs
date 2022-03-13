using System;
using System.Text;

namespace GetNumName
{

    public class Program
    {

        /** 
        * Параметри меню
        */
        static public void MenuChoose()
        {

            Console.WriteLine(" 1. Розпочати програму");
            Console.WriteLine(" 2. Очистити консоль");
            Console.WriteLine(" 3. Вихід");

        }

        /** 
        * Стартове меню
        */
        private static bool Menu()
        {

            Console.WriteLine("\n\n                         ### MENU ###                         ");

            do
            {

                //Виводимо меню з пунктами
                MenuChoose();

                Console.Write("\n Ведіть одне з пунктів меню: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        MainProgram();
                        return true;
                    case "2":
                        Console.Clear();
                        Menu();
                        return false;
                    case "3":
                        return false;
                    default:
                        Console.WriteLine("\n Немає такої команди в меню ведіть знову ! \n");
                        Console.WriteLine(" * MENU * ");
                        break;

                }

            } while (true);

        }

        /** 
        * Головна програма
        */
        static public void MainProgram()
        {
            // Ведення чисел a та b
            Console.Write("\n Напішіть ваше число (від 10 до 20): ");
            double a = CheckIfNum();
            NameTheNumm(a);

            Menu();
        }

        /** 
        * Перевірка ввода користувача
        */
        static public double CheckIfNum()
        {

            double num = 0;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num) && num > 9 && num < 21)
                {
                    // Якщо було веденно вірне число буде закінчення циклу
                    return num;
                }
                else
                {
                    // Якщо було веденно невірне число буде повернення циклу
                    Console.WriteLine(" Ведено невірне значення. Спробуйте знову !");
                    Console.Write(" Ваша значення: ");
                }
            }

        }

        /** 
        * Вивід числа буквами
        */
        public static double NameTheNumm( double num )
        {

            string[] theNumbers = new string[11] {
                "Десять", 
                "Одинадцять", 
                "Дванадцять", 
                "Тринадцять", 
                "Чотирнадцять", 
                "Пятнадцять", 
                "Шістнадцять", 
                "Сімнадцять", 
                "Вісімнадцять", 
                "Девятнадцять", 
                "Двадцять" 
            };

            Console.Write(" Число котре ви ввели є: ");

            do
            {

                switch (num)
                {
                    case 10:
                        Console.Write(theNumbers[0]);
                        return num;
                      
                    case 11:
                        Console.Write(theNumbers[1]);
                        return num;

                    case 12:
                        Console.Write(theNumbers[2]);
                        return num;

                    case 13:
                        Console.Write(theNumbers[3]);
                        return num;

                    case 14:
                        Console.Write(theNumbers[4]);
                        return num;

                    case 15:
                        Console.Write(theNumbers[5]);
                        return num;

                    case 16:
                        Console.Write(theNumbers[6]);
                        return num;

                    case 17:
                        Console.Write(theNumbers[7]);
                        return num;

                    case 18:
                        Console.Write(theNumbers[8]);
                        return num;

                    case 19:
                        Console.Write(theNumbers[9]);
                        return num;

                    case 20:
                        Console.Write(theNumbers[10]);
                        return num;

                    default:
                        Console.WriteLine("\n Щось пішло не так спробуйте знову! \n");
                        break;

                }

            } while (true);

        }

        /** 
        * Виведення результату програми
        */
        static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.Default;
            Menu();

        }

    }

}