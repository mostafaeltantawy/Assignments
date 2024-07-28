using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam02.Classes
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string headerOfTheQuestion, string bodyOfTheQuestion, double mark, int rightAnswer)
            : base(headerOfTheQuestion, bodyOfTheQuestion, mark, [new Answer(1, "True"), new Answer(2, "False")], rightAnswer)
        {
        }
    }
}
