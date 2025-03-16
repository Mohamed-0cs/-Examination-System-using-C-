using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(string _subject, int _time, int _numberOfQuestions):base(_subject, _time, _numberOfQuestions) 
        {
        
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practice Exam:");
            foreach (var question in   QuestionsAnswerDictionary.Keys)
            {
                question.DisplayQuestion();
                Console.WriteLine("Correct Answer: " + QuestionsAnswerDictionary[question].First(a => a.IsCorrect).Answer);
            }
        }
        public override object Clone()
        {
            // Create a new object
           PracticeExam clonedExam = new PracticeExam(this.Subject, this.Time, this.NumberOfQuestions);

            // Deep copy reference-type fields
            clonedExam.QuestionsAnswerDictionary = new Dictionary<Question, AnswerList>(this.QuestionsAnswerDictionary);

            return clonedExam;
        }

    }
}
