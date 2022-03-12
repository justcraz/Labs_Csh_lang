using System;

namespace ConsoleApp1 {
    public class Program {

        static public int Example(int a, int b) {
            int c = a + b;
            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + c.ToString());

            return c;
        }

        static void Main(string[] args) {

            Console.WriteLine("Write yout first number");
            string S1 = Console.ReadLine();

            int a = int.Parse(S1);
            Console.WriteLine("Write yout second number");

            string S2 = Console.ReadLine();

            int b = int.Parse(S2);
            Example(a, b);
            Console.ReadLine();

        }

    }

}