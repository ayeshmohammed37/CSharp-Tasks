namespace examinationSystem
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examination System");
            Console.WriteLine("-----------------");

            // Create a subject
            Subject cSharpProgramming = new Subject("C# Programming", "CS101");

            // Create students
            Student student1 = new Student("John Doe");
            Student student2 = new Student("Jane Smith");

            // Enroll students in the subject
            cSharpProgramming.EnrollStudent(student1);
            cSharpProgramming.EnrollStudent(student2);

            // Create practice exam
            PracticeExam practiceExam = new PracticeExam("C# Basics Practice", 30, cSharpProgramming);

            // Create final exam
            FinalExam finalExam = new FinalExam("C# Final Exam", 60, cSharpProgramming);

            // Add questions to both exams

            // True/False questions
            TrueFalseQuestion tf1 = new TrueFalseQuestion(
                "C# Basics",
                "C# is a statically typed language.",
                5);
            TrueFalseAnswer tf1Answer = new TrueFalseAnswer(tf1.QuestionId, true);

            // Choose one questions
            ChooseOneQuestion co1 = new ChooseOneQuestion(
                "C# Classes",
                "Which of the following is used to implement inheritance in C#?",
                10,
                new List<string> { "extends", ":", "implements", "inherits" });
            ChooseOneAnswer co1Answer = new ChooseOneAnswer(co1.QuestionId, 2);

            // Choose all questions
            ChooseAllQuestion ca1 = new ChooseAllQuestion(
                "C# Features",
                "Which of the following are valid access modifiers in C#?",
                15,
                new List<string> { "public", "private", "protected", "internal", "external" });
            ChooseAllAnswer ca1Answer = new ChooseAllAnswer(ca1.QuestionId, new List<int> { 1, 2, 3, 4 });

            // Add questions to practice exam
            practiceExam.AddQuestion(tf1, tf1Answer);
            practiceExam.AddQuestion(co1, co1Answer);
            practiceExam.AddQuestion(ca1, ca1Answer);

            // Add questions to final exam
            finalExam.AddQuestion(tf1, tf1Answer);
            finalExam.AddQuestion(co1, co1Answer);
            finalExam.AddQuestion(ca1, ca1Answer);

            // Subscribe students to exam mode changes
            practiceExam.ExamModeChanged += student1.ReceiveNotification;
            practiceExam.ExamModeChanged += student2.ReceiveNotification;
            finalExam.ExamModeChanged += student1.ReceiveNotification;
            finalExam.ExamModeChanged += student2.ReceiveNotification;

            // Let the user choose which exam to take
            Console.WriteLine("Select the exam type:");
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam");
            Console.Write("Enter your choice (1 or 2): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                practiceExam.TakeExam(student1);
            }
            else if (choice == "2")
            {
                finalExam.TakeExam(student1);
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}
