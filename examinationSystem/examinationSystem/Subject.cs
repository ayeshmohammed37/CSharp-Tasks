namespace examinationSystem
{
    public class Subject
    {
        public string SubjectId { get; private set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Student> EnrolledStudents { get; private set; }

        public Subject(string name, string code)
        {
            SubjectId = Guid.NewGuid().ToString().Substring(0, 8);
            Name = name;
            Code = code;
            EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (!EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Add(student);
            }
        }

        public override string ToString()
        {
            return $"Subject: {Name} ({Code})";
        }
    }

}
