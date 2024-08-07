﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam02.Classes
{
    internal class Answer
    {
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


        public static Answer CreateAnswer(int answerId) 
        {
            string answerText;
            do
            {
                Console.WriteLine($"Please Enter Answer #{answerId} : ");
                answerText = Console.ReadLine();

            } while (answerText.Trim() == "" || answerText is null);

            return new Answer(answerId, answerText);
        }
    }
}
