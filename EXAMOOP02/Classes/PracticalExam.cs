using EXAMOOP02.Enums;
using EXAMOOP02.Intefaces;
using EXAMOOP02.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMOOP02.Classes
{
    internal class PracticalExam : Exam
    {
        public PracticalExam( int numberOfQuetions , TimeSpan timeOfExam, IInputHandler inputHandler) : base( numberOfQuetions ,timeOfExam, inputHandler)
        {
        }

        public override void CreateExam()
        {

            for (int i = 0; i < NumberOfQuestions; i++)
            {
             
                    Questions[i] = MCQ.CreateQuestion(i + 1 , _inputHandler);
            }
        }

    }
}
