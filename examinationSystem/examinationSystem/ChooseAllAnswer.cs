using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class ChooseAllAnswer : Answer
    {
        public List<int> SelectedOptions { get; set; }

        public ChooseAllAnswer(string questionId, List<int> selectedOptions)
            : base(questionId)
        {
            SelectedOptions = selectedOptions ?? new List<int>();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Selected Options: {string.Join(", ", SelectedOptions)}";
        }
    }

}
