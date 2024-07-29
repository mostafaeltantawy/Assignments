using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class Subject
    {
        #region Props
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        private Exam ExamOfTheSubject { get; set; }

        #endregion

        #region constructor
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }


        #endregion

        #region methods
        public Exam CreateExam(int numberOfQuestions, ExamType examType, TimeSpan timeOfExam, IInputHandler inputHandler)
        {
            if (examType == ExamType.FinalExam)
            {
                ExamOfTheSubject = new FinalExam(numberOfQuestions, timeOfExam, inputHandler);
                ExamOfTheSubject.CreateExam();

            }
            else if (examType == ExamType.PracticalExam)
            {
                ExamOfTheSubject = new PracticalExam(numberOfQuestions, timeOfExam, inputHandler);
                ExamOfTheSubject.CreateExam();

            }
            return ExamOfTheSubject;
        }
        #endregion

    }
}
