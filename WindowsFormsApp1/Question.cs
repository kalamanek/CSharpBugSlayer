using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public struct Question
    {
        private String question { get; }
        private String[] answear { get; }
        private int correctAnswear { get; }

        public Question(string question, string[] answear, int correctAnswear)
        {
            this.question = question;
            this.answear = answear;
            this.correctAnswear = correctAnswear;
        }
        public int getPoints()
        {
            return 1;
        }
    }
}
