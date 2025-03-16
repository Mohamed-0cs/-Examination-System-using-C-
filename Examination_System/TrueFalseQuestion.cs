using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class TrueFalseQuestion: Question
    {
        public bool Answer { get; set; }
        public TrueFalseQuestion(string header, string body, int marks, bool answer) : base(header, body, marks)
        {
            Answer = answer;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine("True or False?");
            Console.WriteLine(Header);
            Console.WriteLine(Body);
        }
    }
    
    }
