using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class TrueFalseAnswer : Answer
    {
        public bool Value { get; set; }

        public TrueFalseAnswer(string questionId, bool value)
            : base(questionId)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Value: {Value}";
        }
    }

}
