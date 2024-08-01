using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignADV02
{
    internal class Q1
    {

        public static void ReverseList(ArrayList list)
        {
            if (list is null) return;
            int Start = 0;
            int End = list.Count - 1;
            object? temp;
            while (Start < End)
            {
                temp = list[Start];
                list[Start] = list[End];
                list[End] = temp;
                Start++;
                End--;
            }
        }
    }
}
