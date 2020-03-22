using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public struct Question
    {
        public String question { get; }
        public List<String>answer { get; }

        public Question(string question, List<string> answear)
        {
            this.question = question;
            this.answer = answear;
        }
    }
}
