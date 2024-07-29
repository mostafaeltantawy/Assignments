

namespace EXAMOOP02.Classes
{
    public class Answer
    {
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }


        public int AnswerId { get;private set; }
        public string AnswerText { get; private set; }


       

        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }
    }
}
