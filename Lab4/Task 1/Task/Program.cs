using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CoderTask
{
    public class csharpExercise
    {


        static public int firstNum(int num)
        {
            while (num >= 10)
            {
                num = num / 10;
            }

            Console.WriteLine("Перша цифра введеного числа: " + num);

            return num;
        }
        static public int lastNum(int num, int last)
        {

            last = num % 10;
            Console.WriteLine("Остання цифра введеного числа: " + last);

            return last;

        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Default;

            int num;

            // Reading number
            Console.Write("Введiть трьохзначне число: ");
            num = Convert.ToInt32(Console.ReadLine());

            firstNum(num);
            lastNum(num, 0);
            Console.ReadLine();

        }
    }

}