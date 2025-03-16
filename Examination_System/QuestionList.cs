using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class QuestionList : List<Question>
    {
        string logFilePath;
        public QuestionList(string _logFilePath)
        {
            logFilePath = _logFilePath;
        }
        public void AddQuestion(Question q)
        {
            base.Add(q);
            LogQuestion(q);

        }
        void LogQuestion(Question q) { 
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{q.Header}: {q.Body}");
            }

        }
    }
}
