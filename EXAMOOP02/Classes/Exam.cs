using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal abstract class Exam
    {
        public Exam(DateTime timeOfExam, int numberOfQuetions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuetions = numberOfQuetions;
            Questions = new Question[numberOfQuetions];
        }

        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuetions { get; set; }
        public Question[] Questions { get; set; }
        public abstract void ShowExam(); 
     

        public abstract void CreateExam();
    }
}
