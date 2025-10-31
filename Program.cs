using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        string number = "";
        for (int i = 0; i < 6; i++)
        {
            number += random.Next(0, 10);
        }

        int attempts = 5;
        char[] guess = new char[number.Length];

        for (int i = 0; i < guess.Length; i++)
        {
            guess[i] = '_';
        }

        Console.WriteLine("Я загадав число з " + number.Length + " цифр.");
        Console.WriteLine("У тебе " + attempts + " спроб.");

        while (attempts > 0)
        {
            Console.Write("Введи цифру: ");
            string input = Console.ReadLine();

            if (input.Length != 1 || !char.IsDigit(input[0]))
            {
                Console.WriteLine("Введи одну цифру!");
                continue;
            }

            char digit = input[0];
            bool found = false;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == digit)
                {
                    guess[i] = digit;
                    found = true;
                }
            }

            if (!found)
            {
                attempts--;
                Console.WriteLine("Такої цифри нема! Залишилось спроб: " + attempts);
            }
            else
            {
                Console.WriteLine("Є така цифра!");
            }

            Console.WriteLine("Поточний стан: " + new string(guess));

            if (new string(guess) == number)
            {
                Console.WriteLine("Ти вгадав число!");
                break;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("Ти програв! Число було: " + number);
        }
    }
}