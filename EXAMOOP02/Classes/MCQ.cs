using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class MCQ :Question
    {

        public MCQ(string headerOfTheQuestion, string bodyOfTheQuestion, double mark, Answer[] answers, int rightAnswer) : base(headerOfTheQuestion, bodyOfTheQuestion, mark, answers, rightAnswer)
        {
        }


        public static MCQ CreateQuestion(int questionNumber)
        {
            string HeaderOfTheQuestion, BodyofTheQustion;
            double Mark;
            Answer[] answers = new Answer[4];
            int rightAnswerNumber;

            do
            {
                Console.WriteLine($"Please Enter The Header Of The Question #{questionNumber}");
                HeaderOfTheQuestion = Console.ReadLine();

            } while (HeaderOfTheQuestion?.Trim() == "" || HeaderOfTheQuestion is null);

            do
            {
                Console.WriteLine($"Please Enter The Body Of The Question #{questionNumber}");
                BodyofTheQustion = Console.ReadLine();

            } while (BodyofTheQustion?.Trim() == "" || BodyofTheQustion is null);

            do
            {
                Console.WriteLine("Enter The Mark ");

            } while (!double.TryParse(Console.ReadLine(), out Mark));


            for (int i = 0; i < answers.Length; i++)
            {

                answers[i] = Answer.CreateAnswer(i + 1);

            }

            do
            {
                Console.WriteLine("Enter The Right Answer Number ");
                 
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerNumber) || !(rightAnswerNumber > 0) || !(rightAnswerNumber < answers.Length));


            return new MCQ(HeaderOfTheQuestion, BodyofTheQustion, Mark, answers, rightAnswerNumber);





        }


        public override void ShowQuestion()
        {
            Console.WriteLine($"{BodyOfTheQuestion}?");
            foreach (var item in Answers)
            {
                Console.WriteLine(item);

            }
        }
    }
}
