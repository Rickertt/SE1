using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String woord = "Aartdejong";
            Console.WriteLine(woord);
            Console.WriteLine(Program.woordOmdraaien(woord));

            Console.WriteLine("");

            int getal = 999999999;
            Console.WriteLine(getal);
            Console.WriteLine("Som der cijfers: " + somDerCijfers(getal));
            Console.Read();
        }

        public static int aantalWoordenInZin(String inputString)
        {
            string[] woorden = inputString.Split(' ');
            return woorden.Length;
        }

        public static int aantalLettersInWoord(String input, char letter)
        {
            int output = 0;
            foreach (char c in input.ToCharArray())
            {
                if (c == letter)
                    output += 1;
            }
            return output;
        }

        public static String woordOmdraaien(String input)
        {
            String output = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        public static int somDerCijfers(int input)
        {
            int output = 0;

            while (input != 0)
            {
                output += input % 10;
                input /= 10;
            }
            if (output > 9)
                output = somDerCijfers(output);

            return output;
        }

        public static int optellen(int a, int b)
        {
            return a + b;
        }

        public static int aftrekken(int a, int b)
        {
            return a - b;
        }

        public static int kwadrateren(int a)
        {
            return a * a;
        }

        public static int vermenigvuldigen(int a, int b)
        {
            return a * b;
        }

        public static int machtsverheffen(int a, int b)
        {
            int output = 1;
            for(int i = 0; i < b ; i++)
            {
                output *= a;
            }
            return output;
        }
    }
}
