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
            IInputHandler input = new InputHandler(); 
            Subject Math = new Subject(10, "Math");
            Exam MathExam = Math.CreateExam(1, ExamType.FinalExam , input);
            MathExam.ShowExam();
            Console.WriteLine($"Your Grade is {MathExam.Result} of {MathExam.TotalMark}");
            Console.WriteLine($"Tiem = {MathExam.TimeOfExam}");
        }
    }
}
