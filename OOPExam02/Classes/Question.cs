using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam02.Classes
{
    internal class Question
    {
       

        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get;  set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswer { get; set; }

        public Question(string headerOfTheQuestion, string bodyOfTheQuestion, double mark, Answer[] answers, int rightAnswer)
        {
            HeaderOfTheQuestion = headerOfTheQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

    }
}
