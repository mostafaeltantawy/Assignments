

using EXAMOOP02.Enums;
using EXAMOOP02.Util;

namespace EXAMOOP02.Classes
{
    internal class FinalExam : Exam
    {
       


        public FinalExam( int numberOfQuetions) : base( numberOfQuetions)
        {
            
        }

        public override void CreateExam()
        {

            for (int i = 0; i < NumberOfQuetions; i++)
            {
                QuestionType questionType = InputHandler.GetQuestionType();

                if (questionType == QuestionType.MCQ)
                    Questions[i] = MCQ.CreateQuestion(i + 1);
                else
                    Questions[i] = TrueOrFalse.CreateQuestion(i + 1);
            }

        }

       


     

       
    }
}
