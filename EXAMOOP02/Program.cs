using EXAMOOP02.Classes;
using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;

namespace EXAMOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IInputHandler input = new InputHandler(); 
            //Subject Math = new Subject(10, "Math");
            //ExamType examtype = Helper.GetExamType();
            //int numberOfQuestions = Helper.GetNumberOfQuestions();
            //TimeSpan time = Helper.GetExamDuration();
            //Exam MathExam = Math.CreateExam(numberOfQuestions, examtype ,  time , input);
            //Helper.StartExam();
            //MathExam.ShowExam();
            //Helper.ShowRightAnswers(MathExam , numberOfQuestions); 
            //Console.WriteLine($"Your Grade is {MathExam.Result} of {MathExam.TotalMark}");
            //Console.WriteLine($"Tiem = {MathExam.TimeTaken}");

            List<int> list = new List<int>() { 12 , 4 , 5 , 6,3,23 , 1};

            Console.WriteLine(list.BinarySearch(12));
            List<int> list2 = new List<int>() { 1,3, 4, 5, 6, 12, 23 };
            Console.WriteLine(list2.BinarySearch(12));

        }
    }
}
