

using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;

namespace EXAMOOP02.Classes
{
    internal class FinalExam : Exam
    {
       


        public FinalExam( int numberOfQuetions , IInputHandler inputHandler) : base( numberOfQuetions ,  inputHandler)
        {
            
        }

        public override void CreateExam()
        {

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                QuestionType questionType = _inputHandler.GetQuestionType();

                if (questionType == QuestionType.MCQ)
                    Questions[i] = MCQ.CreateQuestion(i + 1, _inputHandler);
                else
                    Questions[i] = TrueOrFalse.CreateQuestion(i + 1, _inputHandler);
            }

        }

       


     

       
    }
}
