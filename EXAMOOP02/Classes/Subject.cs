using EXAMOOP02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class Subject
    {
  

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfTheSubject { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(DateTime timeOfExam, int numberOfQuestions, ExamType examType)
        {
            if (examType == ExamType.FinalExam)
            {
                ExamOfTheSubject = new FinalExam( numberOfQuestions);
                ExamOfTheSubject.CreateExam(); 
                
            }
            else if (examType == ExamType.PracticalExam)
            {
                ExamOfTheSubject = new PracticalExam( numberOfQuestions);
                ExamOfTheSubject.CreateExam();

            }
        }
    }
}
