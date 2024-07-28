
using EXAMOOP02.Util;
using System.Diagnostics;


namespace EXAMOOP02.Classes
{
    internal abstract class Exam
    {
        public Exam( int numberOfQuetions)
        {
            NumberOfQuetions = numberOfQuetions;
            Questions = new Question[numberOfQuetions];
            StudentAnswers = new int[numberOfQuetions];
        }

        public TimeSpan TimeOfExam { get; set; }
        public int NumberOfQuetions { get; private set; }
        public Question[] Questions { get; set; }
        public double TotalMark { get;  set; }
        public double Result { get;  set; }
        private int[] StudentAnswers;




        public abstract void CreateExam();

        public  void ShowExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < NumberOfQuetions; i++)
            {
                Questions[i].ShowQuestion();
                StudentAnswers[i] = InputHandler.GetAnswer(i, Questions[i].QuestionType);
            }
            stopwatch.Stop();
            TimeOfExam = stopwatch.Elapsed; 
            this.CalculateResult();

        }


        private  double CalculateResult()
        {
            for (int i = 0; i < NumberOfQuetions; i++)
            {
                TotalMark += Questions[i].Mark;
                if (Questions[i].RightAnswer == StudentAnswers[i])
                {
                    Result += Questions[i].Mark;
                }
            }
            return Result;
        }



    }
}
