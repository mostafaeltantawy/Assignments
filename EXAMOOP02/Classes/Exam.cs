
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;
using System.Diagnostics;


namespace EXAMOOP02.Classes
{
    internal abstract class Exam
    {
        public Exam( int numberOfQuetions, IInputHandler inputHandler)
        {
            NumberOfQuestions = numberOfQuetions > 0 ? numberOfQuetions : throw new ArgumentException("The number of questions Should be greater than 0  ");
            Questions = new Question[numberOfQuetions];
            StudentAnswers = new int[numberOfQuetions];
            _inputHandler = inputHandler;
        }

        public TimeSpan TimeOfExam { get; set; }
        public int NumberOfQuestions { get; private set; }
        public Question[] Questions { get; set; }
        public double TotalMark { get;  set; }
        public double Result { get;  set; }
        private int[] StudentAnswers;
        private protected readonly IInputHandler _inputHandler;

        public abstract void CreateExam();

        public  void ShowExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i].ShowQuestion();
                StudentAnswers[i] = _inputHandler.GetAnswer(i, Questions[i].QuestionType);
            }
            stopwatch.Stop();
            TimeOfExam = stopwatch.Elapsed; 
            this.CalculateResult();

        }


        private  double CalculateResult()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
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
