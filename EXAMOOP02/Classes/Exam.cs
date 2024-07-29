
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;
using System.Diagnostics;


namespace EXAMOOP02.Classes
{
    public abstract class Exam
    {
        #region Props
        public TimeSpan TimeTaken { get; set; }
        public TimeSpan TimeofExam { get; set; }

        public int NumberOfQuestions { get; private set; }
        public Question[] Questions { get; set; }
        public double TotalMark { get; set; }
        public double Result { get; set; }
        public int[] StudentAnswers { get; private set; }
        private protected readonly IInputHandler _inputHandler;

        #endregion

        #region COnsrtuctors
        public Exam(int numberOfQuetions, TimeSpan timeOfExam, IInputHandler inputHandler)
        {
            NumberOfQuestions = numberOfQuetions > 0 ? numberOfQuetions : throw new ArgumentException("The number of questions Should be greater than 0  ");
            Questions = new Question[numberOfQuetions];
            StudentAnswers = new int[numberOfQuetions];
            _inputHandler = inputHandler;
            TimeofExam = timeOfExam;
        }

        #endregion


        #region Methods
        public abstract void CreateExam();

        public void ShowExam()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (stopwatch.Elapsed.TotalSeconds >= TimeofExam.TotalSeconds)
                {
                    Console.WriteLine("Time is Ended");
                    break;
                }
                Questions[i].ShowQuestion();
                StudentAnswers[i] = _inputHandler.GetAnswer(i, Questions[i].QuestionType);
            }
            stopwatch.Stop();
            TimeTaken = stopwatch.Elapsed;
            this.CalculateResult();

        }


        private double CalculateResult()
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

        #endregion





    }
}
