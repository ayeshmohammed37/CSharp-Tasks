namespace examinationSystem
{
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; set; }

        public Student(string name)
        {
            StudentId = Guid.NewGuid().ToString().Substring(0, 8);
            Name = name;
        }

        public void ReceiveNotification(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Student {Name} received notification: {e.Message}");
        }

        public override string ToString()
        {
            return $"Student: {Name} (ID: {StudentId})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return StudentId == other.StudentId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return StudentId.GetHashCode();
        }
    }

}
