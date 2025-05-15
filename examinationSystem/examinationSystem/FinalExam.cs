namespace examinationSystem
{
    /// <summary>
    /// Final exam type - does not show correct answers after completion
    /// </summary>
    public class FinalExam : Exam
    {
        public FinalExam(string title, int duration, Subject subject)
            : base(title, duration, subject)
        {
        }

        public FinalExam(string title, int duration, Subject subject, QuestionList questions)
            : base(title, duration, subject, questions)
        {
        }

        public override void ShowExam(Student student)
        {
            Console.WriteLine($"\n===== FINAL EXAM: {Title} =====");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine($"Subject: {Subject.Name}");
            Console.WriteLine($"Number of Questions: {Questions.Count}");
            Console.WriteLine("This is a final exam. You will not see the correct answers after completion.");
            Console.WriteLine("=============================================\n");
        }

        public override AnswerList TakeExam(Student student)
        {
            ShowExam(student);

            AnswerList studentAnswers = new AnswerList(student.StudentId);

            Console.WriteLine("Press Enter to start the exam...");
            Console.ReadLine();

            // Set the exam mode to Starting
            SetMode(ExamMode.Starting);

            for (int i = 0; i < Questions.Count; i++)
            {
                Question question = Questions[i];
                Console.WriteLine($"\nQuestion {i + 1} of {Questions.Count}");
                Console.WriteLine(question.Display());

                Answer studentAnswer = null;

                if (question is TrueFalseQuestion)
                {
                    Console.Write("Your answer (T/F): ");
                    string input = Console.ReadLine().ToUpper();
                    bool value = input == "T" || input == "TRUE";
                    studentAnswer = new TrueFalseAnswer(question.QuestionId, value);
                }
                else if (question is ChooseOneQuestion)
                {
                    Console.Write("Enter the number of your answer: ");
                    if (int.TryParse(Console.ReadLine(), out int selectedOption))
                    {
                        studentAnswer = new ChooseOneAnswer(question.QuestionId, selectedOption);
                    }
                }
                else if (question is ChooseAllQuestion)
                {
                    Console.Write("Enter the numbers of your answers (comma-separated): ");
                    string input = Console.ReadLine();
                    List<int> selectedOptions = input.Split(',')
                        .Select(s => int.TryParse(s.Trim(), out int num) ? num : -1)
                        .Where(n => n > 0)
                        .ToList();
                    studentAnswer = new ChooseAllAnswer(question.QuestionId, selectedOptions);
                }

                if (studentAnswer != null)
                {
                    studentAnswers.Add(studentAnswer);
                }
            }

            // Set the exam mode to Finished
            SetMode(ExamMode.Finished);

            Console.WriteLine("\nThank you for completing the final exam.");
            Console.WriteLine("Your answers have been recorded.");

            return studentAnswers;
        }
    }

}
