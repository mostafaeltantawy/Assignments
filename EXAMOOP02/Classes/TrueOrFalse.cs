using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;



namespace EXAMOOP02.Classes
{
    internal class TrueOrFalse : Question
    {

        public TrueOrFalse(QuestionType questionType, string bodyOfTheQuestion, double mark, int rightAnswer)
            : base(questionType, bodyOfTheQuestion, mark, [new Answer(1, "True"), new Answer(2, "False")], rightAnswer)
        {
        }

        public static TrueOrFalse CreateQuestion(int questionNumber , IInputHandler inputHandler)
        {

            Answer[] answers = [new Answer(1, "True"), new Answer(2, "False")];

            string BodyOfTheQuestion = inputHandler.GetBodyInput(questionNumber , QuestionType.TrueOrFalse);

            double Mark = inputHandler.GetQuestionMark();

            int rightAnswerNumber = inputHandler.GetTheRightAnswerForTrueOrFalse();

            return new TrueOrFalse(QuestionType.TrueOrFalse, BodyOfTheQuestion, Mark, rightAnswerNumber);


        }


    }
}
