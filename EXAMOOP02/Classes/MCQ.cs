using EXAMOOP02.Enums;
using EXAMOOP02.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class MCQ : Question
    {

        public MCQ(QuestionType questionType, string bodyOfTheQuestion, double mark, Answer[] answers, int rightAnswer) : base(questionType, bodyOfTheQuestion, mark, answers, rightAnswer)
        {
        }


        public static MCQ CreateQuestion(int questionNumber)
        {

            Answer[] answers = new Answer[4];

            string BodyOfTheQuestion = InputHandler.GetBodyInput(questionNumber);

            double Mark = InputHandler.GetQuestionMark();

            InputHandler.GetMCQAnswers(answers);

            int rightAnswerNumber = InputHandler.GetTheRightAnswerForMCQ();

            return new MCQ(QuestionType.MCQ, BodyOfTheQuestion, Mark, answers, rightAnswerNumber);

        }

    }
}
