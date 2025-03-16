using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    
    internal abstract class Exam:ICloneable, IComparable<Exam>
    {
        public enum ExamMode
        {
           Starting,
           Queued,
            Finished
        } 
        public string  Subject { get; set; }
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
         public  Dictionary<Question, AnswerList > QuestionsAnswerDictionary { get; set; }
        public ExamMode Mode { get; set; }
        public Exam(string _subject , int _time , int _numberOfQuestions) {
            Subject = _subject;
            Time = _time;
            NumberOfQuestions = _numberOfQuestions;
            QuestionsAnswerDictionary = new Dictionary<Question, AnswerList>();
            Mode = ExamMode.Starting;
        }
        public abstract void ShowExam();
        public abstract  object Clone();
        public int CompareTo(Exam? ex)
        {
            if (ex == null)
            {
                // If 'other' is null, consider the current object greater
                return 1;
            }


            return this.Subject.CompareTo(ex.Subject);
        }
      
        public override string ToString()
        {
            return $"Subject: {Subject}, Time Limit: {Time}, Questions: {NumberOfQuestions}" ;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Exam)) return false;
            Exam ex = (Exam)obj;
            return this.Subject == ex.Subject && this.Time == ex.Time;
        }

        
    }
}
