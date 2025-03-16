using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examination_System.Exam;

namespace Examination_System
{
    //public delegate void ExamStartedEventHandler(string message);

    public class Notification
    {
        public event EventHandler<string> ExamStarted = (sender, message) => { };

        public void StartExam(object o)
        {
            Exam exam = (Exam)o;
            exam.Mode = ExamMode.Starting;
            OnExamStarted($"Exam for {exam.Subject} has started!");
        }

        public virtual void OnExamStarted(string message)
        {
            
            ExamStarted.Invoke(this, message);
        }
    }
}
