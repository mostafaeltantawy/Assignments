using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Classes
{
    internal class MCQ :Question
    {
        
    MCQ(string headerOfQuestion , string bodyOfQuestion , int mark) : base(headerOfQuestion , bodyOfQuestion , mark , [new Answer(1, "True"), new Answer(2, "false")]  )
        {

        }
    }
}
