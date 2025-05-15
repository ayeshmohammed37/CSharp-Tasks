using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public string QuestionId { get; protected set; }

        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            QuestionId = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public abstract string Display();

        public override string ToString()
        {
            return $"Question ID: {QuestionId}, Header: {Header}, Marks: {Marks}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Question other)
            {
                return QuestionId == other.QuestionId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return QuestionId.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            return Marks.CompareTo(other.Marks);
        }
    }
}
