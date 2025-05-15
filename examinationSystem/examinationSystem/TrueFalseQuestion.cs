using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks)
            : base(header, body, marks)
        {
        }

        public override string Display()
        {
            return $"{Header}\n{Body}\n(True/False)";
        }
    }

}
