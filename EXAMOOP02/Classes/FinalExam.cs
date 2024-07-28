

using EXAMOOP02.Enums;

namespace EXAMOOP02.Classes
{
    internal class FinalExam : Exam
    {
        private int[] StudentAnswers;
        private double TotalMark;
       
        public FinalExam(DateTime timeOfExam, int numberOfQuetions) : base(timeOfExam, numberOfQuetions)
        {
            StudentAnswers = new int[numberOfQuetions];
        }

        public override void CreateExam()
        {

            for (int i = 0; i < NumberOfQuetions; i++)
            {
                int QuestionType;
                do
                {
                    Console.WriteLine("Choose Question Type : 1 - MCQ | 2  - True Or False");

                } while (!int.TryParse(Console.ReadLine(), out QuestionType) || QuestionType < 1 || QuestionType > 2);
                if (QuestionType == 1)
                    Questions[i] = MCQ.CreateQuestion(i + 1);
                else
                    Questions[i] = TrueOrFalse.CreateQuestion(i + 1);
            }
        }

        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuetions; i++)
            {
                Questions[i].ShowQuestion();
                GetAnswer(i);
            }

        }

        private void GetAnswer(int questionNumber)
        {
            int answer;
            do
            {
                Console.WriteLine("Enter you answer pls");


            } while (!int.TryParse(Console.ReadLine(), out answer) || !(answer > 0) || answer > 4);
            StudentAnswers[questionNumber] = answer;

        }

        public override void ShowTheResult()
        {
            for (int i = 0; i < NumberOfQuetions; i++)
            {
                if (Questions[i].RightAnswer == StudentAnswers[i])
                {
                    TotalMark += Questions[i].Mark;
                }
            }

            Console.WriteLine($"Total Mark  : {TotalMark}");
        }
    }
}
