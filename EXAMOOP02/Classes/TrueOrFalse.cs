using EXAMOOP02.Enums;
using EXAMOOP02.Util;



namespace EXAMOOP02.Classes
{
    internal class TrueOrFalse : Question
    {

        public TrueOrFalse(QuestionType questionType, string bodyOfTheQuestion, double mark, int rightAnswer)
            : base(questionType, bodyOfTheQuestion, mark, [new Answer(1, "True"), new Answer(2, "False")], rightAnswer)
        {
        }

        public static TrueOrFalse CreateQuestion(int questionNumber)
        {

            Answer[] answers = [new Answer(1, "True"), new Answer(2, "False")];

            string BodyOfTheQuestion = InputHandler.GetBodyInput(questionNumber);

            double Mark = InputHandler.GetQuestionMark();

            int rightAnswerNumber = InputHandler.GetTheRightAnswerForTrueOrFalse();

            return new TrueOrFalse(QuestionType.TrueOrFalse, BodyOfTheQuestion, Mark, rightAnswerNumber);


        }


    }
}
