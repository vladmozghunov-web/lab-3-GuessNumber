using System;


namespace MillionerGame
{
    struct Question
    {
        public string text;
        public string a;
        public string b;
        public string c;
        public string d;
        public char correctAnswer;
        public int points;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Question[] questions = new Question[3];

            questions[0].text = "Яка планета 4 від Сонця?";
            questions[0].a = "а) Меркурій";
            questions[0].b = "б) Марс";
            questions[0].c = "в) Земля";
            questions[0].d = "г) Уран";
            questions[0].correctAnswer = 'б';
            questions[0].points = 100;

            questions[1].text = "Яка висота Евересту?";
            questions[1].a = "а) 5 км";
            questions[1].b = "б) 10 км";
            questions[1].c = "в) 9 км";
            questions[1].d = "г) 2 км";
            questions[1].correctAnswer = 'в';
            questions[1].points = 200;

            questions[2].text = "Скільки буде 2+2?";
            questions[2].a = "а) 3";
            questions[2].b = "б) 4";
            questions[2].c = "в) 5";
            questions[2].d = "г) 6";
            questions[2].correctAnswer = 'б';
            questions[2].points = 300;

            int totalPoints = 0;

            Console.WriteLine("=== Гра 'Як стати мільйонером' ===\n");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Питання {i + 1}: {questions[i].text}");
                Console.WriteLine(questions[i].a);
                Console.WriteLine(questions[i].b);
                Console.WriteLine(questions[i].c);
                Console.WriteLine(questions[i].d);
                Console.Write("\nОберіть правильну відповідь (а, б, в, г): ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer == questions[i].correctAnswer)
                {
                    totalPoints += questions[i].points;
                    Console.WriteLine("Правильно! Ви заробили {questions[i].points} очок.");
                }
                else
                {
                    Console.WriteLine("Неправильно, ви програли.");
                    break;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nГру закінчено. Ви набрали {totalPoints} очок.");
            Console.ReadKey();
        }
    }
}