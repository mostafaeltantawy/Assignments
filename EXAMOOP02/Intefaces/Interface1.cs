using EXAMOOP02.Classes;
using EXAMOOP02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Intefaces
{
    internal interface IInputHandler
    {
        string GetBodyInput(int questionNumber, QuestionType questionType);
        double GetQuestionMark();
        int GetTheRightAnswerForTrueOrFalse();
        void GetMCQAnswers(Answer[] answers);
        int GetTheRightAnswerForMCQ();
        QuestionType GetQuestionType();
        int GetAnswer(int questionNumber, QuestionType questionType);
    }
}
