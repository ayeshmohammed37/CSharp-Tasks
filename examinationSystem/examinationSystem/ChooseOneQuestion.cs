using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Options { get; set; }

        public ChooseOneQuestion(string header, string body, int marks, List<string> options)
            : base(header, body, marks)
        {
            Options = options ?? new List<string>();
        }

        public override string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Header}");
            sb.AppendLine($"{Body}");
            sb.AppendLine("Choose one option:");

            for (int i = 0; i < Options.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {Options[i]}");
            }

            return sb.ToString();
        }
    }

}
