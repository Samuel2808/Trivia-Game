using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Game
{
    internal class TriviaItem
    {
        private string Question;
        private string Answer;


        public TriviaItem(string triviaQuestion, string trviaAnswer)
        {
            this.Question = triviaQuestion;
            this.Answer = trviaAnswer;

        }
        public TriviaItem()
        {

        }

        public void AskQuestion()
        {
            //TODO: this should display the question, get a response,
            //and display the correct answer.
            Console.WriteLine(Question);
            Console.Write("Whats your answer?");
            string playerAnswer = Console.ReadLine();
            Console.WriteLine($"Your answered \"{playerAnswer}\" .");
            Console.WriteLine($"The correct answer was: {Answer}. ");
        }
    }
}
