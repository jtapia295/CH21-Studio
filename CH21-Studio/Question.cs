using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH21_Studio
{
    class Question
    {
        public string ActualQuestion { get; set; }

        public List<string> Answers { get; set; }



        public Question(string question, List<string> answers)
        {
            ActualQuestion = question;
            Answers = answers;
        }
    }
}
