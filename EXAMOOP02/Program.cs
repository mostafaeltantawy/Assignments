using EXAMOOP02.Classes;
using EXAMOOP02.Enums; 

namespace EXAMOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Math = new Subject(10, "Math");
            Math.CreateExam(DateTime.Now, 2,ExamType.FinalExam);
            Math.ExamOfTheSubject.ShowExam();
            Math.ExamOfTheSubject.ShowTheResult();
        }
    }
}
