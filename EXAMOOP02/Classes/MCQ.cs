using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
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


        public static MCQ CreateQuestion(int questionNumber , IInputHandler inputHandler)
        {

            Answer[] answers = new Answer[4];

            string BodyOfTheQuestion = inputHandler.GetBodyInput(questionNumber , QuestionType.MCQ);

            double Mark = inputHandler.GetQuestionMark();

            inputHandler.GetMCQAnswers(answers);

            int rightAnswerNumber = inputHandler.GetTheRightAnswerForMCQ();

            return new MCQ(QuestionType.MCQ, BodyOfTheQuestion, Mark, answers, rightAnswerNumber);

        }

    }
}
