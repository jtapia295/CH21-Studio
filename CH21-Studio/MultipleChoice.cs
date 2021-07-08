using System;
namespace CH21_Studio
{
    public class MultipleChoice : Question
    {
        public string CorrectAnswer { get; set; }


        public MultipleChoice(string question, string correctAnswer):base(question)
        {
            CorrectAnswer = correctAnswer;
        }
    }
}
