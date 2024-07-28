using EXAMOOP02.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Util
{
    public static class InputHandler
    {
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

        public static int  GetTheRightAnswerForTrueOrFalse()
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

    }
}

