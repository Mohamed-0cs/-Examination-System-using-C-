using static Examination_System.Exam;

namespace Examination_System
{
    internal class Program
    {
        public static void StartExam(Exam ex) {
         
        
            ex.Mode = ExamMode.Starting;
            

        
        }
        static void Main(string[] args)
        {
            // Create questions
            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion("TF1", "Is the sky blue?", 5, true);
            ChooseOneQuestion chooseOneQuestion = new ChooseOneQuestion("CO1", "What is 2+2?", 5, new List<string> { "3", "4", "5" }, 4);

            // Create question list and log questions
            QuestionList questionList = new QuestionList("G:\\ITI .Net\\C#\\Examination_System\\questionlist1");
            questionList.Add(trueFalseQuestion);
            questionList.Add(chooseOneQuestion);

            // Create exams
            PracticeExam practiceExam = new PracticeExam("Math", 60, 2);
            FinalExam finalExam = new FinalExam("Science", 90, 2);

            // Add questions to exams
            practiceExam.QuestionsAnswerDictionary.Add(trueFalseQuestion, new AnswerList { new Answers("True", true) });
            practiceExam.QuestionsAnswerDictionary.Add(chooseOneQuestion, new AnswerList { new Answers("4", true) });

            finalExam.QuestionsAnswerDictionary.Add(trueFalseQuestion, new AnswerList { new Answers("True", true) });
            finalExam.QuestionsAnswerDictionary.Add(chooseOneQuestion, new AnswerList { new Answers("4", true) });

            // Show exams
            Console.WriteLine("Select Exam Type (1: Practice, 2: Final):");
            int choice;
            while (true)
            {
                string input = Console.ReadLine();

                // Try to parse the input as an integer
                if (int.TryParse(input, out choice))
                {
                    // Check if the choice is either 1 or 2
                    if (choice == 1 || choice == 2)
                    {
                        break; // Exit the loop if the input is valid
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1 for Practice or 2 for Final.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            if (choice == 1)
                practiceExam.ShowExam();
            else if (choice == 2)
                finalExam.ShowExam();

            // Notification system
            Student student1 = new Student("Alice");
            Student student2 = new Student("Bob");

            Notification notifier = new Notification();
            notifier.ExamStarted += student1.Notify;
            notifier.ExamStarted += student2.Notify;

            notifier.StartExam(practiceExam);

        }
    }
}
