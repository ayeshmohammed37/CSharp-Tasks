namespace examinationSystem
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public string ExamId { get; protected set; }
        public string Title { get; set; }
        public int Duration { get; set; } // in minutes
        public QuestionList Questions { get; set; }
        public Dictionary<string, Answer> CorrectAnswers { get; set; } // QuestionId -> Answer
        public Subject Subject { get; set; }
        public ExamMode Mode { get; private set; }

        // Event for notifying students when exam mode changes
        public event EventHandler<ExamEventArgs> ExamModeChanged;

        protected Exam(string title, int duration, Subject subject)
        {
            ExamId = Guid.NewGuid().ToString().Substring(0, 8);
            Title = title;
            Duration = duration;
            Subject = subject;
            Questions = new QuestionList($"exam_{ExamId}_questions.log");
            CorrectAnswers = new Dictionary<string, Answer>();
            Mode = ExamMode.Queued;
        }

        // Chaining constructor
        protected Exam(string title, int duration, Subject subject, QuestionList questions)
            : this(title, duration, subject)
        {
            Questions = questions;
        }

        public void SetMode(ExamMode mode)
        {
            Mode = mode;

            // If mode is Starting, notify all enrolled students
            if (mode == ExamMode.Starting)
            {
                NotifyStudents($"The {Title} exam is starting now!");
            }
            else if (mode == ExamMode.Finished)
            {
                NotifyStudents($"The {Title} exam has finished.");
            }
        }

        private void NotifyStudents(string message)
        {
            ExamEventArgs args = new ExamEventArgs(message);
            ExamModeChanged?.Invoke(this, args);
        }

        public abstract void ShowExam(Student student);

        public abstract AnswerList TakeExam(Student student);

        public virtual void AddQuestion(Question question, Answer correctAnswer)
        {
            Questions.Add(question);
            CorrectAnswers[question.QuestionId] = correctAnswer;
        }

        public override string ToString()
        {
            return $"Exam: {Title}, Duration: {Duration} minutes, Questions: {Questions.Count}, Mode: {Mode}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Exam other)
            {
                return ExamId == other.ExamId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ExamId.GetHashCode();
        }

        public object Clone()
        {
            // Create a shallow copy
            Exam clonedExam = (Exam)this.MemberwiseClone();

            // Create deep copies of mutable objects
            clonedExam.Questions = new QuestionList($"exam_{clonedExam.ExamId}_questions.log");
            foreach (var question in Questions)
            {
                clonedExam.Questions.Add((Question)question.Clone());
            }

            clonedExam.CorrectAnswers = new Dictionary<string, Answer>();
            foreach (var pair in CorrectAnswers)
            {
                // Just copying the reference to the answer is sufficient for this example
                clonedExam.CorrectAnswers[pair.Key] = pair.Value;
            }

            return clonedExam;
        }

        public int CompareTo(Exam other)
        {
            // Compare exams based on their duration
            return Duration.CompareTo(other.Duration);
        }
    }

}
