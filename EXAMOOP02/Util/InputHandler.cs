using EXAMOOP02.Classes;
using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;


namespace EXAMOOP02.Util
{
    public  class InputHandler :IInputHandler
    {
        #region CreatingQuestions
        public  string GetBodyInput(int QuestionNumber , QuestionType questionType)
        {
            string BodyOfTheQuestion;
            do
            {
                Console.WriteLine($"{questionType} Question");
                Console.WriteLine($"Please Enter The Body Of The Question #{QuestionNumber}");
                BodyOfTheQuestion = Console.ReadLine();

            } while (BodyOfTheQuestion?.Trim() == "" || BodyOfTheQuestion is null);

            return BodyOfTheQuestion;
        }

        public  double GetQuestionMark()
        {
            double Mark;
            do
            {
                Console.WriteLine("Enter The Mark ");

            } while (!double.TryParse(Console.ReadLine(), out Mark) || Mark <= 0 );
            return Mark;
        }



        public  int GetTheRightAnswerForTrueOrFalse()
        {
            int rightAnswerNumber;
            do
            {
                Console.WriteLine("Enter The Right Answer Number 1 - True | 2 - False  ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerNumber) || rightAnswerNumber < 0 || rightAnswerNumber > 2);
            return rightAnswerNumber;
        }

        public  Answer CreateAnswer(int answerId)
        {
            string answerText;
            do
            {
                Console.WriteLine($"Please Enter Answer #{answerId} : ");
                answerText = Console.ReadLine();

            } while (answerText.Trim() == "" || answerText is null);

            return new Answer(answerId, answerText);
        }

        public  void GetMCQAnswers(Answer[] answers)
        {

            for (int i = 0; i < answers.Length; i++)
            {

                answers[i] = CreateAnswer(i + 1);

            }
        }

        public  int GetTheRightAnswerForMCQ()
        {
            int rightAnswerNumber;

            do
            {
                Console.WriteLine("Enter The Right Answer Number ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerNumber) || !(rightAnswerNumber > 0) || !(rightAnswerNumber <= 4));
            return rightAnswerNumber;
        }
        public  QuestionType GetQuestionType()
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

        public  int GetAnswer(int questionNumber, QuestionType questionType)
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

