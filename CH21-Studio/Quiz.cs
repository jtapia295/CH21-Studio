﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH21_Studio
{
    class Quiz : Question
    {
        public Dictionary<string, List<string>>AnswerKey { get; set; }

        public void AddQuestion(Question question)
        {
            string question
            AnswerKey.Add<question.ActualQuestion, question.PossibleAnswers>;
        }

        public Quiz()
        {

        }

    }
}
