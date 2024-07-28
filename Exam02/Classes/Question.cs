
namespace Exam02.Classes
{
    internal class Question
    {
     

        public string HeaderOfQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public double Mark { get; set; }
        public Answer[] Answers { get; set;}

        public Question(string headerOfQuestion, string bodyOfQuestion, double mark, Answer[] answers)
        {
            HeaderOfQuestion = headerOfQuestion;
            BodyOfQuestion = bodyOfQuestion;
            Mark = mark;
            Answers = answers;
        }



    }
}
