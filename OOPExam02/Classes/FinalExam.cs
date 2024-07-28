using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam02.Classes
{
    internal class FinalExam : Exam
    {
        public FinalExam(DateTime timeOfExam, int numberOfQuetions) : base(timeOfExam, numberOfQuetions)
        {
        }

        public override void CreateExam()
        {
            for (int i = 0; i < NumberOfQuetions; i++) 
            {
                Questions[i] = MCQ.CreateQuestion(i+1); 
            }
        }
    }
}
