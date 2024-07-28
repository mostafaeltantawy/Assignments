

namespace EXAMOOP02.Classes
{
    public class Answer
    {
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


        public static Answer CreateAnswer(int answerId)
        {
            string answerText;
            do
            {
                Console.WriteLine($"Please Enter Answer #{answerId} : ");
                answerText = Console.ReadLine();

            } while (answerText.Trim() == "" || answerText is null);

            return new Answer(answerId, answerText);
        }

        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }
    }
}
