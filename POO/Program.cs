using System;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "In the \"Star Wars\" universe, what is the name of Han Solo's ship?",
                    new string[] {
                        "The Millennium Falcon", 
                        "The Star Destroyer", 
                        "The X-Wing", 
                        "The TIE Fighter"
                    }, 
                    0
                ),
                new Question(
                    "What is the primary programming language used to build Android apps?",
                    new string[] {
                        "Python",
                        "Swift",
                        "Java",
                        "Ruby"
                    },
                    2
                ),
                new Question(
                    "In the Marvel Cinematic Universe, who wields the Infinity Gauntlet to undo Thanos' snap?",
                    new string[] {
                        "Thor",
                        "Iron Man",
                        "Captain America",
                        "Doctor Strange"
                    },
                    1
                ),
                new Question(
                    "Which video game series features the character \"Master Chief\"?",
                    new string[] {
                        "Call of Duty",
                        "Halo",
                        "Doom",
                        "Gears of War"
                    },
                    1
                ),
                new Question(
                    "In the Harry Potter series, what is the name of Harry’s pet owl?",
                    new string[] {
                        "Errol",
                        "Crookshanks",
                        "Scabbers",
                        "Hedwig"
                    },
                    3
                ) 
            };

            Quiz quiz = new Quiz(questions);

            quiz.StartQuiz();

            Console.ReadKey();
        }
    }
}