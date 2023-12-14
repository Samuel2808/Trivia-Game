using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Trivia_Game
{
    internal class Game
    {
        private string GameTitleArt = @"

   _____            _____.__                 __      ________                       
  /     \ ___.__. _/ ____\__|______  _______/  |_   /  _____/_____    _____   ____  
 /  \ /  <   |  | \   __\|  \_  __ \/  ___/\   __\ /   \  ___\__  \  /     \_/ __ \ 
/    Y    \___  |  |  |  |  ||  | \/\___ \  |  |   \    \_\  \/ __ \|  Y Y  \  ___/ 
\____|__  / ____|  |__|  |__||__|  /____  > |__|    \______  (____  /__|_|  /\___  >
        \/\/                            \/                 \/     \/      \/     \/ 



                      / \_______ /|_\             
                     /          /_/ \__
                    /             \_/ /
                  _|_              |/|_
                  _|_  O    _    O  _|_
                  _|_      (_)      _|_
                   \                 /
                    _\_____________/_
                   /  \/  (___)  \/  \
                   \__(  o     o  )__/

";
        private string GameTitle = "Trivia Quest";
        private string Description = "Play to win the other players";
        private Player CurrentPlayer;
        private TriviaItem FoodVenezuela;
        private TriviaItem Agua;
        private TriviaItem malta;

        public Game() 
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            string foodveneca = "The most famous plate in Venezuela is Arepa - true or false ?";
            FoodVenezuela = new TriviaItem(foodveneca,"true");

            string gas = "The sparkilng water is better than water - true or false?";
            Agua = new TriviaItem(gas,"true");

            string coca = "In Venezuela malta is better than Coca Cola - true or false?";
            malta = new TriviaItem(coca, "true");

            
        }
        public void Play() 
        {
            Title = GameTitle;

            WriteLine(GameTitleArt);
            WriteLine($"Welcome To {GameTitle}");
            WriteLine(Description);
            WriteLine("");

            Write("\nWhat is your name: ");
            string playerName = ReadLine();
            CurrentPlayer = new Player(playerName);
            Console.Clear();
            WriteLine($"Welcome to {GameTitle}, {playerName}!");

            WriteLine($"Your current score is {CurrentPlayer.Score}");
            
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            FoodVenezuela.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Clear();
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Agua.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Clear();
            WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            malta.AskQuestion();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            WriteLine("You finished the game");
            WriteLine("\nPress any key to exit");
            ReadKey();

        }
    }
}
