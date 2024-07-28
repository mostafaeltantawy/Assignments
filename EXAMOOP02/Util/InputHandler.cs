using EXAMOOP02.Classes;
using EXAMOOP02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Util
{
    public static class InputHandler
    {
        #region CreatingQuestions
        public static string GetBodyInput(int QuestionNumber)
        {
            string BodyOfTheQuestion;
            do
            {
                Console.WriteLine($"Please Enter The Body Of The Question #{QuestionNumber}");
                BodyOfTheQuestion = Console.ReadLine();

            } while (BodyOfTheQuestion?.Trim() == "" || BodyOfTheQuestion is null);

            return BodyOfTheQuestion;
        }

        public static double GetQuestionMark()
        {
            double Mark;
            do
            {
                Console.WriteLine("Enter The Mark ");

            } while (!double.TryParse(Console.ReadLine(), out Mark));
            return Mark;
        }

        public static int GetTheRightAnswerForTrueOrFalse()
        {
            int rightAnswerNumber;
            do
            {
                Console.WriteLine("Enter The Right Answer Number 1 - True | 2 - False  ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerNumber) || rightAnswerNumber < 0 || rightAnswerNumber > 2);
            return rightAnswerNumber;
        }

        public static void GetMCQAnswers(Answer[] answers)
        {
            for (int i = 0; i < answers.Length; i++)
            {

                answers[i] = Answer.CreateAnswer(i + 1);

            }
        }

        public static int GetTheRightAnswerForMCQ()
        {
            int rightAnswerNumber;

            do
            {
                Console.WriteLine("Enter The Right Answer Number ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerNumber) || !(rightAnswerNumber > 0) || !(rightAnswerNumber <= 4));
            return rightAnswerNumber;
        }
        public static QuestionType GetQuestionType()
        {
            QuestionType questionType;
            do
            {
                Console.WriteLine("Choose Question Type : 1 - MCQ | 2  - True Or False");

            } while (!Enum.TryParse<QuestionType>(Console.ReadLine(), true, out questionType));

            return questionType;
        }

        #endregion

        #region GettingAnswer

        public static int GetAnswer(int questionNumber, QuestionType questionType)
        {
            int answerNumber;
            if (QuestionType.TrueOrFalse == questionType)

                answerNumber = GetTheRightAnswerForTrueOrFalse();

            else

                answerNumber = GetTheRightAnswerForMCQ();

            return answerNumber; 


        }
        #endregion


    }
}

