using OOPExam02.Classes;

namespace OOPExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinalExam exam = new FinalExam(DateTime.Now, 10);
            exam.CreateExam();

        }
    }
}
