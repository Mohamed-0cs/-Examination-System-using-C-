using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class ChooseAllQuestion:Question
    {
        public List<string> Options { get; set; }
        public List<int> CorrectOptionIndexes { get; set; }
        public ChooseAllQuestion(string header, string body, int marks, List<string> options, List<int> correctOptionIndexes)
            : base(header, body, marks)
        {
            Options = options;
            CorrectOptionIndexes = correctOptionIndexes;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}: {Body}");
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }
    }
}
