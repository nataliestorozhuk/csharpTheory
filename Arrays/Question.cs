using System;
using System.Collections.Generic;

namespace Arrays
{
    class Question
    {
        public static void Run()
        {
            int pointsForFirstPlayer = 0;
            int pointsForSecondPlayer = 0;

            List<Question> questions = new List<Question>()
        {
            new Question("When do we celebrate independence day? ", "July 4th", "August 6th", "September 11th", 1),
            new Question("What is the capital of Ukraine?", "Kiev", "Oslo", "London",1),
            new Question("When do we celebrate Christmas?", "December 6th", "December 25th", "December 28th", 2),
            new Question("What is the capital of UK?", "Kiev", "Oslo", "London", 3) };


        //};
        //    for (int i = 0; i < questions.Capacity; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine("Player one answer the question: \n");
        //            PrintQuestion(questions);
        //            String answer = Console.ReadLine();
        //            if (answer.ToUpper(questions(i).CorrectAnswer))
        //            {
        //                pointsForFirstPlayer++;
        //                Console.WriteLine($"Correct!!! You have {pointsForFirstPlayer} points.");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Sorry, that was incorrect!!! You have {pointsForFirstPlayer} points.");
        //            }
        //           else
        //            {
        //                Console.WriteLine("Player two answer the question: \n");
        //                PrintQuestion(questions(i));
        //                String answer2 = Console.ReadLine();
        //                if (answer2.ToUpper(questions(i).CorrectAnswer))
        //                {
        //                    pointsForSecondPlayer++;
        //                    Console.WriteLine($"Correct!!! You have {pointsForSecondPlayer} points.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"Sorry, that was incorrect!!! You have {pointsForSecondPlayer} points.");
        //                }
        //            }

        //        }
        //    }

            // Condition checks who wins.
            if (pointsForFirstPlayer > pointsForSecondPlayer)
            {
                Console.WriteLine("Player one wins!");
            }
            else
            {
                Console.WriteLine("Player two wins!");
            }
        }
        public string TriviaQuestion { get; set; }
        public string PossAnswer1 { get; set; }
        public string PossAnswer2 { get; set; }
        public string PossAnswer3 { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string triviaQuestion, string possAnswer1, string possAnswer2, string possAnswer3, int correctAnswer)
        {
            TriviaQuestion = triviaQuestion;
            PossAnswer1 = possAnswer1;
            PossAnswer2 = possAnswer2;
            PossAnswer3 = possAnswer3;
            CorrectAnswer = correctAnswer;
        }


        public static void PrintQuestion(Question question)
        {
            Console.WriteLine(question.TriviaQuestion);
            Console.WriteLine(question.PossAnswer1);
            Console.WriteLine(question.PossAnswer2);
            Console.WriteLine(question.PossAnswer3);
        }
    }
    //class Player
    //{
    //    public string PlayerName { get; set; }

    //    public int Score { get; set; }

    //    public Player(string playerName)
    //    {
    //        PlayerName = playerName;
    //    }
    //}

}
