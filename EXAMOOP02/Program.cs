using EXAMOOP02.Classes;

namespace EXAMOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinalExam exam = new FinalExam(DateTime.Now,1);
            exam.CreateExam();
            exam.ShowExam();
            exam.ShowTheResult(); 
        }
    }
}
