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

        public void Calculation(double arrayLong, int[] arrayNums, int[] arrayNumLess)
        {
            // шукаємо позиції першого та останнього позитивних елементів
            int firstId = 0, lastId = 0;
            bool foundFirstelement = false;

            int Sum = 0;

            for (int i = 0; i < arrayLong; i++)
            {
                if (arrayNums[i] > 0)
                {
                    if (!foundFirstelement)
                    {
                        firstId = lastId = i;
                        foundFirstelement = true;
                    }
                    else
                    {
                        lastId = i;
                    }
                }
            }

            for (int i = firstId; i < lastId + 1; i++)
            {
                Sum += arrayNums[i];
            }

            for (int i = 0; i < arrayLong; i++)
            {
                if (arrayNums[i] < 7)
                {
                    arrayNumLess[i] = arrayNums[i];
                }
            }

            Console.WriteLine(" Числа з масиву які менше за 7: [{0}]", string.Join(", ", arrayNumLess));
            Console.WriteLine(" Сума елементів масиву, розташованих між першим й останнім додатними елементами : " + Sum.ToString());

        }

        public void NumWrite()
        {

            Console.Write("\n ---------------------------- \n\n");
            Console.Write(" Ведіть довжину масиву: ");
            double arrayLong = CheckIfNumMass();
            
            double inputStr;
            int[] arrayNums = new int[(int)arrayLong];
            int[] arrayNumLess = new int[(int)arrayLong];


            Console.WriteLine("\n Ведіть " + arrayLong + " рази підрять чисел щоб заповнити масив: \n");
            while (i < (int)arrayLong)
            {

                Console.Write(" Ведіть [" + (i) + "] індекс масиву : ");
                inputStr = CheckIfNum();

                arrayNums[i] = (int)inputStr;
                i++;

            }

            Console.WriteLine("\n Ваш масив: [{0}]", string.Join(", ", arrayNums));
            Calculation(arrayLong, arrayNums, arrayNumLess);
            Console.Write("\n ---------------------------- \n\n");
        }

        public void RandWrite()
        {
            // Створення об'єкту для генерування чисел
            Random randomValue = new Random();
            int value;

            Console.Write("\n ---------------------------- \n\n");
            Console.Write(" Ведіть довжину масиву: ");
            double arrayLong = CheckIfNumMass();
            int[] arrayNums = new int[(int)arrayLong];
            int[] arrayNumLess = new int[(int)arrayLong];

            Console.WriteLine("\n\n Ваш массив довжиною " + arrayLong + " : ");
            while (i < (int)arrayLong)
            {

                value = randomValue.Next(-100, 100);
                arrayNums[i] = value;
                i++;

            }

            Console.WriteLine("\n Масив: [{0}]", string.Join(", ", arrayNums));
            Calculation(arrayLong, arrayNums, arrayNumLess);
            Console.Write("\n ---------------------------- \n\n");
        }

    }

    public class MainAlgorythm : UserWrite
    {

        UserWrite UserWriteMethod = new UserWrite();
        public bool TypeStart(bool typeUse){

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