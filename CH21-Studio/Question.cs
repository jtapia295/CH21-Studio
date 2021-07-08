using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH21_Studio
{
    public class Question
    {
        public string ActualQuestion { get; set; }

        public List<string> PossibleAnswers { get; set; }

        public void ShowPossibleAnswers()
        {
            Console.WriteLine($"Questions:");
            int i = 1;
            foreach (var item in PossibleAnswers)
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
        }

        public void AddPossibleAnswers(List<string>options)
        {
            foreach (var item in options)
            {
                PossibleAnswers.Add(item);
            }
        }

        public double PointValue { get; set; }


        public Question(string question)
        {
            ActualQuestion = question;
            PointValue = 1;
        }
    }
}
