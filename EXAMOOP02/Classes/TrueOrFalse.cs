using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class TrueOrFalse : Question
    {

        public TrueOrFalse(string headerOfTheQuestion, string bodyOfTheQuestion, double mark, int rightAnswer)
            : base(headerOfTheQuestion, bodyOfTheQuestion, mark, [new Answer(1, "True"), new Answer(2, "False")], rightAnswer)
        {
        }

        public static TrueOrFalse CreateQuestion(int questionNumber)
        {
            string HeaderOfTheQuestion, BodyofTheQustion;
            double Mark;
            Answer[] answers = [new Answer(1, "True"), new Answer(2, "False")];
            int rightAnswerNumber;

            do
            {
                Console.WriteLine($"Please Enter The Header Of The Question #{questionNumber}");
                HeaderOfTheQuestion = Console.ReadLine();

            } while (HeaderOfTheQuestion?.Trim() == "" || HeaderOfTheQuestion is null);

            do
            {
                Console.WriteLine($"Please Enter The Header Of The Question #{questionNumber}");
                BodyofTheQustion = Console.ReadLine();

            } while (BodyofTheQustion?.Trim() == "" || BodyofTheQustion is null);

            do
            {
                Console.WriteLine("Enter The Mark ");

            } while (double.TryParse(Console.ReadLine(), out Mark));


            do
            {
                Console.WriteLine("Enter The Right Answer Number ");

            } while (int.TryParse(Console.ReadLine(), out rightAnswerNumber) && rightAnswerNumber > 0 && rightAnswerNumber <= answers.Length);


            return new TrueOrFalse(HeaderOfTheQuestion, BodyofTheQustion, Mark, rightAnswerNumber);


        }

        public override void ShowQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
