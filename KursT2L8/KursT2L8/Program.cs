using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Lekcja8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises from lesson 8- loop:");
            Console.WriteLine("Execise 1");
            Exercise1();
            Console.WriteLine("Execise 2");
            Exercise2();
            Console.WriteLine("Execise 3");
            Exercise3();
            Console.WriteLine("Execise 4");
            Exercise4();
            Console.WriteLine("Execise 5");
            Exercise5();
            Console.WriteLine("Execise 6");
            Exercise6();
            Console.WriteLine("Execise 7");
            Exercise7();
            Console.WriteLine("Execise 8");
            Exercise8();
            Console.WriteLine("Execise 9");
            Exercise9();
            Console.WriteLine("Execise 10");
            Exercise10();
            
        }
        public static void Exercise1()
        {
            Console.WriteLine("The program checks the number of primes in the set <1,100>.");
            int count = 0;
            //int[] numbers = new int[100];
            for (int i = 2; i <= 100; i++)
            {
                double squareRoot;
                squareRoot = Math.Sqrt(i);
                bool isTrue = true;

                for (int j = 2; j <= squareRoot; j++)
                {
                    double reminder;
                    reminder = i % j;
                    if (reminder == 0)
                    {
                        isTrue = false;
                    }

                }
                if (isTrue == true)
                    count++;
            }
            Console.WriteLine("The number of primes is: " + count);

        }
        public static void Exercise2()
        {
            double number = 1;

            Console.WriteLine("The app find all real numbers in set <1,1000>");
            Console.WriteLine("List of numbers :");
            do
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                    number++;
                }
                else
                {
                    number++;
                }

            } while (number <= 1000);
        }
        public static void Exercise3()
        {
            Console.WriteLine("Fibonacci series");
            Console.WriteLine("Which component of Fibonacci series do you want to know:");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0)
            {
                int[] fibonacci = new int[n];
                for (int i = 0; i < n; i++)
                {
                    if (i > 1)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                    else if (i == 0)
                    {
                        fibonacci[i] = 0;
                    }
                    else if (i == 1)
                    {
                        fibonacci[i] = 1;
                    }
                }
                if (n > 0)
                {
                    Console.WriteLine("The fibbonaci series for n= " + n + " is " + fibonacci[n - 1]);
                }
                else
                {
                    Console.WriteLine("Incorrect input, it should be a number");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input, it should be greater than 0");
            }

        }
        public static void Exercise4()
        {
            Console.WriteLine("This app shows piramid of numbers.");
            Console.WriteLine("How many numbers do you want to see?");

            int.TryParse(Console.ReadLine(), out int a);
            long number = 1;
            for (int j = 1; j <= a; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(number);
                    number++;
                    if (number > a)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (number >= a)
                {
                    break;
                }
            }
            
        }
        public static void Exercise5()
        {
            Console.WriteLine("The app show cube root of the number");
            for (int i = 0; i < 20; i++)
            {
                double cube;
                cube = Math.Pow(i + 1, 3);
                Console.WriteLine("The cube root of " + (i + 1) + " is " + cube+" .\n");
            }
        }
        public static void Exercise6()
        {
            Console.WriteLine("This app shows the addition by formula 1+1/2+1/3+...+1/n");
            decimal result = 0;
            decimal fraction;

            for (int i = 1; i < 21; i++)
            {
                decimal n = i;
                fraction = 1 / n;
                result += fraction;
            }
            Console.WriteLine("The result of equation is: " + result);
        }
        public static void Exercise7()
        {
            Console.WriteLine("This app make a beautiful diamond.");
            Console.WriteLine("What is odd lenght of diagonal of diamond?");
            int diagonal = int.Parse(Console.ReadLine());
            int half = diagonal / 2;
            int count = 1;
            int howMany = half;
            if (diagonal % 2 != 0)
            {

                for (int i = 1; i <= half; i++)
                {
                    for (int j = 1; j <= howMany; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= count; k++)
                    {
                        Console.Write("*");
                    }
                    count += 2;
                    for (int l = 1; l <= howMany; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                    howMany--;
                }
                for (int m = 1; m <= diagonal; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                howMany = 1;
                count = diagonal - 2;
                for (int n = 1; n <= half; n++)
                {
                    for (int o = 1; o <= howMany; o++)
                    {
                        Console.Write(" ");
                    }
                    for (int p = 1; p <= count; p++)
                    {
                        Console.Write("*");
                    }
                    count -= 2;
                    for (int o = 1; o <= howMany; o++)
                    {
                        Console.Write(" ");
                    }
                    howMany++;
                    Console.WriteLine();
                    if (howMany == (half + 1))
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry, you have to give a odd number");
            }
            

        }
        public static void Exercise8()
        {
            Console.WriteLine("This app write words from the last letters!");
            Console.WriteLine("Write your word:");
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
        }
        public static void Exercise9()
        {
            Console.WriteLine("The app change number to binary number");
            Console.WriteLine("Please enter the number: ");
            int.TryParse(Console.ReadLine(), out int number);
            if (number > 0)
            {
                int division = number; ;
                List<int> Binary = new List<int>();
                while (division > 0)
                {
                    Binary.Add(division % 2);
                    division = division / 2;

                }
                Console.WriteLine("The number in binary system is: ");
                for (int i = Binary.Count - 1; i >= 0; i--)
                {
                    Console.Write(Binary[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You enter the wrong number");
            }
        }
        public static void Exercise10()
        {
            Console.WriteLine("This app calculate lowest common multiple of two numbers");
            Console.WriteLine("Please, enter the first number:");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Please, enter the second number:");
            int.TryParse(Console.ReadLine(), out int b);
            int LCM;
            int GCM;
            if (a > 0 && b > 0)
            {
                if (a > b)
                {
                    int r1;
                    int r2;
                    int variable;
                    r1 = a % b;
                    if (r1 != 0)
                    {
                        r2 = b % r1;
                        while (r1 != 0 && r2 != 0)
                        {
                            variable = r2;
                            r2 = r1 % r2;
                            r1 = variable;
                        }
                        GCM = r1;
                        LCM = (a * b) / GCM; //związek NWW i NWD
                    }
                    else
                    {
                        GCM = b;
                        LCM = a;
                    }
                    Console.WriteLine($"The lowest common multiple of {a} and {b} is {LCM}");
                }
                else if (b > a)
                {
                    int r1;
                    int r2;
                    int variable;
                    r1 = b % a;
                    if (r1 != 0)
                    {
                        r2 = a % r1;
                        while (r1 != 0 && r2 != 0)
                        {
                            variable = r2;
                            r2 = r1 % r2;
                            r1 = variable;
                        }
                        GCM = r1;
                        LCM = (a * b) / GCM; //związek NWW i NWD
                    }
                    else
                    {
                        GCM = b;
                        LCM = a;
                    }
                    Console.WriteLine($"The lowest common multiple of {a} and {b} is {LCM}");
                }
                else
                {
                    Console.WriteLine("The numbers are equal");
                }

            }
            else
            {
                Console.WriteLine("Please enter umbers greater than 0");
            }
        }
    }
}
