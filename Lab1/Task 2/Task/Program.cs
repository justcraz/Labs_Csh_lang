using System;
using System.Text;

namespace TriangleApp
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

            Console.WriteLine("\n                         ### MENU ###                         ");

            do {

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
            Console.Write("\n Напішіть ваш катет A: ");
            double a = CheckIfNum();

            Console.Write(" Напішіть ваш катет B: ");
            double b = CheckIfNum();

            // Обраховування
            Hypotenuse(a, b, true);
            Perimeter(a, b);

            Menu();
        }

        static public double CheckIfNum()
        {

            double num = 0;

            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num)) {
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
        * Функція для вираховування гіпотенузи 
        */
        static public double Hypotenuse(double a, double b, bool t)
        {
            double c = Math.Sqrt(a * a + b * b);

            if (t != false) 
            {
                Console.Write("\n Гіпотенуза прямокутного трикутника : ");
                Console.WriteLine(Math.Round(c, 2).ToString());
                Console.WriteLine(" \u221a(" + a.ToString() + " * " + a.ToString() + " + " + b.ToString() + " * " + b.ToString() + ") = " + Math.Round(c, 2).ToString() + "\n");
            }

            return c;

        }

        /** 
        * Функція для вираховування периметра
        */
        static public double Perimeter(double a, double b)
        {

            double c = Hypotenuse(a, b, false);
            double p = a + b + c;

            Console.Write(" Периметр прямокутного трикутника : ");
            Console.WriteLine(Math.Round(p, 2).ToString());
            Console.WriteLine(" " + a.ToString() + " + " + b.ToString() + " + " + Math.Round(c, 2).ToString() + " = " + Math.Round(p, 2).ToString() + "\n");

            return p;

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