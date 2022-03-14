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
        * Параметри під-меню
        */
        static public void SubMenuChoose()
        {

            Console.WriteLine("\n 1. Використати цикл за типом передумовою");
            Console.WriteLine(" 2. Використати цикл за типом післяумовою");
            Console.WriteLine(" 3. Повернутися");

        }

        /** 
        * Стартове меню
        */
        private static bool Menu()
        {

            Console.WriteLine("\n\n                         ### MENU ###                         ");

            //Виводимо меню з пунктами
            MenuChoose();

            do
            {

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
                        Console.Clear();
                        Console.WriteLine("\n Немає такої команди в меню ведіть знову ! \n");
                        MenuChoose();
                        break;

                }

            } while (true);

        }

        /** 
        * Стартове підменю
        */
        private static bool SubMenu()
        {

            SubMenuChoose();

            do
            {

                Console.Write("\n Ведіть одне з пунктів меню: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AlgorythmType(true);
                        return true;
                    case "2":
                        AlgorythmType(false);
                        return true;
                    case "3":
                        Menu();
                        return false;
                    default:
                        Console.WriteLine("\n Немає такої команди в меню ведіть знову ! \n");
                        SubMenuChoose();
                        break;
                }

            } while (true);

        }


        /** 
         * Типи функції виконання
         */
        static public void AlgorythmType(bool type)
        {

            double a = 1.25;
            double b = 6.75;
            const double dx = 0.25;

            double x = a - 0.25;
            double y;

            Console.WriteLine("\n Виконання обчисленння діапазоном(" + a + "," + b + ") з кроком " + dx +"");

            Console.WriteLine("\t\t ________________________________");
            Console.Write("\t\t |\tx\t|\ty=f(x)\t|\n");
            Console.Write("\t\t ________________________________\n");

            if (type == true) 
            {

                while (x < b)
                {
                    x += dx;
                    y = Math.Pow(x, 1 / 3f) + Math.Log(3 * x);

                    Console.Write("\t\t |\t" + Math.Round(x, 2) + "\t|\t" + Math.Round(y, 2) + "\t|\n");
                }

            }
            else
            {

                do
                {

                    x += dx;
                    y = Math.Pow(x, 1 / 3f) + Math.Log(3 * x);

                    Console.Write("\t\t |\t" + Math.Round(x, 2) + "\t|\t" + Math.Round(y, 2) + "\t|\n");

                } while (x < b);

            }

            Console.Write("\t\t ________________________________\n");

            MainProgram();
        }


        /** 
        * Головна програма
        */
        static public void MainProgram()
        {

            SubMenu();

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