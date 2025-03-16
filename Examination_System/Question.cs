using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public abstract void DisplayQuestion();
    }
}

