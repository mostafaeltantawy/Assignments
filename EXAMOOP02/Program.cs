using EXAMOOP02.Classes;
using EXAMOOP02.Enums; 

namespace EXAMOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Math = new Subject(10, "Math");
            Math.CreateExam(DateTime.Now, 1,ExamType.PracticalExam);
            Math.ExamOfTheSubject.ShowExam();
            Console.WriteLine($"Your Grade is {Math.ExamOfTheSubject.Result} of {Math.ExamOfTheSubject.TotalMark}");
            Console.WriteLine($"Tiem = {Math.ExamOfTheSubject.TimeOfExam}");
        }
    }
    }
