using System;
using System.Text;

namespace GetArray
{

    public class UserWrite
    {

        /** 
        * Перевірка ввода користувача
        */
        static public double CheckIfNum()
        {
            double num = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num))
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

        static public double CheckIfNumMass()
        {
            double num = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out num) && num > 0)
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

        int i = 0;
        int j = 0;

        public void Calculation(int[,] Arr, int arrayWide, int arrayLong)
        {
            // Знаходимо середнє арифметичне максимального та мінімального елементів матриці
            int minElem = Arr[0, 0];
            int maxElem = Arr[0, 0];
            double arithmetic = 0;

            for (int i = 0; i < arrayWide; i++)
            {
                for (int j = 0; j < arrayLong; j++)
                {

                    if (minElem >= Arr[i, j])
                    {
                        minElem = Arr[i, j];
                    }

                    if (maxElem <= Arr[i, j])
                    {
                        maxElem = Arr[i, j];
                    }

                }
            }

            arithmetic += ((double)maxElem + (double)minElem) / 2;

            Console.WriteLine("\n\n Максимальний елемент матриці: " + maxElem + "\n Мінімальний елемент матриці: " + minElem + "");
            Console.Write("\n Середнє арифметичне максимального та мінімального елементів матриці: " + arithmetic);
        }

        public void NumWrite()
        {

            Console.Write("\n ---------------------------- \n\n");

            Console.Write(" Ведіть довжину матрици: ");
            double arrayLong = CheckIfNumMass();

            Console.Write(" Ведіть висоту матрици: ");
            double arrayWide = CheckIfNumMass();

            int[,] arrayNums = new int[(int)arrayWide, (int)arrayLong];

            Console.WriteLine("\n\n Ваша матриця довжиною " + arrayLong + " та висотою " + arrayWide + " : ");
            double inputStr = 0;
            
           
            Console.WriteLine("\n Ведіть " + arrayLong + " рази підрять чисел щоб заповнити масив: \n");

            for (i = 0; i < arrayWide; i++)
            {
                Console.WriteLine();
                for (j = 0; j < arrayLong; j++)
                {

                    Console.Write(" Ведіть |{0}|{1}| : ", i, j);
                    inputStr = CheckIfNum();
                    arrayNums[i, j] = (int)inputStr;

                }
            }

            Console.WriteLine("\n\n Ваша готова матриця довжиною " + arrayLong + " та висотою " + arrayWide + " : ");

            for (i = 0; i < arrayWide; i++)
            {
                Console.WriteLine();
                for (j = 0; j < arrayLong; j++)
                {

                    Console.Write(" |\t{0}\t| ", arrayNums[i, j]);

                }
            }

            Calculation(arrayNums, (int)arrayWide, (int)arrayLong);

            Console.Write("\n ---------------------------- \n\n");
        }

        public void RandWrite()
        {
            // Створення об'єкту для генерування чисел
            Random randomValue = new Random();
            int value;

            Console.Write("\n ---------------------------- \n\n");
            Console.Write(" Ведіть довжину матрици: ");
            double arrayLong = CheckIfNumMass();
            Console.Write(" Ведіть висоту матрици: ");
            double arrayWide = CheckIfNumMass();
            int[,] arrayNums = new int[(int)arrayWide, (int)arrayLong];

            Console.WriteLine("\n\n Ваша матриця довжиною " + arrayLong + " та висотою " + arrayWide + " : ");

            for (i = 0; i < arrayWide; i++)
            {
                Console.WriteLine();
                for (j = 0; j < arrayLong; j++)
                {

                    value = randomValue.Next(-100, 100);
                    arrayNums[i,j] = value;

                    Console.Write(" |\t{0}\t| ", arrayNums[i, j]);

                }
            }

            Calculation(arrayNums, (int)arrayWide, (int)arrayLong);

            Console.Write("\n\n ---------------------------- \n\n");
        }

    }

    public class MainAlgorythm : UserWrite
    {

        UserWrite UserWriteMethod = new UserWrite();
        public bool TypeStart(bool typeUse)
        {

            if (!typeUse == false)
            {
                UserWriteMethod.NumWrite();
            }
            else
            {
                UserWriteMethod.RandWrite();
            }

            return true;
        }

    }

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

            Console.WriteLine("\n 1. Почати ввід масиву з клавіатури");
            Console.WriteLine(" 2. Почати ввід масиву з генерації чисел");
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

            MainAlgorythm alhorythmStart = new MainAlgorythm();

            SubMenuChoose();
            do
            {
                Console.Write("\n Ведіть одне з пунктів меню: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        alhorythmStart.TypeStart(true);
                        SubMenu();
                        return true;
                    case "2":
                        alhorythmStart.TypeStart(false);
                        SubMenu();
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