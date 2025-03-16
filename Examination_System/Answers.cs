using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answers
    {
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        public Answers(string _answer, bool _isCorrect)
        {
            Answer = _answer;
            IsCorrect = _isCorrect;
        }

    }
}
