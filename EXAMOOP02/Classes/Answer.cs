

namespace EXAMOOP02.Classes
{
    public class Answer
    {

        #region props
        public int AnswerId { get; private set; }
        public string AnswerText { get; private set; }
        #endregion


        #region Constructors
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        #endregion


        #region methods
        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }
        #endregion



    }
}
