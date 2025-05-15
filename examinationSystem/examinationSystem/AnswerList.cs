using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class AnswerList : List<Answer>
    {
        public string StudentId { get; set; }

        public AnswerList(string studentId)
        {
            StudentId = studentId;
        }

        public Answer GetAnswerForQuestion(string questionId)
        {
            return this.FirstOrDefault(a => a.QuestionId == questionId);
        }
    }

}
