namespace examinationSystem
{
    public class PracticeExam : Exam
    {
        public PracticeExam(string title, int duration, Subject subject)
            : base(title, duration, subject)
        {
        }

        public PracticeExam(string title, int duration, Subject subject, QuestionList questions)
            : base(title, duration, subject, questions)
        {
        }

        public override void ShowExam(Student student)
        {
            Console.WriteLine($"\n===== PRACTICE EXAM: {Title} =====");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine($"Subject: {Subject.Name}");
            Console.WriteLine($"Number of Questions: {Questions.Count}");
            Console.WriteLine("This is a practice exam. You will see the correct answers after completion.");
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

            // Show correct answers for practice exam
            ShowCorrectAnswers(studentAnswers);

            return studentAnswers;
        }

        private void ShowCorrectAnswers(AnswerList studentAnswers)
        {
            Console.WriteLine("\n===== CORRECT ANSWERS =====");

            foreach (Question question in Questions)
            {
                Console.WriteLine($"\n{question.Header}");
                Console.WriteLine(question.Body);

                Answer studentAnswer = studentAnswers.GetAnswerForQuestion(question.QuestionId);
                Answer correctAnswer = CorrectAnswers[question.QuestionId];

                Console.WriteLine("Your answer:");
                if (studentAnswer != null)
                {
                    if (studentAnswer is TrueFalseAnswer tfAnswer)
                    {
                        Console.WriteLine($"  {tfAnswer.Value}");
                    }
                    else if (studentAnswer is ChooseOneAnswer coAnswer)
                    {
                        Console.WriteLine($"  Option {coAnswer.SelectedOption}");
                    }
                    else if (studentAnswer is ChooseAllAnswer caAnswer)
                    {
                        Console.WriteLine($"  Options: {string.Join(", ", caAnswer.SelectedOptions)}");
                    }
                }
                else
                {
                    Console.WriteLine("  No answer provided");
                }

                Console.WriteLine("Correct answer:");
                if (correctAnswer is TrueFalseAnswer tfCorrect)
                {
                    Console.WriteLine($"  {tfCorrect.Value}");
                }
                else if (correctAnswer is ChooseOneAnswer coCorrect)
                {
                    Console.WriteLine($"  Option {coCorrect.SelectedOption}");
                }
                else if (correctAnswer is ChooseAllAnswer caCorrect)
                {
                    Console.WriteLine($"  Options: {string.Join(", ", caCorrect.SelectedOptions)}");
                }
            }
        }
    }

}
