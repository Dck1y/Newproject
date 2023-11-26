using System;

class MillionaireGame
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру 'Кто хочет стать миллионером'!");
        Console.WriteLine("За каждый правильно отвеченный вопрос вы получаете валюту.");

        string[] questions = {
            "1. Почему?",
            "2. А как?",
            "3. Так а почему вот так?",
            "4. Почему тут не так, как там?",
            "5. А почему там, как тут не там, как там?"
        };

        string[] answers = { "Потому", "Да вот так", "Да потому что вот так", "Потому что тут как в другом там", "Хз" };
        string[] options = { "a) Да b) Потому c) Что d) Ответ",
                             "a) Да вот так b) Об косяк c) Никак d) Не скажу",
                             "a) Да b) Всё еще не скажу c) Не знаю d) Да потому что вот так",
                             "a) Потому что тут как в другом там b) А потому c) Радуйся, что не так, как там d) Почему то",
                             "a) Правильный ответ b) Ответ c) Хз d) Неправильный ответ" };

        int correctAnswersCount = 0;
        int prize = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("\n" + questions[i]);
            Console.WriteLine(options[i]);
            Console.Write("Ваш ответ: ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == answers[i].ToLower())
            {
                Console.WriteLine("Верно!");
                correctAnswersCount++;

                if (correctAnswersCount == 1)
                {
                    prize = 100;
                }
                else
                {
                    prize *= 2;
                }

                Console.WriteLine("Ваш приз: $" + prize);
            }
            else
            {
                Console.WriteLine("Неверно! Игра окончена.");
                break;
            }
        }

        Console.WriteLine("\nИгра окончена. Ваш выигрыш: $" + prize);
    }
}