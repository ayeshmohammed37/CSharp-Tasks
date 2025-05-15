using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public abstract class Answer
    {
        public string AnswerId { get; protected set; }
        public string QuestionId { get; set; }

        protected Answer(string questionId)
        {
            QuestionId = questionId;
            AnswerId = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public override string ToString()
        {
            return $"Answer ID: {AnswerId}, Question ID: {QuestionId}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Answer other)
            {
                return AnswerId == other.AnswerId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AnswerId.GetHashCode();
        }
    }
}
