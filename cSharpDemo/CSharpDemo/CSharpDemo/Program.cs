using System;
using static System.Console;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Hello, What is your name?\n>");
            var name = ReadLine();
            if (WantToPlay(name, true))
            {
                GameLoop(name);
            }
        }

        private static bool WantToPlay(string name, bool newGame)
        {
            Write($"{name}, Would you like to play a{(newGame ? "" : "nother")} game?\n>");
            var answer = ReadLine().ToLower();

            switch (answer)
            {
                case "y":
                case "yes":
                    return true;
                case "n":
                case "no":
                    WriteLine($"Oh well, goodbye, {name}");
                    return false;
                default:
                    WriteLine($"I don't understand {answer}");
                    return WantToPlay(name, newGame);
            }
        }

        private static void GameLoop(string name)
        {
            var rand = new Random();
            var mysteryNumber = rand.Next(10) + 1;
            int guess = 0;
            
            do
            {
                if (guess != 0 && guess >= 1 && guess <= 10)
                {
                    WriteLine($"Sorry, {name}, {guess} is wrong. Try again.");
                }
                Write("Guess a number between 1 and 10\n>");
                var guessString = ReadLine();

                if (!int.TryParse(guessString, out guess))
                    WriteLine($"I don't understand {guessString}, {name}. Try again.");
                else if (guess < 1 || guess > 10)
                    WriteLine($"{guess} is not between 1 and 10, {name}. Try again.");
            }
            while (guess != mysteryNumber);

            WriteLine($"You win, {name}! {guess} was the mystery number!");

            if (WantToPlay(name, false))
            {
                GameLoop(name);
            }
        }
    }
}
