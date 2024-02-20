using System;
using System.ComponentModel;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Console.WriteLine("Wpisz proszę dwie cyfry");

                float number1;
                float number2;
                Console.WriteLine("Podaj pierwszą cyfrę");

                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj drugą cyfrę");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select category:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Press 1, 2, 3 or 4...");

               switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"Your result: {number1}+{number2}=" + (number1 + number2));
                        break;
                    case "2":
                        Console.WriteLine($"Your result: {number1}-{number2}=" + (number1 - number2));
                        break;
                    case "3":
                        Console.WriteLine($"Your result: {number1}*{number2}=" + (number1 * number2));
                        break;
                    case "4":
                        Console.WriteLine($"Your result: {number1}/{number2}=" + (number1 / number2));
                        {
                            if (number2 == 0)
                                Console.WriteLine("Don't divide by zero");
                        }
                        break;
                        Console.WriteLine("Press any key to close the console app...");
                }
            }
        }
    }
}