using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH21_Studio
{
    public class CheckBox : Question
    {
        public List<string> CorrectAnswers { get; set; }

        public CheckBox(string question, List<string>correctAnswers) : base(question)
        {
            CorrectAnswers = correctAnswers;
            PointValue = 1 / correctAnswers.Count();
        }
    }
}
