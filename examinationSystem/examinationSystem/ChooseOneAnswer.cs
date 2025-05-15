using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class ChooseOneAnswer : Answer
    {
        public int SelectedOption { get; set; }

        public ChooseOneAnswer(string questionId, int selectedOption)
            : base(questionId)
        {
            SelectedOption = selectedOption;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Selected Option: {SelectedOption}";
        }
    }

}
