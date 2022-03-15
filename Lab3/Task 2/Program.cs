using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
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

    // Провірка на баланс скобок
    static bool CheckBracers(string str)
    {
        var bracers = "()[]{}";
        var stack = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (bracers.IndexOf(str[i]) % 2 == 0)
            {
                stack.Push(str[i]);
            }
            else if (bracers.IndexOf(str[i]) % 2 == 1)
            {
                if (bracers.IndexOf(str[i]) - bracers.IndexOf(stack.Peek()) == 1) 
                {
                    stack.Pop();
                }
                else return false;
            }    
        }

        return stack.Count == 0;

    }

    static public void MainProgram()
    {
        //Отримання файлу
        string fileName = @"C:\Users\Alxich\Desktop\Labs_Csh_lang\Lab3\Task 2\script.js";
        var s = File.ReadAllText(fileName);

        Console.WriteLine("\n ----------------------------------------- \n");
        Console.WriteLine(" Перевірка відповідністі розміщення круглих та фігурних дужок");
        Console.WriteLine(CheckBracers(s) ? "  - Кількість відкритих та закритих дужок кожного виду співпадає" : "  - Кількість відкритих та закритих дужок кожного виду не співпадає");
        Console.WriteLine("\n-----------------------------------------\n");

        Menu();
    }

    /** 
    * Виведення результату програми
    */
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.Default;

        Menu();

    }


}