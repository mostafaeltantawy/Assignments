using EXAMOOP02.Classes;
using EXAMOOP02.Enums;


namespace EXAMOOP02.Util
{
    public static class Helper
    {
        public static ExamType GetExamType()
        {
            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1 - Practical Exam");
            Console.WriteLine("2 - Final Exam");

            ExamType examTypeInput;
            do
            {
                Console.Write("Enter the number corresponding to the exam type: ");
            } while (!Enum.TryParse<ExamType>(Console.ReadLine(), true, out examTypeInput) || !Enum.IsDefined(typeof(ExamType), examTypeInput)) ; 

            return examTypeInput;
        }

        public static int GetNumberOfQuestions()
        {
            int numberOfQuestions;
            do
            {
                Console.WriteLine("Enter Number of Questions for the Exam:");
            } while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0);

            return numberOfQuestions;
        }

        public static TimeSpan GetExamDuration()
        {
            int examDurationMinutes;
            do
            {
                Console.WriteLine("Enter the duration of the exam (30 to 180 minutes):");
            } while (!int.TryParse(Console.ReadLine(), out examDurationMinutes) || examDurationMinutes < 30 || examDurationMinutes > 180);
            Console.Clear();

            return TimeSpan.FromMinutes(examDurationMinutes);
        }

        
        public static void ShowRightAnswers(Exam exam , int NumberOfQuestions)
        {
            if (exam is PracticalExam)
            {
                Console.WriteLine("Right Answers:");
                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    var correctAnswer = exam.Questions[i].Answers[exam.Questions[i].RightAnswer - 1];
                    Console.WriteLine($"{i + 1}: {correctAnswer}");
                }
            }
            if(exam is FinalExam)
            {
                Console.WriteLine("Exam Results:");
                for (int i = 0; i < NumberOfQuestions; i++)
                {

                    Console.WriteLine($"Question {i+1}");
                    Console.WriteLine($"Your Answer: {exam.Questions[i].Answers[exam.StudentAnswers[i] - 1]}");
                    Console.WriteLine($"Correct Answer: {exam.Questions[i].Answers[exam.Questions[i].RightAnswer - 1]}");

                }
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
