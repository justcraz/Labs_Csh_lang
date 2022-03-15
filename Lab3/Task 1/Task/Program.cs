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

    /** 
    * Провірка на голосні букви
    */
    static string vowels = "aeiouy";
    static bool IsVowel(char ch)
    {
        return vowels.IndexOf(ch) != -1;
    }

    /** 
    * Провірка на мінімальне по довжині слово
    */
    static bool EndsWithVowel(string word)
    {
        return IsVowel(word[word.Length - 1]);
    }

    /** 
    * Провірка на максимальне по довжині слово
    */
    static int maxLength = 4;
    static bool IsShort(string word)
    {
        return word.Length <= maxLength;
    }

    
    static public void MainProgram()
    {
        // Ведення речення
        Console.Write("\n\n Ведіть ваше речення: ");
        string text = CheckIfNotNum();

        // Показ результату
        CheckText(text);

        Menu();
    }
    static public string CheckIfNotNum()
    {
        double num = 0;
        while (true)
        {

            var input = Console.ReadLine();

            if (!double.TryParse(input, out num) && num < ' ' )
            {
                // Якщо було веденно слова то буде закінчення циклу
                return input;
            }
            else
            {
                // Якщо було веденно число буде повернення циклу
                Console.WriteLine(" Ведено невірне значення. Спробуйте знову !");
                Console.Write(" Ваша значення: ");
            }
        }
    }

    static void CheckText(string text)
    {

        int endsWithVowel = 0;
        var shortWords = new List<string>();

        foreach (Match match in Regex.Matches(text, @"(\p{Lu}|\p{Ll})+"))
        {
            string word = match.Value;
            if (EndsWithVowel(word))
                endsWithVowel++;
            if (IsShort(word))
                shortWords.Add(word);
        }

        Console.WriteLine(" Слова, що закінчуються на голосну: " + endsWithVowel);
        Console.WriteLine(" Слова, які коротші за п'ять символів:");

        foreach (var word in shortWords)
        {
            Console.Write(" " + word + " ");
        }

        Console.WriteLine();
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