using System.Collections.Generic;

namespace Arrays
{
    class Question
    {
        public static void Run()
        {
            
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
    }
    class Player
    {
        public string PlayerName { get; set; }

        public int Score { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }
    }
    class DemoQuestion
    {
        List<Question> questions = new List<Question>()
        {
            new Question("When do we celebrate independence day? ", "July 4th", "August 6th", "September 11th", 1),
            new Question("What is the capital of Ukraine?", "Kiev", "Oslo", "London",1),
            new Question("When do we celebrate Christmas?", "December 6th", "December 25th", "December 28th", 2),
            new Question("What is the capital of UK?", "Kiev", "Oslo", "London", 3),
            

        };
    }
}
