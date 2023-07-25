using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:" +
                "\r\n You and your oppenent will both select one of the gestures(rock, paper, scissors, lizard, and Spock.) and the winner is based off the list below. "+
                "\nRock crushes Scissors" +
                "\r\nScissors cuts Paper " +
                "\r\nPaper covers Rock" +
                "\r\nRock crushes Lizard" +
                "\r\nLizard poisons Spock" +
                "\r\nSpock smashes Scissors" +
                "\r\nScissors decapitates Lizard" +
                "\r\nLizard eats Paper" +
                "\r\nPaper disproves Spock" +
                "\r\nSpock vaporizes Rock");
        }

        public int ChooseNumberOfHumanPlayers()
        {

            Console.WriteLine("Choose 1 or 2 human players");
            int numberOfHumanPlayers = Int32.Parse(Console.ReadLine());
            return numberOfHumanPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.WriteLine("Player one enter your name");
            playerOne = new HumanPlayer(Console.ReadLine());
            if (numberOfHumanPlayers == 1)
            {
                playerTwo = new ComputerPlayer("PlayerTwo");
            }
            else
            {
                Console.WriteLine("Player two enter your name");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
        }

        public void CompareGestures()
        {
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie");
            }
            else if (playerOne.chosenGesture == "rock")
            {
                if (playerTwo.chosenGesture == "scissor" || playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player One wins");
                    playerOne.score++;
                }
                else
                {

                    Console.WriteLine("Player two wins");
                    playerTwo.score++;
                };
            }
            else if (playerOne.chosenGesture == "scissors")
            {
                if (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Player One wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine("Player two wins");
                    playerTwo.score++;
                }
            }
            else if (playerOne.chosenGesture == "paper")
            {
                if (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player One wins");
                    playerOne.score++;
                }
                else
                {

                    Console.WriteLine("Player two wins");
                    playerTwo.score++;
                };
            }
            else if (playerOne.chosenGesture == "lizard")
            {
                if (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Player One wins");
                    playerOne.score++;
                }
                else
                {

                    Console.WriteLine("Player two wins");
                    playerTwo.score++;
                };
            }
            else if (playerOne.chosenGesture == "spock")
            {
                if (playerTwo.chosenGesture == "scissor" || playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Player One wins");
                    playerOne.score++;
                }
                else
                {

                    Console.WriteLine("Player two wins");
                    playerTwo.score++;
                };
            }
        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            CreatePlayerObjects(ChooseNumberOfHumanPlayers());
            while (playerOne.score<2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
            }
        }
    }
}
