using EXAMOOP02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    public  class Question
    {
        #region Props
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswer { get; set; }
        public QuestionType QuestionType { get; set; }

        #endregion

        #region Constructor
        public Question(QuestionType questionType, string bodyOfTheQuestion, double mark, Answer[] answers, int rightAnswer)
        {
            HeaderOfTheQuestion = $"{questionType}      mark[{mark}]";
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
            QuestionType = questionType;
        }

        #endregion


        #region Methods
        public void ShowQuestion()
        {
            Console.WriteLine($"{HeaderOfTheQuestion}");
            Console.WriteLine($"{BodyOfTheQuestion}?");
            foreach (var item in Answers)
            {
                Console.WriteLine(item);

            }
        }

        #endregion


    }
}
