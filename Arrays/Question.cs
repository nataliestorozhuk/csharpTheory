using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Question
    {
        public string TriviaQuestion { get; set; }
        public string PossAnswer1 { get; set; }
        public string PossAnswer2 { get; set; }
        public string PossAnswer3 { get; set; }
        public string PossAnswer4 { get; set; }
        public string[] NumberOfCorrectAnswers { get; set; }

        public Question(string triviaQuestion, string possAnswer1, string possAnswer2, string possAnswer3, string possAnswer4, string[] numberOfCorrectAnswers)
        {
            TriviaQuestion = triviaQuestion;
            PossAnswer1 = possAnswer1;
            PossAnswer2 = possAnswer2;
            PossAnswer3 = possAnswer3;
            PossAnswer4 = possAnswer4;
            NumberOfCorrectAnswers = numberOfCorrectAnswers;
        }
    }

    class DemoQuestion
    {
        List<Question> questions = new List<Question>()
        {
            new Question("When do we celebrate independence day? ", "July 4th", "August 6th", "September 11th", 1),

        };
    }
}
